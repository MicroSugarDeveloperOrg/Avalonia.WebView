using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSpringLoadingDestinationWrapper : BaseWrapper, INSSpringLoadingDestination, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSpringLoadingDestinationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("springLoadingActivated:draggingInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Activated(bool activated, NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, Selector.GetHandle("springLoadingActivated:draggingInfo:"), activated, draggingInfo.Handle);
	}

	[Export("springLoadingHighlightChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void HighlightChanged(NSDraggingInfo draggingInfo)
	{
		NSApplication.EnsureUIThread();
		if (draggingInfo == null)
		{
			throw new ArgumentNullException("draggingInfo");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("springLoadingHighlightChanged:"), draggingInfo.Handle);
	}
}
