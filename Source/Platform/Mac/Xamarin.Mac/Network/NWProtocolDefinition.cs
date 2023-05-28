using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolDefinition : NativeObject
{
	private delegate NWFramerStartResult nw_framer_create_definition_t(IntPtr block, IntPtr framer);

	private static nw_framer_create_definition_t static_CreateFramerHandler = TrampolineCreateFramerHandler;

	[Obsolete("Use 'CreateIPDefinition' method instead.")]
	public static NWProtocolDefinition IPDefinition => new NWProtocolDefinition(nw_protocol_copy_ip_definition(), owns: true);

	[Obsolete("Use 'CreateTcpDefinition' method instead.")]
	public static NWProtocolDefinition TcpDefinition => new NWProtocolDefinition(nw_protocol_copy_tcp_definition(), owns: true);

	[Obsolete("Use 'CreateUdpDefinition' method instead.")]
	public static NWProtocolDefinition UdpDefinition => new NWProtocolDefinition(nw_protocol_copy_udp_definition(), owns: true);

	[Obsolete("Use 'CreateTlsDefinition' method instead.")]
	public static NWProtocolDefinition TlsDefinition => new NWProtocolDefinition(nw_protocol_copy_tls_definition(), owns: true);

	[Obsolete("Use 'CreateWebSocketDefinition' method instead.")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public static NWProtocolDefinition WebSocketDefinition => new NWProtocolDefinition(nw_protocol_copy_ws_definition(), owns: true);

	public NWProtocolDefinition(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_protocol_definition_is_equal(IntPtr definition1, IntPtr definition2);

	public new bool Equals(object other)
	{
		if (other == null)
		{
			return false;
		}
		if (!(other is NWProtocolDefinition nWProtocolDefinition))
		{
			return false;
		}
		return nw_protocol_definition_is_equal(GetCheckedHandle(), nWProtocolDefinition.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_copy_ip_definition();

	public static NWProtocolDefinition CreateIPDefinition()
	{
		return new NWProtocolDefinition(nw_protocol_copy_ip_definition(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_copy_tcp_definition();

	public static NWProtocolDefinition CreateTcpDefinition()
	{
		return new NWProtocolDefinition(nw_protocol_copy_tcp_definition(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_copy_udp_definition();

	public static NWProtocolDefinition CreateUdpDefinition()
	{
		return new NWProtocolDefinition(nw_protocol_copy_udp_definition(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_copy_tls_definition();

	public static NWProtocolDefinition CreateTlsDefinition()
	{
		return new NWProtocolDefinition(nw_protocol_copy_tls_definition(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr nw_protocol_copy_ws_definition();

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public static NWProtocolDefinition CreateWebSocketDefinition()
	{
		return new NWProtocolDefinition(nw_protocol_copy_ws_definition(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr nw_framer_create_definition(string identifier, NWFramerCreateFlags flags, ref BlockLiteral start_handler);

	[MonoPInvokeCallback(typeof(nw_framer_create_definition_t))]
	private static NWFramerStartResult TrampolineCreateFramerHandler(IntPtr block, IntPtr framer)
	{
		Func<NWFramer, NWFramerStartResult> target = BlockLiteral.GetTarget<Func<NWFramer, NWFramerStartResult>>(block);
		if (target != null)
		{
			NWFramer arg = new NWFramer(framer, owns: true);
			return target(arg);
		}
		return NWFramerStartResult.Unknown;
	}

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static NWProtocolDefinition CreateFramerDefinition(string identifier, NWFramerCreateFlags flags, Func<NWFramer, NWFramerStartResult> startCallback)
	{
		BlockLiteral start_handler = default(BlockLiteral);
		start_handler.SetupBlockUnsafe(static_CreateFramerHandler, startCallback);
		try
		{
			return new NWProtocolDefinition(nw_framer_create_definition(identifier, flags, ref start_handler), owns: true);
		}
		finally
		{
			start_handler.CleanupBlock();
		}
	}
}
