using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWBrowser : NativeObject
{
	private delegate void nw_browser_browse_results_changed_handler_t(IntPtr block, IntPtr oldResult, IntPtr newResult, bool completed);

	private delegate void nw_browser_set_state_changed_handler_t(IntPtr block, NWBrowserState state, IntPtr error);

	private bool started = false;

	private bool queueSet = false;

	private object startLock = new object();

	private static nw_browser_browse_results_changed_handler_t static_ChangesHandler = TrampolineChangesHandler;

	private object changesLock = new object();

	private List<(NWBrowseResult result, NWBrowseResultChange change)> changes = new List<(NWBrowseResult, NWBrowseResultChange)>();

	private static nw_browser_set_state_changed_handler_t static_StateChangesHandler = TrampolineStateChangesHandler;

	public bool IsActive
	{
		get
		{
			lock (startLock)
			{
				return started;
			}
		}
	}

	public NWBrowserDescriptor Descriptor => new NWBrowserDescriptor(nw_browser_copy_browse_descriptor(GetCheckedHandle()), owns: true);

	public NWParameters Parameters => new NWParameters(nw_browser_copy_parameters(GetCheckedHandle()), owns: true);

	public Action<NWBrowseResult, NWBrowseResult> IndividualChangesDelegate { get; set; }

	public NWBrowserCompleteChangesDelegate CompleteChangesDelegate { get; set; }

	internal NWBrowser(IntPtr handle, bool owns)
		: base(handle, owns)
	{
		SetChangesHandler(InternalChangesHandler);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browser_create(IntPtr descriptor, IntPtr parameters);

	public NWBrowser(NWBrowserDescriptor descriptor, NWParameters parameters)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		InitializeHandle(nw_browser_create(descriptor.Handle, parameters.GetHandle()));
		SetChangesHandler(InternalChangesHandler);
	}

	public NWBrowser(NWBrowserDescriptor descriptor)
		: this(descriptor, null)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_browser_set_queue(IntPtr browser, IntPtr queue);

	public void SetDispatchQueue(DispatchQueue queue)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		lock (startLock)
		{
			nw_browser_set_queue(GetCheckedHandle(), queue.Handle);
			queueSet = true;
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_browser_start(IntPtr browser);

	public void Start()
	{
		lock (startLock)
		{
			if (!queueSet)
			{
				throw new InvalidOperationException("Cannot start the browser without a DispatchQueue.");
			}
			nw_browser_start(GetCheckedHandle());
			started = true;
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_browser_cancel(IntPtr browser);

	public void Cancel()
	{
		lock (startLock)
		{
			try
			{
				nw_browser_cancel(GetCheckedHandle());
			}
			finally
			{
				started = false;
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browser_copy_browse_descriptor(IntPtr browser);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browser_copy_parameters(IntPtr browser);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_browser_set_browse_results_changed_handler(IntPtr browser, void* handler);

	[MonoPInvokeCallback(typeof(nw_browser_browse_results_changed_handler_t))]
	private static void TrampolineChangesHandler(IntPtr block, IntPtr oldResult, IntPtr newResult, bool completed)
	{
		NWBrowserChangesDelegate target = BlockLiteral.GetTarget<NWBrowserChangesDelegate>(block);
		if (target != null)
		{
			NWBrowseResult oldResult2 = ((oldResult == IntPtr.Zero) ? null : new NWBrowseResult(oldResult, owns: false));
			NWBrowseResult newResult2 = ((newResult == IntPtr.Zero) ? null : new NWBrowseResult(newResult, owns: false));
			target(oldResult2, newResult2, completed);
		}
	}

	private void InternalChangesHandler(NWBrowseResult oldResult, NWBrowseResult newResult, bool completed)
	{
		IndividualChangesDelegate?.Invoke(oldResult, newResult);
		NWBrowserCompleteChangesDelegate completeChangesDelegate = CompleteChangesDelegate;
		if (completeChangesDelegate == null)
		{
			oldResult?.Dispose();
			newResult?.Dispose();
			return;
		}
		NWBrowseResultChange item = NWBrowseResult.GetChanges(oldResult, newResult);
		(NWBrowseResult, NWBrowseResultChange) item2 = (newResult, item);
		oldResult?.Dispose();
		List<(NWBrowseResult, NWBrowseResultChange)> list = null;
		lock (changesLock)
		{
			changes.Add(item2);
			if (completed)
			{
				list = changes;
				changes = new List<(NWBrowseResult, NWBrowseResultChange)>();
			}
		}
		if (!completed)
		{
			return;
		}
		completeChangesDelegate(list);
		foreach (var item3 in list)
		{
			item3.Item1?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	private unsafe void SetChangesHandler(NWBrowserChangesDelegate handler)
	{
		if (handler == null)
		{
			nw_browser_set_browse_results_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* handler2 = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_ChangesHandler, handler);
		try
		{
			nw_browser_set_browse_results_changed_handler(GetCheckedHandle(), handler2);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}

	[Obsolete("Uset the 'IndividualChangesDelegate' instead.")]
	public void SetChangesHandler(Action<NWBrowseResult, NWBrowseResult> handler)
	{
		IndividualChangesDelegate = handler;
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private unsafe static extern void nw_browser_set_state_changed_handler(IntPtr browser, void* state_changed_handler);

	[MonoPInvokeCallback(typeof(nw_browser_set_state_changed_handler_t))]
	private static void TrampolineStateChangesHandler(IntPtr block, NWBrowserState state, IntPtr error)
	{
		Action<NWBrowserState, NWError> target = BlockLiteral.GetTarget<Action<NWBrowserState, NWError>>(block);
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
			nw_browser_set_state_changed_handler(GetCheckedHandle(), null);
			return;
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* state_changed_handler = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(static_StateChangesHandler, handler);
		try
		{
			nw_browser_set_state_changed_handler(GetCheckedHandle(), state_changed_handler);
		}
		finally
		{
			blockLiteral.CleanupBlock();
		}
	}
}
