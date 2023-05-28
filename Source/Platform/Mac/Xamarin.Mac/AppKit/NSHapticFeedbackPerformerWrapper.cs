using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSHapticFeedbackPerformerWrapper : BaseWrapper, INSHapticFeedbackPerformer, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSHapticFeedbackPerformerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("performFeedbackPattern:performanceTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PerformFeedback(NSHapticFeedbackPattern pattern, NSHapticFeedbackPerformanceTime performanceTime)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64_UInt64(base.Handle, Selector.GetHandle("performFeedbackPattern:performanceTime:"), (long)pattern, (ulong)performanceTime);
	}
}
