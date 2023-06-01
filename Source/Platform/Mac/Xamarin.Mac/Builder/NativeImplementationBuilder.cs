using Foundation;
using ObjCRuntime;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Xamarin.Utiles;

namespace Builder;

internal abstract class NativeImplementationBuilder
{
    static NativeImplementationBuilder()
    {
        __convertarray = typeof(NSArray).GetMethod("ArrayFromHandle", new Type[1] { typeof(IntPtr) });
        __convertsarray = typeof(NSArray).GetMethod("StringArrayFromHandle", new Type[1] { typeof(IntPtr) });
        __convertstring = typeof(NSString).GetMethod("ToString", Type.EmptyTypes);
        __getobject = typeof(Runtime).GetMethod("GetNSObject", BindingFlags.Static | BindingFlags.Public);
        __gethandle = typeof(NSObject).GetMethod("get_Handle", BindingFlags.Instance | BindingFlags.Public);
        __getFunctionPointerForDelegate = typeof(Marshal).GetMethod("GetFunctionPointerForDelegateInternal", BindingFlags.Static | BindingFlags.NonPublic);
        __intptrzero = typeof(IntPtr).GetField("Zero", BindingFlags.Static | BindingFlags.Public);
        s_Builder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
        s_Module = s_Builder.DefineDynamicModule("Implementations");
    }

    internal static AssemblyBuilder s_Builder;
    internal static ModuleBuilder s_Module;

    private static MethodInfo __convertarray;
    private static MethodInfo __convertsarray;
    private static MethodInfo __convertstring;
    private static MethodInfo __getobject;
    private static MethodInfo __gethandle;
    private static MethodInfo __getFunctionPointerForDelegate;
    private static FieldInfo __intptrzero;

    private Delegate _delegate;

    internal int ArgumentOffset { get; set; }

    internal IntPtr SelectorHandle { get; set; }

    internal Type[] ParameterTypes { get; set; }

    internal ParameterInfo[] Parameters { get; set; }

    internal Delegate Delegate
    {
        get
        {
            if ((object)_delegate == null)
                _delegate = CreateDelegate();
            return _delegate;
        }
    }

    internal Type DelegateType { get; set; }

    internal string Signature { get; set; }

    internal abstract Delegate CreateDelegate();

