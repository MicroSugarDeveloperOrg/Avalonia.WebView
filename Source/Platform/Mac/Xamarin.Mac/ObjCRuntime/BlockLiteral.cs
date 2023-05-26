using Foundation;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

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

    private static IntPtr NSConcreteStackBlock
    {
        get
        {
            if (block_class == IntPtr.Zero)
            {
                block_class = Dlfcn.dlsym(Libraries.System.Handle, "_NSConcreteStackBlock");
            }
            return block_class;
        }
    }

    public object Target
    {
        get
        {
            IntPtr value = ((global_handle != IntPtr.Zero) ? global_handle : local_handle);
            object target = GCHandle.FromIntPtr(value).Target;
            if (target is Tuple<Delegate, Delegate> tuple)
            {
                return tuple.Item2;
            }
            return target;
        }
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr _Block_copy(ref BlockLiteral block);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern IntPtr _Block_copy(IntPtr block);

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void _Block_release(IntPtr block);

    static BlockLiteral()
	{
		block_class = Class.GetHandle("__NSStackBlock");
		global_descriptor = BlockDescriptor.CreateDescriptor();
		global_descriptor_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * 2 + Marshal.SizeOf(typeof(IntPtr)) * 2);
		Marshal.StructureToPtr(global_descriptor, global_descriptor_ptr, fDeleteOld: false);
	}

    [BindingImpl(BindingImplOptions.Optimizable)]
    internal static IntPtr GetBlockForDelegate(MethodInfo minfo, object @delegate, uint token_ref, string signature)
    {
        if (@delegate == null)
        {
            return IntPtr.Zero;
        }
        if (!(@delegate is Delegate))
        {
            throw ErrorHelper.CreateError(8016, "Unable to convert delegate to block for the return value for the method {0}.{1}, because the input isn't a delegate, it's a {1}. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", minfo.DeclaringType.FullName, minfo.Name, @delegate.GetType().FullName);
        }
        MethodInfo baseMethod;
        Type delegateProxyType = GetDelegateProxyType(minfo, token_ref, out baseMethod);
        if (baseMethod == null)
        {
            baseMethod = minfo;
        }
        if (delegateProxyType == null)
        {
            throw ErrorHelper.CreateError(8012, "Invalid DelegateProxyAttribute for the return value for the method {0}.{1}: DelegateType is null. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", baseMethod.DeclaringType.FullName, baseMethod.Name);
        }
        FieldInfo field = delegateProxyType.GetField("Handler", BindingFlags.Static | BindingFlags.NonPublic);
        if (field == null)
        {
            throw ErrorHelper.CreateError(8013, "Invalid DelegateProxyAttribute for the return value for the method {0}.{1}: DelegateType ({2}) specifies a type without a 'Handler' field. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", baseMethod.DeclaringType.FullName, baseMethod.Name, delegateProxyType.FullName);
        }
        object value = field.GetValue(null);
        if (value == null)
        {
            throw ErrorHelper.CreateError(8014, "Invalid DelegateProxyAttribute for the return value for the method {0}.{1}: The DelegateType's ({2}) 'Handler' field is null. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", baseMethod.DeclaringType.FullName, baseMethod.Name, delegateProxyType.FullName);
        }
        if (!(value is Delegate))
        {
            throw ErrorHelper.CreateError(8015, "Invalid DelegateProxyAttribute for the return value for the method {0}.{1}: The DelegateType's ({2}) 'Handler' field is not a delegate, it's a {3}. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", baseMethod.DeclaringType.FullName, baseMethod.Name, delegateProxyType.FullName, value.GetType().FullName);
        }
        BlockLiteral block = default(BlockLiteral);
        if (signature == null)
        {
            if (!Runtime.DynamicRegistrationSupported)
            {
                throw ErrorHelper.CreateError(8026, "BlockLiteral.GetBlockForDelegate with a null signature is not supported when the dynamic registrar has been linked away (delegate type: " + @delegate.GetType().FullName + ").");
            }
            block.SetupBlock((Delegate)value, (Delegate)@delegate);
        }
        else
        {
            block.SetupBlockImpl((Delegate)value, (Delegate)@delegate, safe: true, signature);
        }
        IntPtr result = _Block_copy(ref block);
        block.CleanupBlock();
        return result;
    }

    private static Type GetDelegateProxyType(MethodInfo minfo, uint token_ref, out MethodInfo baseMethod)
    {
        baseMethod = null;
        if (token_ref != uint.MaxValue)
        {
            return Class.ResolveTypeTokenReference(token_ref);
        }
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
                text = Runtime.GetExportAttribute(minfo)?.Selector ?? string.Empty;
            }
            if (!string.IsNullOrEmpty(text))
            {
                ProtocolMemberAttribute protocolMemberAttribute = Runtime.GetProtocolMemberAttribute(type, text, minfo);
                if (protocolMemberAttribute?.ReturnTypeDelegateProxy != null)
                {
                    return protocolMemberAttribute.ReturnTypeDelegateProxy;
                }
            }
        }
        throw ErrorHelper.CreateError(8011, "Unable to locate the delegate to block conversion attribute ([DelegateProxy]) for the return value for the method {0}.{1}. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", baseMethod.DeclaringType.FullName, baseMethod.Name);
    }


    #region

    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SetupBlockUnsafe(Delegate trampoline, Delegate userDelegate)
    {
        SetupBlock(trampoline, userDelegate, safe: false);
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

    [BindingImpl(BindingImplOptions.Optimizable)]
    private void SetupBlock(Delegate trampoline, Delegate userDelegate, bool safe)
    {
        if (!Runtime.DynamicRegistrationSupported)
        {
            throw ErrorHelper.CreateError(8026, "BlockLiteral.SetupBlock is not supported when the dynamic registrar has been linked away.");
        }
        Type type = trampoline.GetType().GetCustomAttribute<UserDelegateTypeAttribute>()?.UserDelegateType;
        MethodInfo method;
        bool isBlockSignature;
        if (type != null)
        {
            method = type.GetMethod("Invoke");
            isBlockSignature = true;
        }
        else
        {
            method = trampoline.Method;
            isBlockSignature = false;
        }
        string signature = Runtime.ComputeSignature(method, isBlockSignature);
        SetupBlockImpl(trampoline, userDelegate, safe, signature);
    }

    private unsafe void SetupBlockImpl(Delegate trampoline, Delegate userDelegate, bool safe, string signature)
    {
        isa = NSConcreteStackBlock;
        invoke = Marshal.GetFunctionPointerForDelegate(trampoline);
        object value = ((!safe) ? ((object)userDelegate) : ((object)new Tuple<Delegate, Delegate>(trampoline, userDelegate)));
        local_handle = (IntPtr)GCHandle.Alloc(value);
        global_handle = IntPtr.Zero;
        flags = BlockFlags.BLOCK_HAS_COPY_DISPOSE | BlockFlags.BLOCK_HAS_SIGNATURE;
        byte[] bytes = Encoding.UTF8.GetBytes(signature);
        int cb = sizeof(XamarinBlockDescriptor) + bytes.Length + 1;
        IntPtr intPtr = (block_descriptor = Marshal.AllocHGlobal(cb));
        XamarinBlockDescriptor* ptr = (XamarinBlockDescriptor*)(void*)block_descriptor;
        ptr->descriptor = *(BlockDescriptor*)(void*)xamarin_get_block_descriptor();
        ptr->descriptor.signature = intPtr + sizeof(BlockDescriptor) + 4;
        ptr->ref_count = 1;
        Marshal.Copy(bytes, 0, ptr->descriptor.signature, bytes.Length);
        Marshal.WriteByte(ptr->descriptor.signature + bytes.Length, 0);
    }

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_get_block_descriptor();

    [EditorBrowsable(EditorBrowsableState.Never)]
    public unsafe static bool IsManagedBlock(IntPtr block)
    {
        if (block == IntPtr.Zero)
        {
            throw new ArgumentNullException("block");
        }
        BlockLiteral* ptr = (BlockLiteral*)(void*)block;
        BlockDescriptor* ptr2 = (BlockDescriptor*)(void*)xamarin_get_block_descriptor();
        return ptr2->copy_helper == ((BlockDescriptor*)(void*)ptr->block_descriptor)->copy_helper;
    }

    public T GetDelegateForBlock<T>() where T : class
    {
        return (T)(object)Runtime.GetDelegateForBlock(invoke, typeof(T));
    }

    #endregion

    public void CleanupBlock()
	{
		GCHandle.FromIntPtr(local_handle).Free();
	}
}
