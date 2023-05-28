using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWConnection : NativeObject
{
	private delegate void StateChangeCallback(IntPtr block, NWConnectionState state, IntPtr error);

	private delegate void nw_connection_boolean_event_handler_t(IntPtr block, [MarshalAs(UnmanagedType.U1)] bool value);

	private delegate void nw_connection_path_event_handler_t(IntPtr block, IntPtr path);

	private delegate void nw_connection_receive_completion_t(IntPtr block, IntPtr dispatchData, IntPtr contentContext, [MarshalAs(UnmanagedType.U1)] bool isComplete, IntPtr error);

	private delegate void nw_connection_send_completion_t(IntPtr block, IntPtr error);

	private delegate void nw_establishment_report_access_block_t(IntPtr block, IntPtr report);

	private static StateChangeCallback static_stateChangeHandler = Trampoline_StateChangeCallback;

	private static nw_connection_boolean_event_handler_t static_BooleanChangeHandler = TrampolineBooleanChangeHandler;

	private static nw_connection_path_event_handler_t static_PathChanged = TrampolinePathChanged;

	private static nw_connection_receive_completion_t static_ReceiveCompletion = TrampolineReceiveCompletion;

	private static nw_connection_receive_completion_t static_ReceiveCompletionDispatchData = TrampolineReceiveCompletionData;

	private static nw_connection_receive_completion_t static_ReceiveCompletionDispatchReadnOnlyData = TrampolineReceiveCompletionReadOnlyData;

	private static nw_connection_send_completion_t static_SendCompletion = TrampolineSendCompletion;

	private static nw_establishment_report_access_block_t static_GetEstablishmentReportHandler = TrampolineGetEstablishmentReportHandler;

	public NWEndpoint Endpoint
	{
		get
		{
			IntPtr intPtr = nw_connection_copy_endpoint(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWEndpoint(intPtr, owns: true);
		}
	}

	public NWParameters Parameters
	{
		get
		{
			IntPtr intPtr = nw_connection_copy_parameters(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWParameters(intPtr, owns: true);
		}
	}

	public string Description => nw_connection_copy_description(GetCheckedHandle());

	public NWPath CurrentPath
	{
		get
		{
			IntPtr intPtr = nw_connection_copy_current_path(GetCheckedHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new NWPath(intPtr, owns: true);
		}
	}

	public uint MaximumDatagramSize => nw_connection_get_maximum_datagram_size(GetCheckedHandle());

	public NWConnection(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_create(IntPtr endpoint, IntPtr parameters);

	public NWConnection(NWEndpoint endpoint, NWParameters parameters)
	{
		if (endpoint == null)
		{
			throw new ArgumentNullException("endpoint");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		InitializeHandle(nw_connection_create(endpoint.Handle, parameters.Handle));
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_copy_endpoint(IntPtr connection);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_copy_parameters(IntPtr connection);

	[MonoPInvokeCallback(typeof(StateChangeCallback))]
	private static void Trampoline_StateChangeCallback(IntPtr block, NWConnectionState state, IntPtr error)
	{
		Action<NWConnectionState, NWError> target = BlockLiteral.GetTarget<Action<NWConnectionState, NWError>>(block);
		if (target != null)
		{
			NWError arg = ((error != IntPtr.Zero) ? new NWError(error, owns: false) : null);
			target(state, arg);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_connection_set_state_changed_handler(IntPtr connection, void* handler);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetStateChangeHandler(Action<NWConnectionState, NWError> stateHandler)
	{
		if (stateHandler == null)
		{
			nw_connection_set_state_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* handler = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_stateChangeHandler, stateHandler);
		try
		{
			nw_connection_set_state_changed_handler(GetCheckedHandle(), handler);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(nw_connection_boolean_event_handler_t))]
	private static void TrampolineBooleanChangeHandler(IntPtr block, bool value)
	{
		BlockLiteral.GetTarget<Action<bool>>(block)?.Invoke(value);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_connection_set_viability_changed_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetBooleanChangeHandler(Action<bool> callback)
	{
		if (callback == null)
		{
			nw_connection_set_viability_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_BooleanChangeHandler, callback);
		try
		{
			nw_connection_set_viability_changed_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_connection_set_better_path_available_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetBetterPathAvailableHandler(Action<bool> callback)
	{
		if (callback == null)
		{
			nw_connection_set_better_path_available_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_BooleanChangeHandler, callback);
		try
		{
			nw_connection_set_better_path_available_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(nw_connection_path_event_handler_t))]
	private static void TrampolinePathChanged(IntPtr block, IntPtr path)
	{
		Action<NWPath> target = BlockLiteral.GetTarget<Action<NWPath>>(block);
		if (target != null)
		{
			NWPath obj = new NWPath(path, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_set_path_changed_handler(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void SetPathChangedHandler(Action<NWPath> callback)
	{
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_PathChanged, callback);
		try
		{
			nw_connection_set_path_changed_handler(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_set_queue(IntPtr handle, IntPtr queue);

	public void SetQueue(DispatchQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		nw_connection_set_queue(GetCheckedHandle(), queue.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_start(IntPtr handle);

	public void Start()
	{
		nw_connection_start(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_restart(IntPtr handle);

	public void Restart()
	{
		nw_connection_restart(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_cancel(IntPtr handle);

	public void Cancel()
	{
		nw_connection_cancel(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_force_cancel(IntPtr handle);

	public void ForceCancel()
	{
		nw_connection_force_cancel(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_cancel_current_endpoint(IntPtr handle);

	public void CancelCurrentEndpoint()
	{
		nw_connection_cancel_current_endpoint(GetCheckedHandle());
	}

	[MonoPInvokeCallback(typeof(nw_connection_receive_completion_t))]
	private static void TrampolineReceiveCompletion(IntPtr block, IntPtr dispatchDataPtr, IntPtr contentContext, bool isComplete, IntPtr error)
	{
		NWConnectionReceiveCompletion target = BlockLiteral.GetTarget<NWConnectionReceiveCompletion>(block);
		if (target != null)
		{
			DispatchData dispatchData = null;
			DispatchData dispatchData2 = null;
			IntPtr bufferPtr = IntPtr.Zero;
			nuint size = (byte)0;
			if (dispatchDataPtr != IntPtr.Zero)
			{
				dispatchData = new DispatchData(dispatchDataPtr, owns: false);
				dispatchData2 = dispatchData.CreateMap(out bufferPtr, out size);
			}
			target(bufferPtr, size, (contentContext == IntPtr.Zero) ? null : new NWContentContext(contentContext, owns: false), isComplete, (error == IntPtr.Zero) ? null : new NWError(error, owns: false));
			if (dispatchData != null)
			{
				dispatchData2.Dispose();
				dispatchData.Dispose();
			}
		}
	}

	[MonoPInvokeCallback(typeof(nw_connection_receive_completion_t))]
	private static void TrampolineReceiveCompletionData(IntPtr block, IntPtr dispatchDataPtr, IntPtr contentContext, bool isComplete, IntPtr error)
	{
		NWConnectionReceiveDispatchDataCompletion target = BlockLiteral.GetTarget<NWConnectionReceiveDispatchDataCompletion>(block);
		if (target != null)
		{
			DispatchData dispatchData = null;
			IntPtr zero = IntPtr.Zero;
			if (dispatchDataPtr != IntPtr.Zero)
			{
				dispatchData = new DispatchData(dispatchDataPtr, owns: false);
			}
			target(dispatchData, (contentContext == IntPtr.Zero) ? null : new NWContentContext(contentContext, owns: false), isComplete, (error == IntPtr.Zero) ? null : new NWError(error, owns: false));
			if (dispatchData != null)
			{
				dispatchData.Dispose();
			}
		}
	}

	[MonoPInvokeCallback(typeof(nw_connection_receive_completion_t))]
	private static void TrampolineReceiveCompletionReadOnlyData(IntPtr block, IntPtr dispatchDataPtr, IntPtr contentContext, bool isComplete, IntPtr error)
	{
        var del = BlockLiteral.GetTarget<NWConnectionReceiveReadOnlySpanCompletion>(block);
        if (del is not null)
        {
            var dispatchData = (dispatchDataPtr != IntPtr.Zero) ? new DispatchData(dispatchDataPtr, owns: false) : null;

            var spanData = new ReadOnlySpan<byte>(dispatchData?.ToArray() ?? Array.Empty<byte>());
            del(spanData,
                contentContext == IntPtr.Zero ? null : new NWContentContext(contentContext, owns: false),
                isComplete,
                error == IntPtr.Zero ? null : new NWError(error, owns: false));

            if (dispatchData is not null)
            {
                dispatchData.Dispose();
            }
        }
    }

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_receive(IntPtr handle, uint minimumIncompleteLength, uint maximumLength, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void Receive(uint minimumIncompleteLength, uint maximumLength, NWConnectionReceiveCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletion, callback);
		try
		{
			nw_connection_receive(GetCheckedHandle(), minimumIncompleteLength, maximumLength, ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void ReceiveData(uint minimumIncompleteLength, uint maximumLength, NWConnectionReceiveDispatchDataCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletionDispatchData, callback);
		try
		{
			nw_connection_receive(GetCheckedHandle(), minimumIncompleteLength, maximumLength, ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void ReceiveReadOnlyData(uint minimumIncompleteLength, uint maximumLength, NWConnectionReceiveReadOnlySpanCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletionDispatchReadnOnlyData, callback);
		try
		{
			nw_connection_receive(GetCheckedHandle(), minimumIncompleteLength, maximumLength, ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_receive_message(IntPtr handle, ref BlockLiteral callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void ReceiveMessage(NWConnectionReceiveCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletion, callback);
		try
		{
			nw_connection_receive_message(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void ReceiveMessageData(NWConnectionReceiveDispatchDataCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletionDispatchData, callback);
		try
		{
			nw_connection_receive_message(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void ReceiveMessageReadOnlyData(NWConnectionReceiveReadOnlySpanCompletion callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral callback2 = default(BlockLiteral);
		callback2.SetupBlockUnsafe(static_ReceiveCompletionDispatchReadnOnlyData, callback);
		try
		{
			nw_connection_receive_message(GetCheckedHandle(), ref callback2);
		}
		finally
		{
			callback2.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(nw_connection_send_completion_t))]
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

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_connection_send(IntPtr handle, IntPtr dispatchData, IntPtr contentContext, [MarshalAs(UnmanagedType.U1)] bool isComplete, void* callback);

	private unsafe void LowLevelSend(IntPtr handle, DispatchData buffer, IntPtr contentContext, bool isComplete, void* callback)
	{
		nw_connection_send(GetCheckedHandle(), buffer.GetHandle(), contentContext, isComplete, callback);
	}

	public void Send(byte[] buffer, NWContentContext context, bool isComplete, Action<NWError> callback)
	{
		DispatchData buffer2 = null;
		if (buffer != null)
		{
			buffer2 = DispatchData.FromByteBuffer(buffer);
		}
		Send(buffer2, context, isComplete, callback);
	}

	public void Send(byte[] buffer, int start, int length, NWContentContext context, bool isComplete, Action<NWError> callback)
	{
		DispatchData buffer2 = null;
		if (buffer != null)
		{
			buffer2 = DispatchData.FromByteBuffer(buffer, start, length);
		}
		Send(buffer2, context, isComplete, callback);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void Send(DispatchData buffer, NWContentContext context, bool isComplete, Action<NWError> callback)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_SendCompletion, callback);
		try
		{
			LowLevelSend(GetCheckedHandle(), buffer, context.Handle, isComplete, callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	public unsafe void SendIdempotent(DispatchData buffer, NWContentContext context, bool isComplete)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		LowLevelSend(GetCheckedHandle(), buffer, context.Handle, isComplete, (void*)NWConnectionConstants._SendIdempotentContent);
	}

	public void SendIdempotent(byte[] buffer, NWContentContext context, bool isComplete)
	{
		DispatchData dispatchData = null;
		if (buffer != null)
		{
			dispatchData = DispatchData.FromByteBuffer(buffer);
		}
		SendIdempotent(buffer, context, isComplete);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern string nw_connection_copy_description(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_copy_current_path(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_connection_copy_protocol_metadata(IntPtr handle, IntPtr protocolDefinition);

	public NWProtocolMetadata GetProtocolMetadata(NWProtocolDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition");
		}
		IntPtr intPtr = nw_connection_copy_protocol_metadata(GetCheckedHandle(), definition.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWProtocolMetadata(intPtr, owns: true);
	}

	public T GetProtocolMetadata<T>(NWProtocolDefinition definition) where T : NWProtocolMetadata
	{
		if (definition == null)
		{
			throw new ArgumentNullException("definition");
		}
		IntPtr ptr = nw_connection_copy_protocol_metadata(GetCheckedHandle(), definition.Handle);
		return Runtime.GetINativeObject<T>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern uint nw_connection_get_maximum_datagram_size(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_connection_batch(IntPtr handle, IntPtr callback_block);

	public void Batch(Action method)
	{
		BlockLiteral.SimpleCall(method, delegate(IntPtr arg)
		{
			nw_connection_batch(GetCheckedHandle(), arg);
		});
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void nw_connection_access_establishment_report(IntPtr connection, IntPtr queue, ref BlockLiteral access_block);

	[MonoPInvokeCallback(typeof(nw_establishment_report_access_block_t))]
	private static void TrampolineGetEstablishmentReportHandler(IntPtr block, IntPtr report)
	{
		Action<NWEstablishmentReport> target = BlockLiteral.GetTarget<Action<NWEstablishmentReport>>(block);
		if (target != null)
		{
			NWEstablishmentReport obj = new NWEstablishmentReport(report, owns: true);
			target(obj);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public void GetEstablishmentReport(DispatchQueue queue, Action<NWEstablishmentReport> handler)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral access_block = default(BlockLiteral);
		access_block.SetupBlockUnsafe(static_GetEstablishmentReportHandler, handler);
		try
		{
			nw_connection_access_establishment_report(GetCheckedHandle(), queue.Handle, ref access_block);
		}
		finally
		{
			access_block.CleanupBlock();
		}
	}
}
