using System;
using ObjCRuntime;
using Security;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWTlsMetadata : NWProtocolMetadata
{
	public new SecProtocolMetadata SecProtocolMetadata => new SecProtocolMetadata(NWProtocolMetadata.nw_tls_copy_sec_protocol_metadata(GetCheckedHandle()), owns: true);

	internal NWTlsMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
