using Foundation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace ObjCRuntime;
internal abstract class NativeImplementationBuilder
{
    internal static AssemblyBuilder builder;
    internal static ModuleBuilder module;
    private static MethodInfo convertarray = typeof(NSArray).GetMethod("ArrayFromHandleEx", new Type[1]
    {
      typeof (IntPtr)
    });
    private static MethodInfo convertsarray = typeof(NSArray).GetMethod("StringArrayFromHandleEx", new Type[1]
    {
      typeof (IntPtr)
    });
    private static MethodInfo convertstring = typeof(NSString).GetMethod("ToString", Type.EmptyTypes);
    private static MethodInfo getobject = typeof(Runtime).GetMethod("GetNSObjectEx", (BindingFlags)24);
    private static MethodInfo gethandle = typeof(NSObject).GetMethod("get_Handle", (BindingFlags)20);
    private static FieldInfo intptrzero = typeof(IntPtr).GetField("Zero", (BindingFlags)24);
    private Delegate del;

    static NativeImplementationBuilder()
    {
        NativeImplementationBuilder.builder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(Guid.NewGuid().ToString()), AssemblyBuilderAccess.Run);
        NativeImplementationBuilder.module = NativeImplementationBuilder.builder.DefineDynamicModule("Implementations");
    }

    internal abstract Delegate CreateDelegate();

    internal int ArgumentOffset { get; set; }

    internal IntPtr Selector { get; set; }

    internal Type[] ParameterTypes { get; set; }

    internal ParameterInfo[] Parameters { get; set; }

    internal Delegate Delegate
    {
        get
        {
            if ((object)this.del == null)
                this.del = this.CreateDelegate();
            return this.del;
        }
    }

    internal Type DelegateType { get; set; }

    internal string Signature { get; set; }

    protected Type CreateDelegateType(Type return_type, Type[] argument_types)
    {
        TypeBuilder typeBuilder = NativeImplementationBuilder.module.DefineType(Guid.NewGuid().ToString(), (TypeAttributes)131329, typeof(MulticastDelegate));
        typeBuilder.DefineConstructor((MethodAttributes)6, (CallingConventions)1, new Type[2]
        {
        typeof (object),
        typeof (int)
        }).SetImplementationFlags((MethodImplAttributes)3);
        MethodBuilder builder = typeBuilder.DefineMethod("Invoke", (MethodAttributes)454, return_type, argument_types);
        if (this.NeedsCustomMarshaler(return_type))
            this.SetupParameter(builder, 0, return_type);
        for (int index = 1; index <= argument_types.Length; ++index)
        {
            if (this.NeedsCustomMarshaler(argument_types[index - 1]))
                this.SetupParameter(builder, index, argument_types[index - 1]);
        }
        builder.SetImplementationFlags((MethodImplAttributes)3);
        return typeBuilder.CreateTypeInfo().AsType();
    }

    private bool NeedsCustomMarshaler(Type t) => t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)) || t == typeof(Selector);

    private Type MarshalerForType(Type t)
    {
        if (t == typeof(NSObject) || t.IsSubclassOf(typeof(NSObject)))
            return typeof(NSObjectMarshaler<>).MakeGenericType(t);
        if (t == typeof(Selector))
            return typeof(SelectorMarshaler);
        throw new ArgumentException("Cannot determine marshaler type for: " + (object)t);
    }

    private void SetupParameter(MethodBuilder builder, int index, Type t)
    {
        ParameterBuilder parameterBuilder = builder.DefineParameter(index, (ParameterAttributes)8192, string.Format("arg{0}", (object)index));
        ConstructorInfo constructor = typeof(MarshalAsAttribute).GetConstructor(new Type[1]
        {
        typeof (UnmanagedType)
        });
        FieldInfo field = typeof(MarshalAsAttribute).GetField("MarshalTypeRef");
        object[] objArray1 = new object[1]
        {
        (object) UnmanagedType.CustomMarshaler
        };
        FieldInfo[] fieldInfoArray = new FieldInfo[1] { field };
        object[] objArray2 = new object[1]
        {
        (object) this.MarshalerForType(t)
        };
        CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(constructor, objArray1, fieldInfoArray, objArray2);
        parameterBuilder.SetCustomAttribute(customBuilder);
    }

    protected bool IsWrappedType(Type type) => type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)) || type == typeof(string);

    protected void ConvertParameters(ParameterInfo[] parms, bool isstatic, bool isstret)
    {
        if (isstret)
        {
            this.ArgumentOffset = 3;
            this.ParameterTypes = new Type[this.ArgumentOffset + parms.Length];
            this.ParameterTypes[0] = typeof(IntPtr);
            this.ParameterTypes[1] = isstatic ? typeof(IntPtr) : typeof(NSObject);
            this.ParameterTypes[2] = typeof(Selector);
        }
        else
        {
            this.ArgumentOffset = 2;
            this.ParameterTypes = new Type[this.ArgumentOffset + parms.Length];
            this.ParameterTypes[0] = isstatic ? typeof(IntPtr) : typeof(NSObject);
            this.ParameterTypes[1] = typeof(Selector);
        }
        for (int index = 0; index < this.Parameters.Length; ++index)
        {
            this.ParameterTypes[index + this.ArgumentOffset] = !this.Parameters[index].ParameterType.IsByRef || !this.IsWrappedType(this.Parameters[index].ParameterType.GetElementType()) ? (!this.Parameters[index].ParameterType.IsArray || !this.IsWrappedType(this.Parameters[index].ParameterType.GetElementType()) ? (!typeof(INativeObject).IsAssignableFrom(this.Parameters[index].ParameterType) || this.IsWrappedType(this.Parameters[index].ParameterType) ? (!(this.Parameters[index].ParameterType == typeof(string)) ? this.Parameters[index].ParameterType : typeof(NSString)) : typeof(IntPtr)) : typeof(IntPtr)) : typeof(IntPtr).MakeByRefType();
            this.Signature += TypeConverter.ToNative(this.Parameters[index].ParameterType);
        }
    }

    protected void DeclareLocals(ILGenerator il)
    {
        for (int index = 0; index < this.Parameters.Length; ++index)
        {
            if (this.Parameters[index].ParameterType.IsByRef && this.IsWrappedType(this.Parameters[index].ParameterType.GetElementType()))
                il.DeclareLocal(this.Parameters[index].ParameterType.GetElementType());
            else if (this.Parameters[index].ParameterType.IsArray && this.IsWrappedType(this.Parameters[index].ParameterType.GetElementType()))
                il.DeclareLocal(this.Parameters[index].ParameterType);
            else if (this.Parameters[index].ParameterType == typeof(string))
                il.DeclareLocal(typeof(string));
        }
    }

    protected void ConvertArguments(ILGenerator il, int locoffset)
    {
        int argumentOffset = this.ArgumentOffset;
        int num = 0;
        for (; argumentOffset < this.ParameterTypes.Length; ++argumentOffset)
        {
            if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsByRef && Attribute.GetCustomAttribute(this.Parameters[argumentOffset - this.ArgumentOffset], typeof(OutAttribute)) == null && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
            {
                Label label1 = il.DefineLabel();
                Label label2 = il.DefineLabel();
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Brfalse, label1);
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Ldind_I);
                il.Emit(OpCodes.Call, NativeImplementationBuilder.getobject);
                il.Emit(OpCodes.Br, label2);
                il.MarkLabel(label1);
                il.Emit(OpCodes.Ldnull);
                il.MarkLabel(label2);
                il.Emit(OpCodes.Stloc, num + locoffset);
                ++num;
            }
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsArray && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
            {
                Label label3 = il.DefineLabel();
                Label label4 = il.DefineLabel();
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Brfalse, label3);
                il.Emit(OpCodes.Ldarg, argumentOffset);
                if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType() == typeof(string))
                    il.Emit(OpCodes.Call, NativeImplementationBuilder.convertsarray);
                else
                    il.Emit(OpCodes.Call, NativeImplementationBuilder.convertarray.MakeGenericMethod(new Type[1]
                    {
              this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()
                    }));
                il.Emit(OpCodes.Br, label4);
                il.MarkLabel(label3);
                il.Emit(OpCodes.Ldnull);
                il.MarkLabel(label4);
                il.Emit(OpCodes.Stloc, num + locoffset);
                ++num;
            }
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType == typeof(string))
            {
                Label label5 = il.DefineLabel();
                Label label6 = il.DefineLabel();
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Brfalse, label5);
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Call, NativeImplementationBuilder.convertstring);
                il.Emit(OpCodes.Br, label6);
                il.MarkLabel(label5);
                il.Emit(OpCodes.Ldnull);
                il.MarkLabel(label6);
                il.Emit(OpCodes.Stloc, num + locoffset);
                ++num;
            }
        }
    }

    protected void LoadArguments(ILGenerator il, int locoffset)
    {
        int argumentOffset = this.ArgumentOffset;
        int num = 0;
        for (; argumentOffset < this.ParameterTypes.Length; ++argumentOffset)
        {
            if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsByRef && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
            {
                il.Emit(OpCodes.Ldloca_S, num + locoffset);
                ++num;
            }
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsArray && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
            {
                il.Emit(OpCodes.Ldloc, num + locoffset);
                ++num;
            }
            else if (typeof(INativeObject).IsAssignableFrom(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType) && !this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType))
            {
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Newobj, this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetConstructor((BindingFlags)52, (Binder)null, new Type[1]
                {
            typeof (IntPtr)
                }, (ParameterModifier[])null));
            }
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType == typeof(string))
            {
                il.Emit(OpCodes.Ldloc, num + locoffset);
                ++num;
            }
            else
                il.Emit(OpCodes.Ldarg, argumentOffset);
        }
    }

    protected void UpdateByRefArguments(ILGenerator il, int locoffset)
    {
        int argumentOffset = this.ArgumentOffset;
        int num = 0;
        for (; argumentOffset < this.ParameterTypes.Length; ++argumentOffset)
        {
            if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsByRef && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
            {
                Label label1 = il.DefineLabel();
                Label label2 = il.DefineLabel();
                il.Emit(OpCodes.Ldloc, num + locoffset);
                il.Emit(OpCodes.Brfalse, label1);
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Ldloc, num + locoffset);
                il.Emit(OpCodes.Call, NativeImplementationBuilder.gethandle);
                il.Emit(OpCodes.Stind_I);
                il.Emit(OpCodes.Br, label2);
                il.MarkLabel(label1);
                il.Emit(OpCodes.Ldarg, argumentOffset);
                il.Emit(OpCodes.Ldsfld, NativeImplementationBuilder.intptrzero);
                il.Emit(OpCodes.Stind_I);
                il.MarkLabel(label2);
                ++num;
            }
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.IsArray && this.IsWrappedType(this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType.GetElementType()))
                ++num;
            else if (this.Parameters[argumentOffset - this.ArgumentOffset].ParameterType == typeof(string))
                ++num;
        }
    }
}