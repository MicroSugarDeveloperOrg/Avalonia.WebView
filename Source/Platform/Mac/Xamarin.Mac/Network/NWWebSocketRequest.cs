using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWWebSocketRequest : NativeObject
{
	private delegate void nw_ws_request_enumerate_additional_headers_t(IntPtr block, string header, string value);

	private delegate void nw_ws_request_enumerate_subprotocols_t(IntPtr block, string subprotocol);

	private static nw_ws_request_enumerate_additional_headers_t static_EnumerateHeaderHandler = TrampolineEnumerateHeaderHandler;

	private static nw_ws_request_enumerate_subprotocols_t static_EnumerateSubprotocolHandler = TrampolineEnumerateSubprotocolHandler;

	internal NWWebSocketRequest(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_ws_request_enumerate_additional_headers(IntPtr request, ref BlockLiteral enumerator);

	[MonoPInvokeCallback(typeof(nw_ws_request_enumerate_additional_headers_t))]
	private static void TrampolineEnumerateHeaderHandler(IntPtr block, string header, string value)
	{
		BlockLiteral.GetTarget<Action<string, string>>(block)?.Invoke(header, value);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateAdditionalHeaders(Action<string, string> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerator = default(BlockLiteral);
		enumerator.SetupBlockUnsafe(static_EnumerateHeaderHandler, handler);
		try
		{
			nw_ws_request_enumerate_additional_headers(GetCheckedHandle(), ref enumerator);
		}
		finally
		{
			enumerator.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_ws_request_enumerate_subprotocols(IntPtr request, ref BlockLiteral enumerator);

	[MonoPInvokeCallback(typeof(nw_ws_request_enumerate_subprotocols_t))]
	private static void TrampolineEnumerateSubprotocolHandler(IntPtr block, string subprotocol)
	{
		BlockLiteral.GetTarget<Action<string>>(block)?.Invoke(subprotocol);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateSubprotocols(Action<string> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerator = default(BlockLiteral);
		enumerator.SetupBlockUnsafe(static_EnumerateSubprotocolHandler, handler);
		try
		{
			nw_ws_request_enumerate_subprotocols(GetCheckedHandle(), ref enumerator);
		}
		finally
		{
			enumerator.CleanupBlock();
		}
	}
}
