using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWPath : NativeObject
{
	private delegate void nw_path_enumerate_interfaces_block_t(IntPtr block, IntPtr iface);

	private delegate void nw_path_enumerate_gateways_t(IntPtr block, IntPtr endpoint);

	private static nw_path_enumerate_interfaces_block_t static_Enumerator = TrampolineEnumerator;

	private static nw_path_enumerate_gateways_t static_EnumerateGatewaysHandler = TrampolineGatewaysHandler;

	public NWPathStatus Status => nw_path_get_status(GetCheckedHandle());

	public bool IsExpensive => nw_path_is_expensive(GetCheckedHandle());

	public bool HasIPV4 => nw_path_has_ipv4(GetCheckedHandle());

	public bool HasIPV6 => nw_path_has_ipv6(GetCheckedHandle());

	public bool HasDns => nw_path_has_dns(GetCheckedHandle());

	public NWEndpoint EffectiveLocalEndpoint
	{
		get
		{
			IntPtr intPtr = nw_path_copy_effective_local_endpoint(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWEndpoint(intPtr, owns: true);
		}
	}

	public NWEndpoint EffectiveRemoteEndpoint
	{
		get
		{
			IntPtr intPtr = nw_path_copy_effective_remote_endpoint(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWEndpoint(intPtr, owns: true);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public bool IsConstrained => nw_path_is_constrained(GetCheckedHandle());

	public NWPath(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWPathStatus nw_path_get_status(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_is_expensive(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_has_ipv4(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_has_ipv6(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_has_dns(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_uses_interface_type(IntPtr handle, NWInterfaceType type);

	public bool UsesInterfaceType(NWInterfaceType type)
	{
		return nw_path_uses_interface_type(GetCheckedHandle(), type);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_path_copy_effective_local_endpoint(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_path_copy_effective_remote_endpoint(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool nw_path_is_equal(IntPtr p1, IntPtr p2);

	public bool EqualsTo(NWPath other)
	{
		if (other == null)
		{
			return false;
		}
		return nw_path_is_equal(GetCheckedHandle(), other.Handle);
	}

	[MonoPInvokeCallback(typeof(nw_path_enumerate_interfaces_block_t))]
	private static void TrampolineEnumerator(IntPtr block, IntPtr iface)
	{
		BlockLiteral.GetTarget<Action<NWInterface>>(block)?.Invoke(new NWInterface(iface, owns: false));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_path_enumerate_interfaces(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateInterfaces(Action<NWInterface> callback)
	{
		if (callback == null)
		{
			return;
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_Enumerator, callback);
		try
		{
			nw_path_enumerate_interfaces(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern bool nw_path_is_constrained(IntPtr path);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern void nw_path_enumerate_gateways(IntPtr path, ref BlockLiteral enumerate_block);

	[MonoPInvokeCallback(typeof(nw_path_enumerate_gateways_t))]
	private static void TrampolineGatewaysHandler(IntPtr block, IntPtr endpoint)
	{
		Action<NWEndpoint> target = BlockLiteral.GetTarget<Action<NWEndpoint>>(block);
		if (target != null)
		{
			NWEndpoint obj = new NWEndpoint(endpoint, owns: false);
			target(obj);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateGateways(Action<NWEndpoint> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral enumerate_block = default(BlockLiteral);
		enumerate_block.SetupBlockUnsafe(static_Enumerator, callback);
		try
		{
			nw_path_enumerate_gateways(GetCheckedHandle(), ref enumerate_block);
		}
		finally
		{
			enumerate_block.CleanupBlock();
		}
	}
}
