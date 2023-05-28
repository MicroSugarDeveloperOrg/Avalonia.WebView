using System;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolTcpOptions : NWProtocolOptions
{
	internal NWProtocolTcpOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public NWProtocolTcpOptions()
		: this(NWProtocolOptions.nw_tcp_create_options(), owns: true)
	{
	}

	public void SetNoDelay(bool noDelay)
	{
		NWProtocolOptions.nw_tcp_options_set_no_delay(GetCheckedHandle(), noDelay);
	}

	public void SetNoPush(bool noPush)
	{
		NWProtocolOptions.nw_tcp_options_set_no_push(GetCheckedHandle(), noPush);
	}

	public void SetNoOptions(bool noOptions)
	{
		NWProtocolOptions.nw_tcp_options_set_no_options(GetCheckedHandle(), noOptions);
	}

	public void SetEnableKeepAlive(bool enableKeepAlive)
	{
		NWProtocolOptions.nw_tcp_options_set_enable_keepalive(GetCheckedHandle(), enableKeepAlive);
	}

	public void SetKeepAliveCount(uint keepAliveCount)
	{
		NWProtocolOptions.nw_tcp_options_set_keepalive_count(GetCheckedHandle(), keepAliveCount);
	}

	public void SetKeepAliveIdleTime(TimeSpan keepAliveIdleTime)
	{
		NWProtocolOptions.nw_tcp_options_set_keepalive_idle_time(GetCheckedHandle(), (uint)keepAliveIdleTime.Seconds);
	}

	public void SetKeepAliveInterval(TimeSpan keepAliveInterval)
	{
		NWProtocolOptions.nw_tcp_options_set_keepalive_interval(GetCheckedHandle(), (uint)keepAliveInterval.Seconds);
	}

	public void SetMaximumSegmentSize(uint maximumSegmentSize)
	{
		NWProtocolOptions.nw_tcp_options_set_maximum_segment_size(GetCheckedHandle(), maximumSegmentSize);
	}

	public void SetConnectionTimeout(TimeSpan connectionTimeout)
	{
		NWProtocolOptions.nw_tcp_options_set_connection_timeout(GetCheckedHandle(), (uint)connectionTimeout.Seconds);
	}

	public void SetPersistTimeout(TimeSpan persistTimeout)
	{
		NWProtocolOptions.nw_tcp_options_set_persist_timeout(GetCheckedHandle(), (uint)persistTimeout.Seconds);
	}

	public void SetRetransmitConnectionDropTime(TimeSpan connectionDropTime)
	{
		NWProtocolOptions.nw_tcp_options_set_retransmit_connection_drop_time(GetCheckedHandle(), (uint)connectionDropTime.Seconds);
	}

	public void SetRetransmitFinDrop(bool retransmitFinDrop)
	{
		NWProtocolOptions.nw_tcp_options_set_retransmit_fin_drop(GetCheckedHandle(), retransmitFinDrop);
	}

	public void SetDisableAckStretching(bool disableAckStretching)
	{
		NWProtocolOptions.nw_tcp_options_set_disable_ack_stretching(GetCheckedHandle(), disableAckStretching);
	}

	public void SetEnableFastOpen(bool enableFastOpen)
	{
		NWProtocolOptions.nw_tcp_options_set_enable_fast_open(GetCheckedHandle(), enableFastOpen);
	}

	public void SetDisableEcn(bool disableEcn)
	{
		NWProtocolOptions.nw_tcp_options_set_disable_ecn(GetCheckedHandle(), disableEcn);
	}
}
