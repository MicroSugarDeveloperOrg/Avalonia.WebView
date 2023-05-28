using Foundation;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace ObjCRuntime;
internal class NativeMethodBuilder : NativeImplementationBuilder
{
    private static MethodInfo creatensstring = typeof(NSString).GetMethod("op_Explicit", new Type[1]
    {
      typeof (string)
    });
    private static MethodInfo convertstruct = typeof(Marshal).GetMethod("StructureToPtr", new Type[3]
    {
      typeof (object),
      typeof (IntPtr),
      typeof (bool)
    });
    private static MethodInfo buildarray = typeof(NSArray).GetMethod("FromNSObjects", new Type[1]
    {
      typeof (NSObject[])
    });
    private static MethodInfo buildsarray = typeof(NSArray).GetMethod("FromStrings", new Type[1]
    {
      typeof (string[])
    });
    private MethodInfo minfo;
    private Type type;
    private Type rettype;
    private bool isstret;

    internal NativeMethodBuilder(MethodInfo minfo)
      : this(minfo, ((MemberInfo)minfo).DeclaringType, (ExportAttribute)Attribute.GetCustomAttribute((MemberInfo)minfo.GetBaseDefinition(), typeof(ExportAttribute)))
    {
    }

    internal NativeMethodBuilder(MethodInfo minfo, Type type, ExportAttribute ea)
    {
        if (ea == null)
            throw new ArgumentException("MethodInfo does not have a export attribute");
        if (((MemberInfo)minfo).DeclaringType.IsGenericType)
            throw new ArgumentException("MethodInfo cannot be in a generic type");
        this.Parameters = ((MethodBase)minfo).GetParameters();
        this.rettype = this.ConvertReturnType(minfo.ReturnType);
        this.Selector = new Selector(ea.Selector ?? ((MemberInfo)minfo).Name, true).Handle;
        this.Signature = string.Format("{0}@:", (object)TypeConverter.ToNative(minfo.ReturnType));
        this.ConvertParameters(this.Parameters, ((MethodBase)minfo).IsStatic, this.isstret);
        this.DelegateType = this.CreateDelegateType(this.rettype, this.ParameterTypes);
        this.minfo = minfo;
        this.type = type;
    }

    internal override Delegate CreateDelegate()
    {
        DynamicMethod dynamicMethod = new DynamicMethod(string.Format("[{0}:{1}]", (object)((MemberInfo)this.minfo).DeclaringType, (object)this.minfo), this.rettype, this.ParameterTypes, (Module)NativeImplementationBuilder.module, true);
        ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
        this.DeclareLocals(ilGenerator);
        this.ConvertArguments(ilGenerator, 0);
        if (!((MethodBase)this.minfo).IsStatic)
        {
            ilGenerator.Emit(OpCodes.Ldarg, this.isstret ? 1 : 0);
            ilGenerator.Emit(OpCodes.Castclass, this.type);
        }
        this.LoadArguments(ilGenerator, 0);
        if (((MethodBase)this.minfo).IsVirtual)
            ilGenerator.Emit(OpCodes.Callvirt, this.minfo);
        else
            ilGenerator.Emit(OpCodes.Call, this.minfo);
        this.UpdateByRefArguments(ilGenerator, 0);
        if (this.minfo.ReturnType == typeof(string))
            ilGenerator.Emit(OpCodes.Call, NativeMethodBuilder.creatensstring);
        else if (this.minfo.ReturnType.IsArray && this.IsWrappedType(this.minfo.ReturnType.GetElementType()))
        {
            if (this.minfo.ReturnType.GetElementType() == typeof(string))
                ilGenerator.Emit(OpCodes.Call, NativeMethodBuilder.buildsarray);
            else
                ilGenerator.Emit(OpCodes.Call, NativeMethodBuilder.buildarray);
        }
        else if (typeof(INativeObject).IsAssignableFrom(this.minfo.ReturnType) && !this.IsWrappedType(this.minfo.ReturnType))
            ilGenerator.Emit(OpCodes.Call, this.minfo.ReturnType.GetProperty("Handle").GetGetMethod());
        else if (this.isstret)
        {
            ilGenerator.Emit(OpCodes.Box, this.minfo.ReturnType);
            ilGenerator.Emit(OpCodes.Ldarg, 0);
            ilGenerator.Emit(OpCodes.Ldc_I4, 0);
            ilGenerator.Emit(OpCodes.Call, NativeMethodBuilder.convertstruct);
        }
        ilGenerator.Emit(OpCodes.Ret);
        return ((MethodInfo)dynamicMethod).CreateDelegate(this.DelegateType);
    }

    private Type ConvertReturnType(Type type)
    {
        if (type.IsValueType && !type.IsEnum && (type.Assembly != typeof(object).Assembly) && Marshal.SizeOf(type) > IntPtr.Size * 2)
        {
            this.isstret = true;
            return typeof(void);
        }
        if (type == typeof(string))
            return typeof(NSString);
        if (type.IsArray && this.IsWrappedType(type.GetElementType()))
            return typeof(NSArray);
        return typeof(INativeObject).IsAssignableFrom(type) && !this.IsWrappedType(type) ? typeof(IntPtr) : type;
    }
}