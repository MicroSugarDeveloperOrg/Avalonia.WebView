using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextFinderBarContainerWrapper : BaseWrapper, INSTextFinderBarContainer, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool FindBarVisible
	{
		[Export("isFindBarVisible")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isFindBarVisible"));
		}
		[Export("setFindBarVisible:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setFindBarVisible:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSView FindBarView
	{
		[Export("findBarView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("findBarView")));
		}
		[Export("setFindBarView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setFindBarView:"), value.Handle);
		}
	}

	[Preserve(Conditional = true)]
	public NSTextFinderBarContainerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("findBarViewDidChangeHeight")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FindBarViewDidChangeHeight()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("findBarViewDidChangeHeight"));
	}
}
