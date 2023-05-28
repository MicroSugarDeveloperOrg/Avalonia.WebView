using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public abstract class CFRunLoopSourceCustom : CFRunLoopSource
{
	private delegate void ScheduleCallback(IntPtr info, IntPtr runLoop, IntPtr mode);

	private delegate void CancelCallback(IntPtr info, IntPtr runLoop, IntPtr mode);

	private delegate void PerformCallback(IntPtr info);

	private GCHandle gch;

	private static ScheduleCallback ScheduleDelegate = Schedule;

	private static CancelCallback CancelDelegate = Cancel;

	private static PerformCallback PerformDelegate = Perform;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFRunLoopSourceCreate(IntPtr allocator, nint order, IntPtr context);

	protected CFRunLoopSourceCustom()
		: base(IntPtr.Zero, ownsHandle: true)
	{
		gch = GCHandle.Alloc(this);
		CFRunLoopSourceContext structure = new CFRunLoopSourceContext
		{
			Info = GCHandle.ToIntPtr(gch),
			Schedule = Marshal.GetFunctionPointerForDelegate(ScheduleDelegate),
			Cancel = Marshal.GetFunctionPointerForDelegate(CancelDelegate),
			Perform = Marshal.GetFunctionPointerForDelegate(PerformDelegate)
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
		using CFRunLoop loop = new CFRunLoop(runLoop);
		using NSString mode2 = new NSString(mode);
		cFRunLoopSourceCustom.OnSchedule(loop, mode2);
	}

	protected abstract void OnSchedule(CFRunLoop loop, NSString mode);

	[MonoPInvokeCallback(typeof(CancelCallback))]
	private static void Cancel(IntPtr info, IntPtr runLoop, IntPtr mode)
	{
		CFRunLoopSourceCustom cFRunLoopSourceCustom = GCHandle.FromIntPtr(info).Target as CFRunLoopSourceCustom;
		using CFRunLoop loop = new CFRunLoop(runLoop);
		using NSString mode2 = new NSString(mode);
		cFRunLoopSourceCustom.OnCancel(loop, mode2);
	}

	protected abstract void OnCancel(CFRunLoop loop, NSString mode);

	[MonoPInvokeCallback(typeof(PerformCallback))]
	private static void Perform(IntPtr info)
	{
		CFRunLoopSourceCustom cFRunLoopSourceCustom = GCHandle.FromIntPtr(info).Target as CFRunLoopSourceCustom;
		cFRunLoopSourceCustom.OnPerform();
	}

	protected abstract void OnPerform();

	protected override void Dispose(bool disposing)
	{
		if (disposing && gch.IsAllocated)
		{
			gch.Free();
		}
		base.Dispose(disposing);
	}
}
