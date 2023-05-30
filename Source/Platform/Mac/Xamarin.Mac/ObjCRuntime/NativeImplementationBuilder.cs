using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Foundation;

namespace ObjCRuntime;

internal abstract class NativeImplementationBuilder
{
	internal static AssemblyBuilder builder;

	internal static ModuleBuilder module;

	private static MethodInfo convertarray;

	private static MethodInfo convertsarray;

	private static MethodInfo convertstring;

	private static MethodInfo getobject;

	private static MethodInfo gethandle;

	private static FieldInfo intptrzero;

	private Delegate del;

	internal int ArgumentOffset { get; set; }

	internal IntPtr Selector { get; set; }

	internal Type[] ParameterTypes { get; set; }

	internal ParameterInfo[] Parameters { get; set; }

	internal Delegate Delegate
	{
		get
		{
			if ((object)del == null)
			{
				del = CreateDelegate();
			}
			return del;
		}
	}

	internal Type DelegateType { get; set; }

	internal string Signature { get; set; }

	static NativeImplementationBuilder()
	{
		convertarray = typeof(NSArray).GetMethod("ArrayFromHandle", new Type[1] { typeof(IntPtr) });
		convertsarray = typeof(NSArray).GetMethod("StringArrayFromHandle", new Type[1] { typeof(IntPtr) });
		convertstring = typeof(NSString).GetMethod("ToString", Type.EmptyTypes);
		getobject = typeof(Runtime).GetMethod("GetNSObject", BindingFlags.Static | BindingFlags.Public);
		gethandle = typeof(NSObject).GetMethod("get_Handle", BindingFlags.Instance | BindingFlags.Public);
		intptrzero = typeof(IntPtr).GetField("Zero", BindingFlags.Static | BindingFlags.Public);
		builder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
		module = builder.DefineDynamicModule("Implementations");
	}

	internal abstract Delegate CreateDelegate();

