using System.Buffers;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWFramer : NativeObject
{
	private delegate void nw_framer_set_wakeup_handler_t(IntPtr block, IntPtr framer);

	private delegate void nw_framer_set_stop_handler_t(IntPtr block, IntPtr framer);

	private delegate void nw_framer_set_output_handler_t(IntPtr block, IntPtr framer, IntPtr message, nuint message_length, bool is_complete);

	private delegate nuint nw_framer_set_input_handler_t(IntPtr block, IntPtr framer);

	private delegate void nw_framer_set_cleanup_handler_t(IntPtr block, IntPtr framer);

	private delegate void nw_framer_async_t(IntPtr block);

	private delegate void nw_framer_parse_output_t(IntPtr block, IntPtr buffer, nuint buffer_length, bool is_complete);

	private delegate nuint nw_framer_parse_input_t(IntPtr block, IntPtr buffer, nuint buffer_length, bool is_complete);

	private static nw_framer_set_wakeup_handler_t static_WakeupHandler = TrampolineWakeupHandler;

	private static nw_framer_set_stop_handler_t static_StopHandler = TrampolineStopHandler;

	private static nw_framer_set_output_handler_t static_OutputHandler = TrampolineOutputHandler;

	private static nw_framer_set_input_handler_t static_InputHandler = TrampolineInputHandler;

	private static nw_framer_set_cleanup_handler_t static_CleanupHandler = TrampolineCleanupHandler;

	private static nw_framer_async_t static_ScheduleHandler = TrampolineScheduleHandler;

	private static nw_framer_parse_output_t static_ParseOutputHandler = TrampolineParseOutputHandler;

	private static nw_framer_parse_input_t static_ParseInputHandler = TrampolineParseInputHandler;

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe Action<NWFramer> WakeupHandler
	{
		set
		{
			if (value == null)
			{
				nw_framer_set_wakeup_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* wakeup_handler = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_WakeupHandler, value);
			try
			{
				nw_framer_set_wakeup_handler(GetCheckedHandle(), wakeup_handler);
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe Action<NWFramer> StopHandler
	{
		set
		{
			if (value == null)
			{
				nw_framer_set_stop_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* stop_handler = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_StopHandler, value);
			try
			{
				nw_framer_set_stop_handler(GetCheckedHandle(), stop_handler);
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe Action<NWFramer, NWFramerMessage, nuint, bool> OutputHandler
	{
		set
		{
			if (value == null)
			{
				nw_framer_set_output_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* output_handler = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_OutputHandler, value);
			try
			{
				nw_framer_set_output_handler(GetCheckedHandle(), output_handler);
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe NWFramerInputDelegate InputHandler
	{
		set
		{
			if (value == null)
			{
				nw_framer_set_input_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* input_handler = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_InputHandler, value);
			try
			{
				nw_framer_set_input_handler(GetCheckedHandle(), input_handler);
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe Action<NWFramer> CleanupHandler
	{
		set
		{
			if (value == null)
			{
				nw_framer_set_cleanup_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* cleanup_handler = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_InputHandler, value);
			try
			{
				nw_framer_set_cleanup_handler(GetCheckedHandle(), cleanup_handler);
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	public NWEndpoint Endpoint => new NWEndpoint(nw_framer_copy_remote_endpoint(GetCheckedHandle()), owns: true);

	public NWParameters Parameters => new NWParameters(nw_framer_copy_parameters(GetCheckedHandle()), owns: true);

	public NWEndpoint LocalEndpoint => new NWEndpoint(nw_framer_copy_local_endpoint(GetCheckedHandle()), owns: true);

	internal NWFramer(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_framer_write_output_no_copy(IntPtr framer, nuint output_length);

	public bool WriteOutputNoCopy(nuint outputLength)
	{
		return nw_framer_write_output_no_copy(GetCheckedHandle(), outputLength);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_write_output_data(IntPtr framer, IntPtr output_data);

	public void WriteOutput(DispatchData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		nw_framer_write_output_data(GetCheckedHandle(), data.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_write_output(IntPtr framer, byte* output_buffer, nuint output_length);

	public unsafe void WriteOutput(ReadOnlySpan<byte> data)
	{
        fixed (byte* output_buffer = data)
		{
			nw_framer_write_output(GetCheckedHandle(), output_buffer, (nuint)data.Length);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_set_wakeup_handler(IntPtr framer, void* wakeup_handler);

	[MonoPInvokeCallback(typeof(nw_framer_set_wakeup_handler_t))]
	private static void TrampolineWakeupHandler(IntPtr block, IntPtr framer)
	{
		Action<NWFramer> target = BlockLiteral.GetTarget<Action<NWFramer>>(block);
		if (target != null)
		{
			NWFramer obj = new NWFramer(framer, owns: true);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_set_stop_handler(IntPtr framer, void* stop_handler);

	[MonoPInvokeCallback(typeof(nw_framer_set_stop_handler_t))]
	private static void TrampolineStopHandler(IntPtr block, IntPtr framer)
	{
		Action<NWFramer> target = BlockLiteral.GetTarget<Action<NWFramer>>(block);
		if (target != null)
		{
			NWFramer obj = new NWFramer(framer, owns: true);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_set_output_handler(IntPtr framer, void* output_handler);

	[MonoPInvokeCallback(typeof(nw_framer_set_output_handler_t))]
	private static void TrampolineOutputHandler(IntPtr block, IntPtr framer, IntPtr message, nuint message_length, bool is_complete)
	{
		Action<NWFramer, NWProtocolMetadata, nuint, bool> target = BlockLiteral.GetTarget<Action<NWFramer, NWProtocolMetadata, nuint, bool>>(block);
		if (target != null)
		{
			NWFramer arg = new NWFramer(framer, owns: true);
			NWFramerMessage arg2 = new NWFramerMessage(message, owns: true);
			target(arg, arg2, message_length, is_complete);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_set_input_handler(IntPtr framer, void* input_handler);

	[MonoPInvokeCallback(typeof(nw_framer_set_input_handler_t))]
	private static nuint TrampolineInputHandler(IntPtr block, IntPtr framer)
	{
		NWFramerInputDelegate target = BlockLiteral.GetTarget<NWFramerInputDelegate>(block);
		if (target != null)
		{
			NWFramer framer2 = new NWFramer(framer, owns: true);
			return target(framer2);
		}
		return (byte)0;
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_set_cleanup_handler(IntPtr framer, void* cleanup_handler);

	[MonoPInvokeCallback(typeof(nw_framer_set_cleanup_handler_t))]
	private static void TrampolineCleanupHandler(IntPtr block, IntPtr framer)
	{
		Action<NWFramer> target = BlockLiteral.GetTarget<Action<NWFramer>>(block);
		if (target != null)
		{
			NWFramer obj = new NWFramer(framer, owns: true);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_schedule_wakeup(IntPtr framer, ulong milliseconds);

	public void ScheduleWakeup(ulong milliseconds)
	{
		nw_framer_schedule_wakeup(GetCheckedHandle(), milliseconds);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_message_create(IntPtr framer);

	public NWFramerMessage CreateMessage()
	{
		return new NWFramerMessage(nw_framer_message_create(GetCheckedHandle()), owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_framer_prepend_application_protocol(IntPtr framer, IntPtr protocol_options);

	public bool PrependApplicationProtocol(NWProtocolOptions options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		return nw_framer_prepend_application_protocol(GetCheckedHandle(), options.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_pass_through_output(IntPtr framer);

	public void PassThroughOutput()
	{
		nw_framer_pass_through_output(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_pass_through_input(IntPtr framer);

	public void PassThroughInput()
	{
		nw_framer_pass_through_input(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_mark_ready(IntPtr framer);

	public void MarkReady()
	{
		nw_framer_mark_ready(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_framer_mark_failed_with_error(IntPtr framer, int error_code);

	public void MarkFailedWithError(int errorCode)
	{
		nw_framer_mark_failed_with_error(GetCheckedHandle(), errorCode);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_framer_deliver_input_no_copy(IntPtr framer, nuint input_length, IntPtr message, bool is_complete);

	public bool DeliverInputNoCopy(nuint length, NWFramerMessage message, bool isComplete)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		return nw_framer_deliver_input_no_copy(GetCheckedHandle(), length, message.Handle, isComplete);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_create_options(IntPtr framer_definition);

	public static T CreateOptions<T>(NWProtocolDefinition protocolDefinition) where T : NWProtocolOptions
	{
		if (protocolDefinition == null)
		{
			throw new ArgumentNullException("protocolDefinition");
		}
		IntPtr ptr = nw_framer_create_options(protocolDefinition.Handle);
		return Runtime.GetINativeObject<T>(ptr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_copy_remote_endpoint(IntPtr framer);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_copy_parameters(IntPtr framer);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_framer_copy_local_endpoint(IntPtr framer);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_async(IntPtr framer, void* async_block);

	[MonoPInvokeCallback(typeof(nw_framer_async_t))]
	private static void TrampolineScheduleHandler(IntPtr block)
	{
		BlockLiteral.GetTarget<Action>(block)?.Invoke();
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void ScheduleAsync(Action handler)
	{
		if (handler == null)
		{
			nw_framer_async(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* async_block = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_ScheduleHandler, handler);
		try
		{
			nw_framer_async(GetCheckedHandle(), async_block);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern bool nw_framer_parse_output(IntPtr framer, nuint minimum_incomplete_length, nuint maximum_length, byte* temp_buffer, ref BlockLiteral parse);

	[MonoPInvokeCallback(typeof(nw_framer_parse_output_t))]
	private static void TrampolineParseOutputHandler(IntPtr block, IntPtr buffer, nuint buffer_length, bool is_complete)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Action<Memory<byte>, bool> target = BlockLiteral.GetTarget<Action<Memory<byte>, bool>>(block);
		if (target != null)
		{
			byte[] array = new byte[(ulong)buffer_length];
			Marshal.Copy(buffer, array, 0, (int)buffer_length);
			Memory<byte> arg = default(Memory<byte>);
			arg = new Memory<byte>(array);
			target(arg, is_complete);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe bool ParseOutput(nuint minimumIncompleteLength, nuint maximumLength, Memory<byte> tempBuffer, Action<Memory<byte>, bool> handler)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral parse = default(BlockLiteral);
		parse.SetupBlockUnsafe(static_ParseOutputHandler, handler);
		try
		{
			MemoryHandle val = tempBuffer.Pin();
			try
			{
				return nw_framer_parse_output(GetCheckedHandle(), minimumIncompleteLength, maximumLength, (byte*)val.Pointer, ref parse);
			}
			finally
			{
                val.Dispose();
			}
		}
		finally
		{
			parse.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern bool nw_framer_parse_input(IntPtr framer, nuint minimum_incomplete_length, nuint maximum_length, byte* temp_buffer, ref BlockLiteral parse);

	[MonoPInvokeCallback(typeof(nw_framer_parse_input_t))]
	private static nuint TrampolineParseInputHandler(IntPtr block, IntPtr buffer, nuint buffer_length, bool is_complete)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		NWFramerParseCompletionDelegate target = BlockLiteral.GetTarget<NWFramerParseCompletionDelegate>(block);
		if (target != null)
		{
			byte[] array = new byte[(ulong)buffer_length];
			Marshal.Copy(buffer, array, 0, (int)buffer_length);
			Memory<byte> buffer2 = default(Memory<byte>);
			buffer2 = new Memory<byte>(array);
			return target(buffer2, is_complete);
		}
		return (byte)0;
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe bool ParseInput(nuint minimumIncompleteLength, nuint maximumLength, Memory<byte> tempBuffer, NWFramerParseCompletionDelegate handler)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral parse = default(BlockLiteral);
		parse.SetupBlockUnsafe(static_ParseInputHandler, handler);
		try
		{
			MemoryHandle val = tempBuffer.Pin();
			try
			{
				return nw_framer_parse_input(GetCheckedHandle(), minimumIncompleteLength, maximumLength, (byte*)val.Pointer, ref parse);
			}
			finally
			{
                val.Dispose();
			}
		}
		finally
		{
			parse.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_framer_deliver_input(IntPtr framer, byte* input_buffer, nuint input_length, IntPtr message, bool is_complete);

	public unsafe void DeliverInput(ReadOnlySpan<byte> buffer, NWFramerMessage message, bool isComplete)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		fixed (byte* input_buffer = buffer)
		{
			nw_framer_deliver_input(GetCheckedHandle(), input_buffer, (nuint)buffer.Length, message.Handle, isComplete);
		}
	}
}
