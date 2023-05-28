using System;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolUdpOptions : NWProtocolOptions
{
	internal NWProtocolUdpOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public NWProtocolUdpOptions()
		: this(NWProtocolOptions.nw_udp_create_options(), owns: true)
	{
	}

	public void SetPreferNoChecksum(bool preferNoChecksum)
	{
		NWProtocolOptions.nw_udp_options_set_prefer_no_checksum(GetCheckedHandle(), preferNoChecksum);
	}
}
