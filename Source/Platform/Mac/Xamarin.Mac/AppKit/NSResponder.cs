using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSResponder", true)]
public class NSResponder : NSObject
{
	private static readonly IntPtr selNextResponderHandle = Selector.GetHandle("nextResponder");

	private static readonly IntPtr selSetNextResponder_Handle = Selector.GetHandle("setNextResponder:");

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	private static readonly IntPtr selTryToPerformWith_Handle = Selector.GetHandle("tryToPerform:with:");

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	private static readonly IntPtr selValidRequestorForSendTypeReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	private static readonly IntPtr selRightMouseDown_Handle = Selector.GetHandle("rightMouseDown:");

	private static readonly IntPtr selOtherMouseDown_Handle = Selector.GetHandle("otherMouseDown:");

	private static readonly IntPtr selMouseUp_Handle = Selector.GetHandle("mouseUp:");

	private static readonly IntPtr selRightMouseUp_Handle = Selector.GetHandle("rightMouseUp:");

	private static readonly IntPtr selOtherMouseUp_Handle = Selector.GetHandle("otherMouseUp:");

	private static readonly IntPtr selMouseMoved_Handle = Selector.GetHandle("mouseMoved:");

	private static readonly IntPtr selMouseDragged_Handle = Selector.GetHandle("mouseDragged:");

	private static readonly IntPtr selScrollWheel_Handle = Selector.GetHandle("scrollWheel:");

	private static readonly IntPtr selRightMouseDragged_Handle = Selector.GetHandle("rightMouseDragged:");

	private static readonly IntPtr selOtherMouseDragged_Handle = Selector.GetHandle("otherMouseDragged:");

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	private static readonly IntPtr selKeyUp_Handle = Selector.GetHandle("keyUp:");

	private static readonly IntPtr selFlagsChanged_Handle = Selector.GetHandle("flagsChanged:");

	private static readonly IntPtr selTabletPoint_Handle = Selector.GetHandle("tabletPoint:");

	private static readonly IntPtr selTabletProximity_Handle = Selector.GetHandle("tabletProximity:");

	private static readonly IntPtr selCursorUpdate_Handle = Selector.GetHandle("cursorUpdate:");

	private static readonly IntPtr selMagnifyWithEvent_Handle = Selector.GetHandle("magnifyWithEvent:");

	private static readonly IntPtr selRotateWithEvent_Handle = Selector.GetHandle("rotateWithEvent:");

	private static readonly IntPtr selSwipeWithEvent_Handle = Selector.GetHandle("swipeWithEvent:");

	private static readonly IntPtr selBeginGestureWithEvent_Handle = Selector.GetHandle("beginGestureWithEvent:");

	private static readonly IntPtr selEndGestureWithEvent_Handle = Selector.GetHandle("endGestureWithEvent:");

	private static readonly IntPtr selTouchesBeganWithEvent_Handle = Selector.GetHandle("touchesBeganWithEvent:");

	private static readonly IntPtr selTouchesMovedWithEvent_Handle = Selector.GetHandle("touchesMovedWithEvent:");

	private static readonly IntPtr selTouchesEndedWithEvent_Handle = Selector.GetHandle("touchesEndedWithEvent:");

	private static readonly IntPtr selTouchesCancelledWithEvent_Handle = Selector.GetHandle("touchesCancelledWithEvent:");

	private static readonly IntPtr selNoResponderFor_Handle = Selector.GetHandle("noResponderFor:");

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	private static readonly IntPtr selBecomeFirstResponderHandle = Selector.GetHandle("becomeFirstResponder");

	private static readonly IntPtr selResignFirstResponderHandle = Selector.GetHandle("resignFirstResponder");

	private static readonly IntPtr selInterpretKeyEvents_Handle = Selector.GetHandle("interpretKeyEvents:");

	private static readonly IntPtr selFlushBufferedKeyEventsHandle = Selector.GetHandle("flushBufferedKeyEvents");

	private static readonly IntPtr selShowContextHelp_Handle = Selector.GetHandle("showContextHelp:");

	private static readonly IntPtr selHelpRequested_Handle = Selector.GetHandle("helpRequested:");

	private static readonly IntPtr selShouldBeTreatedAsInkEvent_Handle = Selector.GetHandle("shouldBeTreatedAsInkEvent:");

	private static readonly IntPtr selEncodeRestorableStateWithCoder_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:");

	private static readonly IntPtr selRestoreStateWithCoder_Handle = Selector.GetHandle("restoreStateWithCoder:");

	private static readonly IntPtr selInvalidateRestorableStateHandle = Selector.GetHandle("invalidateRestorableState");

	private static readonly IntPtr selRestorableStateKeyPathsHandle = Selector.GetHandle("restorableStateKeyPaths");

	private static readonly IntPtr selWantsForwardedScrollEventsForAxis_Handle = Selector.GetHandle("wantsForwardedScrollEventsForAxis:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSResponder");

	private object __mt_NextResponder_var;

