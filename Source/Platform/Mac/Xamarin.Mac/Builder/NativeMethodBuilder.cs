using Foundation;
using ObjCRuntime;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace Builder;

internal class NativeMethodBuilder : NativeImplementationBuilder
{
    static MethodInfo __creatensstring = typeof(NSString).GetMethod("op_Explicit", new Type[1] { typeof(string) });
    static MethodInfo __convertstruct = typeof(Marshal).GetMethod("StructureToPtr", new Type[3]
    {
        typeof(object),
        typeof(IntPtr),
        typeof(bool)
    });
    static MethodInfo __buildarray = typeof(NSArray).GetMethod("FromNSObjects", new Type[1] { typeof(NSObject[]) });
    static MethodInfo __buildsarray = typeof(NSArray).GetMethod("FromStrings", new Type[1] { typeof(string[]) });

    internal NativeMethodBuilder(MethodInfo minfo)
        : this(minfo, minfo.DeclaringType, (ExportAttribute)Attribute.GetCustomAttribute(minfo.GetBaseDefinition(), typeof(ExportAttribute)))
    {
    }

    internal NativeMethodBuilder(MethodInfo minfo, Type type, ExportAttribute ea)
    {
        if (ea == null)
            throw new ArgumentException("MethodInfo does not have a export attribute");

        if (minfo.DeclaringType.IsGenericType)
            throw new ArgumentException("MethodInfo cannot be in a generic type");

        _methodInfo = minfo;
        _type = type;
        _returnType = ConvertReturnType(minfo.ReturnType);

        Parameters = minfo.GetParameters();
        SelectorHandle = new Selector(ea.Selector ?? minfo.Name, alloc: true).Handle;
        Signature = $"{TypeConverter.ToNative(minfo.ReturnType)}@:";
        ConvertParameters(Parameters, minfo.IsStatic, _isstret);
        DelegateType = CreateDelegateType(_returnType, ParameterTypes);
    }

    internal NativeMethodBuilder(Type type, MethodInfo methodInfo, ProtocolMemberAttribute attribute)
    {
        if (attribute == null)
            throw new ArgumentException("attribute does not have a ProtocolMember attribute");

        if (type is null)
            throw new ArgumentException("type does not have a ProtocolMember attribute");

        if (methodInfo is null)
            throw new ArgumentException("type does not have a MethodInfo");

        if (methodInfo.DeclaringType.IsGenericType)
            throw new ArgumentException("MethodInfo cannot be in a generic type");

        _methodInfo = methodInfo;
        _type = type;
        _returnType = ConvertReturnType(methodInfo.ReturnType);

        SelectorHandle = new Selector(attribute.Selector ?? methodInfo.Name, alloc: true).Handle;
        Parameters = methodInfo.GetParameters();
        Signature = $"{TypeConverter.ToNative(methodInfo.ReturnType)}@:";
        ConvertParameters(Parameters, attribute.IsStatic, _isstret);
        DelegateType = CreateDelegateTypeWithProxy(_returnType, ParameterTypes, attribute.ParameterBlockProxy);
    }


    MethodInfo _methodInfo;
    Type _type;
    Type _returnType;
    bool _isstret; 

    private Type ConvertReturnType(Type type)
    {
        if (type.IsValueType && !type.IsEnum && type.Assembly != typeof(object).Assembly && Marshal.SizeOf(type) > IntPtr.Size * 2)
        {
            _isstret = true;
            return typeof(void);
        }

        if (type == typeof(string))
            return typeof(NSString);

        if (type.IsArray && IsWrappedType(type.GetElementType()))
            return typeof(NSArray);

        if (typeof(INativeObject).IsAssignableFrom(type) && !IsWrappedType(type))
            return typeof(IntPtr);

        return type;
    }

    internal override Delegate CreateDelegate()
    {
        DynamicMethod dynamicMethod = new DynamicMethod($"[{_methodInfo.DeclaringType}:{_methodInfo}]", _returnType, ParameterTypes, s_Module, skipVisibility: true);

        ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
        DeclareLocals(iLGenerator);

        ConvertArguments(iLGenerator, 0);

        if (!_methodInfo.IsStatic)
        {
            iLGenerator.Emit(OpCodes.Ldarg, _isstret ? 1 : 0);
            iLGenerator.Emit(OpCodes.Castclass, _type);
        }

        LoadArguments(iLGenerator, 0);

        //IL 调用函数 c# 函数
        if (_methodInfo.IsVirtual)
            iLGenerator.Emit(OpCodes.Callvirt, _methodInfo);
        else
            iLGenerator.Emit(OpCodes.Call, _methodInfo);

        UpdateByRefArguments(iLGenerator, 0);

        // Return Type
        Type returnType = _methodInfo.ReturnType;
        if (returnType == typeof(string))
            iLGenerator.Emit(OpCodes.Call, __creatensstring);
        else if (returnType.IsArray && IsWrappedType(returnType.GetElementType()))
        {
            if (returnType.GetElementType() == typeof(string))
                iLGenerator.Emit(OpCodes.Call, __buildsarray);
            else
                iLGenerator.Emit(OpCodes.Call, __buildarray);
        }
        else if (typeof(INativeObject).IsAssignableFrom(returnType) && !IsWrappedType(returnType))
            iLGenerator.Emit(OpCodes.Call, returnType.GetProperty("Handle").GetGetMethod());
        else if (_isstret)
        {
            iLGenerator.Emit(OpCodes.Box, returnType);
            iLGenerator.Emit(OpCodes.Ldarg, 0);
            iLGenerator.Emit(OpCodes.Ldc_I4, 0);
            iLGenerator.Emit(OpCodes.Call, __convertstruct);
        }

        iLGenerator.Emit(OpCodes.Ret);
        return dynamicMethod.CreateDelegate(DelegateType);
    }

}
