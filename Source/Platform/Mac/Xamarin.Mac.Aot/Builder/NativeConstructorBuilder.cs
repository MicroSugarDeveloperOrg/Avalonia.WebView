using Foundation;
using ObjCRuntime;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace Builder;

internal class NativeConstructorBuilder : NativeImplementationBuilder
{
    private static MethodInfo __trygetnsobject = typeof(Runtime).GetMethod("TryGetNSObject", BindingFlags.Static | BindingFlags.Public);

    private static MethodInfo __newobject = typeof(FormatterServices).GetMethod("GetUninitializedObject", BindingFlags.Static | BindingFlags.Public);

    private static MethodInfo __gettype = typeof(Type).GetMethod("GetTypeFromHandle", BindingFlags.Static | BindingFlags.Public);

    private static MethodInfo __retain = typeof(NSObject).GetMethod("Retain", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

    private static FieldInfo __handlefld = typeof(NSObject).GetField("handle", BindingFlags.Instance | BindingFlags.NonPublic);

    private static FieldInfo __valuefld = typeof(RuntimeTypeHandle).GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);

    private static IntPtr __selInit = ObjCRuntime.Selector.GetHandle("init");

    internal NativeConstructorBuilder(ConstructorInfo cinfo)
    {
        ExportAttribute exportAttribute = (ExportAttribute)Attribute.GetCustomAttribute(cinfo, typeof(ExportAttribute));
        Parameters = cinfo.GetParameters();
        if (exportAttribute == null && Parameters.Length != 0)
            throw new ArgumentException("ConstructorInfo does not have a export attribute");

        if (exportAttribute == null)
            SelectorHandle = __selInit;
        else
            SelectorHandle = new Selector(exportAttribute.Selector, alloc: true).Handle;

        Signature = "@@:";
        ConvertParameters(Parameters, isstatic: true, isstret: false);
        DelegateType = CreateDelegateType(typeof(IntPtr), ParameterTypes);
        _constructor = cinfo;
    }

    private ConstructorInfo _constructor;

    internal override Delegate CreateDelegate()
    {
        DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString(), typeof(IntPtr), ParameterTypes, s_Module, skipVisibility: true);
        ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
        Label label = iLGenerator.DefineLabel();
        iLGenerator.DeclareLocal(typeof(object));
        DeclareLocals(iLGenerator);
        for (int i = 0; i < Parameters.Length; i++)
        {
            if (Parameters[i].ParameterType.IsByRef && (Parameters[i].ParameterType.GetElementType().IsSubclassOf(typeof(NSObject)) || Parameters[i].ParameterType.GetElementType() == typeof(NSObject)))
                iLGenerator.DeclareLocal(Parameters[i].ParameterType.GetElementType());
        }
        iLGenerator.Emit(OpCodes.Ldarg_0);
        iLGenerator.Emit(OpCodes.Call, __trygetnsobject);
        iLGenerator.Emit(OpCodes.Brtrue, label);
        iLGenerator.Emit(OpCodes.Ldtoken, _constructor.DeclaringType);
        iLGenerator.Emit(OpCodes.Call, __gettype);
        iLGenerator.Emit(OpCodes.Call, __newobject);
        iLGenerator.Emit(OpCodes.Stloc_0);
        iLGenerator.Emit(OpCodes.Ldloc_0);
        iLGenerator.Emit(OpCodes.Ldarg_0);
        iLGenerator.Emit(OpCodes.Stfld, __handlefld);
        ConvertArguments(iLGenerator, 1);
        iLGenerator.Emit(OpCodes.Ldloc_0);
        iLGenerator.Emit(OpCodes.Castclass, _constructor.DeclaringType);
        LoadArguments(iLGenerator, 1);
        iLGenerator.Emit(OpCodes.Call, _constructor);
        UpdateByRefArguments(iLGenerator, 1);
        iLGenerator.Emit(OpCodes.Ldloc_0);
        iLGenerator.Emit(OpCodes.Call, __retain);
        iLGenerator.Emit(OpCodes.Pop);
        iLGenerator.MarkLabel(label);
        iLGenerator.Emit(OpCodes.Ldarg_0);
        iLGenerator.Emit(OpCodes.Ret);
        return dynamicMethod.CreateDelegate(DelegateType);
    }
}
