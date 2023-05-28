using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Foundation;
namespace ObjCRuntime;

public class Class : INativeObject, IEquatable<Class>
{
	internal struct objc_attribute_prop
	{
		[MarshalAs(UnmanagedType.LPStr)]
		internal string name;

		[MarshalAs(UnmanagedType.LPStr)]
		internal string value;
	}

    #region

    private static object lock_obj = new object();
    private static Dictionary<IntPtr, Type> type_map = new Dictionary<IntPtr, Type>();
    private static Dictionary<Type, Type> custom_types = new Dictionary<Type, Type>();
    private static List<Delegate> method_wrappers = new List<Delegate>();

    #endregion

    public static bool ThrowOnInitFailure = true;

	private static Dictionary<Type, IntPtr> type_to_class;

	private static Type[] class_to_type;

	internal IntPtr handle;

	public IntPtr Handle => handle;

	public IntPtr SuperClass => class_getSuperclass(handle);

	public string Name
	{
		get
		{
			IntPtr ptr = class_getName(handle);
			return Marshal.PtrToStringAuto(ptr);
		}
	}

	internal static string GetName(IntPtr @class)
	{
		return Marshal.PtrToStringAuto(class_getName(@class));
	}

	static bool is_xamarin_initilized = false;

	[BindingImpl(BindingImplOptions.Optimizable)]
	internal unsafe static void Initialize(Runtime.InitializationOptions* options)
	{
		is_xamarin_initilized = true;
        type_to_class = new Dictionary<Type, IntPtr>(Runtime.TypeEqualityComparer);
		Runtime.MTRegistrationMap* registrationMap = options->RegistrationMap;
		if (registrationMap == null)
		{
			return;
		}
		class_to_type = new Type[registrationMap->map_count];
		if (Runtime.DynamicRegistrationSupported)
		{
			for (int i = 0; i < registrationMap->assembly_count; i++)
			{
				IntPtr ptr = Marshal.ReadIntPtr(registrationMap->assembly, i * IntPtr.Size);
				Runtime.Registrar.SetAssemblyRegistered(Marshal.PtrToStringAuto(ptr));
			}
		}
	}

	internal static void Initialize()
	{
		is_xamarin_initilized = false;
        type_to_class = new Dictionary<Type, IntPtr>(Runtime.TypeEqualityComparer);
		class_to_type = new Type[20];
        if (Runtime.DynamicRegistrationSupported)
        {
            //IntPtr ptr = Marshal.ReadIntPtr(assembly, IntPtr.Size);
            //Runtime.Registrar.SetAssemblyRegistered(Marshal.PtrToStringAuto(ptr));
        }
    }

