using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSSharingServiceDelegate", false)]
[Model]
public class NSSharingServiceDelegate : NSObject, INSSharingServiceDelegate, INativeObject, IDisposable
{
	private CGRect SourceFrameOnScreenForShareItem(NSSharingService sharingService, NSPasteboardWriting item)
	{
		return SourceFrameOnScreenForShareItem(sharingService, (INSPasteboardWriting)item);
	}

	private NSImage TransitionImageForShareItem(NSSharingService sharingService, NSPasteboardWriting item, CGRect contentRect)
	{
		return TransitionImageForShareItem(sharingService, (INSPasteboardWriting)item, contentRect);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSharingServiceDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSharingServiceDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSharingServiceDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("anchoringViewForSharingService:showRelativeToRect:preferredEdge:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? CreateAnchoringView(NSSharingService sharingService, ref CGRect positioningRect, ref NSRectEdge preferredEdge)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didFailToShareItems:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFailToShareItems(NSSharingService sharingService, NSObject[] items, NSError error)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:didShareItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidShareItems(NSSharingService sharingService, NSObject[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:sourceFrameOnScreenForShareItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect SourceFrameOnScreenForShareItem(NSSharingService sharingService, INSPasteboardWriting item)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:sourceWindowForShareItems:sharingContentScope:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow SourceWindowForShareItems(NSSharingService sharingService, NSObject[] items, NSSharingContentScope sharingContentScope)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:transitionImageForShareItem:contentRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage TransitionImageForShareItem(NSSharingService sharingService, INSPasteboardWriting item, CGRect contentRect)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("sharingService:willShareItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillShareItems(NSSharingService sharingService, NSObject[] items)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
