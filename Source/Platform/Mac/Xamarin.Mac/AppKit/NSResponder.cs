using System;
using System.ComponentModel;
using System.Diagnostics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSResponder", true)]
public class NSResponder : NSObject, INSCoding, INativeObject, IDisposable, INSTouchBarProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsFirstResponder = "acceptsFirstResponder";

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomeFirstResponder = "becomeFirstResponder";

	private static readonly IntPtr selBecomeFirstResponderHandle = Selector.GetHandle("becomeFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginGestureWithEvent_ = "beginGestureWithEvent:";

	private static readonly IntPtr selBeginGestureWithEvent_Handle = Selector.GetHandle("beginGestureWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeModeWithEvent_ = "changeModeWithEvent:";

	private static readonly IntPtr selChangeModeWithEvent_Handle = Selector.GetHandle("changeModeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCursorUpdate_ = "cursorUpdate:";

	private static readonly IntPtr selCursorUpdate_Handle = Selector.GetHandle("cursorUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_ = "encodeRestorableStateWithCoder:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_BackgroundQueue_ = "encodeRestorableStateWithCoder:backgroundQueue:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_BackgroundQueue_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:backgroundQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndGestureWithEvent_ = "endGestureWithEvent:";

	private static readonly IntPtr selEndGestureWithEvent_Handle = Selector.GetHandle("endGestureWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlagsChanged_ = "flagsChanged:";

	private static readonly IntPtr selFlagsChanged_Handle = Selector.GetHandle("flagsChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlushBufferedKeyEvents = "flushBufferedKeyEvents";

	private static readonly IntPtr selFlushBufferedKeyEventsHandle = Selector.GetHandle("flushBufferedKeyEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHelpRequested_ = "helpRequested:";

	private static readonly IntPtr selHelpRequested_Handle = Selector.GetHandle("helpRequested:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpretKeyEvents_ = "interpretKeyEvents:";

	private static readonly IntPtr selInterpretKeyEvents_Handle = Selector.GetHandle("interpretKeyEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateRestorableState = "invalidateRestorableState";

	private static readonly IntPtr selInvalidateRestorableStateHandle = Selector.GetHandle("invalidateRestorableState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyDown_ = "keyDown:";

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyUp_ = "keyUp:";

	private static readonly IntPtr selKeyUp_Handle = Selector.GetHandle("keyUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnifyWithEvent_ = "magnifyWithEvent:";

	private static readonly IntPtr selMagnifyWithEvent_Handle = Selector.GetHandle("magnifyWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenu = "menu";

	private static readonly IntPtr selMenuHandle = Selector.GetHandle("menu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDown_ = "mouseDown:";

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDragged_ = "mouseDragged:";

	private static readonly IntPtr selMouseDragged_Handle = Selector.GetHandle("mouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseEntered_ = "mouseEntered:";

	private static readonly IntPtr selMouseEntered_Handle = Selector.GetHandle("mouseEntered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseExited_ = "mouseExited:";

	private static readonly IntPtr selMouseExited_Handle = Selector.GetHandle("mouseExited:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseMoved_ = "mouseMoved:";

	private static readonly IntPtr selMouseMoved_Handle = Selector.GetHandle("mouseMoved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseUp_ = "mouseUp:";

	private static readonly IntPtr selMouseUp_Handle = Selector.GetHandle("mouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewWindowForTab_ = "newWindowForTab:";

	private static readonly IntPtr selNewWindowForTab_Handle = Selector.GetHandle("newWindowForTab:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextResponder = "nextResponder";

	private static readonly IntPtr selNextResponderHandle = Selector.GetHandle("nextResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoResponderFor_ = "noResponderFor:";

	private static readonly IntPtr selNoResponderFor_Handle = Selector.GetHandle("noResponderFor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseDown_ = "otherMouseDown:";

	private static readonly IntPtr selOtherMouseDown_Handle = Selector.GetHandle("otherMouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseDragged_ = "otherMouseDragged:";

	private static readonly IntPtr selOtherMouseDragged_Handle = Selector.GetHandle("otherMouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOtherMouseUp_ = "otherMouseUp:";

	private static readonly IntPtr selOtherMouseUp_Handle = Selector.GetHandle("otherMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformKeyEquivalent_ = "performKeyEquivalent:";

	private static readonly IntPtr selPerformKeyEquivalent_Handle = Selector.GetHandle("performKeyEquivalent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ = "presentError:";

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_ = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";

	private static readonly IntPtr selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressureChangeWithEvent_ = "pressureChangeWithEvent:";

	private static readonly IntPtr selPressureChangeWithEvent_Handle = Selector.GetHandle("pressureChangeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuickLookWithEvent_ = "quickLookWithEvent:";

	private static readonly IntPtr selQuickLookWithEvent_Handle = Selector.GetHandle("quickLookWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResignFirstResponder = "resignFirstResponder";

	private static readonly IntPtr selResignFirstResponderHandle = Selector.GetHandle("resignFirstResponder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestorableStateKeyPaths = "restorableStateKeyPaths";

	private static readonly IntPtr selRestorableStateKeyPathsHandle = Selector.GetHandle("restorableStateKeyPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreStateWithCoder_ = "restoreStateWithCoder:";

	private static readonly IntPtr selRestoreStateWithCoder_Handle = Selector.GetHandle("restoreStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreUserActivityState_ = "restoreUserActivityState:";

	private static readonly IntPtr selRestoreUserActivityState_Handle = Selector.GetHandle("restoreUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseDown_ = "rightMouseDown:";

	private static readonly IntPtr selRightMouseDown_Handle = Selector.GetHandle("rightMouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseDragged_ = "rightMouseDragged:";

	private static readonly IntPtr selRightMouseDragged_Handle = Selector.GetHandle("rightMouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightMouseUp_ = "rightMouseUp:";

	private static readonly IntPtr selRightMouseUp_Handle = Selector.GetHandle("rightMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotateWithEvent_ = "rotateWithEvent:";

	private static readonly IntPtr selRotateWithEvent_Handle = Selector.GetHandle("rotateWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollWheel_ = "scrollWheel:";

	private static readonly IntPtr selScrollWheel_Handle = Selector.GetHandle("scrollWheel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ = "setMenu:";

	private static readonly IntPtr selSetMenu_Handle = Selector.GetHandle("setMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNextResponder_ = "setNextResponder:";

	private static readonly IntPtr selSetNextResponder_Handle = Selector.GetHandle("setNextResponder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserActivity_ = "setUserActivity:";

	private static readonly IntPtr selSetUserActivity_Handle = Selector.GetHandle("setUserActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBeTreatedAsInkEvent_ = "shouldBeTreatedAsInkEvent:";

	private static readonly IntPtr selShouldBeTreatedAsInkEvent_Handle = Selector.GetHandle("shouldBeTreatedAsInkEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowContextHelp_ = "showContextHelp:";

	private static readonly IntPtr selShowContextHelp_Handle = Selector.GetHandle("showContextHelp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSmartMagnifyWithEvent_ = "smartMagnifyWithEvent:";

	private static readonly IntPtr selSmartMagnifyWithEvent_Handle = Selector.GetHandle("smartMagnifyWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementalTargetForAction_Sender_ = "supplementalTargetForAction:sender:";

	private static readonly IntPtr selSupplementalTargetForAction_Sender_Handle = Selector.GetHandle("supplementalTargetForAction:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSwipeWithEvent_ = "swipeWithEvent:";

	private static readonly IntPtr selSwipeWithEvent_Handle = Selector.GetHandle("swipeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabletPoint_ = "tabletPoint:";

	private static readonly IntPtr selTabletPoint_Handle = Selector.GetHandle("tabletPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabletProximity_ = "tabletProximity:";

	private static readonly IntPtr selTabletProximity_Handle = Selector.GetHandle("tabletProximity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchBar = "touchBar";

	private static readonly IntPtr selTouchBarHandle = Selector.GetHandle("touchBar");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesBeganWithEvent_ = "touchesBeganWithEvent:";

	private static readonly IntPtr selTouchesBeganWithEvent_Handle = Selector.GetHandle("touchesBeganWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesCancelledWithEvent_ = "touchesCancelledWithEvent:";

	private static readonly IntPtr selTouchesCancelledWithEvent_Handle = Selector.GetHandle("touchesCancelledWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesEndedWithEvent_ = "touchesEndedWithEvent:";

	private static readonly IntPtr selTouchesEndedWithEvent_Handle = Selector.GetHandle("touchesEndedWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchesMovedWithEvent_ = "touchesMovedWithEvent:";

	private static readonly IntPtr selTouchesMovedWithEvent_Handle = Selector.GetHandle("touchesMovedWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryToPerform_With_ = "tryToPerform:with:";

	private static readonly IntPtr selTryToPerform_With_Handle = Selector.GetHandle("tryToPerform:with:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateUserActivityState_ = "updateUserActivityState:";

	private static readonly IntPtr selUpdateUserActivityState_Handle = Selector.GetHandle("updateUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserActivity = "userActivity";

	private static readonly IntPtr selUserActivityHandle = Selector.GetHandle("userActivity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidRequestorForSendType_ReturnType_ = "validRequestorForSendType:returnType:";

	private static readonly IntPtr selValidRequestorForSendType_ReturnType_Handle = Selector.GetHandle("validRequestorForSendType:returnType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateProposedFirstResponder_ForEvent_ = "validateProposedFirstResponder:forEvent:";

	private static readonly IntPtr selValidateProposedFirstResponder_ForEvent_Handle = Selector.GetHandle("validateProposedFirstResponder:forEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsForwardedScrollEventsForAxis_ = "wantsForwardedScrollEventsForAxis:";

	private static readonly IntPtr selWantsForwardedScrollEventsForAxis_Handle = Selector.GetHandle("wantsForwardedScrollEventsForAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsScrollEventsForSwipeTrackingOnAxis_ = "wantsScrollEventsForSwipeTrackingOnAxis:";

	private static readonly IntPtr selWantsScrollEventsForSwipeTrackingOnAxis_Handle = Selector.GetHandle("wantsScrollEventsForSwipeTrackingOnAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillPresentError_ = "willPresentError:";

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSResponder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSMenu? Menu
	{
		[Export("menu", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, selMenuHandle));
			}
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMenuHandle));
		}
		[Export("setMenu:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMenu_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSResponder? NextResponder
	{
		[Export("nextResponder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextResponderHandle));
			}
			return Runtime.GetNSObject<NSResponder>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextResponderHandle));
		}
		[Export("setNextResponder:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNextResponder_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSTouchBar? TouchBar
	{
		[Export("touchBar", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSend(base.Handle, selTouchBarHandle));
			}
			return Runtime.GetNSObject<NSTouchBar>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTouchBarHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSUserActivity UserActivity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("userActivity", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserActivityHandle));
			}
			return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserActivityHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUserActivity:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserActivity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserActivity_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSResponder()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSResponder(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSResponder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSResponder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("acceptsFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAcceptsFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsFirstResponderHandle);
	}

	[Export("becomeFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BecomeFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selBecomeFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBecomeFirstResponderHandle);
	}

	[Export("beginGestureWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("changeModeWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeMode(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChangeModeWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChangeModeWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("cursorUpdate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CursorUpdate(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCursorUpdate_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCursorUpdate_Handle, theEvent.Handle);
		}
	}

	[Export("encodeRestorableStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRestorableState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("encodeRestorableStateWithCoder:backgroundQueue:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRestorableState(NSCoder coder, NSOperationQueue queue)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("endGestureWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndGestureWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEndGestureWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("flagsChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlagsChanged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlagsChanged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlagsChanged_Handle, theEvent.Handle);
		}
	}

	[Export("flushBufferedKeyEvents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlushBufferedKeyEvents()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFlushBufferedKeyEventsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFlushBufferedKeyEventsHandle);
		}
	}

	[Export("newWindowForTab:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void GetNewWindowForTab(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNewWindowForTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewWindowForTab_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("helpRequested:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HelpRequested(NSEvent theEventPtr)
	{
		NSApplication.EnsureUIThread();
		if (theEventPtr == null)
		{
			throw new ArgumentNullException("theEventPtr");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHelpRequested_Handle, theEventPtr.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHelpRequested_Handle, theEventPtr.Handle);
		}
	}

	[Export("interpretKeyEvents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InterpretKeyEvents(NSEvent[] eventArray)
	{
		NSApplication.EnsureUIThread();
		if (eventArray == null)
		{
			throw new ArgumentNullException("eventArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(eventArray);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInterpretKeyEvents_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("invalidateRestorableState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateRestorableState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateRestorableStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateRestorableStateHandle);
		}
	}

	[Export("keyDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void KeyDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, theEvent.Handle);
		}
	}

	[Export("keyUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void KeyUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyUp_Handle, theEvent.Handle);
		}
	}

	[Export("magnifyWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MagnifyWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMagnifyWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("mouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("mouseEntered:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseEntered(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseEntered_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseEntered_Handle, theEvent.Handle);
		}
	}

	[Export("mouseExited:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseExited(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseExited_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseExited_Handle, theEvent.Handle);
		}
	}

	[Export("mouseMoved:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseMoved(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseMoved_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseMoved_Handle, theEvent.Handle);
		}
	}

	[Export("mouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("noResponderFor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoResponderFor(Selector eventSelector)
	{
		NSApplication.EnsureUIThread();
		if (eventSelector == null)
		{
			throw new ArgumentNullException("eventSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoResponderFor_Handle, eventSelector.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoResponderFor_Handle, eventSelector.Handle);
		}
	}

	[Export("otherMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("otherMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("performKeyEquivalent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PerformKeyEquivalent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPerformKeyEquivalent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformKeyEquivalent_Handle, theEvent.Handle);
	}

	[Export("presentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPresentError_Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentError_Handle, error.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PresentError(NSError error, NSWindow window, NSObject? @delegate, Selector? didPresentSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle, error.Handle, window.Handle, @delegate?.Handle ?? IntPtr.Zero, (didPresentSelector == null) ? IntPtr.Zero : didPresentSelector.Handle, contextInfo);
	}

	[Export("pressureChangeWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PressureChange(NSEvent pressureChangeEvent)
	{
		NSApplication.EnsureUIThread();
		if (pressureChangeEvent == null)
		{
			throw new ArgumentNullException("pressureChangeEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPressureChangeWithEvent_Handle, pressureChangeEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPressureChangeWithEvent_Handle, pressureChangeEvent.Handle);
		}
	}

	[Export("quickLookWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void QuickLook(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selQuickLookWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuickLookWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("resignFirstResponder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ResignFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResignFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResignFirstResponderHandle);
	}

	[Export("restorableStateKeyPaths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] RestorableStateKeyPaths()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selRestorableStateKeyPathsHandle));
	}

	[Export("restoreStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("restoreUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
	}

	[Export("rightMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseDown(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDown_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDown_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseDragged(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDragged_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDragged_Handle, theEvent.Handle);
		}
	}

	[Export("rightMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseUp(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseUp_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseUp_Handle, theEvent.Handle);
		}
	}

	[Export("rotateWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RotateWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("scrollWheel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollWheel(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selScrollWheel_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selScrollWheel_Handle, theEvent.Handle);
		}
	}

	[Export("shouldBeTreatedAsInkEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeTreatedAsInkEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldBeTreatedAsInkEvent_Handle, theEvent.Handle);
	}

	[Export("showContextHelp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowContextHelp(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowContextHelp_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowContextHelp_Handle, sender.Handle);
		}
	}

	[Export("smartMagnifyWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SmartMagnify(NSEvent withEvent)
	{
		NSApplication.EnsureUIThread();
		if (withEvent == null)
		{
			throw new ArgumentNullException("withEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSmartMagnifyWithEvent_Handle, withEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSmartMagnifyWithEvent_Handle, withEvent.Handle);
		}
	}

	[Export("supplementalTargetForAction:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SupplementalTargetForAction(Selector action, NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSupplementalTargetForAction_Sender_Handle, action.Handle, sender?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSupplementalTargetForAction_Sender_Handle, action.Handle, sender?.Handle ?? IntPtr.Zero));
	}

	[Export("swipeWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SwipeWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSwipeWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("tabletPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TabletPoint(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletPoint_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletPoint_Handle, theEvent.Handle);
		}
	}

	[Export("tabletProximity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TabletProximity(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletProximity_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletProximity_Handle, theEvent.Handle);
		}
	}

	[Export("touchesBeganWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesBeganWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesBeganWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesCancelledWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesCancelledWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesCancelledWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesEndedWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesEndedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesEndedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("touchesMovedWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesMovedWithEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesMovedWithEvent_Handle, theEvent.Handle);
		}
	}

	[Export("tryToPerform:with:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TryToPerformwith(Selector anAction, NSObject? anObject)
	{
		NSApplication.EnsureUIThread();
		if (anAction == null)
		{
			throw new ArgumentNullException("anAction");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTryToPerform_With_Handle, anAction.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTryToPerform_With_Handle, anAction.Handle, anObject?.Handle ?? IntPtr.Zero);
	}

	[Export("updateUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
	}

	[Export("validRequestorForSendType:returnType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ValidRequestorForSendType(string? sendType, string? returnType)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(sendType);
		IntPtr arg2 = NSString.CreateNative(returnType);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidRequestorForSendType_ReturnType_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("validateProposedFirstResponder:forEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateProposedFirstResponder(NSResponder responder, NSEvent? forEvent)
	{
		NSApplication.EnsureUIThread();
		if (responder == null)
		{
			throw new ArgumentNullException("responder");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selValidateProposedFirstResponder_ForEvent_Handle, responder.Handle, forEvent?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selValidateProposedFirstResponder_ForEvent_Handle, responder.Handle, forEvent?.Handle ?? IntPtr.Zero);
	}

	[Export("wantsForwardedScrollEventsForAxis:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsForwardedScrollEventsForAxis(NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selWantsForwardedScrollEventsForAxis_Handle, (long)axis);
	}

	[Export("wantsScrollEventsForSwipeTrackingOnAxis:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsScrollEventsForSwipeTrackingOnAxis(NSEventGestureAxis axis)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selWantsScrollEventsForSwipeTrackingOnAxis_Handle, (long)axis);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selWantsScrollEventsForSwipeTrackingOnAxis_Handle, (long)axis);
	}

	[Export("willPresentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError WillPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWillPresentError_Handle, error.Handle));
		}
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillPresentError_Handle, error.Handle));
	}
}
