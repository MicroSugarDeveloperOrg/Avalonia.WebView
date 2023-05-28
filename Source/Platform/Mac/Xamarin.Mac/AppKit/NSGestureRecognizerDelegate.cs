using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSGestureRecognizerDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSGestureRecognizerDelegate : NSObject, INSGestureRecognizerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGestureRecognizerDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSGestureRecognizerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGestureRecognizerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("gestureRecognizer:shouldAttemptToRecognizeWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldAttemptToRecognize(NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeRequiredToFail(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("gestureRecognizerShouldBegin:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBegin(NSGestureRecognizer gestureRecognizer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReceiveEvent(NSGestureRecognizer gestureRecognizer, NSEvent gestureEvent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("gestureRecognizer:shouldReceiveTouch:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldReceiveTouch(NSGestureRecognizer gestureRecognizer, NSTouch touch)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRecognizeSimultaneously(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRequireFailure(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
