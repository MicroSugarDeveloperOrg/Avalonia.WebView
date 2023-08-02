using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

public abstract class CFRunLoopSourceCustom : CFRunLoopSource
{
	private delegate void ScheduleCallback(IntPtr info, IntPtr runLoop, IntPtr mode);

	private delegate void CancelCallback(IntPtr info, IntPtr runLoop, IntPtr mode);

	private delegate void PerformCallback(IntPtr info);

	private GCHandle gch;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFRunLoopSourceCreate(IntPtr allocator, int order, IntPtr context);

	protected CFRunLoopSourceCustom()
		: base(IntPtr.Zero, ownsHandle: true)
	{
		gch = GCHandle.Alloc(this);
		CFRunLoopSourceContext structure = new CFRunLoopSourceContext
		{
			Info = GCHandle.ToIntPtr(gch),
			Schedule = Marshal.GetFunctionPointerForDelegate<ScheduleCallback>(Schedule),
			Cancel = Marshal.GetFunctionPointerForDelegate<CancelCallback>(Cancel),
			Perform = Marshal.GetFunctionPointerForDelegate<PerformCallback>(Perform)
		};
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CFRunLoopSourceContext)));
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			handle = CFRunLoopSourceCreate(IntPtr.Zero, 0, intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		if (handle == IntPtr.Zero)
		{
			throw new NotSupportedException();
		}
	}

	[MonoPInvokeCallback(typeof(ScheduleCallback))]
	private static void Schedule(IntPtr info, IntPtr runLoop, IntPtr mode)
	{
		CFRunLoopSourceCustom cFRunLoopSourceCustom = GCHandle.FromIntPtr(info).Target as CFRunLoopSourceCustom;
		CFRunLoop cFRunLoop = new CFRunLoop(runLoop);
		CFString cFString = new CFString(mode);
		try
		{
			cFRunLoopSourceCustom.OnSchedule(cFRunLoop, cFString);
		}
		finally
		{
			cFRunLoop.Dispose();
			cFString.Dispose();
		}
	}

	protected abstract void OnSchedule(CFRunLoop loop, string mode);

	[MonoPInvokeCallback(typeof(CancelCallback))]
	private static void Cancel(IntPtr info, IntPtr runLoop, IntPtr mode)
	{
		CFRunLoopSourceCustom cFRunLoopSourceCustom = GCHandle.FromIntPtr(info).Target as CFRunLoopSourceCustom;
		CFRunLoop cFRunLoop = new CFRunLoop(runLoop);
		CFString cFString = new CFString(mode);
		try
		{
			cFRunLoopSourceCustom.OnCancel(cFRunLoop, cFString);
		}
		finally
		{
			cFRunLoop.Dispose();
			cFString.Dispose();
		}
	}

	protected abstract void OnCancel(CFRunLoop loop, string mode);

	[MonoPInvokeCallback(typeof(PerformCallback))]
	private static void Perform(IntPtr info)
	{
		(GCHandle.FromIntPtr(info).Target as CFRunLoopSourceCustom).OnPerform();
	}

	protected abstract void OnPerform();

	public override void Dispose(bool disposing)
	{
		if (disposing && gch.IsAllocated)
		{
			gch.Free();
		}
		base.Dispose(disposing);
	}
}