	private object __mt_Menu_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSResponder NextResponder
	{
		[Export("nextResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSResponder)(__mt_NextResponder_var = ((!IsDirectBinding) ? ((NSResponder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextResponderHandle))) : ((NSResponder)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextResponderHandle)))));
		}
		[Export("setNextResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_NextResponder_var = value;
		}
	}

	public virtual NSMenu Menu
	{
		[Export("menu")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSMenu)(__mt_Menu_var = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle)))));
		}
		[Export("setMenu:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value.Handle);
			}
			__mt_Menu_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSResponder()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSResponder(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSResponder(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSResponder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("tryToPerform:with:")]
	public virtual bool TryToPerformwith(Selector anAction, NSObject anObject)
	{
		NSApplication.EnsureUIThread();
		if (anAction == null)
		{
			throw new ArgumentNullException("anAction");
		}
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTryToPerformWith_Handle, anAction.Handle, anObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTryToPerformWith_Handle, anAction.Handle, anObject.Handle);
	}

	[Export("performKeyEquivalent:")]
	public virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("validRequestorForSendType:returnType:")]
	public virtual NSObject ValidRequestorForSendTypereturnType(string sendType, string returnType)
	{
		NSApplication.EnsureUIThread();
		if (sendType == null)
		{
			throw new ArgumentNullException("sendType");
		}
		if (returnType == null)
		{
			throw new ArgumentNullException("returnType");
		}
		IntPtr arg = NSString.CreateNative(sendType);
		IntPtr arg2 = NSString.CreateNative(returnType);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendTypeReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("mouseDown:")]
	public virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseDown:")]
	public virtual void RightMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseDown:")]
	public virtual void OtherMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("mouseUp:")]
	public virtual void MouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseUp:")]
	public virtual void RightMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseUp:")]
	public virtual void OtherMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("mouseMoved:")]
	public virtual void MouseMoved(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseMoved_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseMoved_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDragged:")]
	public virtual void MouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("scrollWheel:")]
	public virtual void ScrollWheel(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollWheel_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollWheel_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseDragged:")]
	public virtual void RightMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseDragged:")]
	public virtual void OtherMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("mouseEntered:")]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	[Export("keyDown:")]
	public virtual void KeyDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, theEvent.Handle);
		}
	}

	[Export("keyUp:")]
	public virtual void KeyUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyUp_Handle, theEvent.Handle);
		}
	}

	[Export("flagsChanged:")]
	public virtual void FlagsChanged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlagsChanged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlagsChanged_Handle, theEvent.Handle);
		}
	}

	[Export("tabletPoint:")]
	public virtual void TabletPoint(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletPoint_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletPoint_Handle, theEvent.Handle);
		}
	}

	[Export("tabletProximity:")]
	public virtual void TabletProximity(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletProximity_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletProximity_Handle, theEvent.Handle);
		}
	}

	[Export("cursorUpdate:")]
	public virtual void CursorUpdate(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCursorUpdate_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCursorUpdate_Handle, theEvent.Handle);
		}
	}

	[Export("magnifyWithEvent:")]
	public virtual void MagnifyWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("rotateWithEvent:")]
	public virtual void RotateWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("swipeWithEvent:")]
	public virtual void SwipeWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("beginGestureWithEvent:")]
	public virtual void BeginGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("endGestureWithEvent:")]
	public virtual void EndGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesBeganWithEvent:")]
	public virtual void TouchesBeganWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesMovedWithEvent:")]
	public virtual void TouchesMovedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesEndedWithEvent:")]
	public virtual void TouchesEndedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesCancelledWithEvent:")]
	public virtual void TouchesCancelledWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("noResponderFor:")]
	public virtual void NoResponderFor(Selector eventSelector)
	{
		NSApplication.EnsureUIThread();
		if (eventSelector == null)
		{
			throw new ArgumentNullException("eventSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoResponderFor_Handle, eventSelector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoResponderFor_Handle, eventSelector.Handle);
		}
	}

	[Export("acceptsFirstResponder")]
	public virtual bool AcceptsFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAcceptsFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsFirstResponderHandle);
	}

	[Export("becomeFirstResponder")]
	public virtual bool BecomeFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selBecomeFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBecomeFirstResponderHandle);
	}

	[Export("resignFirstResponder")]
	public virtual bool ResignFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResignFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResignFirstResponderHandle);
	}

	[Export("interpretKeyEvents:")]
	public virtual void InterpretKeyEvents(NSEvent[] eventArray)
	{
		NSApplication.EnsureUIThread();
		if (eventArray == null)
		{
			throw new ArgumentNullException("eventArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(eventArray);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("flushBufferedKeyEvents")]
	public virtual void FlushBufferedKeyEvents()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushBufferedKeyEventsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushBufferedKeyEventsHandle);
		}
	}

	[Export("showContextHelp:")]
	public virtual void ShowContextHelp(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowContextHelp_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowContextHelp_Handle, sender.Handle);
		}
	}

	[Export("helpRequested:")]
	public virtual void HelpRequested(NSEvent theEventPtr)
	{
		NSApplication.EnsureUIThread();
		if (theEventPtr == null)
		{
			throw new ArgumentNullException("theEventPtr");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHelpRequested_Handle, theEventPtr.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHelpRequested_Handle, theEventPtr.Handle);
		}
	}

	[Export("shouldBeTreatedAsInkEvent:")]
	public virtual bool ShouldBeTreatedAsInkEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
	}

	[Export("encodeRestorableStateWithCoder:")]
	public virtual void EncodeRestorableState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("restoreStateWithCoder:")]
	public virtual void RestoreState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("invalidateRestorableState")]
	public virtual void InvalidateRestorableState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateRestorableStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateRestorableStateHandle);
		}
	}

	[Export("restorableStateKeyPaths")]
	public static string[] RestorableStateKeyPaths()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selRestorableStateKeyPathsHandle));
	}

	[Export("wantsForwardedScrollEventsForAxis:")]
	public virtual bool WantsForwardedScrollEventsForAxis(NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_NextResponder_var = null;
			__mt_Menu_var = null;
		}
	}
}
