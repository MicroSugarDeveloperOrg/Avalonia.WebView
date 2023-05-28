using System;
using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[NoWatch]
[NoTV]
[NoiOS]
[Mac(10, 15)]
public class NWEthernetChannel : NativeObject
{
	private delegate void nw_ethernet_channel_send_completion_t(IntPtr block, IntPtr error);

	private delegate void nw_ethernet_channel_receive_handler_t(IntPtr block, IntPtr content, ushort vlan_tag, byte[] local_address, byte[] remote_address);

	private delegate void nw_ethernet_channel_state_changed_handler_t(IntPtr block, NWEthernetChannelState state, IntPtr error);

	private static nw_ethernet_channel_send_completion_t static_SendCompletion = TrampolineSendCompletion;

	private static nw_ethernet_channel_receive_handler_t static_ReceiveHandler = TrampolineReceiveHandler;

	private static nw_ethernet_channel_state_changed_handler_t static_StateChangesHandler = TrampolineStateChangesHandler;

	internal NWEthernetChannel(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_ethernet_channel_create(ushort ether_type, IntPtr networkInterface);

	public NWEthernetChannel(ushort ethernetType, NWInterface networkInterface)
	{
		if (networkInterface == null)
		{
			throw new ArgumentNullException("networkInterface");
		}
		InitializeHandle(nw_ethernet_channel_create(ethernetType, networkInterface.Handle));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ethernet_channel_start(IntPtr ethernet_channel);

	public void Start()
	{
		nw_ethernet_channel_start(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ethernet_channel_cancel(IntPtr ethernet_channel);

	public void Cancel()
	{
		nw_ethernet_channel_cancel(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ethernet_channel_set_queue(IntPtr ethernet_channel, IntPtr queue);

	public void SetQueue(DispatchQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		nw_ethernet_channel_set_queue(GetCheckedHandle(), queue.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ethernet_channel_send(IntPtr ethernet_channel, IntPtr content, ushort vlan_tag, string remote_address, ref BlockLiteral completion);

	[MonoPInvokeCallback(typeof(nw_ethernet_channel_send_completion_t))]
	private static void TrampolineSendCompletion(IntPtr block, IntPtr error)
	{
		Action<NWError> target = BlockLiteral.GetTarget<Action<NWError>>(block);
		if (target != null)
		{
			NWError nWError = ((error == IntPtr.Zero) ? null : new NWError(error, owns: false));
			target(nWError);
			nWError?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void Send(ReadOnlySpan<byte> content, ushort vlanTag, string remoteAddress, Action<NWError> callback)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		using DispatchData self = DispatchData.FromReadOnlySpan(content);
		BlockLiteral completion = default(BlockLiteral);
		completion.SetupBlockUnsafe(static_SendCompletion, callback);
		try
		{
			nw_ethernet_channel_send(GetCheckedHandle(), self.GetHandle(), vlanTag, remoteAddress, ref completion);
		}
		finally
		{
			completion.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_ethernet_channel_set_receive_handler(IntPtr ethernet_channel, BlockLiteral* handler);

	[MonoPInvokeCallback(typeof(nw_ethernet_channel_receive_handler_t))]
	private static void TrampolineReceiveHandler(IntPtr block, IntPtr content, ushort vlanTag, byte[] localAddress, byte[] remoteAddress)
	{
		NWEthernetChannelReceiveDelegate target = BlockLiteral.GetTarget<NWEthernetChannelReceiveDelegate>(block);
		if (target != null)
		{
			DispatchData content2 = ((content == IntPtr.Zero) ? null : new DispatchData(content, owns: false));
			string localAddress2 = ((localAddress == null) ? null : Encoding.UTF8.GetString(localAddress));
			string remoteAddress2 = ((remoteAddress == null) ? null : Encoding.UTF8.GetString(remoteAddress));
			target(content2, vlanTag, localAddress2, remoteAddress2);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetReceiveHandler(NWEthernetChannelReceiveDelegate handler)
	{
		if (handler == null)
		{
			nw_ethernet_channel_set_receive_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		blockLiteral.SetupBlockUnsafe(static_ReceiveHandler, handler);
		try
		{
			nw_ethernet_channel_set_receive_handler(GetCheckedHandle(), &blockLiteral);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_ethernet_channel_set_state_changed_handler(IntPtr ethernet_channel, BlockLiteral* handler);

	[MonoPInvokeCallback(typeof(nw_ethernet_channel_state_changed_handler_t))]
	private static void TrampolineStateChangesHandler(IntPtr block, NWEthernetChannelState state, IntPtr error)
	{
		Action<NWEthernetChannelState, NWError> target = BlockLiteral.GetTarget<Action<NWEthernetChannelState, NWError>>(block);
		if (target != null)
		{
			NWError arg = ((error == IntPtr.Zero) ? null : new NWError(error, owns: false));
			target(state, arg);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetStateChangesHandler(Action<NWBrowserState, NWError> handler)
	{
		if (handler == null)
		{
			nw_ethernet_channel_set_state_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		blockLiteral.SetupBlockUnsafe(static_StateChangesHandler, handler);
		try
		{
			nw_ethernet_channel_set_state_changed_handler(GetCheckedHandle(), &blockLiteral);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}
}