    public Class(string name)
	{
		handle = objc_getClass(name);
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException($"'{name}' is an unknown class");
		}
	}

	public Class(Type type)
	{
		handle = GetClassHandle(type);
	}

	public Class(IntPtr handle)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	public Class(IntPtr handle, bool owns)
	{
		this.handle = handle;
	}

	internal static Class Construct(IntPtr handle)
	{
		return new Class(handle);
	}

	public static IntPtr GetHandle(string name)
	{
		return objc_getClass(name);
	}

	public override bool Equals(object right)
	{
		return Equals(right as Class);
	}

	public bool Equals(Class right)
	{
		if (right == null)
		{
			return false;
		}
		return handle == right.handle;
	}

	public override int GetHashCode()
	{
		return handle.GetHashCode();
	}

	public static IntPtr GetHandleIntrinsic(string name)
	{
		return objc_getClass(name);
	}

	public static IntPtr GetHandle(Type type)
	{
		return GetClassHandle(type);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	private static IntPtr GetClassHandle(Type type, bool throw_if_failure, out bool is_custom_type)
	{
		IntPtr value = IntPtr.Zero;
		if (type.IsByRef || type.IsPointer || type.IsArray)
		{
			is_custom_type = false;
			return IntPtr.Zero;
		}
		bool flag;
		lock (type_to_class)
		{
			flag = type_to_class.TryGetValue(type, out value);
		}
		if (!flag)
		{
			if (is_xamarin_initilized)
                value = FindClass(type, out is_custom_type);
			else
				value = FindClassEx(type, out is_custom_type);
			lock (type_to_class)
			{
				type_to_class[type] = value + (is_custom_type ? 1 : 0);
			}
		}
		else
		{
			is_custom_type = (value.ToInt64() & 1) == 1;
			if (is_custom_type)
			{
				value -= 1;
			}
		}
		if (value == IntPtr.Zero)
		{
			if (!Runtime.DynamicRegistrationSupported)
			{
				if (throw_if_failure)
				{
					throw ErrorHelper.CreateError(8026, "Can't register the class " + type.FullName + " when the dynamic registrar has been linked away.");
				}
				return IntPtr.Zero;
			}
			value = Register(type);
			is_custom_type = Runtime.Registrar.IsCustomType(type);
			lock (type_to_class)
			{
				type_to_class[type] = value + (is_custom_type ? 1 : 0);
			}
		}
		return value;
	}

	private static IntPtr GetClassHandle(Type type)
	{
		bool is_custom_type;
		return GetClassHandle(type, throw_if_failure: true, out is_custom_type);
	}

	internal static IntPtr GetClassForObject(IntPtr obj)
	{
		return Messaging.IntPtr_objc_msgSend(obj, Selector.GetHandle("class"));
	}

	internal static string LookupFullName(IntPtr klass)
	{
		Type type = Lookup(klass);
		return (type == null) ? null : type.FullName;
	}

	public static Type Lookup(Class @class)
	{
		return Lookup(@class.Handle, throw_on_error: true);
	}

	internal static Type Lookup(IntPtr klass)
	{
		return LookupClass(klass, throw_on_error: true);
	}

    #region

    private static int size_left;

    private static IntPtr memory;

    [MonoNativeFunctionWrapper]
    private delegate int getFrameLengthDelegate(IntPtr @this, IntPtr sel);

    private static IntPtr getFrameLengthPtr = Marshal.GetFunctionPointerForDelegate<Class.getFrameLengthDelegate>(Class.getFrameLength);

    private static Class.getFrameLengthDelegate getFrameLength = new Class.getFrameLengthDelegate(Selector.GetFrameLength);


    internal static Type LookupEx(IntPtr klass) => Class.LookupEx(klass, true);

    internal static Type LookupEx(IntPtr klass, bool throw_on_error)
    {
        lock (Class.lock_obj)
        {
            Type type;
            if (Class.type_map.TryGetValue(klass, out type))
                return type;
            IntPtr num = klass;
            while (true)
            {
                IntPtr superclass = Class.class_getSuperclass(klass);
                if (!Class.type_map.TryGetValue(superclass, out type))
                {
                    if (!(superclass == IntPtr.Zero))
                        klass = superclass;
                    else
                        goto label_7;
                }
                else
                    break;
            }
            Class.type_map[num] = type;
            return type;
        label_7:
            if (!throw_on_error)
                return (Type)null;
            throw new ArgumentException("Could not find a valid superclass for type " + new Class(num).Name + ". Did you forget to register the bindings at " + typeof(Class).FullName + ".Register() or call NSApplication.Init()?");
        }
    }

    internal static Type Lookup(IntPtr klass, bool throw_on_error)
	{
		return LookupClass(klass, throw_on_error);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	private static Type LookupClass(IntPtr klass, bool throw_on_error)
	{
		IntPtr intPtr = klass;
		do
		{
			bool is_custom_type;
			Type type = FindType(intPtr, out is_custom_type);
			if (type != null)
			{
				return type;
			}
			if (Runtime.DynamicRegistrationSupported)
			{
				break;
			}
			intPtr = class_getSuperclass(intPtr);
		}
		while (intPtr != IntPtr.Zero);
		if (Runtime.DynamicRegistrationSupported)
		{
			return Runtime.Registrar.Lookup(klass, throw_on_error);
		}
		if (throw_on_error)
		{
			throw ErrorHelper.CreateError(8026, string.Format("Can't lookup the Objective-C class 0x{0} ({1}) when the dynamic registrar has been linked away.", klass.ToString("x"), class_getName(klass)));
		}
		return null;
	}

	internal static IntPtr Register(Type type)
	{
		return Runtime.Registrar.Register(type);
	}

    public static IntPtr FindClassEx(Type type, out bool is_custom_type)
    {
        is_custom_type = false;
        var customAttribute = (RegisterAttribute)Attribute.GetCustomAttribute((MemberInfo)type, typeof(RegisterAttribute), false);
        var name = customAttribute == null ? type.FullName : customAttribute.Name ?? type.FullName;
        bool is_wrapper = customAttribute != null && customAttribute.IsWrapper;
        IntPtr handle = Class.object_getClass(name);
        if (handle == IntPtr.Zero)
            handle = Class.Register(type, name, is_wrapper);

        return handle;
    }

    private static IntPtr Register(Type type, string name, bool is_wrapper)
    {
        IntPtr zero1 = IntPtr.Zero;
        IntPtr zero2 = IntPtr.Zero;
        IntPtr key = Class.objc_getClass(name);
        lock (Class.lock_obj)
        {
            if (key != IntPtr.Zero)
            {
                if (!Class.type_map.ContainsKey(key))
                    Class.type_map[key] = type;
                return key;
            }
            if (Class.objc_getProtocol(name) != IntPtr.Zero)
                throw new ArgumentException("Attempting to register a class named: " + name + " which is a valid protocol");
            if (is_wrapper)
                return IntPtr.Zero;
            Type baseType = type.BaseType;
            while (Attribute.IsDefined((MemberInfo)baseType, typeof(ModelAttribute), false))
                baseType = baseType.BaseType;
            RegisterAttribute customAttribute1 = (RegisterAttribute)Attribute.GetCustomAttribute((MemberInfo)baseType, typeof(RegisterAttribute), false);
            string name1 = customAttribute1 == null ? baseType.FullName : customAttribute1.Name ?? baseType.FullName;
            IntPtr superclass = Class.objc_getClass(name1);
            if (superclass == IntPtr.Zero && (baseType.Assembly != NSObject.MonoMacAssembly))
            {
                bool is_wrapper1 = customAttribute1 != null && customAttribute1.IsWrapper;
                Class.Register(baseType, name1, is_wrapper1);
                superclass = Class.objc_getClass(name1);
            }
            if (superclass == IntPtr.Zero)
                superclass = Class.objc_getClass("NSObject");
            IntPtr num = Class.objc_allocateClassPair(superclass, name, IntPtr.Zero);
            foreach (PropertyInfo property in type.GetProperties((BindingFlags)54))
            {
                ConnectAttribute customAttribute2 = (ConnectAttribute)Attribute.GetCustomAttribute((MemberInfo)property, typeof(ConnectAttribute));
                if (customAttribute2 != null)
                {
                    string name2 = customAttribute2.Name ?? ((MemberInfo)property).Name;
                    Class.class_addIvar(num, name2, (IntPtr)Marshal.SizeOf(typeof(IntPtr)), (ushort)Math.Log((double)Marshal.SizeOf(typeof(IntPtr)), 2.0), "@");
                }
                Class.RegisterProperty(property, type, num);
            }

            NSObject.OverrideRetainAndRelease(num);

            foreach (MethodInfo method in type.GetMethods((BindingFlags)62))
                Class.RegisterMethod(method, type, num);

            ConstructorInfo constructor1 = type.GetConstructor(Type.EmptyTypes);

            if (constructor1 is not null)
            {
                NativeConstructorBuilder constructorBuilder = new NativeConstructorBuilder(constructor1);
                Class.class_addMethod(num, constructorBuilder.Selector, constructorBuilder.Delegate, constructorBuilder.Signature);
                Class.method_wrappers.Add(constructorBuilder.Delegate);
            }
            foreach (ConstructorInfo constructor2 in type.GetConstructors((BindingFlags)60))
            {
                if ((ExportAttribute)Attribute.GetCustomAttribute((MemberInfo)constructor2, typeof(ExportAttribute)) != null)
                {
                    NativeConstructorBuilder constructorBuilder = new NativeConstructorBuilder(constructor2);
                    Class.class_addMethod(num, constructorBuilder.Selector, constructorBuilder.Delegate, constructorBuilder.Signature);
                    Class.method_wrappers.Add(constructorBuilder.Delegate);
                }
            }
            Class.objc_registerClassPair(num);
            Class.type_map[num] = type;
            Class.custom_types.Add(type, type);
            return num;
        }
    }

    private static void RegisterProperty(PropertyInfo prop, Type type, IntPtr handle)
    {
        ExportAttribute customAttribute = (ExportAttribute)Attribute.GetCustomAttribute((MemberInfo)prop, typeof(ExportAttribute));
        if (customAttribute == null)
            return;
        if (prop.PropertyType.IsGenericType || prop.PropertyType.IsGenericTypeDefinition)
            throw new ArgumentException(string.Format("Cannot export the property '{0}.{1}': it is generic.", (object)((MemberInfo)prop).DeclaringType.FullName, (object)((MemberInfo)prop).Name));
        
        MethodInfo getMethod = prop.GetGetMethod(true);
        if (getMethod is not null)
            Class.RegisterMethod(getMethod, customAttribute.ToGetter(prop), type, handle);
        
        MethodInfo setMethod = prop.GetSetMethod(true);
        if (setMethod is not null)
            Class.RegisterMethod(setMethod, customAttribute.ToSetter(prop), type, handle);

        int num1 = 0;
        Class.objc_attribute_prop[] attributes = new Class.objc_attribute_prop[3];
        Class.objc_attribute_prop[] objcAttributePropArray1 = attributes;

        int index1 = num1;
        int num2 = index1 + 1;
        Class.objc_attribute_prop objcAttributeProp1 = new Class.objc_attribute_prop();

        objcAttributeProp1.name = "T";
        objcAttributeProp1.value = TypeConverter.ToNative(prop.PropertyType);
        Class.objc_attribute_prop objcAttributeProp2 = objcAttributeProp1;
        objcAttributePropArray1[index1] = objcAttributeProp2;
        switch (customAttribute.ArgumentSemantic)
        {
            case ArgumentSemantic.Copy:
                Class.objc_attribute_prop[] objcAttributePropArray2 = attributes;
                int index2 = num2++;
                objcAttributeProp1 = new Class.objc_attribute_prop();
                objcAttributeProp1.name = "C";
                objcAttributeProp1.value = "";
                Class.objc_attribute_prop objcAttributeProp3 = objcAttributeProp1;
                objcAttributePropArray2[index2] = objcAttributeProp3;
                break;
            case ArgumentSemantic.Retain:
                Class.objc_attribute_prop[] objcAttributePropArray3 = attributes;
                int index3 = num2++;
                objcAttributeProp1 = new Class.objc_attribute_prop();
                objcAttributeProp1.name = "&";
                objcAttributeProp1.value = "";
                Class.objc_attribute_prop objcAttributeProp4 = objcAttributeProp1;
                objcAttributePropArray3[index3] = objcAttributeProp4;
                break;
        }
        Class.objc_attribute_prop[] objcAttributePropArray4 = attributes;
        int index4 = num2;
        int count = index4 + 1;
        objcAttributeProp1 = new Class.objc_attribute_prop();
        objcAttributeProp1.name = "V";
        objcAttributeProp1.value = customAttribute.Selector;
        Class.objc_attribute_prop objcAttributeProp5 = objcAttributeProp1;
        objcAttributePropArray4[index4] = objcAttributeProp5;
        Class.class_addProperty(handle, customAttribute.Selector, attributes, count);
    }

    private static void RegisterMethod(MethodInfo minfo, Type type, IntPtr handle)
    {
        ExportAttribute customAttribute = (ExportAttribute)Attribute.GetCustomAttribute((MemberInfo)minfo.GetBaseDefinition(), typeof(ExportAttribute));
        if (customAttribute == null || ((MethodBase)minfo).IsVirtual && ((MemberInfo)minfo).DeclaringType != type &&  (((MemberInfo)minfo).DeclaringType.Assembly != NSObject.MonoMacAssembly))
            return;
        Class.RegisterMethod(minfo, customAttribute, type, handle);
    }

    internal static void RegisterMethod( MethodInfo minfo, ExportAttribute ea, Type type,  IntPtr handle)
    {
        NativeMethodBuilder nativeMethodBuilder = new NativeMethodBuilder(minfo, type, ea);
        Class.class_addMethod(((MethodBase)minfo).IsStatic ? Class.object_getClass(handle) : handle, nativeMethodBuilder.Selector, Class.GetFunctionPointer(minfo, nativeMethodBuilder.Delegate), nativeMethodBuilder.Signature);
        lock (Class.lock_obj)
            Class.method_wrappers.Add(nativeMethodBuilder.Delegate);
    }

    private static IntPtr GetFunctionPointer(MethodInfo minfo, Delegate @delegate)
    {
        IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate(@delegate);
        if (!Class.TypeRequiresFloatingPointTrampoline(minfo.ReturnType))
            return pointerForDelegate;
        IntPtr destination = Class.AllocExecMemory(83);
        IntPtr num1 = new IntPtr(pointerForDelegate.ToInt32() - destination.ToInt32() - 70);
        IntPtr num2 = new IntPtr(Class.getFrameLengthPtr.ToInt32() - destination.ToInt32() - 27);
        byte[] bytes1 = BitConverter.GetBytes(num1.ToInt32());
        byte[] bytes2 = BitConverter.GetBytes(num2.ToInt32());
        byte[] source = new byte[83]
        {
        (byte) 85,
        (byte) 137,
        (byte) 229,
        (byte) 86,
        (byte) 87,
        (byte) 83,
        (byte) 131,
        (byte) 236,
        (byte) 60,
        (byte) 139,
        (byte) 69,
        (byte) 16,
        (byte) 137,
        (byte) 68,
        (byte) 36,
        (byte) 4,
        (byte) 139,
        (byte) 69,
        (byte) 12,
        (byte) 137,
        (byte) 4,
        (byte) 36,
        (byte) 232,
        bytes2[0],
        bytes2[1],
        bytes2[2],
        bytes2[3],
        (byte) 137,
        (byte) 69,
        (byte) 240,
        (byte) 131,
        (byte) 192,
        (byte) 15,
        (byte) 193,
        (byte) 232,
        (byte) 4,
        (byte) 193,
        (byte) 224,
        (byte) 4,
        (byte) 41,
        (byte) 196,
        (byte) 139,
        (byte) 77,
        (byte) 240,
        (byte) 141,
        (byte) 117,
        (byte) 8,
        (byte) 137,
        (byte) 231,
        (byte) 131,
        (byte) 249,
        (byte) 0,
        (byte) 116,
        (byte) 11,
        (byte) 131,
        (byte) 233,
        (byte) 4,
        (byte) 139,
        (byte) 4,
        (byte) 14,
        (byte) 137,
        (byte) 4,
        (byte) 15,
        (byte) 235,
        (byte) 240,
        (byte) 232,
        bytes1[0],
        bytes1[1],
        bytes1[2],
        bytes1[3],
        (byte) 139,
        (byte) 93,
        (byte) 244,
        (byte) 139,
        (byte) 125,
        (byte) 248,
        (byte) 139,
        (byte) 117,
        (byte) 252,
        (byte) 201,
        (byte) 194,
        (byte) 4,
        (byte) 0
        };
        Marshal.Copy(source, 0, destination, source.Length);
        return destination;
    }

    private static bool TypeRequiresFloatingPointTrampoline(Type t) => IntPtr.Size == 4 && !(typeof(float) == t) && !(typeof(double) == t) && t.IsValueType && !t.IsEnum && Marshal.SizeOf(t) > 8 && Class.TypeContainsFloatingPoint(t);

    private static bool TypeContainsFloatingPoint(Type t)
    {
        if (!t.IsValueType || t.IsEnum || t.IsPrimitive)
            return false;
        foreach (FieldInfo field in t.GetFields((BindingFlags)52))
        {
            if (field.FieldType == typeof(double) || field.FieldType == typeof(float) || !(field.FieldType == t) && Class.TypeContainsFloatingPoint(field.FieldType))
                return true;
        }
        return false;
    }

    private static IntPtr AllocExecMemory(int size)
    {
        if (Class.size_left < size)
        {
            Class.size_left = 4096;
            Class.memory = Marshal.AllocHGlobal(Class.size_left);
            if (Class.memory == IntPtr.Zero)
                throw new Exception(string.Format("Could not allocate memory for specialized x86 floating point stret delegate thunk: {0}", (object)Marshal.GetLastWin32Error()));
            if (Class.mprotect(Class.memory, Class.size_left, 7) != 0)
                throw new Exception(string.Format("Could not make allocated memory for specialized x86 floating point stret delegate thunk code executable: {0}", (object)Marshal.GetLastWin32Error()));
        }
        IntPtr memory = Class.memory;
        Class.size_left -= size;
        Class.memory = new IntPtr(Class.memory.ToInt32() + size);
        return memory;
    }

    [DllImport("libc", SetLastError = true)]
    private static extern int mprotect(IntPtr addr, int len, int prot);

    #endregion

    private unsafe static IntPtr FindClass(Type type, out bool is_custom_type)
	{
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		is_custom_type = false;
		if (registrationMap == null)
		{
			return IntPtr.Zero;
		}
		if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}
		string name = type.Assembly.GetName().Name;
		int metadataToken = type.Module.MetadataToken;
		int type_token = type.MetadataToken & -33554433;
		for (int i = 0; i < registrationMap->map_count; i++)
		{
			Runtime.MTClassMap mTClassMap = registrationMap->map[i];
			uint type_reference = mTClassMap.type_reference;
			if (CompareTokenReference(name, metadataToken, type_token, type_reference))
			{
				IntPtr result = mTClassMap.handle;
				is_custom_type = (mTClassMap.flags & Runtime.MTTypeFlags.CustomType) == Runtime.MTTypeFlags.CustomType;
				return result;
			}
		}
		for (int j = 0; j < registrationMap->skipped_map_count; j++)
		{
			Runtime.MTManagedClassMap mTManagedClassMap = registrationMap->skipped_map[j];
			uint skipped_reference = mTManagedClassMap.skipped_reference;
			if (!CompareTokenReference(name, metadataToken, type_token, skipped_reference))
			{
				continue;
			}
			uint actual_reference = mTManagedClassMap.actual_reference;
			for (int k = 0; k < registrationMap->map_count; k++)
			{
				Runtime.MTClassMap mTClassMap2 = registrationMap->map[k];
				if (mTClassMap2.type_reference == actual_reference)
				{
					return mTClassMap2.handle;
				}
			}
		}
		return IntPtr.Zero;
	}

	private unsafe static bool CompareTokenReference(string asm_name, int mod_token, int type_token, uint token_reference)
	{
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		IntPtr utf;
		if ((token_reference & 1) == 1)
		{
			int num = (int)(token_reference >> 1);
			IntPtr intPtr = Runtime.options->RegistrationMap->full_token_references + (IntPtr.Size + 8) * num;
			uint num2 = (uint)Marshal.ReadInt32(intPtr + IntPtr.Size + 4);
			if (type_token != num2)
			{
				return false;
			}
			uint num3 = (uint)Marshal.ReadInt32(intPtr + IntPtr.Size);
			if (mod_token != num3)
			{
				return false;
			}
			utf = Marshal.ReadIntPtr(intPtr);
		}
		else
		{
			if (token_reference >> 8 != type_token)
			{
				return false;
			}
			uint num4 = (token_reference >> 1) & 0x7Fu;
			utf = Marshal.ReadIntPtr(registrationMap->assembly, (int)num4 * IntPtr.Size);
		}
		return Runtime.StringEquals(utf, asm_name);
	}

	private unsafe static int FindMapIndex(Runtime.MTClassMap* array, int lo, int hi, IntPtr @class)
	{
		if (hi >= lo)
		{
			int num = lo + (hi - lo) / 2;
			IntPtr intPtr = array[num].handle;
			if (intPtr == @class)
			{
				return num;
			}
			if (intPtr.ToInt64() > @class.ToInt64())
			{
				return FindMapIndex(array, lo, num - 1, @class);
			}
			return FindMapIndex(array, num + 1, hi, @class);
		}
		return -1;
	}

	internal unsafe static Type FindType(IntPtr @class, out bool is_custom_type)
	{
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		is_custom_type = false;
		if (registrationMap == null)
		{
			return null;
		}
		int num = FindMapIndex(registrationMap->map, 0, registrationMap->map_count - 1, @class);
		if (num == -1)
		{
			return null;
		}
		is_custom_type = (registrationMap->map[num].flags & Runtime.MTTypeFlags.CustomType) == Runtime.MTTypeFlags.CustomType;
		Type type = class_to_type[num];
		if (type != null)
		{
			return type;
		}
		uint type_reference = registrationMap->map[num].type_reference;
		type = ResolveTypeTokenReference(type_reference);
		class_to_type[num] = type;
		return type;
	}

	internal unsafe static MemberInfo ResolveFullTokenReference(uint token_reference)
	{
		IntPtr intPtr = Runtime.options->RegistrationMap->full_token_references + (IntPtr.Size + 8) * (int)(token_reference >> 1);
		IntPtr assembly_name = Marshal.ReadIntPtr(intPtr);
		uint token = (uint)Marshal.ReadInt32(intPtr + IntPtr.Size);
		uint token2 = (uint)Marshal.ReadInt32(intPtr + IntPtr.Size + 4);
		Assembly assembly = ResolveAssembly(assembly_name);
		Module module = ResolveModule(assembly, token);
		return ResolveToken(module, token2);
	}

	internal static Type ResolveTypeTokenReference(uint token_reference)
	{
		MemberInfo memberInfo = ResolveTokenReference(token_reference, 33554432u);
		if (memberInfo == null)
		{
			return null;
		}
		if (memberInfo is Type result)
		{
			return result;
		}
		throw ErrorHelper.CreateError(8022, $"Expected the token reference 0x{token_reference:X} to be a type, but it's a {memberInfo.GetType().Name}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new.");
	}

	internal static MethodBase ResolveMethodTokenReference(uint token_reference)
	{
		MemberInfo memberInfo = ResolveTokenReference(token_reference, 100663296u);
		if (memberInfo == null)
		{
			return null;
		}
		if (memberInfo is MethodBase result)
		{
			return result;
		}
		throw ErrorHelper.CreateError(8022, $"Expected the token reference 0x{token_reference:X} to be a method, but it's a {memberInfo.GetType().Name}. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new.");
	}

	private unsafe static MemberInfo ResolveTokenReference(uint token_reference, uint implicit_token_type)
	{
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		if ((token_reference & 1) == 1)
		{
			return ResolveFullTokenReference(token_reference);
		}
		uint num = (token_reference >> 1) & 0x7Fu;
		uint num2 = (token_reference >> 8) + implicit_token_type;
		IntPtr assembly_name = Marshal.ReadIntPtr(registrationMap->assembly, (int)num * IntPtr.Size);
		Assembly assembly = ResolveAssembly(assembly_name);
		Module module = ResolveModule(assembly, 1u);
		return ResolveToken(module, num2 | implicit_token_type);
	}

	private static MemberInfo ResolveToken(Module module, uint token)
	{
		uint num = token & 0xFF000000u;
		return (token & 0xFF000000u) switch
		{
			33554432u => module.ResolveType((int)token), 
			100663296u => module.ResolveMethod((int)token), 
			_ => throw ErrorHelper.CreateError(8021, $"Unknown implicit token type: 0x{num:X}."), 
		};
	}

	private static Module ResolveModule(Assembly assembly, uint token)
	{
		Module[] modules = assembly.GetModules();
		foreach (Module module in modules)
		{
			if (module.MetadataToken == token)
			{
				return module;
			}
		}
		throw ErrorHelper.CreateError(8020, $"Could not find the module with MetadataToken 0x{token:X} in the assembly {assembly}.");
	}

	private static Assembly ResolveAssembly(IntPtr assembly_name)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			if (Runtime.StringEquals(assembly_name, assembly.GetName().Name))
			{
				return assembly;
			}
		}
		throw ErrorHelper.CreateError(8019, "Could not find the assembly " + Marshal.PtrToStringAuto(assembly_name) + " in the loaded assemblies.");
	}

	internal unsafe static uint GetTokenReference(Type type, bool throw_exception = true)
	{
		if (type.IsGenericType)
		{
			type = type.GetGenericTypeDefinition();
		}
		string name = type.Module.Assembly.GetName().Name;
		uint fullTokenReference = GetFullTokenReference(name, type.Module.MetadataToken, type.MetadataToken);
		if (fullTokenReference != uint.MaxValue)
		{
			return fullTokenReference;
		}
		if (type.Module.MetadataToken != 1)
		{
			if (!throw_exception)
			{
				return uint.MaxValue;
			}
			throw ErrorHelper.CreateError(8025, $"Failed to compute the token reference for the type '{type.AssemblyQualifiedName}' because its module's metadata token is {type.Module.MetadataToken} when expected 1.");
		}
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		int num = -1;
		for (int i = 0; i < registrationMap->assembly_count; i++)
		{
			IntPtr utf = Marshal.ReadIntPtr(registrationMap->assembly, i * IntPtr.Size);
			if (Runtime.StringEquals(utf, name))
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			if (!throw_exception)
			{
				return uint.MaxValue;
			}
			throw ErrorHelper.CreateError(8025, "Failed to compute the token reference for the type '" + type.AssemblyQualifiedName + "' because the assembly couldn't be found in the list of registered assemblies.");
		}
		if (num > 127)
		{
			if (!throw_exception)
			{
				return uint.MaxValue;
			}
			throw ErrorHelper.CreateError(8025, $"Failed to compute the token reference for the type '{type.AssemblyQualifiedName}' because the assembly index {num} is not valid (must be <= 127).");
		}
		return (uint)((type.MetadataToken << 8) + (num << 1));
	}

	private unsafe static uint GetFullTokenReference(string assembly_name, int module_token, int metadata_token)
	{
		Runtime.MTRegistrationMap* registrationMap = Runtime.options->RegistrationMap;
		for (int i = 0; i < registrationMap->full_token_reference_count; i++)
		{
			IntPtr intPtr = registrationMap->full_token_references + i * (IntPtr.Size + 8);
			IntPtr utf = Marshal.ReadIntPtr(intPtr);
			int num = Marshal.ReadInt32(intPtr + IntPtr.Size + 4);
			if (num == metadata_token)
			{
				int num2 = Marshal.ReadInt32(intPtr + IntPtr.Size);
				if (num2 == module_token && Runtime.StringEquals(utf, assembly_name))
				{
					return (uint)((i << 1) + 1);
				}
			}
		}
		return uint.MaxValue;
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	internal static bool IsCustomType(Type type)
	{
		bool is_custom_type;
		IntPtr classHandle = GetClassHandle(type, throw_if_failure: false, out is_custom_type);
		if (classHandle != IntPtr.Zero)
		{
			return is_custom_type;
		}
		if (Runtime.DynamicRegistrationSupported)
		{
			return Runtime.Registrar.IsCustomType(type);
		}
		throw ErrorHelper.CreateError(8026, "Can't determine if " + type.FullName + " is a custom type when the dynamic registrar has been linked away.");
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr objc_allocateClassPair(IntPtr superclass, string name, IntPtr extraBytes);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr objc_getClass(string name);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern void objc_registerClassPair(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addIvar(IntPtr cls, string name, IntPtr size, byte alignment, string types);


    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern bool class_addIvar(IntPtr cls, string name, IntPtr size,  ushort alignment, string types);


    [DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addMethod(IntPtr cls, IntPtr name, IntPtr imp, string types);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addMethod(IntPtr cls, IntPtr name, Delegate imp, string types);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern bool class_addProtocol(IntPtr cls, IntPtr protocol);

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr objc_getProtocol(string name);

    [DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getName(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getSuperclass(IntPtr cls);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr object_getClass(IntPtr obj);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr object_getClass(string name);

    [DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getMethodImplementation(IntPtr cls, IntPtr sel);

	[DllImport("/usr/lib/libobjc.dylib")]
	internal static extern IntPtr class_getInstanceVariable(IntPtr cls, string name);

	[DllImport("/usr/lib/libobjc.dylib", CharSet = CharSet.Ansi)]
	internal static extern bool class_addProperty(IntPtr cls, string name, objc_attribute_prop[] attributes, int count);
}