	protected Type CreateDelegateType(Type return_type, Type[] argument_types)
	{
		TypeBuilder typeBuilder = module.DefineType(Guid.NewGuid().ToString(), TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(MulticastDelegate));
		typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[2]
		{
			typeof(object),
			typeof(int)
		}).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
		MethodBuilder methodBuilder = null;
		methodBuilder = typeBuilder.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, return_type, argument_types);
		if (NeedsCustomMarshaler(return_type))
		{
			SetupParameter(methodBuilder, 0, return_type);
		}
		for (int i = 1; i <= argument_types.Length; i++)
		{
			if (NeedsCustomMarshaler(argument_types[i - 1]))
			{
				SetupParameter(methodBuilder, i, argument_types[i - 1]);
			}
		}
		methodBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
		return typeBuilder.CreateTypeInfo().AsType();
	}

	private bool NeedsCustomMarshaler(Type t)
	{
		if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
		{
			return true;
		}
		if (t == typeof(Selector))
		{
			return true;
		}
		return false;
	}

	private Type MarshalerForType(Type t)
	{
		if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
		{
			return typeof(NSObjectMarshaler<>).MakeGenericType(t);
		}
		if (t == typeof(Selector))
		{
			return typeof(SelectorMarshaler);
		}
		throw new ArgumentException("Cannot determine marshaler type for: " + t);
	}

	private void SetupParameter(MethodBuilder builder, int index, Type t)
	{
		ParameterBuilder parameterBuilder = builder.DefineParameter(index, ParameterAttributes.HasFieldMarshal, $"arg{index}");
		ConstructorInfo? constructor = typeof(MarshalAsAttribute).GetConstructor(new Type[1] { typeof(UnmanagedType) });
		FieldInfo field = typeof(MarshalAsAttribute).GetField("MarshalTypeRef");
		CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, new object[1] { UnmanagedType.CustomMarshaler }, new FieldInfo[1] { field }, new object[1] { MarshalerForType(t) });
		parameterBuilder.SetCustomAttribute(customAttribute);
	}

	protected bool IsWrappedType(Type type)
	{
		if (type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)) || type == typeof(string))
		{
			return true;
		}
		return false;
	}

	protected void ConvertParameters(ParameterInfo[] parms, bool isstatic, bool isstret)
	{
		if (isstret)
		{
			ArgumentOffset = 3;
			ParameterTypes = new Type[ArgumentOffset + parms.Length];
			ParameterTypes[0] = typeof(IntPtr);
			ParameterTypes[1] = (isstatic ? typeof(IntPtr) : typeof(NSObject));
			ParameterTypes[2] = typeof(Selector);
		}
		else
		{
			ArgumentOffset = 2;
			ParameterTypes = new Type[ArgumentOffset + parms.Length];
			ParameterTypes[0] = (isstatic ? typeof(IntPtr) : typeof(NSObject));
			ParameterTypes[1] = typeof(Selector);
		}
		for (int i = 0; i < Parameters.Length; i++)
		{
            var parameterInfo = Parameters[i];
            var parameterType = parameterInfo.ParameterType;
 
            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (parameterType.IsByRef && IsWrappedType(parameterType.GetElementType()))
			{
				ParameterTypes[i + ArgumentOffset] = typeof(IntPtr).MakeByRefType();
			}
			else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
			{
				ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
			}
			else if (typeof(INativeObject).IsAssignableFrom(parameterType) && !IsWrappedType(parameterType))
			{
				ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
			}
			else if (parameterType == typeof(string))
			{
				ParameterTypes[i + ArgumentOffset] = typeof(NSString);
			}
			else
			{
				ParameterTypes[i + ArgumentOffset] = parameterType;
			}
			Signature += TypeConverter.ToNative(parameterType);
		}
	}

	protected void DeclareLocals(ILGenerator il)
	{
		for (int i = 0; i < Parameters.Length; i++)
		{
            var parameterInfo = Parameters[i];
            var parameterType = parameterInfo.ParameterType;

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (parameterType.IsByRef && IsWrappedType(parameterType.GetElementType()))
			{
				il.DeclareLocal(parameterType.GetElementType());
			}
			else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
			{
				il.DeclareLocal(parameterType);
			}
			else if (parameterType == typeof(string))
			{
				il.DeclareLocal(typeof(string));
			}
		}
	}

	protected void ConvertArguments(ILGenerator il, int locoffset)
	{
		int i = ArgumentOffset;
		int num = 0;
		for (; i < ParameterTypes.Length; i++)
		{
            var parameterInfo = Parameters[i - ArgumentOffset];
            var parameterType = parameterInfo.ParameterType;

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (parameterType.IsByRef && Attribute.GetCustomAttribute(parameterInfo, typeof(OutAttribute)) == null && IsWrappedType(parameterType.GetElementType()))
			{
				Label label = il.DefineLabel();
				Label label2 = il.DefineLabel();
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Brfalse, label);
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Ldind_I);
				il.Emit(OpCodes.Call, getobject);
				il.Emit(OpCodes.Br, label2);
				il.MarkLabel(label);
				il.Emit(OpCodes.Ldnull);
				il.MarkLabel(label2);
				il.Emit(OpCodes.Stloc, num + locoffset);
				num++;
			}
			else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
			{
				Label label3 = il.DefineLabel();
				Label label4 = il.DefineLabel();
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Brfalse, label3);
				il.Emit(OpCodes.Ldarg, i);
				if (parameterType.GetElementType() == typeof(string))
				{
					il.Emit(OpCodes.Call, convertsarray);
				}
				else
				{
					il.Emit(OpCodes.Call, convertarray.MakeGenericMethod(parameterType.GetElementType()));
				}
				il.Emit(OpCodes.Br, label4);
				il.MarkLabel(label3);
				il.Emit(OpCodes.Ldnull);
				il.MarkLabel(label4);
				il.Emit(OpCodes.Stloc, num + locoffset);
				num++;
			}
			else if (parameterType == typeof(string))
			{
				Label label5 = il.DefineLabel();
				Label label6 = il.DefineLabel();
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Brfalse, label5);
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Call, convertstring);
				il.Emit(OpCodes.Br, label6);
				il.MarkLabel(label5);
				il.Emit(OpCodes.Ldnull);
				il.MarkLabel(label6);
				il.Emit(OpCodes.Stloc, num + locoffset);
				num++;
			}
		}
	}

	protected void LoadArguments(ILGenerator il, int locoffset)
	{
		int i = ArgumentOffset;
		int num = 0;
		for (; i < ParameterTypes.Length; i++)
		{
            var parameterInfo = Parameters[i - ArgumentOffset];
            var parameterType = parameterInfo.ParameterType;

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (parameterType.IsInterface && typeof(INativeObject).IsAssignableFrom(parameterType))
            {
                //此处需要获取对象的构造函数，由于这里使用了Interface所以大概率这里或抱错获取不到构造
                var protocolAttribute = parameterType.GetCustomAttribute<ProtocolAttribute>();
                if (protocolAttribute is null)
                    continue;

                var wrapperType = protocolAttribute.WrapperType;
                var constructorInfo = wrapperType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(IntPtr) }, null);
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Newobj, constructorInfo);
            }
            else if (parameterType.IsByRef && IsWrappedType(parameterType.GetElementType()))
			{
				il.Emit(OpCodes.Ldloca_S, num + locoffset);
				num++;
			}
			else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
			{
				il.Emit(OpCodes.Ldloc, num + locoffset);
				num++;
			}
			else if (typeof(INativeObject).IsAssignableFrom(parameterType) && !IsWrappedType(parameterType))
			{
				il.Emit(OpCodes.Ldarg, i); 
				il.Emit(OpCodes.Newobj, parameterType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(IntPtr) }, null));
			}
			else if (parameterType == typeof(string))
			{
				il.Emit(OpCodes.Ldloc, num + locoffset);
				num++;
			}
			else
			{
				il.Emit(OpCodes.Ldarg, i);
			}
		}
	}

	protected void UpdateByRefArguments(ILGenerator il, int locoffset)
	{
		int i = ArgumentOffset;
		int num = 0;
		for (; i < ParameterTypes.Length; i++)
		{
            var parameterInfo = Parameters[i - ArgumentOffset];
            var parameterType = parameterInfo.ParameterType;

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (parameterType.IsByRef && IsWrappedType(parameterType.GetElementType()))
			{
				Label label = il.DefineLabel();
				Label label2 = il.DefineLabel();
				il.Emit(OpCodes.Ldloc, num + locoffset);
				il.Emit(OpCodes.Brfalse, label);
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Ldloc, num + locoffset);
				il.Emit(OpCodes.Call, gethandle);
				il.Emit(OpCodes.Stind_I);
				il.Emit(OpCodes.Br, label2);
				il.MarkLabel(label);
				il.Emit(OpCodes.Ldarg, i);
				il.Emit(OpCodes.Ldsfld, intptrzero);
				il.Emit(OpCodes.Stind_I);
				il.MarkLabel(label2);
				num++;
			}
			else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
			{
				num++;
			}
			else if (parameterType == typeof(string))
			{
				num++;
			}
		}
	}
}
