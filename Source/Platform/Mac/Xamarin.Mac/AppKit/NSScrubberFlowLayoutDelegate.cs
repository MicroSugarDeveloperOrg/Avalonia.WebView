using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSScrubberFlowLayoutDelegate", false)]
[Model]
public class NSScrubberFlowLayoutDelegate : NSObject, INSScrubberFlowLayoutDelegate, INativeObject, IDisposable, INSScrubberDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScrubberFlowLayoutDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSScrubberFlowLayoutDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScrubberFlowLayoutDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("didBeginInteractingWithScrubber:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidBeginInteracting(NSScrubber scrubber)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didCancelInteractingWithScrubber:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCancelInteracting(NSScrubber scrubber)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scrubber:didChangeVisibleRange:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeVisible(NSScrubber scrubber, NSRange visibleRange)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didFinishInteractingWithScrubber:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishInteracting(NSScrubber scrubber)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scrubber:didHighlightItemAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidHighlightItem(NSScrubber scrubber, nint highlightedIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scrubber:didSelectItemAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidSelectItem(NSScrubber scrubber, nint selectedIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("scrubber:layout:sizeForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Layout(NSScrubber scrubber, NSScrubberFlowLayout layout, nint itemIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
