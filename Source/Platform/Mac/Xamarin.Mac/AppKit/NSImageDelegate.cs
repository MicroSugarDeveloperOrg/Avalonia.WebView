using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSImageDelegate", false)]
[Model]
public class NSImageDelegate : NSObject, INSImageDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImageDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSImageDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSImageDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("image:didLoadPartOfRepresentation:withValidRows:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidLoadPartOfRepresentation(NSImage image, NSImageRep rep, nint rows)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:didLoadRepresentation:withStatus:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidLoadRepresentation(NSImage image, NSImageRep rep, NSImageLoadStatus status)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:didLoadRepresentationHeader:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidLoadRepresentationHeader(NSImage image, NSImageRep rep)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageDidNotDraw:inRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage ImageDidNotDraw(NSObject sender, CGRect aRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("image:willLoadRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillLoadRepresentation(NSImage image, NSImageRep rep)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
