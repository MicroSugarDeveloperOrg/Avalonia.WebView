using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWWebSocketMetadata : NWProtocolMetadata
{
	private delegate void nw_ws_metadata_set_pong_handler_t(IntPtr block, IntPtr error);

	private static nw_ws_metadata_set_pong_handler_t static_PongHandler = TrampolinePongHandler;

	public NWWebSocketCloseCode CloseCode
	{
		get
		{
			return nw_ws_metadata_get_close_code(GetCheckedHandle());
		}
		set
		{
			nw_ws_metadata_set_close_code(GetCheckedHandle(), value);
		}
	}

	public NWWebSocketOpCode OpCode => nw_ws_metadata_get_opcode(GetCheckedHandle());

	public NWWebSocketResponse ServerResponse
	{
		get
		{
			IntPtr intPtr = nw_ws_metadata_copy_server_response(GetCheckedHandle());
			return (intPtr == IntPtr.Zero) ? null : new NWWebSocketResponse(intPtr, owns: true);
		}
	}

	internal NWWebSocketMetadata(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_ws_create_metadata(NWWebSocketOpCode opcode);

	public NWWebSocketMetadata(NWWebSocketOpCode opcode)
		: this(nw_ws_create_metadata(opcode), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWWebSocketCloseCode nw_ws_metadata_get_close_code(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_metadata_set_close_code(IntPtr metadata, NWWebSocketCloseCode close_code);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWWebSocketOpCode nw_ws_metadata_get_opcode(IntPtr metadata);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_ws_metadata_set_pong_handler(IntPtr metadata, IntPtr client_queue, ref BlockLiteral pong_handler);

	[MonoPInvokeCallback(typeof(nw_ws_metadata_set_pong_handler_t))]
	private static void TrampolinePongHandler(IntPtr block, IntPtr error)
	{
		Action<NWError> target = BlockLiteral.GetTarget<Action<NWError>>(block);
		if (target != null)
		{
			NWError obj = ((error == IntPtr.Zero) ? null : new NWError(error, owns: false));
			target(obj);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetPongHandler(DispatchQueue queue, Action<NWError> handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral pong_handler = default(BlockLiteral);
		pong_handler.SetupBlockUnsafe(static_PongHandler, handler);
		try
		{
			nw_ws_metadata_set_pong_handler(GetCheckedHandle(), queue.Handle, ref pong_handler);
		}
		finally
		{
			pong_handler.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_ws_metadata_copy_server_response(IntPtr metadata);
}
