using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWWebSocketOptions : NWProtocolOptions
{
	private delegate void nw_ws_options_set_client_request_handler_t(IntPtr block, IntPtr request);

	private bool autoReplyPing = false;

	private bool skipHandShake = false;

	private nuint maximumMessageSize = (nuint)0;

	private static nw_ws_options_set_client_request_handler_t static_ClientRequestHandler = TrampolineClientRequestHandler;

	public bool AutoReplyPing
	{
		get
		{
			return autoReplyPing;
		}
		set
		{
			autoReplyPing = value;
			nw_ws_options_set_auto_reply_ping(GetCheckedHandle(), value);
		}
	}

	public nuint MaximumMessageSize
	{
		get
		{
			return maximumMessageSize;
		}
		set
		{
			maximumMessageSize = value;
			nw_ws_options_set_maximum_message_size(GetCheckedHandle(), value);
		}
	}

	public bool SkipHandShake
	{
		get
		{
			return skipHandShake;
		}
		set
		{
			skipHandShake = value;
			nw_ws_options_set_skip_handshake(GetCheckedHandle(), value);
		}
	}

	internal NWWebSocketOptions(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_ws_create_options(NWWebSocketVersion version);

	public NWWebSocketOptions(NWWebSocketVersion version)
		: base(nw_ws_create_options(version), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void nw_ws_options_add_additional_header(IntPtr options, string name, string value);

	public void SetHeader(string header, string value)
	{
		if (header == null)
		{
			throw new ArgumentNullException(header);
		}
		nw_ws_options_add_additional_header(GetCheckedHandle(), header, value);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void nw_ws_options_add_subprotocol(IntPtr options, string subprotocol);

	public void AddSubprotocol(string subprotocol)
	{
		if (subprotocol == null)
		{
			throw new ArgumentNullException("subprotocol");
		}
		nw_ws_options_add_subprotocol(GetCheckedHandle(), subprotocol);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_options_set_auto_reply_ping(IntPtr options, bool auto_reply_ping);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_options_set_maximum_message_size(IntPtr options, nuint maximum_message_size);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_options_set_skip_handshake(IntPtr options, bool skip_handshake);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_options_set_client_request_handler(IntPtr options, IntPtr client_queue, ref BlockLiteral handler);

	[MonoPInvokeCallback(typeof(nw_ws_options_set_client_request_handler_t))]
	private static void TrampolineClientRequestHandler(IntPtr block, IntPtr request)
	{
		Action<NWWebSocketRequest> target = BlockLiteral.GetTarget<Action<NWWebSocketRequest>>(block);
		if (target != null)
		{
			NWWebSocketRequest obj = new NWWebSocketRequest(request, owns: true);
			target(obj);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetClientRequestHandler(DispatchQueue queue, Action<NWWebSocketRequest> handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral handler2 = default(BlockLiteral);
		handler2.SetupBlockUnsafe(static_ClientRequestHandler, handler);
		try
		{
			nw_ws_options_set_client_request_handler(GetCheckedHandle(), queue.Handle, ref handler2);
		}
		finally
		{
			handler2.CleanupBlock();
		}
	}
}