    protected Type CreateDelegateType(Type return_type, Type[] argument_types)
    {
        TypeBuilder typeBuilder = s_Module.DefineType(Guid.NewGuid().ToString(), TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(MulticastDelegate));
        typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[2]
        {
            typeof(object),
            typeof(int)
        }).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);

        MethodBuilder methodBuilder = typeBuilder.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, return_type, argument_types);
        if (NeedsCustomMarshaler(return_type))
            SetupParameter(methodBuilder, 0, return_type);

        for (int i = 0; i < argument_types.Length; i++)
        {
            var argument_type = argument_types[i];
            Type? proxyType = default;
            Type? rawType = default;

            if (i >= ArgumentOffset)
            {
                rawType = Parameters[i - ArgumentOffset].ParameterType;
                var proxyAttribute = argument_type.GetCustomAttribute<BlockProxyAttribute>();
                if (proxyAttribute is not null && argument_type.IsSubclassOf(typeof(Delegate)))
                    proxyType = proxyAttribute.Type;
            }

            if (NeedsCustomMarshalerWithProxy(argument_type, rawType, proxyType))
                SetupParameterWithProxy(methodBuilder, i + 1, argument_type, rawType, proxyType);
        }

        methodBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
        return typeBuilder.CreateTypeInfo().AsType();
    }

    protected Type CreateDelegateTypeWithProxy(Type return_type, Type[] argument_types, Type?[]? proxy_types)
    {
        TypeBuilder typeBuilder = s_Module.DefineType(Guid.NewGuid().ToString(), TypeAttributes.Public | TypeAttributes.Sealed | TypeAttributes.AutoClass, typeof(MulticastDelegate));
        typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[2]
        {
            typeof(object),
            typeof(int)
        }).SetImplementationFlags(MethodImplAttributes.CodeTypeMask);

        MethodBuilder methodBuilder = typeBuilder.DefineMethod("Invoke", MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, return_type, argument_types);
        if (NeedsCustomMarshaler(return_type))
            SetupParameter(methodBuilder, 0, return_type);

        for (int i = 0; i < argument_types.Length; i++)
        {
            var argument_type = argument_types[i];
            Type? raw_type = default; 
            Type? proxy_type = default;
            if (i >= ArgumentOffset)
            {
                raw_type = Parameters[i - ArgumentOffset].ParameterType;
                proxy_type = proxy_types == null ? null : proxy_types[i - ArgumentOffset];
            }

            if (NeedsCustomMarshalerWithProxy(argument_type, raw_type, proxy_type))
                SetupParameterWithProxy(methodBuilder, i + 1, argument_type, raw_type, proxy_type);
        }

        methodBuilder.SetImplementationFlags(MethodImplAttributes.CodeTypeMask);
        return typeBuilder.CreateTypeInfo().AsType();
    }


    private bool NeedsCustomMarshaler(Type t)
    {
        if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
            return true;

        if (t == typeof(Selector))
            return true;

        return false;
    }

    private bool NeedsCustomMarshalerWithProxy(Type t, Type? rawType, Type? proxyType)
    {
        if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
            return true;

        if (t == typeof(Selector))
            return true;

        if (rawType.IsSubclassOf(typeof(Delegate)) && proxyType is not null)
            return true;

        return false;
    }

    private Type MarshalerForType(Type t)
    {
        if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
            return typeof(NSObjectMarshaler<>).MakeGenericType(t);

        if (t == typeof(Selector))
            return typeof(SelectorMarshaler);

        throw new ArgumentException("Cannot determine marshaler type for: " + t);
    }

    private Type MarshalerForTypeWithProxy(Type t, Type? proxy)
    {
        if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
            return typeof(NSObjectMarshaler<>).MakeGenericType(t);

        if (t == typeof(Selector))
            return typeof(SelectorMarshaler);

        if (proxy is not null && t.IsSubclassOf(typeof(Delegate)))
            return typeof(ActionMarshaler<,>).MakeGenericType(t, proxy);


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

    private void SetupParameterWithProxy(MethodBuilder builder, int index, Type t, Type? rawType , Type? proxyType)
    {
        ParameterBuilder parameterBuilder = builder.DefineParameter(index, ParameterAttributes.HasFieldMarshal, $"arg{index}");
        ConstructorInfo? constructor = typeof(MarshalAsAttribute).GetConstructor(new Type[1] { typeof(UnmanagedType) });
        FieldInfo field = typeof(MarshalAsAttribute).GetField("MarshalTypeRef");
        CustomAttributeBuilder customAttribute = new CustomAttributeBuilder(constructor, new object[1] { UnmanagedType.CustomMarshaler }, new FieldInfo[1] { field }, new object[1] { MarshalerForTypeWithProxy(rawType, proxyType) });
        parameterBuilder.SetCustomAttribute(customAttribute);
    }

    protected bool IsWrappedType(Type type)
    {
        if (type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)) || type == typeof(string))
            return true;

        return false;
    }

    protected void ConvertParameters(ParameterInfo[] parms, bool isstatic, bool isstret)
    {
        if (isstret)
        {
            ArgumentOffset = 3;
            ParameterTypes = new Type[ArgumentOffset + parms.Length];
            ParameterTypes[0] = typeof(IntPtr);
            ParameterTypes[1] = isstatic ? typeof(IntPtr) : typeof(NSObject);
            ParameterTypes[2] = typeof(Selector);
        }
        else
        {
            ArgumentOffset = 2;
            ParameterTypes = new Type[ArgumentOffset + parms.Length];
            ParameterTypes[0] = isstatic ? typeof(IntPtr) : typeof(NSObject);
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
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr).MakeByRefType();
            else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
            else if (typeof(INativeObject).IsAssignableFrom(parameterType) && !IsWrappedType(parameterType))
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
            else if (parameterType == typeof(string))
                ParameterTypes[i + ArgumentOffset] = typeof(NSString);
            else
                ParameterTypes[i + ArgumentOffset] = parameterType;

            var proxyAttribute = parameterInfo.GetCustomAttribute<BlockProxyAttribute>();
            if (proxyAttribute is not null && parameterType.IsSubclassOf(typeof(Delegate)))
                ParameterTypes[i + ArgumentOffset] = typeof(NSAction);
                //ParameterTypes[i + ArgumentOffset] = proxyAttribute.Type;

            Signature += TypeConverter.ToNative(parameterType);
        }
    }

    protected void ConvertParametersByRef(Type[] rawTypes, bool[] refTypes, Type?[]? proxyTypes , bool isstatic, bool isstret)
    {
        if (isstret)
        {
            ArgumentOffset = 3;
            ParameterTypes = new Type[ArgumentOffset + rawTypes.Length];
            ParameterTypes[0] = typeof(IntPtr);
            ParameterTypes[1] = isstatic ? typeof(IntPtr) : typeof(NSObject);
            ParameterTypes[2] = typeof(Selector);
        }
        else
        {
            ArgumentOffset = 2;
            ParameterTypes = new Type[ArgumentOffset + rawTypes.Length];
            ParameterTypes[0] = isstatic ? typeof(IntPtr) : typeof(NSObject);
            ParameterTypes[1] = typeof(Selector);
        }

        for (int i = 0; i < rawTypes.Length; i++)
        {
            var parameterType = rawTypes[i];
            var boolRef = refTypes[i];
            var proxyType = proxyTypes == null ? null : proxyTypes[i];
  
            if (parameterType is null)
                continue;

            if (boolRef && IsWrappedType(parameterType.GetElementType()))
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr).MakeByRefType();
            else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
            else if (typeof(INativeObject).IsAssignableFrom(parameterType) && !IsWrappedType(parameterType))
                ParameterTypes[i + ArgumentOffset] = typeof(IntPtr);
            else if (parameterType == typeof(string))
                ParameterTypes[i + ArgumentOffset] = typeof(NSString);
            else
                ParameterTypes[i + ArgumentOffset] = parameterType;

            if (proxyType is not null && parameterType.IsSubclassOf(typeof(Delegate)))
                ParameterTypes[i + ArgumentOffset] = typeof(NSAction);
                //ParameterTypes[i + ArgumentOffset] = proxyType;
            //ParameterTypes[i + ArgumentOffset] = typeof(NSAction);

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
                il.DeclareLocal(parameterType.GetElementType());
            else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
                il.DeclareLocal(parameterType);
            else if (parameterType == typeof(string))
                il.DeclareLocal(typeof(string));
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
                il.Emit(OpCodes.Call, __getobject);
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
                    il.Emit(OpCodes.Call, __convertsarray);
                else
                    il.Emit(OpCodes.Call, __convertarray.MakeGenericMethod(parameterType.GetElementType()));
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
                il.Emit(OpCodes.Call, __convertstring);
                il.Emit(OpCodes.Br, label6);
                il.MarkLabel(label5);
                il.Emit(OpCodes.Ldnull);
                il.MarkLabel(label6);
                il.Emit(OpCodes.Stloc, num + locoffset);
                num++;
            }
        }
    }

    protected void ConvertArgumentsWithProxyTypes(ILGenerator il, Type[] proxyTypes ,int locoffset)
    {
        int i = ArgumentOffset;
        int num = 0;
        for (; i < ParameterTypes.Length; i++)
        {
            var parameterInfo = Parameters[i - ArgumentOffset];
            var parameterType = parameterInfo.ParameterType;
            var proxyType = proxyTypes[i - ArgumentOffset];

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (proxyType is not null && parameterType.IsSubclassOf(typeof(Delegate)))
            {
                //var createMethod = proxyType.GetMethod("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[1] { typeof(IntPtr) }, null);
                //
                Label label = il.DefineLabel();
                Label label2 = il.DefineLabel();
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Brfalse, label);
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Call, __getFunctionPointerForDelegate);
                il.Emit(OpCodes.Br, label2);
                il.MarkLabel(label);
                il.Emit(OpCodes.Ldnull);
                il.MarkLabel(label2);
                il.Emit(OpCodes.Stloc, num + locoffset);
                num++; 
            }
            else if (parameterType.IsByRef && Attribute.GetCustomAttribute(parameterInfo, typeof(OutAttribute)) == null && IsWrappedType(parameterType.GetElementType()))
            {
                Label label = il.DefineLabel();
                Label label2 = il.DefineLabel();
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Brfalse, label);
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Ldind_I);
                il.Emit(OpCodes.Call, __getobject);
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
                    il.Emit(OpCodes.Call, __convertsarray);
                else
                    il.Emit(OpCodes.Call, __convertarray.MakeGenericMethod(parameterType.GetElementType()));
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
                il.Emit(OpCodes.Call, __convertstring);
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
                il.Emit(OpCodes.Ldarg, i);
        }
    }

    protected void LoadArgumentsWithProxyTypes(ILGenerator il, Type[] proxyTypes ,int locoffset)
    {
        int i = ArgumentOffset;
        int num = 0;
        for (; i < ParameterTypes.Length; i++)
        {
            var parameterInfo = Parameters[i - ArgumentOffset];
            var parameterType = parameterInfo.ParameterType;
            var proxyType = proxyTypes[i - ArgumentOffset];

            if (parameterInfo is null)
                continue;

            if (parameterType is null)
                continue;

            if (proxyType is not null)
            {
                //var createMethod = proxyType.GetMethod("Create", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[1] { typeof(IntPtr) }, null);
                //if (createMethod is null)
                    //continue;

                //il.Emit(OpCodes.Ldarg, i);
                //il.Emit(OpCodes.Call, createMethod);
            }
            else
            {
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
                il.Emit(OpCodes.Call, __gethandle);
                il.Emit(OpCodes.Stind_I);
                il.Emit(OpCodes.Br, label2);
                il.MarkLabel(label);
                il.Emit(OpCodes.Ldarg, i);
                il.Emit(OpCodes.Ldsfld, __intptrzero);
                il.Emit(OpCodes.Stind_I);
                il.MarkLabel(label2);
                num++;
            }
            else if (parameterType.IsArray && IsWrappedType(parameterType.GetElementType()))
                num++;
            else if (parameterType == typeof(string))
                num++;
        }
    }


}
