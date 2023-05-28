using System;
using System.ComponentModel;
using ObjCRuntime;

namespace AppKit;

public static class NSGestureRecognizerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldBegin(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizerShouldBegin:"), gestureRecognizer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRecognizeSimultaneously(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (otherGestureRecognizer == null)
		{
			throw new ArgumentNullException("otherGestureRecognizer");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:"), gestureRecognizer.Handle, otherGestureRecognizer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRequireFailure(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (otherGestureRecognizer == null)
		{
			throw new ArgumentNullException("otherGestureRecognizer");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:"), gestureRecognizer.Handle, otherGestureRecognizer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldBeRequiredToFail(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (otherGestureRecognizer == null)
		{
			throw new ArgumentNullException("otherGestureRecognizer");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:"), gestureRecognizer.Handle, otherGestureRecognizer.Handle);
	}

	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReceiveEvent(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSEvent gestureEvent)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (gestureEvent == null)
		{
			throw new ArgumentNullException("gestureEvent");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("xamarinselector:removed:"), gestureRecognizer.Handle, gestureEvent.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAttemptToRecognize(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizer:shouldAttemptToRecognizeWithEvent:"), gestureRecognizer.Handle, theEvent.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldReceiveTouch(this INSGestureRecognizerDelegate This, NSGestureRecognizer gestureRecognizer, NSTouch touch)
	{
		NSApplication.EnsureUIThread();
		if (gestureRecognizer == null)
		{
			throw new ArgumentNullException("gestureRecognizer");
		}
		if (touch == null)
		{
			throw new ArgumentNullException("touch");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("gestureRecognizer:shouldReceiveTouch:"), gestureRecognizer.Handle, touch.Handle);
	}
}
