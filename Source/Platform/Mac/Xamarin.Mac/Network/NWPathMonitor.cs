using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWPathMonitor : NativeObject
{
	private delegate void nw_path_monitor_update_handler_t(IntPtr block, IntPtr path);

	private delegate void nw_path_monitor_cancel_handler_t(IntPtr block);

	private NWPath currentPath;

	private static nw_path_monitor_update_handler_t static_UpdateSnapshot = TrampolineUpdatedSnapshot;

	private Action<NWPath> userSnapshotHandler;

	private static nw_path_monitor_cancel_handler_t static_MonitorCanceled = TrampolineMonitorCanceled;

	public NWPath CurrentPath => currentPath;

	public Action<NWPath> SnapshotHandler
	{
		get
		{
			return userSnapshotHandler;
		}
		set
		{
			userSnapshotHandler = value;
		}
	}

	public NWPathMonitor(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_path_monitor_create();

	public NWPathMonitor()
	{
		InitializeHandle(nw_path_monitor_create());
		_SetUpdatedSnapshotHandler(SetUpdatedSnapshotHandlerWrapper);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_path_monitor_create_with_type(NWInterfaceType interfaceType);

	public NWPathMonitor(NWInterfaceType interfaceType)
	{
		InitializeHandle(nw_path_monitor_create_with_type(interfaceType));
		_SetUpdatedSnapshotHandler(SetUpdatedSnapshotHandlerWrapper);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_path_monitor_cancel(IntPtr handle);

	public void Cancel()
	{
		nw_path_monitor_cancel(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_path_monitor_start(IntPtr handle);

	public void Start()
	{
		nw_path_monitor_start(GetCheckedHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_path_monitor_set_queue(IntPtr handle, IntPtr queue);

	public void SetQueue(DispatchQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		nw_path_monitor_set_queue(GetCheckedHandle(), queue.Handle);
	}

	[MonoPInvokeCallback(typeof(nw_path_monitor_update_handler_t))]
	private static void TrampolineUpdatedSnapshot(IntPtr block, IntPtr path)
	{
		Action<NWPath> target = BlockLiteral.GetTarget<Action<NWPath>>(block);
		if (target != null)
		{
			NWPath obj = new NWPath(path, owns: false);
			target(obj);
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_path_monitor_set_update_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	private unsafe void _SetUpdatedSnapshotHandler(Action<NWPath> callback)
	{
		if (callback == null)
		{
			nw_path_monitor_set_update_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_UpdateSnapshot, callback);
		try
		{
			nw_path_monitor_set_update_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[Obsolete("Use the 'SnapshotHandler' property instead.")]
	public void SetUpdatedSnapshotHandler(Action<NWPath> callback)
	{
		userSnapshotHandler = callback;
	}

	private void SetUpdatedSnapshotHandlerWrapper(NWPath path)
	{
		currentPath = path;
		if (userSnapshotHandler != null)
		{
			userSnapshotHandler(currentPath);
		}
	}

	[MonoPInvokeCallback(typeof(nw_path_monitor_cancel_handler_t))]
	private static void TrampolineMonitorCanceled(IntPtr block)
	{
		BlockLiteral.GetTarget<Action>(block)?.Invoke();
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_path_monitor_set_cancel_handler(IntPtr handle, void* callback);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public unsafe void SetMonitorCanceledHandler(Action callback)
	{
		if (callback == null)
		{
			nw_path_monitor_set_cancel_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* callback2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_MonitorCanceled, callback);
		try
		{
			nw_path_monitor_set_cancel_handler(GetCheckedHandle(), callback2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}
}
