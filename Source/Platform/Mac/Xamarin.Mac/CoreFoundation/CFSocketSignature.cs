using System;
using System.Net.Sockets;

namespace CoreFoundation;

internal struct CFSocketSignature
{
	private int protocolFamily;

	private int socketType;

	private int protocol;

	private IntPtr address;

	public CFSocketSignature(AddressFamily family, SocketType type, ProtocolType proto, CFSocketAddress address)
	{
		protocolFamily = AddressFamilyToInt(family);
		socketType = SocketTypeToInt(type);
		protocol = ProtocolToInt(proto);
		this.address = address.Handle;
	}

	internal static int AddressFamilyToInt(AddressFamily family)
	{
		return family switch
		{
			AddressFamily.Unspecified => 0, 
			AddressFamily.Unix => 1, 
			AddressFamily.InterNetwork => 2, 
			AddressFamily.AppleTalk => 16, 
			AddressFamily.InterNetworkV6 => 30, 
			_ => throw new ArgumentException(), 
		};
	}

	internal static int SocketTypeToInt(SocketType type)
	{
		return type switch
		{
			(SocketType)0 => 0, 
			SocketType.Unknown => 0, 
			SocketType.Stream => 1, 
			SocketType.Dgram => 2, 
			SocketType.Raw => 3, 
			SocketType.Rdm => 4, 
			SocketType.Seqpacket => 5, 
			_ => throw new ArgumentException(), 
		};
	}

	internal static int ProtocolToInt(ProtocolType type)
	{
		return (int)type;
	}
}
