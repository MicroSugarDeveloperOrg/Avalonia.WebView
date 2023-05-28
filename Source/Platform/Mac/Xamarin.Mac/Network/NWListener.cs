using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWListener : NativeObject
{
	private delegate void nw_listener_state_changed_handler_t(IntPtr block, NWListenerState state, IntPtr nwerror);

	private delegate void nw_listener_new_connection_handler_t(IntPtr block, IntPtr connection);

	private delegate void nw_listener_advertised_endpoint_changed_handler_t(IntPtr block, IntPtr endpoint, byte added);

	public delegate void AdvertisedEndpointChanged(NWEndpoint endpoint, bool added);

	private bool connectionHandlerWasSet = false;

	private object connectionHandlerLock = new object();

	private static nw_listener_state_changed_handler_t static_ListenerStateChanged = TrampolineListenerStateChanged;

	private static nw_listener_new_connection_handler_t static_NewConnection = TrampolineNewConnection;

	private static nw_listener_advertised_endpoint_changed_handler_t static_AdvertisedEndpointChangedHandler = TrampolineAdvertisedEndpointChangedHandler;

	public ushort Port => nw_listener_get_port(GetCheckedHandle());

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public uint ConnectionLimit
	{
		get
		{
			return nw_listener_get_new_connection_limit(GetCheckedHandle());
		}
		set
		{
			nw_listener_set_new_connection_limit(GetCheckedHandle(), value);
		}
	}

	public NWListener(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_listener_create_with_port(string port, IntPtr nwparameters);

	public static NWListener Create(string port, NWParameters parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		IntPtr intPtr = nw_listener_create_with_port(port, parameters.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWListener(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_listener_create(IntPtr nwparameters);

	public static NWListener Create(NWParameters parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		IntPtr intPtr = nw_listener_create(parameters.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWListener(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_listener_create_with_connection(IntPtr nwconnection, IntPtr nwparameters);

	public static NWListener Create(NWConnection connection, NWParameters parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		IntPtr intPtr = nw_listener_create_with_connection(connection.Handle, parameters.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWListener(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_listener_set_queue(IntPtr listener, IntPtr queue);

	public void SetQueue(DispatchQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		nw_listener_set_queue(GetCheckedHandle(), queue.Handle);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ushort nw_listener_get_port(IntPtr listener);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_listener_start(IntPtr handle);

	public void Start()
	{
		lock (connectionHandlerLock)
		{
			if (!connectionHandlerWasSet)
			{
				throw new InvalidOperationException("A connection handler should be set before starting a NWListener.");
			}
			nw_listener_start(GetCheckedHandle());
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_listener_cancel(IntPtr handle);

	public void Cancel()
	{
		nw_listener_cancel(GetCheckedHandle());
	}

	[MonoPInvokeCallback(typeof(nw_listener_state_changed_handler_t))]
	private static void TrampolineListenerStateChanged(IntPtr block, NWListenerState state, IntPtr nwerror)
	{
		Action<NWListenerState, NWError> target = BlockLiteral.GetTarget<Action<NWListenerState, NWError>>(block);
		if (target != null)
		{
			NWError nWError = ((nwerror == IntPtr.Zero) ? null : new NWError(nwerror, owns: false));
			target(state, nWError);
			nWError?.Dispose();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_listener_set_state_changed_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetStateChangedHandler(Action<NWListenerState, NWError> callback)
	{
		if (callback == null)
		{
			nw_listener_set_state_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_ListenerStateChanged, callback);
		try
		{
			nw_listener_set_state_changed_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[MonoPInvokeCallback(typeof(nw_listener_new_connection_handler_t))]
	private static void TrampolineNewConnection(IntPtr block, IntPtr connection)
	{
		Action<NWConnection> target = BlockLiteral.GetTarget<Action<NWConnection>>(block);
		if (target != null)
		{
			NWConnection obj = new NWConnection(connection, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_listener_set_new_connection_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetNewConnectionHandler(Action<NWConnection> callback)
	{
		lock (connectionHandlerLock)
		{
			if (callback == null)
			{
				nw_listener_set_new_connection_handler(GetCheckedHandle(), null);
				return;
			}
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* callback2 = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(static_NewConnection, callback);
			try
			{
				nw_listener_set_new_connection_handler(GetCheckedHandle(), callback2);
				connectionHandlerWasSet = true;
			}
			finally
			{
				blockLiteral.CleanupBlock();
			}
		}
	}

	[MonoPInvokeCallback(typeof(nw_listener_advertised_endpoint_changed_handler_t))]
	private static void TrampolineAdvertisedEndpointChangedHandler(IntPtr block, IntPtr endpoint, byte added)
	{
		AdvertisedEndpointChanged target = BlockLiteral.GetTarget<AdvertisedEndpointChanged>(block);
		if (target != null)
		{
			NWEndpoint nWEndpoint = new NWEndpoint(endpoint, owns: false);
			target(nWEndpoint, (added != 0) ? true : false);
			nWEndpoint.Dispose();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_listener_set_advertised_endpoint_changed_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetAdvertisedEndpointChangedHandler(AdvertisedEndpointChanged callback)
	{
		if (callback == null)
		{
			nw_listener_set_advertised_endpoint_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_AdvertisedEndpointChangedHandler, callback);
		try
		{
			nw_listener_set_advertised_endpoint_changed_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_listener_set_advertise_descriptor(IntPtr handle, IntPtr advertiseDescriptor);

	public void SetAdvertiseDescriptor(NWAdvertiseDescriptor descriptor)
	{
		nw_listener_set_advertise_descriptor(GetCheckedHandle(), descriptor.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern uint nw_listener_get_new_connection_limit(IntPtr listener);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern void nw_listener_set_new_connection_limit(IntPtr listener, uint new_connection_limit);
}
