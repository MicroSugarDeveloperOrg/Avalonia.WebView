using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWDataTransferReport : NativeObject
{
	private delegate void nw_data_transfer_report_collect_t(IntPtr block, IntPtr report);

	private static nw_data_transfer_report_collect_t static_CollectHandler = TrampolineCollectHandler;

	public uint PathCount => nw_data_transfer_report_get_path_count(GetCheckedHandle());

	public TimeSpan Duration => TimeSpan.FromMilliseconds(nw_data_transfer_report_get_duration_milliseconds(GetCheckedHandle()));

	public NWDataTransferReportState State => nw_data_transfer_report_get_state(GetCheckedHandle());

	internal NWDataTransferReport(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_create_new_data_transfer_report(IntPtr connection);

	public NWDataTransferReport(NWConnection connection)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		InitializeHandle(nw_connection_create_new_data_transfer_report(connection.Handle));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern uint nw_data_transfer_report_get_path_count(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_duration_milliseconds(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_data_transfer_report_copy_path_interface(IntPtr report, uint path_index);

	public NWInterface GetInterface(uint pathIndex)
	{
		return new NWInterface(nw_data_transfer_report_copy_path_interface(GetCheckedHandle(), pathIndex), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_received_application_byte_count(IntPtr report, uint path_index);

	public ulong GetApplicationReceivedByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_received_application_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_sent_application_byte_count(IntPtr report, uint path_index);

	public ulong GetApplicationSentByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_sent_application_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_received_transport_byte_count(IntPtr report, uint path_index);

	public ulong GetTransportReceivedByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_received_transport_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_received_transport_duplicate_byte_count(IntPtr report, uint path_index);

	public ulong GetTransportReceivedDuplicateByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_received_transport_duplicate_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_received_transport_out_of_order_byte_count(IntPtr report, uint path_index);

	public ulong GetTransportReceivedOutOfOrderByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_received_transport_duplicate_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_sent_transport_byte_count(IntPtr report, uint path_index);

	public ulong GetTransportSentByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_sent_transport_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_sent_transport_retransmitted_byte_count(IntPtr report, uint path_index);

	public ulong GetTransportRetransmittedByteCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_sent_transport_retransmitted_byte_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_transport_smoothed_rtt_milliseconds(IntPtr report, uint path_index);

	public TimeSpan GetTransportSmoothedRoundTripTime(uint pathIndex)
	{
		return TimeSpan.FromMilliseconds(nw_data_transfer_report_get_transport_smoothed_rtt_milliseconds(GetCheckedHandle(), pathIndex));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_transport_minimum_rtt_milliseconds(IntPtr report, uint path_index);

	public TimeSpan GetTransportMinimumRoundTripTime(uint pathIndex)
	{
		return TimeSpan.FromMilliseconds(nw_data_transfer_report_get_transport_minimum_rtt_milliseconds(GetCheckedHandle(), pathIndex));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_transport_rtt_variance(IntPtr report, uint path_index);

	public ulong GetTransportRoundTripTimeVariance(uint pathIndex)
	{
		return nw_data_transfer_report_get_transport_rtt_variance(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_received_ip_packet_count(IntPtr report, uint path_index);

	public ulong GetTransportReceivedIPPackageCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_received_ip_packet_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_data_transfer_report_get_sent_ip_packet_count(IntPtr report, uint path_index);

	public ulong GetTransportSentIPPackageCount(uint pathIndex)
	{
		return nw_data_transfer_report_get_sent_ip_packet_count(GetCheckedHandle(), pathIndex);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_data_transfer_report_collect(IntPtr report, IntPtr queue, ref BlockLiteral collect_block);

	[MonoPInvokeCallback(typeof(nw_data_transfer_report_collect_t))]
	private static void TrampolineCollectHandler(IntPtr block, IntPtr report)
	{
		Action<NWDataTransferReport> target = BlockLiteral.GetTarget<Action<NWDataTransferReport>>(block);
		if (target != null)
		{
			using (NWDataTransferReport obj = new NWDataTransferReport(report, owns: false))
			{
				target(obj);
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void Collect(DispatchQueue queue, Action<NWDataTransferReport> handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral collect_block = default(BlockLiteral);
		collect_block.SetupBlockUnsafe(static_CollectHandler, handler);
		try
		{
			nw_data_transfer_report_collect(GetCheckedHandle(), queue.Handle, ref collect_block);
		}
		finally
		{
			collect_block.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWDataTransferReportState nw_data_transfer_report_get_state(IntPtr report);
}
