using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWProtocolStack : NativeObject
{
	private delegate void nw_protocol_stack_iterate_protocols_block_t(IntPtr block, IntPtr options);

	private static nw_protocol_stack_iterate_protocols_block_t static_iterateHandler = TrampolineIterateHandler;

	public NWProtocolOptions TransportProtocol
	{
		get
		{
			IntPtr intPtr = nw_protocol_stack_copy_transport_protocol(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			NWProtocolOptions nWProtocolOptions = new NWProtocolOptions(intPtr, owns: true);
			using NWProtocolDefinition nWProtocolDefinition = nWProtocolOptions.ProtocolDefinition;
			NWProtocolOptions nWProtocolOptions2 = null;
			if (nWProtocolDefinition.Equals(NWProtocolDefinition.TcpDefinition))
			{
				nWProtocolOptions2 = new NWProtocolTcpOptions(intPtr, owns: true);
			}
			if (nWProtocolDefinition.Equals(NWProtocolDefinition.UdpDefinition))
			{
				nWProtocolOptions2 = new NWProtocolUdpOptions(intPtr, owns: true);
			}
			if (nWProtocolOptions2 == null)
			{
				return nWProtocolOptions;
			}
			nWProtocolOptions.Dispose();
			return nWProtocolOptions2;
		}
		set
		{
			nw_protocol_stack_set_transport_protocol(GetCheckedHandle(), value.GetHandle());
		}
	}

	public NWProtocolOptions InternetProtocol
	{
		get
		{
			IntPtr intPtr = nw_protocol_stack_copy_internet_protocol(GetCheckedHandle());
			return (intPtr == IntPtr.Zero) ? null : new NWProtocolIPOptions(intPtr, owns: true);
		}
	}

	public NWProtocolStack(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_protocol_stack_prepend_application_protocol(IntPtr stack, IntPtr options);

	public void PrependApplicationProtocol(NWProtocolOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		nw_protocol_stack_prepend_application_protocol(GetCheckedHandle(), options.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_protocol_stack_clear_application_protocols(IntPtr stack);

	public void ClearApplicationProtocols()
	{
		nw_protocol_stack_clear_application_protocols(GetCheckedHandle());
	}

	[MonoPInvokeCallback(typeof(nw_protocol_stack_iterate_protocols_block_t))]
	private static void TrampolineIterateHandler(IntPtr block, IntPtr options)
	{
		Action<NWProtocolOptions> target = BlockLiteral.GetTarget<Action<NWProtocolOptions>>(block);
		if (target == null)
		{
			return;
		}
		using NWProtocolOptions nWProtocolOptions = new NWProtocolOptions(options, owns: false);
		using NWProtocolDefinition nWProtocolDefinition = nWProtocolOptions.ProtocolDefinition;
		NWProtocolOptions nWProtocolOptions2 = null;
		if (nWProtocolDefinition.Equals(NWProtocolDefinition.TcpDefinition))
		{
			nWProtocolOptions2 = new NWProtocolTcpOptions(options, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.UdpDefinition))
		{
			nWProtocolOptions2 = new NWProtocolUdpOptions(options, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.TlsDefinition))
		{
			nWProtocolOptions2 = new NWProtocolTlsOptions(options, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.IPDefinition))
		{
			nWProtocolOptions2 = new NWProtocolIPOptions(options, owns: false);
		}
		else if (nWProtocolDefinition.Equals(NWProtocolDefinition.WebSocketDefinition))
		{
			nWProtocolOptions2 = new NWWebSocketOptions(options, owns: false);
		}
		target(nWProtocolOptions2 ?? nWProtocolOptions);
		nWProtocolOptions2?.Dispose();
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_protocol_stack_iterate_application_protocols(IntPtr stack, ref BlockLiteral completion);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void IterateProtocols(Action<NWProtocolOptions> callback)
	{
		BlockLiteral completion = default(BlockLiteral);
		completion.SetupBlockUnsafe(static_iterateHandler, callback);
		try
		{
			nw_protocol_stack_iterate_application_protocols(GetCheckedHandle(), ref completion);
		}
		finally
		{
			completion.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_stack_copy_transport_protocol(IntPtr stack);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_protocol_stack_set_transport_protocol(IntPtr stack, IntPtr value);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_protocol_stack_copy_internet_protocol(IntPtr stack);
}
