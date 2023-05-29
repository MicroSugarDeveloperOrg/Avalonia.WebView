using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using Foundation;

namespace ObjCRuntime;

internal class NativeConstructorBuilder : NativeImplementationBuilder
{
	private static MethodInfo trygetnsobject = typeof(Runtime).GetMethod("TryGetNSObject", BindingFlags.Static | BindingFlags.Public);

	private static MethodInfo newobject = typeof(FormatterServices).GetMethod("GetUninitializedObject", BindingFlags.Static | BindingFlags.Public);

	private static MethodInfo gettype = typeof(Type).GetMethod("GetTypeFromHandle", BindingFlags.Static | BindingFlags.Public);

	private static MethodInfo retain = typeof(NSObject).GetMethod("Retain", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

	private static FieldInfo handlefld = typeof(NSObject).GetField("handle", BindingFlags.Instance | BindingFlags.NonPublic);

	private static FieldInfo valuefld = typeof(RuntimeTypeHandle).GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);

	private static IntPtr selInit = ObjCRuntime.Selector.GetHandle("init");

	private ConstructorInfo cinfo;

	internal NativeConstructorBuilder(ConstructorInfo cinfo)
	{
		ExportAttribute exportAttribute = (ExportAttribute)Attribute.GetCustomAttribute(cinfo, typeof(ExportAttribute));
		base.Parameters = cinfo.GetParameters();
		if (exportAttribute == null && base.Parameters.Length != 0)
		{
			throw new ArgumentException("ConstructorInfo does not have a export attribute");
		}
		if (exportAttribute == null)
		{
			base.Selector = selInit;
		}
		else
		{
			base.Selector = new Selector(exportAttribute.Selector, alloc: true).Handle;
		}
		base.Signature = "@@:";
		ConvertParameters(base.Parameters, isstatic: true, isstret: false);
		base.DelegateType = CreateDelegateType(typeof(IntPtr), base.ParameterTypes);
		this.cinfo = cinfo;
	}

	internal override Delegate CreateDelegate()
	{
		DynamicMethod dynamicMethod = new DynamicMethod(Guid.NewGuid().ToString(), typeof(IntPtr), base.ParameterTypes, NativeImplementationBuilder.module, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		Label label = iLGenerator.DefineLabel();
		iLGenerator.DeclareLocal(typeof(object));
		DeclareLocals(iLGenerator);
		for (int i = 0; i < base.Parameters.Length; i++)
		{
			if (base.Parameters[i].ParameterType.IsByRef && (base.Parameters[i].ParameterType.GetElementType().IsSubclassOf(typeof(NSObject)) || base.Parameters[i].ParameterType.GetElementType() == typeof(NSObject)))
			{
				iLGenerator.DeclareLocal(base.Parameters[i].ParameterType.GetElementType());
			}
		}
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Call, trygetnsobject);
		iLGenerator.Emit(OpCodes.Brtrue, label);
		iLGenerator.Emit(OpCodes.Ldtoken, cinfo.DeclaringType);
		iLGenerator.Emit(OpCodes.Call, gettype);
		iLGenerator.Emit(OpCodes.Call, newobject);
		iLGenerator.Emit(OpCodes.Stloc_0);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Stfld, handlefld);
		ConvertArguments(iLGenerator, 1);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.Emit(OpCodes.Castclass, cinfo.DeclaringType);
		LoadArguments(iLGenerator, 1);
		iLGenerator.Emit(OpCodes.Call, cinfo);
		UpdateByRefArguments(iLGenerator, 1);
		iLGenerator.Emit(OpCodes.Ldloc_0);
		iLGenerator.Emit(OpCodes.Call, retain);
		iLGenerator.Emit(OpCodes.Pop);
		iLGenerator.MarkLabel(label);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.CreateDelegate(base.DelegateType);
	}
}
