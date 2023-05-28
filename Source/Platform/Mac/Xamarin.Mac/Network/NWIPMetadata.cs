using System;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWIPMetadata : NWProtocolMetadata
{
	public NWIPEcnFlag EcnFlag
	{
		get
		{
			return NWProtocolMetadata.nw_ip_metadata_get_ecn_flag(GetCheckedHandle());
		}
		set
		{
			NWProtocolMetadata.nw_ip_metadata_set_ecn_flag(GetCheckedHandle(), value);
		}
	}

	public TimeSpan ReceiveTime
	{
		get
		{
			ulong num = NWProtocolMetadata.nw_ip_metadata_get_receive_time(GetCheckedHandle());
			return TimeSpan.FromTicks((long)num / 100L);
		}
	}

	public new NWServiceClass ServiceClass
	{
		get
		{
			return NWProtocolMetadata.nw_ip_metadata_get_service_class(GetCheckedHandle());
		}
		set
		{
			NWProtocolMetadata.nw_ip_metadata_set_service_class(GetCheckedHandle(), value);
		}
	}

	internal NWIPMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public NWIPMetadata()
		: this(NWProtocolMetadata.nw_ip_create_metadata(), owns: true)
	{
	}
}
