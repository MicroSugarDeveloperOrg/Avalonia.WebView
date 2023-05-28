using System;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWTcpMetadata : NWProtocolMetadata
{
	public uint AvailableReceiveBuffer => NWProtocolMetadata.nw_tcp_get_available_receive_buffer(GetCheckedHandle());

	public uint AvailableSendBuffer => NWProtocolMetadata.nw_tcp_get_available_send_buffer(GetCheckedHandle());

	internal NWTcpMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
