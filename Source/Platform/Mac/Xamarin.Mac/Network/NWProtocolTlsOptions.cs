using System;
using ObjCRuntime;
using Security;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolTlsOptions : NWProtocolOptions
{
	public SecProtocolOptions ProtocolOptions => new SecProtocolOptions(NWProtocolOptions.nw_tls_copy_sec_protocol_options(GetCheckedHandle()), owns: true);

	internal NWProtocolTlsOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public NWProtocolTlsOptions()
		: this(NWProtocolOptions.nw_tls_create_options(), owns: true)
	{
	}
}
