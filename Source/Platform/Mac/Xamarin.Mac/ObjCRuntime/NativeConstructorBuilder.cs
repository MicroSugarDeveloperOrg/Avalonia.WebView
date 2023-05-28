using Foundation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace ObjCRuntime;

internal class NativeConstructorBuilder : NativeImplementationBuilder
{
    private static MethodInfo trygetnsobject = typeof(Runtime).GetMethod("TryGetNSObjectEx", (BindingFlags)24);
    private static MethodInfo newobject = typeof(FormatterServices).GetMethod("GetUninitializedObject", (BindingFlags)24);
    private static MethodInfo gettype = typeof(Type).GetMethod("GetTypeFromHandle", (BindingFlags)24);
    private static MethodInfo retain = typeof(NSObject).GetMethod("Retain", (BindingFlags)52);
    private static FieldInfo handlefld = typeof(NSObject).GetField("handle", (BindingFlags)36);
    private static FieldInfo valuefld = typeof(RuntimeTypeHandle).GetField("value", (BindingFlags)36);
    private static IntPtr selInit = ObjCRuntime.Selector.GetHandle("init");
    private ConstructorInfo cinfo;

    internal NativeConstructorBuilder(ConstructorInfo cinfo)
    {
        ExportAttribute customAttribute = (ExportAttribute)Attribute.GetCustomAttribute((MemberInfo)cinfo, typeof(ExportAttribute));
        this.Parameters = ((MethodBase)cinfo).GetParameters();
        if (customAttribute == null && this.Parameters.Length != 0)
            throw new ArgumentException("ConstructorInfo does not have a export attribute");
        if (customAttribute == null)
            this.Selector = selInit;
        else
            this.Selector = new Selector(customAttribute.Selector, true).Handle;
        this.Signature = "@@:";
        this.ConvertParameters(this.Parameters, true, false);
        this.DelegateType = this.CreateDelegateType(typeof(IntPtr), this.ParameterTypes);
        this.cinfo = cinfo;
    }

    internal override Delegate CreateDelegate()
    {
        DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString(), typeof(IntPtr), this.ParameterTypes, (Module)NativeImplementationBuilder.module, true);
        ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
        Label label = ilGenerator.DefineLabel();
        ilGenerator.DeclareLocal(typeof(object));
        this.DeclareLocals(ilGenerator);
        for (int index = 0; index < this.Parameters.Length; ++index)
        {
            if (this.Parameters[index].ParameterType.IsByRef && (this.Parameters[index].ParameterType.GetElementType().IsSubclassOf(typeof(NSObject)) || this.Parameters[index].ParameterType.GetElementType() == typeof(NSObject)))
                ilGenerator.DeclareLocal(this.Parameters[index].ParameterType.GetElementType());
        }
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Call, NativeConstructorBuilder.trygetnsobject);
        ilGenerator.Emit(OpCodes.Brtrue, label);
        ilGenerator.Emit(OpCodes.Ldtoken, ((MemberInfo)this.cinfo).DeclaringType);
        ilGenerator.Emit(OpCodes.Call, NativeConstructorBuilder.gettype);
        ilGenerator.Emit(OpCodes.Call, NativeConstructorBuilder.newobject);
        ilGenerator.Emit(OpCodes.Stloc_0);
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Stfld, NativeConstructorBuilder.handlefld);
        this.ConvertArguments(ilGenerator, 1);
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Castclass, ((MemberInfo)this.cinfo).DeclaringType);
        this.LoadArguments(ilGenerator, 1);
        ilGenerator.Emit(OpCodes.Call, this.cinfo);
        this.UpdateByRefArguments(ilGenerator, 1);
        ilGenerator.Emit(OpCodes.Ldloc_0);
        ilGenerator.Emit(OpCodes.Call, NativeConstructorBuilder.retain);
        ilGenerator.Emit(OpCodes.Pop);
        ilGenerator.MarkLabel(label);
        ilGenerator.Emit(OpCodes.Ldarg_0);
        ilGenerator.Emit(OpCodes.Ret);
        return ((MethodInfo)dynamicMethod).CreateDelegate(this.DelegateType);
    }
}