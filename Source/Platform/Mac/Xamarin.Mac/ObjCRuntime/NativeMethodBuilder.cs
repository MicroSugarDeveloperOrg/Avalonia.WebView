using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Foundation;
using Xamarin.Utiles;

namespace ObjCRuntime;

internal class NativeMethodBuilder : NativeImplementationBuilder
{
	private static MethodInfo creatensstring = typeof(NSString).GetMethod("op_Explicit", new Type[1] { typeof(string) });

	private static MethodInfo convertstruct = typeof(Marshal).GetMethod("StructureToPtr", new Type[3]
	{
		typeof(object),
		typeof(IntPtr),
		typeof(bool)
	});

	private static MethodInfo buildarray = typeof(NSArray).GetMethod("FromNSObjects", new Type[1] { typeof(NSObject[]) });

	private static MethodInfo buildsarray = typeof(NSArray).GetMethod("FromStrings", new Type[1] { typeof(string[]) });

	private MethodInfo minfo;

	private Type type;

	private Type rettype;

	private bool isstret;

	internal NativeMethodBuilder(MethodInfo minfo)
		: this(minfo, minfo.DeclaringType, (ExportAttribute)Attribute.GetCustomAttribute(minfo.GetBaseDefinition(), typeof(ExportAttribute)))
	{
	}

	internal NativeMethodBuilder(MethodInfo minfo, Type type, ExportAttribute ea)
	{
		if (ea == null)
		{
			throw new ArgumentException("MethodInfo does not have a export attribute");
		}
		if (minfo.DeclaringType.IsGenericType)
		{
			throw new ArgumentException("MethodInfo cannot be in a generic type");
		}
		base.Parameters = minfo.GetParameters();
		rettype = ConvertReturnType(minfo.ReturnType);
		base.Selector = new Selector(ea.Selector ?? minfo.Name, alloc: true).Handle;
		base.Signature = $"{TypeConverter.ToNative(minfo.ReturnType)}@:";
		ConvertParameters(base.Parameters, minfo.IsStatic, isstret);
		base.DelegateType = CreateDelegateType(rettype, base.ParameterTypes);
		this.minfo = minfo;
		this.type = type;
	}

	internal override Delegate CreateDelegate()
	{
		DynamicMethod dynamicMethod = new DynamicMethod($"[{minfo.DeclaringType}:{minfo}]", rettype, base.ParameterTypes, NativeImplementationBuilder.module, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		DeclareLocals(iLGenerator);
		ConvertArguments(iLGenerator, 0);
		if (!minfo.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarg, isstret ? 1 : 0);
			iLGenerator.Emit(OpCodes.Castclass, type);
		}
		LoadArguments(iLGenerator, 0);
		if (minfo.IsVirtual)
		{
			iLGenerator.Emit(OpCodes.Callvirt, minfo);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Call, minfo);
		}
		UpdateByRefArguments(iLGenerator, 0);
		if (minfo.ReturnType == typeof(string))
		{
			iLGenerator.Emit(OpCodes.Call, creatensstring);
		}
		else if (minfo.ReturnType.IsArray && IsWrappedType(minfo.ReturnType.GetElementType()))
		{
			if (minfo.ReturnType.GetElementType() == typeof(string))
			{
				iLGenerator.Emit(OpCodes.Call, buildsarray);
			}
			else
			{
				iLGenerator.Emit(OpCodes.Call, buildarray);
			}
		}
		else if (typeof(INativeObject).IsAssignableFrom(minfo.ReturnType) && !IsWrappedType(minfo.ReturnType))
		{
			iLGenerator.Emit(OpCodes.Call, minfo.ReturnType.GetProperty("Handle").GetGetMethod());
		}
		else if (isstret)
		{
			iLGenerator.Emit(OpCodes.Box, minfo.ReturnType);
			iLGenerator.Emit(OpCodes.Ldarg, 0);
			iLGenerator.Emit(OpCodes.Ldc_I4, 0);
			iLGenerator.Emit(OpCodes.Call, convertstruct);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod.CreateDelegate(base.DelegateType);
	}

	private Type ConvertReturnType(Type type)
	{
		if (type.IsValueType && !type.IsEnum && type.Assembly != typeof(object).Assembly && Marshal.SizeOf(type) > IntPtr.Size * 2)
		{
			isstret = true;
			return typeof(void);
		}
		if (type == typeof(string))
		{
			return typeof(NSString);
		}
		if (type.IsArray && IsWrappedType(type.GetElementType()))
		{
			return typeof(NSArray);
		}
		if (typeof(INativeObject).IsAssignableFrom(type) && !IsWrappedType(type))
		{
			return typeof(IntPtr);
		}
		return type;
	}
}
