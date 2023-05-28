using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Security;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolMetadata : NativeObject
{
	public NWProtocolDefinition ProtocolDefinition => new NWProtocolDefinition(nw_protocol_metadata_copy_definition(GetCheckedHandle()), owns: true);

	public bool IsIP => nw_protocol_metadata_is_ip(GetCheckedHandle());

	public bool IsUdp => nw_protocol_metadata_is_udp(GetCheckedHandle());

	public bool IsTls => nw_protocol_metadata_is_tls(GetCheckedHandle());

	public bool IsTcp => nw_protocol_metadata_is_tcp(GetCheckedHandle());

	[Obsolete("Use the 'NWTlsMetadata' class and methods instead.")]
	public SecProtocolMetadata SecProtocolMetadata => TlsSecProtocolMetadata;

	[Obsolete("Use the 'NWTlsMetadata' class and methods instead.")]
	public SecProtocolMetadata TlsSecProtocolMetadata
	{
		get
		{
			CheckIsTls();
			return new SecProtocolMetadata(nw_tls_copy_sec_protocol_metadata(GetCheckedHandle()), owns: true);
		}
	}

	[Obsolete("Use the 'NWIPMetadata' class and methods instead.")]
	public NWIPEcnFlag IPMetadataEcnFlag
	{
		get
		{
			CheckIsIP();
			return nw_ip_metadata_get_ecn_flag(GetCheckedHandle());
		}
		set
		{
			CheckIsIP();
			nw_ip_metadata_set_ecn_flag(GetCheckedHandle(), value);
		}
	}

	[Obsolete("Use the 'NWIPMetadata' class and methods instead.")]
	public ulong IPMetadataReceiveTime
	{
		get
		{
			CheckIsIP();
			return nw_ip_metadata_get_receive_time(GetCheckedHandle());
		}
	}

	[Obsolete("Use the 'NWIPMetadata' class and methods instead.")]
	public NWServiceClass ServiceClass
	{
		get
		{
			return IPServiceClass;
		}
		set
		{
			IPServiceClass = value;
		}
	}

	[Obsolete("Use the 'NWIPMetadata' class and methods instead.")]
	public NWServiceClass IPServiceClass
	{
		get
		{
			CheckIsIP();
			return nw_ip_metadata_get_service_class(GetCheckedHandle());
		}
		set
		{
			CheckIsIP();
			nw_ip_metadata_set_service_class(GetCheckedHandle(), value);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public bool IsFramerMessage => nw_protocol_metadata_is_framer_message(GetCheckedHandle());

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public bool IsWebSocket => nw_protocol_metadata_is_ws(GetCheckedHandle());

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern IntPtr nw_ip_create_metadata();

	[Obsolete("Use the 'NWIPMetadata' class and methods instead.")]
	public static NWProtocolMetadata CreateIPMetadata()
	{
		return new NWProtocolMetadata(nw_ip_create_metadata(), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern IntPtr nw_udp_create_metadata();

	[Obsolete("Use the 'NSUdpMetadata' class and methods instead.")]
	public static NWProtocolMetadata CreateUdpMetadata()
	{
		return new NWProtocolMetadata(nw_udp_create_metadata(), owns: true);
	}

	public NWProtocolMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern IntPtr nw_protocol_metadata_copy_definition(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool nw_protocol_metadata_is_ip(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool nw_protocol_metadata_is_udp(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool nw_protocol_metadata_is_tls(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	internal static extern bool nw_protocol_metadata_is_tcp(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern IntPtr nw_tls_copy_sec_protocol_metadata(IntPtr handle);

	private void CheckIsIP()
	{
		if (!IsIP)
		{
			throw new InvalidOperationException("This metadata is not IP metadata.");
		}
	}

	private void CheckIsTcp()
	{
		if (!IsTcp)
		{
			throw new InvalidOperationException("This metadata is not TCP metadata.");
		}
	}

	private void CheckIsTls()
	{
		if (!IsTls)
		{
			throw new InvalidOperationException("This metadata is not TLS metadata.");
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern void nw_ip_metadata_set_ecn_flag(IntPtr metadata, NWIPEcnFlag ecn_flag);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern NWIPEcnFlag nw_ip_metadata_get_ecn_flag(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern ulong nw_ip_metadata_get_receive_time(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern void nw_ip_metadata_set_service_class(IntPtr metadata, NWServiceClass service_class);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern NWServiceClass nw_ip_metadata_get_service_class(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern uint nw_tcp_get_available_receive_buffer(IntPtr handle);

	[Obsolete("Use the 'NWTcpMetadata' class and methods instead.")]
	public uint TcpGetAvailableReceiveBuffer()
	{
		CheckIsTcp();
		return nw_tcp_get_available_receive_buffer(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	internal static extern uint nw_tcp_get_available_send_buffer(IntPtr handle);

	[Obsolete("Use the 'NWTcpMetadata' class and methods instead.")]
	public uint TcpGetAvailableSendBuffer()
	{
		CheckIsTcp();
		return nw_tcp_get_available_send_buffer(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	internal static extern bool nw_protocol_metadata_is_framer_message(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	internal static extern bool nw_protocol_metadata_is_ws(IntPtr metadata);
}
