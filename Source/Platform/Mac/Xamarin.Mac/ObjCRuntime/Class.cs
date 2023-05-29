using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Foundation;

namespace ObjCRuntime;

public class Class : INativeObject
{
	[MonoNativeFunctionWrapper]
	private delegate int getFrameLengthDelegate(IntPtr @this, IntPtr sel);

	[MonoNativeFunctionWrapper]
	private delegate IntPtr addPropertyDelegate(IntPtr cls, string name, objc_attribute_prop[] attributes, int count);

	private struct objc_attribute_prop
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string name;

		[MarshalAs(UnmanagedType.LPStr)]
		internal string value;
	}

	public static bool ThrowOnInitFailure = true;

	private static Dictionary<IntPtr, Type> type_map = new Dictionary<IntPtr, Type>();

	private static Dictionary<Type, Type> custom_types = new Dictionary<Type, Type>();

	private static List<Delegate> method_wrappers = new List<Delegate>();

	private static object lock_obj = new object();

	internal IntPtr handle;

	private static IntPtr memory;

	private static int size_left;

	private static getFrameLengthDelegate getFrameLength = Selector.GetFrameLength;

	private static IntPtr getFrameLengthPtr = Marshal.GetFunctionPointerForDelegate(getFrameLength);

	private static addPropertyDelegate addProperty;

	private static bool addPropertyInitialized;

	public IntPtr Handle => handle;

	public IntPtr SuperClass => class_getSuperclass(handle);

	public string Name => Messaging.StringFromNativeUtf8(class_getName(handle));

	public Class(string name)
	{
		handle = objc_getClass(name);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException($"name {name} is an unknown class", "name");
		}
	}

	public Class(Type type)
	{
		handle = Register(type);
	}

	public Class(IntPtr handle)
	{
		this.handle = handle;
	}

	internal static Class Construct(IntPtr handle)
	{
		return new Class(handle);
	}

	internal static string GetName(IntPtr @class)
	{
		return Messaging.StringFromNativeUtf8(class_getName(@class));
	}

	public static IntPtr GetHandle(string name)
	{
		return objc_getClass(name);
	}

	public static IntPtr GetHandle(Type type)
	{
		RegisterAttribute registerAttribute = (RegisterAttribute)Attribute.GetCustomAttribute(type, typeof(RegisterAttribute), inherit: false);
		string name = ((registerAttribute == null) ? type.FullName : (registerAttribute.Name ?? type.FullName));
		bool is_wrapper = registerAttribute?.IsWrapper ?? false;
		IntPtr intPtr = objc_getClass(name);
		if (intPtr == IntPtr.Zero)
		{
			intPtr = Register(type, name, is_wrapper);
		}
		return intPtr;
	}

	public static bool IsCustomType(Type type)
	{
		lock (lock_obj)
		{
			return custom_types.ContainsKey(type);
		}
	}

	internal static Type Lookup(IntPtr klass)
	{
		return Lookup(klass, throw_on_error: true);
	}

	internal static Type Lookup(IntPtr klass, bool throw_on_error)
	{
		lock (lock_obj)
		{
			if (type_map.TryGetValue(klass, out var value))
			{
				return value;
			}
			IntPtr key = klass;
			while (true)
			{
				IntPtr intPtr = class_getSuperclass(klass);
				if (type_map.TryGetValue(intPtr, out value))
				{
					type_map[key] = value;
					return value;
				}
				if (intPtr == IntPtr.Zero)
				{
					break;
				}
				klass = intPtr;
			}
			if (!throw_on_error)
			{
				return null;
			}
			throw new ArgumentException("Could not find a valid superclass for type " + new Class(key).Name + ". Did you forget to register the bindings at " + typeof(Class).FullName + ".Register() or call NSApplication.Init()?");
		}
	}

	internal static IntPtr Register(Type type)
	{
		RegisterAttribute registerAttribute = (RegisterAttribute)Attribute.GetCustomAttribute(type, typeof(RegisterAttribute), inherit: false);
		string name = ((registerAttribute == null) ? type.FullName : (registerAttribute.Name ?? type.FullName));
		bool is_wrapper = registerAttribute?.IsWrapper ?? false;
		return Register(type, name, is_wrapper);
	}

	private static IntPtr Register(Type type, string name, bool is_wrapper)
	{
		IntPtr zero = IntPtr.Zero;
		IntPtr zero2 = IntPtr.Zero;
		zero2 = objc_getClass(name);
		lock (lock_obj)
		{
			if (zero2 != IntPtr.Zero)
			{
				if (!type_map.ContainsKey(zero2))
				{
					type_map[zero2] = type;
				}
				return zero2;
			}
			if (objc_getProtocol(name) != IntPtr.Zero)
			{
				throw new ArgumentException("Attempting to register a class named: " + name + " which is a valid protocol");
			}
			if (is_wrapper)
			{
				return IntPtr.Zero;
			}
			Type baseType = type.BaseType;
			string text = null;
			while (Attribute.IsDefined(baseType, typeof(ModelAttribute), inherit: false))
			{
				baseType = baseType.BaseType;
			}
			RegisterAttribute registerAttribute = (RegisterAttribute)Attribute.GetCustomAttribute(baseType, typeof(RegisterAttribute), inherit: false);
			text = ((registerAttribute == null) ? baseType.FullName : (registerAttribute.Name ?? baseType.FullName));
			zero = objc_getClass(text);
			if (zero == IntPtr.Zero && baseType.Assembly != NSObject.MonoMacAssembly)
			{
				bool is_wrapper2 = registerAttribute?.IsWrapper ?? false;
				Register(baseType, text, is_wrapper2);
				zero = objc_getClass(text);
			}
			if (zero == IntPtr.Zero)
			{
				zero = objc_getClass("NSObject");
			}
			zero2 = objc_allocateClassPair(zero, name, IntPtr.Zero);
			PropertyInfo[] properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (PropertyInfo propertyInfo in properties)
			{
				ConnectAttribute connectAttribute = (ConnectAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(ConnectAttribute));
				if (connectAttribute != null)
				{
					string name2 = connectAttribute.Name ?? propertyInfo.Name;
					class_addIvar(zero2, name2, (IntPtr)Marshal.SizeOf(typeof(IntPtr)), (ushort)Math.Log(Marshal.SizeOf(typeof(IntPtr)), 2.0), "@");
				}
				RegisterProperty(propertyInfo, type, zero2);
			}
			NSObject.OverrideRetainAndRelease(zero2);
			MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			for (int i = 0; i < methods.Length; i++)
			{
				RegisterMethod(methods[i], type, zero2);
			}
			ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
			if (constructor != null)
			{
				NativeConstructorBuilder nativeConstructorBuilder = new NativeConstructorBuilder(constructor);
				class_addMethod(zero2, nativeConstructorBuilder.Selector, nativeConstructorBuilder.Delegate, nativeConstructorBuilder.Signature);
				method_wrappers.Add(nativeConstructorBuilder.Delegate);
			}
			ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				if ((ExportAttribute)Attribute.GetCustomAttribute(constructorInfo, typeof(ExportAttribute)) != null)
				{
					NativeConstructorBuilder nativeConstructorBuilder2 = new NativeConstructorBuilder(constructorInfo);
					class_addMethod(zero2, nativeConstructorBuilder2.Selector, nativeConstructorBuilder2.Delegate, nativeConstructorBuilder2.Signature);
					method_wrappers.Add(nativeConstructorBuilder2.Delegate);
				}
			}
			objc_registerClassPair(zero2);
			type_map[zero2] = type;
			custom_types.Add(type, type);
			return zero2;
		}
	}

	private static void RegisterProperty(PropertyInfo prop, Type type, IntPtr handle)
	{
		ExportAttribute exportAttribute = (ExportAttribute)Attribute.GetCustomAttribute(prop, typeof(ExportAttribute));
		if (exportAttribute != null)
		{
			if (prop.PropertyType.IsGenericType || prop.PropertyType.IsGenericTypeDefinition)
			{
				throw new ArgumentException($"Cannot export the property '{prop.DeclaringType.FullName}.{prop.Name}': it is generic.");
			}
			MethodInfo getMethod = prop.GetGetMethod(nonPublic: true);
			if (getMethod != null)
			{
				RegisterMethod(getMethod, exportAttribute.ToGetter(prop), type, handle);
			}
			getMethod = prop.GetSetMethod(nonPublic: true);
			if (getMethod != null)
			{
				RegisterMethod(getMethod, exportAttribute.ToSetter(prop), type, handle);
			}
			int count = 0;
			objc_attribute_prop[] array = new objc_attribute_prop[3];
			array[count++] = new objc_attribute_prop
			{
				name = "T",
				value = TypeConverter.ToNative(prop.PropertyType)
			};
			switch (exportAttribute.ArgumentSemantic)
			{
			case ArgumentSemantic.Copy:
				array[count++] = new objc_attribute_prop
				{
					name = "C",
					value = ""
				};
				break;
			case ArgumentSemantic.Retain:
				array[count++] = new objc_attribute_prop
				{
					name = "&",
					value = ""
				};
				break;
			}
			array[count++] = new objc_attribute_prop
			{
				name = "V",
				value = exportAttribute.Selector
			};
			class_addProperty(handle, exportAttribute.Selector, array, count);
		}
	}

	private static void RegisterMethod(MethodInfo minfo, Type type, IntPtr handle)
	{
		ExportAttribute exportAttribute = (ExportAttribute)Attribute.GetCustomAttribute(minfo.GetBaseDefinition(), typeof(ExportAttribute));
		if (exportAttribute != null && (!minfo.IsVirtual || !(minfo.DeclaringType != type) || !(minfo.DeclaringType.Assembly == NSObject.MonoMacAssembly)))
		{
			RegisterMethod(minfo, exportAttribute, type, handle);
		}
	}

	private static IntPtr AllocExecMemory(int size)
	{
		if (size_left < size)
		{
			size_left = 4096;
			memory = Marshal.AllocHGlobal(size_left);
			if (memory == IntPtr.Zero)
			{
				throw new Exception($"Could not allocate memory for specialized x86 floating point stret delegate thunk: {Marshal.GetLastWin32Error()}");
			}
			if (mprotect(memory, size_left, 7) != 0)
			{
				throw new Exception($"Could not make allocated memory for specialized x86 floating point stret delegate thunk code executable: {Marshal.GetLastWin32Error()}");
			}
		}
		IntPtr result = memory;
		size_left -= size;
		memory = new IntPtr(memory.ToInt32() + size);
		return result;
	}

	private static bool TypeRequiresFloatingPointTrampoline(Type t)
	{
		if (IntPtr.Size != 4)
		{
			return false;
		}
		if (typeof(float) == t || typeof(double) == t)
		{
			return false;
		}
		if (!t.IsValueType || t.IsEnum)
		{
			return false;
		}
		if (Marshal.SizeOf(t) <= 8)
		{
			return false;
		}
		return TypeContainsFloatingPoint(t);
	}

	private static bool TypeContainsFloatingPoint(Type t)
	{
		if (!t.IsValueType || t.IsEnum || t.IsPrimitive)
		{
			return false;
		}
		FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			if (fieldInfo.FieldType == typeof(double) || fieldInfo.FieldType == typeof(float))
			{
				return true;
			}
			if (!(fieldInfo.FieldType == t) && TypeContainsFloatingPoint(fieldInfo.FieldType))
			{
				return true;
			}
		}
		return false;
	}

	private static IntPtr GetFunctionPointer(MethodInfo minfo, Delegate @delegate)
	{
		IntPtr functionPointerForDelegate = Marshal.GetFunctionPointerForDelegate(@delegate);
		if (!TypeRequiresFloatingPointTrampoline(minfo.ReturnType))
		{
			return functionPointerForDelegate;
		}
		IntPtr intPtr = AllocExecMemory(83);
		IntPtr intPtr2 = new IntPtr(functionPointerForDelegate.ToInt32() - intPtr.ToInt32() - 70);
		IntPtr intPtr3 = new IntPtr(getFrameLengthPtr.ToInt32() - intPtr.ToInt32() - 27);
		byte[] bytes = BitConverter.GetBytes(intPtr2.ToInt32());
		byte[] bytes2 = BitConverter.GetBytes(intPtr3.ToInt32());
		byte[] obj = new byte[83]
		{
			85, 137, 229, 86, 87, 83, 131, 236, 60, 139,
			69, 16, 137, 68, 36, 4, 139, 69, 12, 137,
			4, 36, 232, 0, 0, 0, 0, 137, 69, 240,
			131, 192, 15, 193, 232, 4, 193, 224, 4, 41,
			196, 139, 77, 240, 141, 117, 8, 137, 231, 131,
			249, 0, 116, 11, 131, 233, 4, 139, 4, 14,
			137, 4, 15, 235, 240, 232, 0, 0, 0, 0,
			139, 93, 244, 139, 125, 248, 139, 117, 252, 201,
			194, 4, 0
		};
		obj[23] = bytes2[0];
		obj[24] = bytes2[1];
		obj[25] = bytes2[2];
		obj[26] = bytes2[3];
		obj[66] = bytes[0];
		obj[67] = bytes[1];
		obj[68] = bytes[2];
		obj[69] = bytes[3];
		byte[] array = obj;
		Marshal.Copy(array, 0, intPtr, array.Length);
		return intPtr;
	}

	internal static void RegisterMethod(MethodInfo minfo, ExportAttribute ea, Type type, IntPtr handle)
	{
		NativeMethodBuilder nativeMethodBuilder = new NativeMethodBuilder(minfo, type, ea);
		class_addMethod(minfo.IsStatic ? object_getClass(handle) : handle, nativeMethodBuilder.Selector, GetFunctionPointer(minfo, nativeMethodBuilder.Delegate), nativeMethodBuilder.Signature);
		lock (lock_obj)
		{
			method_wrappers.Add(nativeMethodBuilder.Delegate);
		}
	}

	[DllImport("libc", SetLastError = true)]
	private static extern int mprotect(IntPtr addr, int len, int prot);

	[DllImport("libc", SetLastError = true)]
	private static extern IntPtr mmap(IntPtr start, ulong length, int prot, int flags, int fd, long offset);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern IntPtr objc_allocateClassPair(IntPtr superclass, string name, IntPtr extraBytes);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern IntPtr objc_getClass(string name);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern IntPtr objc_getProtocol(string name);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern void objc_registerClassPair(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern bool class_addIvar(IntPtr cls, string name, IntPtr size, ushort alignment, string types);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addMethod(IntPtr cls, IntPtr name, Delegate imp, string types);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addMethod(IntPtr cls, IntPtr name, IntPtr imp, string types);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern IntPtr class_getName(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getSuperclass(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr object_getClass(IntPtr obj);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getMethodImplementation(IntPtr cls, IntPtr sel);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getInstanceVariable(IntPtr cls, string name);

	private static IntPtr class_addProperty(IntPtr cls, string name, objc_attribute_prop[] attributes, int count)
	{
		if (!addPropertyInitialized)
		{
			IntPtr intPtr = Dlfcn.dlopen("/usr/lib/libobjc.dylib", 0);
			try
			{
				IntPtr intPtr2 = Dlfcn.dlsym(intPtr, "class_addProperty");
				if (intPtr2 != IntPtr.Zero)
				{
					addProperty = (addPropertyDelegate)Marshal.GetDelegateForFunctionPointer(intPtr2, typeof(addPropertyDelegate));
				}
			}
			finally
			{
				Dlfcn.dlclose(intPtr);
			}
			addPropertyInitialized = true;
		}
		if (addProperty == null)
		{
			return IntPtr.Zero;
		}
		return addProperty(cls, name, attributes, count);
	}
}
