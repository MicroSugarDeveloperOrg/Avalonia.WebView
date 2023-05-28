using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWProtocolIPOptions : NWProtocolOptions
{
	internal NWProtocolIPOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public void SetVersion(NWIPVersion version)
	{
		NWProtocolOptions.nw_ip_options_set_version(GetCheckedHandle(), version);
	}

	public void SetHopLimit(nuint hopLimit)
	{
		NWProtocolOptions.nw_ip_options_set_hop_limit(GetCheckedHandle(), (byte)hopLimit);
	}

	public void SetUseMinimumMtu(bool useMinimumMtu)
	{
		NWProtocolOptions.nw_ip_options_set_use_minimum_mtu(GetCheckedHandle(), useMinimumMtu);
	}

	public void SetDisableFragmentation(bool disableFragmentation)
	{
		NWProtocolOptions.nw_ip_options_set_disable_fragmentation(GetCheckedHandle(), disableFragmentation);
	}

	public void SetCalculateReceiveTime(bool shouldCalculateReceiveTime)
	{
		NWProtocolOptions.nw_ip_options_set_calculate_receive_time(GetCheckedHandle(), shouldCalculateReceiveTime);
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public void SetIPLocalAddressPreference(NWIPLocalAddressPreference localAddressPreference)
	{
		NWProtocolOptions.nw_ip_options_set_local_address_preference(GetCheckedHandle(), localAddressPreference);
	}
}
