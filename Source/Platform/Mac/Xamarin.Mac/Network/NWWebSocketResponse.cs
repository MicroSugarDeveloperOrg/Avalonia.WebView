using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWWebSocketResponse : NativeObject
{
	private delegate void nw_ws_response_enumerate_additional_headers_t(IntPtr block, string header, string value);

	private static nw_ws_response_enumerate_additional_headers_t static_EnumerateHeadersHandler = TrampolineEnumerateHeadersHandler;

	public string SelectedSubprotocol => nw_ws_response_get_selected_subprotocol(GetCheckedHandle());

	public NWWebSocketResponseStatus Status => nw_ws_response_get_status(GetCheckedHandle());

	internal NWWebSocketResponse(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr nw_ws_response_create(NWWebSocketResponseStatus status, string selected_subprotocol);

	public NWWebSocketResponse(NWWebSocketResponseStatus status, string subprotocol)
	{
		InitializeHandle(nw_ws_response_create(status, subprotocol));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern string nw_ws_response_get_selected_subprotocol(IntPtr response);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWWebSocketResponseStatus nw_ws_response_get_status(IntPtr response);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_ws_response_enumerate_additional_headers(IntPtr response, ref BlockLiteral enumerator);

	[MonoPInvokeCallback(typeof(nw_ws_response_enumerate_additional_headers_t))]
	private static void TrampolineEnumerateHeadersHandler(IntPtr block, string header, string value)
	{
		BlockLiteral.GetTarget<Action<string, string>>(block)?.Invoke(header, value);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool EnumerateAdditionalHeaders(Action<string, string> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerator = default(BlockLiteral);
		enumerator.SetupBlockUnsafe(static_EnumerateHeadersHandler, handler);
		try
		{
			return nw_ws_response_enumerate_additional_headers(GetCheckedHandle(), ref enumerator);
		}
		finally
		{
			enumerator.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void nw_ws_response_add_additional_header(IntPtr response, string name, string value);

	public void SetHeader(string header, string value)
	{
		nw_ws_response_add_additional_header(GetCheckedHandle(), header, value);
	}
}
