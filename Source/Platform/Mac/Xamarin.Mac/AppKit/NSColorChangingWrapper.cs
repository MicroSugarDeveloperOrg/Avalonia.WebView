using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSColorChangingWrapper : BaseWrapper, INSColorChanging, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSColorChangingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("changeColor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ChangeColor(NSColorPanel? sender)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("changeColor:"), sender?.Handle ?? IntPtr.Zero);
	}
}
