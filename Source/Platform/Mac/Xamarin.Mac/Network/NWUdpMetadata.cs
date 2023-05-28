using System;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWUdpMetadata : NWProtocolMetadata
{
	internal NWUdpMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public NWUdpMetadata()
		: this(NWProtocolMetadata.nw_udp_create_metadata(), owns: true)
	{
	}
}
