using Foundation;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using Xamarin.Utiles;

namespace ObjCRuntime;

public struct BlockLiteral
{
	public IntPtr isa;

	public BlockFlags flags;

	public int reserved;

	public IntPtr invoke;

	public IntPtr block_descriptor;

	public IntPtr local_handle;

	public IntPtr global_handle;

	internal static IntPtr block_class;

	internal static BlockDescriptor global_descriptor;

	internal static IntPtr global_descriptor_ptr;

	static BlockLiteral()
	{
		block_class = Class.GetHandle("__NSStackBlock");
		global_descriptor = BlockDescriptor.CreateDescriptor();
		global_descriptor_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * 2 + Marshal.SizeOf(typeof(IntPtr)) * 2);
		Marshal.StructureToPtr(global_descriptor, global_descriptor_ptr, fDeleteOld: false);
	}


    public object Target
    {
        get
        {
            object target = GCHandle.FromIntPtr((global_handle != IntPtr.Zero) ? global_handle : local_handle).Target;
            if (target is Tuple<Delegate, Delegate> tuple)
            {
                return tuple.Item2;
            }
            return target;
        }
    }

    public unsafe static T GetTarget<T>(IntPtr block) where T : MulticastDelegate
    {
        return (T)((BlockLiteral*)block)->Target;
    }

    public void SetupBlock(Delegate trampoline, Delegate userDelegate)
	{
		isa = block_class;
		invoke = Marshal.GetFunctionPointerForDelegate(trampoline);
		local_handle = (IntPtr)GCHandle.Alloc(userDelegate);
		global_handle = IntPtr.Zero;
		flags = BlockFlags.BLOCK_HAS_COPY_DISPOSE | BlockFlags.BLOCK_HAS_DESCRIPTOR;
		block_descriptor = global_descriptor_ptr;
	}

    public T GetDelegateForBlock<T>() where T : class
    {
        return (T)(object)Marshal.GetDelegateForFunctionPointer(invoke, typeof(T));
    }

    private static Type GetDelegateProxyType(MethodInfo minfo, uint token_ref, out MethodInfo baseMethod)
    {
        //baseMethod = null;
        //if (token_ref != uint.MaxValue)
        //{
        //    return Class.ResolveTypeTokenReference(token_ref);
        //}
        baseMethod = minfo.GetBaseDefinition();
        object[] customAttributes = baseMethod.ReturnTypeCustomAttributes.GetCustomAttributes(typeof(DelegateProxyAttribute), inherit: false);
        if (customAttributes.Length != 0)
        {
            return ((DelegateProxyAttribute)customAttributes[0]).DelegateType;
        }
        string text = null;
        Type[] interfaces = minfo.DeclaringType.GetInterfaces();
        foreach (Type type in interfaces)
        {
            if (!type.IsDefined(typeof(ProtocolAttribute), inherit: false))
            {
                continue;
            }
            InterfaceMapping interfaceMap = minfo.DeclaringType.GetInterfaceMap(type);
            for (int j = 0; j < interfaceMap.TargetMethods.Length; j++)
            {
                if (interfaceMap.TargetMethods[j] == minfo)
                {
                    customAttributes = interfaceMap.InterfaceMethods[j].ReturnTypeCustomAttributes.GetCustomAttributes(typeof(DelegateProxyAttribute), inherit: false);
                    if (customAttributes.Length != 0)
                    {
                        return ((DelegateProxyAttribute)customAttributes[0]).DelegateType;
                    }
                }
            }
            if (text == null)
            {
                text = RuntimeEx.GetExportAttribute(minfo)?.Selector ?? string.Empty;
            }
            if (!string.IsNullOrEmpty(text))
            {
                ProtocolMemberAttribute protocolMemberAttribute = RuntimeEx.GetProtocolMemberAttribute(type, text, minfo);
                if (protocolMemberAttribute?.ReturnTypeDelegateProxy != null)
                {
                    return protocolMemberAttribute.ReturnTypeDelegateProxy;
                }
            }
        }
        throw ErrorHelper.CreateError(8011, $"Unable to locate the delegate to block conversion attribute ([DelegateProxy]) for the return value for the method {baseMethod.DeclaringType.FullName}.{baseMethod.Name}. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}");
    }

    internal static IntPtr GetBlockForDelegate(MethodInfo minfo, object @delegate, uint token_ref, string signature)
    {
        if (@delegate == null)
        {
            return IntPtr.Zero;
        }
        if (!(@delegate is Delegate))
        {
            throw ErrorHelper.CreateError(8016, $"Unable to convert delegate to block for the return value for the method {minfo.DeclaringType.FullName}.{minfo.Name}, because the input isn't a delegate, it's a {@delegate.GetType().FullName}. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}");
        }
        MethodInfo baseMethod;
        Type delegateProxyType = GetDelegateProxyType(minfo, token_ref, out baseMethod);
        if ((object)baseMethod == null)
        {
            baseMethod = minfo;
        }
        if (delegateProxyType == null)
        {
            throw ErrorHelper.CreateError(8012, $"Invalid DelegateProxyAttribute for the return value for the method {baseMethod.DeclaringType.FullName}.{baseMethod.Name}: DelegateType is null. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}");
        }
        object value = (delegateProxyType.GetField("Handler", BindingFlags.Static | BindingFlags.NonPublic) ?? throw ErrorHelper.CreateError(8013, $"Invalid DelegateProxyAttribute for the return value for the method {baseMethod.DeclaringType.FullName}.{baseMethod.Name}: DelegateType ({delegateProxyType.FullName}) specifies a type without a 'Handler' field. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}")).GetValue(null);
        if (value == null)
        {
            throw ErrorHelper.CreateError(8014, $"Invalid DelegateProxyAttribute for the return value for the method {baseMethod.DeclaringType.FullName}.{baseMethod.Name}: The DelegateType's ({delegateProxyType.FullName}) 'Handler' field is null. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}");
        }
        if (!(value is Delegate))
        {
            throw ErrorHelper.CreateError(8015, $"Invalid DelegateProxyAttribute for the return value for the method {baseMethod.DeclaringType.FullName}.{baseMethod.Name}: The DelegateType's ({delegateProxyType.FullName}) 'Handler' field is not a delegate, it's a {value.GetType().FullName}. {"Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new."}");
        }
        BlockLiteral block = default(BlockLiteral);
        if (signature == null)
        {
            if (!RuntimeEx.DynamicRegistrationSupported)
            {
                throw ErrorHelper.CreateError(8026, "BlockLiteral.GetBlockForDelegate with a null signature is not supported when the dynamic registrar has been linked away (delegate type: " + @delegate.GetType().FullName + ").");
            }
            block.SetupBlock((Delegate)value, (Delegate)@delegate);
        }
        else
        {
            block.SetupBlock((Delegate)value, (Delegate)@delegate);
        }
        IntPtr result = _Block_copy(ref block);
        block.CleanupBlock();
        return result;
    }

    public unsafe static bool IsManagedBlock(IntPtr block)
    {
        if (block == IntPtr.Zero)
            throw new ArgumentNullException("block");

        return false;
    }

    public void CleanupBlock()
	{
		GCHandle.FromIntPtr(local_handle).Free();
	}

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr _Block_copy(ref BlockLiteral block);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr _Block_copy(IntPtr block);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void _Block_release(IntPtr block);
}
