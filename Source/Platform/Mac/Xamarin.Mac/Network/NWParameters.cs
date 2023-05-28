using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWParameters : NativeObject
{
	private delegate void nw_parameters_configure_protocol_block_t(IntPtr block, IntPtr iface);

	private delegate bool nw_parameters_iterate_interfaces_block_t(IntPtr block, IntPtr iface);

	private delegate bool nw_parameters_iterate_interface_types_block_t(IntPtr block, NWInterfaceType type);

	private static nw_parameters_configure_protocol_block_t static_ConfigureHandler = TrampolineConfigureHandler;

	private static nw_parameters_iterate_interfaces_block_t static_iterateProhibitedHandler = TrampolineIterateProhibitedHandler;

	private static nw_parameters_iterate_interface_types_block_t static_IterateProhibitedTypeHandler = TrampolineIterateProhibitedTypeHandler;

	public NWMultiPathService MultipathService
	{
		get
		{
			return nw_parameters_get_multipath_service(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_multipath_service(GetCheckedHandle(), value);
		}
	}

	public NWProtocolStack ProtocolStack => new NWProtocolStack(nw_parameters_copy_default_protocol_stack(GetCheckedHandle()), owns: true);

	public bool LocalOnly
	{
		get
		{
			return nw_parameters_get_local_only(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_local_only(GetCheckedHandle(), value);
		}
	}

	public bool PreferNoProxy
	{
		get
		{
			return nw_parameters_get_prefer_no_proxy(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_prefer_no_proxy(GetCheckedHandle(), value);
		}
	}

	public NWParametersExpiredDnsBehavior ExpiredDnsBehavior
	{
		get
		{
			return nw_parameters_get_expired_dns_behavior(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_expired_dns_behavior(GetCheckedHandle(), value);
		}
	}

	public NWInterface RequiredInterface
	{
		get
		{
			IntPtr intPtr = nw_parameters_copy_required_interface(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWInterface(intPtr, owns: true);
		}
		set
		{
			nw_parameters_require_interface(GetCheckedHandle(), value.GetHandle());
		}
	}

	public NWInterfaceType RequiredInterfaceType
	{
		get
		{
			return nw_parameters_get_required_interface_type(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_required_interface_type(GetCheckedHandle(), value);
		}
	}

	public bool ProhibitExpensive
	{
		get
		{
			return nw_parameters_get_prohibit_expensive(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_prohibit_expensive(GetCheckedHandle(), value);
		}
	}

	public bool ReuseLocalAddress
	{
		get
		{
			return nw_parameters_get_reuse_local_address(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_reuse_local_address(GetCheckedHandle(), value);
		}
	}

	public bool FastOpenEnabled
	{
		get
		{
			return nw_parameters_get_fast_open_enabled(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_fast_open_enabled(GetCheckedHandle(), value);
		}
	}

	public NWServiceClass ServiceClass
	{
		get
		{
			return nw_parameters_get_service_class(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_service_class(GetCheckedHandle(), value);
		}
	}

	public NWEndpoint LocalEndpoint
	{
		get
		{
			IntPtr intPtr = nw_parameters_copy_local_endpoint(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWEndpoint(intPtr, owns: true);
		}
		set
		{
			nw_parameters_set_local_endpoint(GetCheckedHandle(), value.GetHandle());
		}
	}

	public bool IncludePeerToPeer
	{
		get
		{
			return nw_parameters_get_include_peer_to_peer(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_include_peer_to_peer(GetCheckedHandle(), value);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public bool ProhibitConstrained
	{
		get
		{
			return nw_parameters_get_prohibit_constrained(GetCheckedHandle());
		}
		set
		{
			nw_parameters_set_prohibit_constrained(GetCheckedHandle(), value);
		}
	}

	public NWParameters(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	private unsafe static BlockLiteral* DEFAULT_CONFIGURATION()
	{
		return (BlockLiteral*)(void*)NWParametersConstants._DefaultConfiguration;
	}

	private unsafe static BlockLiteral* DISABLE_PROTOCOL()
	{
		return (BlockLiteral*)(void*)NWParametersConstants._ProtocolDisable;
	}

	[MonoPInvokeCallback(typeof(nw_parameters_configure_protocol_block_t))]
	private static void TrampolineConfigureHandler(IntPtr block, IntPtr iface)
	{
		Action<NWProtocolOptions> target = BlockLiteral.GetTarget<Action<NWProtocolOptions>>(block);
		if (target == null)
		{
			return;
		}
		using NWProtocolOptions nWProtocolOptions = new NWProtocolOptions(iface, owns: false);
		using NWProtocolDefinition nWProtocolDefinition = nWProtocolOptions.ProtocolDefinition;
		NWProtocolOptions nWProtocolOptions2 = null;
		if (nWProtocolDefinition.Equals(NWProtocolDefinition.TcpDefinition))
		{
			nWProtocolOptions2 = new NWProtocolTcpOptions(iface, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.UdpDefinition))
		{
			nWProtocolOptions2 = new NWProtocolUdpOptions(iface, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.TlsDefinition))
		{
			nWProtocolOptions2 = new NWProtocolTlsOptions(iface, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.IPDefinition))
		{
			nWProtocolOptions2 = new NWProtocolIPOptions(iface, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.WebSocketDefinition))
		{
			nWProtocolOptions2 = new NWWebSocketOptions(iface, owns: false);
		}
		target(nWProtocolOptions2 ?? nWProtocolOptions);
		nWProtocolOptions2?.Dispose();
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern IntPtr nw_parameters_create_secure_tcp(void* configure_tls, void* configure_tcp);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static NWParameters CreateSecureTcp(Action<NWProtocolOptions> configureTls = null, Action<NWProtocolOptions> configureTcp = null)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		BlockLiteral* ptr2 = &blockLiteral2;
		if (configureTls == null)
		{
			ptr = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral.SetupBlockUnsafe(static_ConfigureHandler, configureTls);
		}
		if (configureTcp == null)
		{
			ptr2 = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral2.SetupBlockUnsafe(static_ConfigureHandler, configureTcp);
		}
		IntPtr intPtr = nw_parameters_create_secure_tcp(ptr, ptr2);
		if (configureTls != null)
		{
			ptr->CleanupBlock();
		}
		if (configureTcp != null)
		{
			ptr2->CleanupBlock();
		}
		return new NWParameters(intPtr, owns: true);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static NWParameters CreateTcp(Action<NWProtocolOptions> configureTcp = null)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		if (configureTcp == null)
		{
			ptr = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral.SetupBlockUnsafe(static_ConfigureHandler, configureTcp);
		}
		IntPtr intPtr = nw_parameters_create_secure_tcp(DISABLE_PROTOCOL(), ptr);
		if (configureTcp != null)
		{
			ptr->CleanupBlock();
		}
		return new NWParameters(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern IntPtr nw_parameters_create_secure_udp(void* configure_tls, void* configure_tcp);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static NWParameters CreateSecureUdp(Action<NWProtocolOptions> configureTls = null, Action<NWProtocolOptions> configureUdp = null)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		BlockLiteral* ptr2 = &blockLiteral2;
		if (configureTls == null)
		{
			ptr = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral.SetupBlockUnsafe(static_ConfigureHandler, configureTls);
		}
		if (configureUdp == null)
		{
			ptr2 = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral2.SetupBlockUnsafe(static_ConfigureHandler, configureUdp);
		}
		IntPtr intPtr = nw_parameters_create_secure_udp(ptr, ptr2);
		if (configureTls != null)
		{
			ptr->CleanupBlock();
		}
		if (configureUdp != null)
		{
			ptr2->CleanupBlock();
		}
		return new NWParameters(intPtr, owns: true);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static NWParameters CreateUdp(Action<NWProtocolOptions> configureUdp = null)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		if (configureUdp == null)
		{
			ptr = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral.SetupBlockUnsafe(static_ConfigureHandler, configureUdp);
		}
		IntPtr intPtr = nw_parameters_create_secure_udp(DISABLE_PROTOCOL(), ptr);
		if (configureUdp != null)
		{
			ptr->CleanupBlock();
		}
		return new NWParameters(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 15)]
	private unsafe static extern IntPtr nw_parameters_create_custom_ip(byte custom_ip_protocol_number, BlockLiteral* configure_ip);

	[NoWatch]
	[NoTV]
	[NoiOS]
	[Mac(10, 15)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe static NWParameters CreateCustomIP(byte protocolNumber, Action<NWProtocolOptions> configureCustomIP = null)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		if (configureCustomIP == null)
		{
			ptr = DEFAULT_CONFIGURATION();
		}
		else
		{
			blockLiteral.SetupBlockUnsafe(static_ConfigureHandler, configureCustomIP);
		}
		IntPtr intPtr = nw_parameters_create_custom_ip(protocolNumber, ptr);
		if (configureCustomIP != null)
		{
			ptr->CleanupBlock();
		}
		return new NWParameters(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_parameters_create();

	public NWParameters()
	{
		InitializeHandle(nw_parameters_create());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_parameters_copy(IntPtr handle);

	public NWParameters Clone()
	{
		return new NWParameters(nw_parameters_copy(GetCheckedHandle()), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_multipath_service(IntPtr parameters, NWMultiPathService multipath_service);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWMultiPathService nw_parameters_get_multipath_service(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_parameters_copy_default_protocol_stack(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_local_only(IntPtr parameters, [MarshalAs(UnmanagedType.I1)] bool local_only);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_local_only(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_prefer_no_proxy(IntPtr parameters, [MarshalAs(UnmanagedType.I1)] bool prefer_no_proxy);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_prefer_no_proxy(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_expired_dns_behavior(IntPtr parameters, NWParametersExpiredDnsBehavior expired_dns_behavior);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWParametersExpiredDnsBehavior nw_parameters_get_expired_dns_behavior(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_require_interface(IntPtr parameters, IntPtr handleInterface);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_parameters_copy_required_interface(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_prohibit_interface(IntPtr parameters, IntPtr handleInterface);

	public void ProhibitInterface(NWInterface iface)
	{
		if (iface == null)
		{
			throw new ArgumentNullException("iface");
		}
		nw_parameters_prohibit_interface(GetCheckedHandle(), iface.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_clear_prohibited_interfaces(IntPtr parameters);

	public void ClearProhibitedInterfaces()
	{
		nw_parameters_clear_prohibited_interfaces(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_required_interface_type(IntPtr parameters, NWInterfaceType ifaceType);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWInterfaceType nw_parameters_get_required_interface_type(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_prohibit_interface_type(IntPtr parameters, NWInterfaceType type);

	public void ProhibitInterfaceType(NWInterfaceType ifaceType)
	{
		nw_parameters_prohibit_interface_type(GetCheckedHandle(), ifaceType);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_clear_prohibited_interface_types(IntPtr parameters);

	public void ClearProhibitedInterfaceTypes()
	{
		nw_parameters_clear_prohibited_interface_types(GetCheckedHandle());
	}

	[MonoPInvokeCallback(typeof(nw_parameters_iterate_interfaces_block_t))]
	[return: MarshalAs(UnmanagedType.I1)]
	private static bool TrampolineIterateProhibitedHandler(IntPtr block, IntPtr iface)
	{
		Func<NWInterface, bool> target = BlockLiteral.GetTarget<Func<NWInterface, bool>>(block);
		if (target != null)
		{
			NWInterface nWInterface = new NWInterface(iface, owns: false);
			bool result = target(nWInterface);
			nWInterface.Dispose();
			return result;
		}
		return false;
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_iterate_prohibited_interfaces(IntPtr parameters, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void IterateProhibitedInterfaces(Func<NWInterface, bool> iterationCallback)
	{
		BlockLiteral callback = default(BlockLiteral);
		callback.SetupBlockUnsafe(static_iterateProhibitedHandler, iterationCallback);
		try
		{
			nw_parameters_iterate_prohibited_interfaces(GetCheckedHandle(), ref callback);
		}
		finally
		{
			callback.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(nw_parameters_iterate_interface_types_block_t))]
	[return: MarshalAs(UnmanagedType.I1)]
	private static bool TrampolineIterateProhibitedTypeHandler(IntPtr block, NWInterfaceType type)
	{
		return BlockLiteral.GetTarget<Func<NWInterfaceType, bool>>(block)?.Invoke(type) ?? false;
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_iterate_prohibited_interface_types(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void IterateProhibitedInterfaces(Func<NWInterfaceType, bool> callback)
	{
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_IterateProhibitedTypeHandler, callback);
		try
		{
			nw_parameters_iterate_prohibited_interface_types(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_prohibit_expensive(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_prohibit_expensive(IntPtr handle, [MarshalAs(UnmanagedType.I1)] bool prohibit_expensive);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_reuse_local_address(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_reuse_local_address(IntPtr handle, [MarshalAs(UnmanagedType.I1)] bool reuse_local_address);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_fast_open_enabled(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_fast_open_enabled(IntPtr handle, [MarshalAs(UnmanagedType.I1)] bool fast_open_enabled);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWServiceClass nw_parameters_get_service_class(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_service_class(IntPtr handle, NWServiceClass service_class);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_parameters_copy_local_endpoint(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_local_endpoint(IntPtr handle, IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_parameters_set_include_peer_to_peer(IntPtr handle, bool includePeerToPeer);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_include_peer_to_peer(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_parameters_get_prohibit_constrained(IntPtr parameters);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern void nw_parameters_set_prohibit_constrained(IntPtr parameters, bool prohibit_constrained);
}
