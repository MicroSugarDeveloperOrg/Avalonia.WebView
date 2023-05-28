using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSValidatedUserInterfaceItemWrapper : BaseWrapper, INSValidatedUserInterfaceItem, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Selector? Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("action")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint Tag
	{
		[Export("tag")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("tag"));
		}
	}

	[Preserve(Conditional = true)]
	public NSValidatedUserInterfaceItemWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
