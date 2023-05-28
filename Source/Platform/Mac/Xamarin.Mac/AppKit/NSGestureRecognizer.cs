using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSGestureRecognizer", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSGestureRecognizer : NSObject, INSCoding, INativeObject, IDisposable
{
	[Register("__NSGestureRecognizerToken")]
	[Preserve(Conditional = true)]
	public class Token : NSObject
	{
		public Token()
		{
			base.IsDirectBinding = false;
		}
	}

	[Register("__NSGestureRecognizerParameterlessToken")]
	[Preserve(Conditional = true)]
	public class ParameterlessDispatch : Token
	{
		private Action action;

		internal ParameterlessDispatch(Action action)
		{
			this.action = action;
		}

		[Export("target")]
		[Preserve(Conditional = true)]
		public void Activated()
		{
			action();
		}
	}

	[Register("__NSGestureRecognizerParametrizedToken")]
	[Preserve(Conditional = true)]
	public class ParametrizedDispatch : Token
	{
		private Action<NSGestureRecognizer> action;

		internal ParametrizedDispatch(Action<NSGestureRecognizer> action)
		{
			this.action = action;
		}

		[Export("target:")]
		[Preserve(Conditional = true)]
		public void Activated(NSGestureRecognizer sender)
		{
			action(sender);
		}
	}

	[Register]
	internal class _NSGestureRecognizerDelegate : NSObject, INSGestureRecognizerDelegate, INativeObject, IDisposable
	{
		internal NSGestureEvent? shouldAttemptToRecognize;

		internal NSGesturesProbe? shouldBeRequiredToFail;

		internal NSGestureProbe? shouldBegin;

		internal NSGestureEvent? shouldReceiveEvent;

		internal NSTouchEvent? shouldReceiveTouch;

		internal NSGesturesProbe? shouldRecognizeSimultaneously;

		internal NSGesturesProbe? shouldRequireFailure;

		public _NSGestureRecognizerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizer:shouldAttemptToRecognizeWithEvent:")]
		public bool ShouldAttemptToRecognize(NSGestureRecognizer gestureRecognizer, NSEvent theEvent)
		{
			return shouldAttemptToRecognize?.Invoke(gestureRecognizer, theEvent) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
		public bool ShouldBeRequiredToFail(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return shouldBeRequiredToFail?.Invoke(gestureRecognizer, otherGestureRecognizer) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizerShouldBegin:")]
		public bool ShouldBegin(NSGestureRecognizer gestureRecognizer)
		{
			return shouldBegin?.Invoke(gestureRecognizer) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("xamarinselector:removed:")]
		public bool ShouldReceiveEvent(NSGestureRecognizer gestureRecognizer, NSEvent gestureEvent)
		{
			return shouldReceiveEvent?.Invoke(gestureRecognizer, gestureEvent) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizer:shouldReceiveTouch:")]
		public bool ShouldReceiveTouch(NSGestureRecognizer gestureRecognizer, NSTouch touch)
		{
			return shouldReceiveTouch?.Invoke(gestureRecognizer, touch) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		public bool ShouldRecognizeSimultaneously(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return shouldRecognizeSimultaneously?.Invoke(gestureRecognizer, otherGestureRecognizer) ?? false;
		}

		[Preserve(Conditional = true)]
		[Export("gestureRecognizer:shouldRequireFailureOfGestureRecognizer:")]
		public bool ShouldRequireFailure(NSGestureRecognizer gestureRecognizer, NSGestureRecognizer otherGestureRecognizer)
		{
			return shouldRequireFailure?.Invoke(gestureRecognizer, otherGestureRecognizer) ?? false;
		}
	}

	private object recognizers;

	private static Selector tsel = new Selector("target");

	internal static Selector ParametrizedSelector = new Selector("target:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanBePreventedByGestureRecognizer_ = "canBePreventedByGestureRecognizer:";

	private static readonly IntPtr selCanBePreventedByGestureRecognizer_Handle = Selector.GetHandle("canBePreventedByGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanPreventGestureRecognizer_ = "canPreventGestureRecognizer:";

	private static readonly IntPtr selCanPreventGestureRecognizer_Handle = Selector.GetHandle("canPreventGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysKeyEvents = "delaysKeyEvents";

	private static readonly IntPtr selDelaysKeyEventsHandle = Selector.GetHandle("delaysKeyEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysMagnificationEvents = "delaysMagnificationEvents";

	private static readonly IntPtr selDelaysMagnificationEventsHandle = Selector.GetHandle("delaysMagnificationEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysOtherMouseButtonEvents = "delaysOtherMouseButtonEvents";

	private static readonly IntPtr selDelaysOtherMouseButtonEventsHandle = Selector.GetHandle("delaysOtherMouseButtonEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysPrimaryMouseButtonEvents = "delaysPrimaryMouseButtonEvents";

	private static readonly IntPtr selDelaysPrimaryMouseButtonEventsHandle = Selector.GetHandle("delaysPrimaryMouseButtonEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysRotationEvents = "delaysRotationEvents";

	private static readonly IntPtr selDelaysRotationEventsHandle = Selector.GetHandle("delaysRotationEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelaysSecondaryMouseButtonEvents = "delaysSecondaryMouseButtonEvents";

	private static readonly IntPtr selDelaysSecondaryMouseButtonEventsHandle = Selector.GetHandle("delaysSecondaryMouseButtonEvents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlagsChanged_ = "flagsChanged:";

	private static readonly IntPtr selFlagsChanged_Handle = Selector.GetHandle("flagsChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTarget_Action_ = "initWithTarget:action:";

	private static readonly IntPtr selInitWithTarget_Action_Handle = Selector.GetHandle("initWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyDown_ = "keyDown:";

	private static readonly IntPtr selKeyDown_Handle = Selector.GetHandle("keyDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyUp_ = "keyUp:";

	private static readonly IntPtr selKeyUp_Handle = Selector.GetHandle("keyUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocationInView_ = "locationInView:";

	private static readonly IntPtr selLocationInView_Handle = Selector.GetHandle("locationInView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnifyWithEvent_ = "magnifyWithEvent:";

	private static readonly IntPtr selMagnifyWithEvent_Handle = Selector.GetHandle("magnifyWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDown_ = "mouseDown:";

	private static readonly IntPtr selMouseDown_Handle = Selector.GetHandle("mouseDown:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseDragged_ = "mouseDragged:";

	private static readonly IntPtr selMouseDragged_Handle = Selector.GetHandle("mouseDragged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMouseUp_ = "mouseUp:";

	private static readonly IntPtr selMouseUp_Handle = Selector.GetHandle("mouseUp:");

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
	private const string selPressureChangeWithEvent_ = "pressureChangeWithEvent:";

	private static readonly IntPtr selPressureChangeWithEvent_Handle = Selector.GetHandle("pressureChangeWithEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPressureConfiguration = "pressureConfiguration";

	private static readonly IntPtr selPressureConfigurationHandle = Selector.GetHandle("pressureConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

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
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysKeyEvents_ = "setDelaysKeyEvents:";

	private static readonly IntPtr selSetDelaysKeyEvents_Handle = Selector.GetHandle("setDelaysKeyEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysMagnificationEvents_ = "setDelaysMagnificationEvents:";

	private static readonly IntPtr selSetDelaysMagnificationEvents_Handle = Selector.GetHandle("setDelaysMagnificationEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysOtherMouseButtonEvents_ = "setDelaysOtherMouseButtonEvents:";

	private static readonly IntPtr selSetDelaysOtherMouseButtonEvents_Handle = Selector.GetHandle("setDelaysOtherMouseButtonEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysPrimaryMouseButtonEvents_ = "setDelaysPrimaryMouseButtonEvents:";

	private static readonly IntPtr selSetDelaysPrimaryMouseButtonEvents_Handle = Selector.GetHandle("setDelaysPrimaryMouseButtonEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysRotationEvents_ = "setDelaysRotationEvents:";

	private static readonly IntPtr selSetDelaysRotationEvents_Handle = Selector.GetHandle("setDelaysRotationEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelaysSecondaryMouseButtonEvents_ = "setDelaysSecondaryMouseButtonEvents:";

	private static readonly IntPtr selSetDelaysSecondaryMouseButtonEvents_Handle = Selector.GetHandle("setDelaysSecondaryMouseButtonEvents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPressureConfiguration_ = "setPressureConfiguration:";

	private static readonly IntPtr selSetPressureConfiguration_Handle = Selector.GetHandle("setPressureConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetState_ = "setState:";

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldBeRequiredToFailByGestureRecognizer_ = "shouldBeRequiredToFailByGestureRecognizer:";

	private static readonly IntPtr selShouldBeRequiredToFailByGestureRecognizer_Handle = Selector.GetHandle("shouldBeRequiredToFailByGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRequireFailureOfGestureRecognizer_ = "shouldRequireFailureOfGestureRecognizer:";

	private static readonly IntPtr selShouldRequireFailureOfGestureRecognizer_Handle = Selector.GetHandle("shouldRequireFailureOfGestureRecognizer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTabletPoint_ = "tabletPoint:";

	private static readonly IntPtr selTabletPoint_Handle = Selector.GetHandle("tabletPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

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
	private const string selView = "view";

	private static readonly IntPtr selViewHandle = Selector.GetHandle("view");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSGestureRecognizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysKeyEvents
	{
		[Export("delaysKeyEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysKeyEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysKeyEventsHandle);
		}
		[Export("setDelaysKeyEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysKeyEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysKeyEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysMagnificationEvents
	{
		[Export("delaysMagnificationEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysMagnificationEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysMagnificationEventsHandle);
		}
		[Export("setDelaysMagnificationEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysMagnificationEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysMagnificationEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysOtherMouseButtonEvents
	{
		[Export("delaysOtherMouseButtonEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysOtherMouseButtonEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysOtherMouseButtonEventsHandle);
		}
		[Export("setDelaysOtherMouseButtonEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysOtherMouseButtonEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysOtherMouseButtonEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysPrimaryMouseButtonEvents
	{
		[Export("delaysPrimaryMouseButtonEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysPrimaryMouseButtonEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysPrimaryMouseButtonEventsHandle);
		}
		[Export("setDelaysPrimaryMouseButtonEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysPrimaryMouseButtonEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysPrimaryMouseButtonEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysRotationEvents
	{
		[Export("delaysRotationEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysRotationEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysRotationEventsHandle);
		}
		[Export("setDelaysRotationEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysRotationEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysRotationEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DelaysSecondaryMouseButtonEvents
	{
		[Export("delaysSecondaryMouseButtonEvents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDelaysSecondaryMouseButtonEventsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDelaysSecondaryMouseButtonEventsHandle);
		}
		[Export("setDelaysSecondaryMouseButtonEvents:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDelaysSecondaryMouseButtonEvents_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDelaysSecondaryMouseButtonEvents_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSGestureRecognizerDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSGestureRecognizerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSPressureConfiguration PressureConfiguration
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("pressureConfiguration", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPressureConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selPressureConfigurationHandle));
			}
			return Runtime.GetNSObject<NSPressureConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPressureConfigurationHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setPressureConfiguration:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPressureConfiguration_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPressureConfiguration_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSGestureRecognizerState State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSGestureRecognizerState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSGestureRecognizerState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
		[Export("setState:")]
		[Advice("Only subclasses of 'NSGestureRecognizer' can set this property.")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetState_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView View
	{
		[Export("view")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSGestureRecognizerDelegate);

	public NSGestureEvent? ShouldAttemptToRecognize
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldAttemptToRecognize;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldAttemptToRecognize = value;
		}
	}

	public NSGesturesProbe? ShouldBeRequiredToFail
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldBeRequiredToFail;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldBeRequiredToFail = value;
		}
	}

	public NSGestureProbe? ShouldBegin
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldBegin;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldBegin = value;
		}
	}

	public NSGestureEvent? ShouldReceiveEvent
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldReceiveEvent;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldReceiveEvent = value;
		}
	}

	public NSTouchEvent? ShouldReceiveTouch
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldReceiveTouch;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldReceiveTouch = value;
		}
	}

	public NSGesturesProbe? ShouldRecognizeSimultaneously
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldRecognizeSimultaneously;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldRecognizeSimultaneously = value;
		}
	}

	public NSGesturesProbe? ShouldRequireFailure
	{
		get
		{
			return EnsureNSGestureRecognizerDelegate().shouldRequireFailure;
		}
		set
		{
			EnsureNSGestureRecognizerDelegate().shouldRequireFailure = value;
		}
	}

	public NSGestureRecognizer(Action action)
		: this(tsel, new ParameterlessDispatch(action))
	{
	}

	public NSGestureRecognizer(Selector sel, Token token)
		: this(token, sel)
	{
		recognizers = token;
		MarkDirty();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSGestureRecognizer()
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
	public NSGestureRecognizer(NSCoder coder)
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
	protected NSGestureRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSGestureRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTarget:action:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSGestureRecognizer(NSObject? target, Selector? action)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTarget_Action_Handle, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle), "initWithTarget:action:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTarget_Action_Handle, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle), "initWithTarget:action:");
		}
	}

	[Export("canBePreventedByGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanBePrevented(NSGestureRecognizer preventingGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (preventingGestureRecognizer == null)
		{
			throw new ArgumentNullException("preventingGestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanBePreventedByGestureRecognizer_Handle, preventingGestureRecognizer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanBePreventedByGestureRecognizer_Handle, preventingGestureRecognizer.Handle);
	}

	[Export("canPreventGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanPrevent(NSGestureRecognizer preventedGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (preventedGestureRecognizer == null)
		{
			throw new ArgumentNullException("preventedGestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanPreventGestureRecognizer_Handle, preventedGestureRecognizer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanPreventGestureRecognizer_Handle, preventedGestureRecognizer.Handle);
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

	[Export("flagsChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlagsChanged(NSEvent flagEvent)
	{
		NSApplication.EnsureUIThread();
		if (flagEvent == null)
		{
			throw new ArgumentNullException("flagEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlagsChanged_Handle, flagEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlagsChanged_Handle, flagEvent.Handle);
		}
	}

	[Export("keyDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void KeyDown(NSEvent keyEvent)
	{
		NSApplication.EnsureUIThread();
		if (keyEvent == null)
		{
			throw new ArgumentNullException("keyEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyDown_Handle, keyEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyDown_Handle, keyEvent.Handle);
		}
	}

	[Export("keyUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void KeyUp(NSEvent keyEvent)
	{
		NSApplication.EnsureUIThread();
		if (keyEvent == null)
		{
			throw new ArgumentNullException("keyEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selKeyUp_Handle, keyEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selKeyUp_Handle, keyEvent.Handle);
		}
	}

	[Export("locationInView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LocationInView(NSView? view)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_IntPtr(base.Handle, selLocationInView_Handle, view?.Handle ?? IntPtr.Zero);
		}
		return Messaging.CGPoint_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocationInView_Handle, view?.Handle ?? IntPtr.Zero);
	}

	[Export("magnifyWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Magnify(NSEvent magnifyEvent)
	{
		NSApplication.EnsureUIThread();
		if (magnifyEvent == null)
		{
			throw new ArgumentNullException("magnifyEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMagnifyWithEvent_Handle, magnifyEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMagnifyWithEvent_Handle, magnifyEvent.Handle);
		}
	}

	[Export("mouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDown(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDown_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDown_Handle, mouseEvent.Handle);
		}
	}

	[Export("mouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseDragged(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseDragged_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseDragged_Handle, mouseEvent.Handle);
		}
	}

	[Export("mouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MouseUp(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMouseUp_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMouseUp_Handle, mouseEvent.Handle);
		}
	}

	[Export("otherMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseDown(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDown_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDown_Handle, mouseEvent.Handle);
		}
	}

	[Export("otherMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseDragged(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseDragged_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseDragged_Handle, mouseEvent.Handle);
		}
	}

	[Export("otherMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OtherMouseUp(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOtherMouseUp_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOtherMouseUp_Handle, mouseEvent.Handle);
		}
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

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("rightMouseDown:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseDown(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDown_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDown_Handle, mouseEvent.Handle);
		}
	}

	[Export("rightMouseDragged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseDragged(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseDragged_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseDragged_Handle, mouseEvent.Handle);
		}
	}

	[Export("rightMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RightMouseUp(NSEvent mouseEvent)
	{
		NSApplication.EnsureUIThread();
		if (mouseEvent == null)
		{
			throw new ArgumentNullException("mouseEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRightMouseUp_Handle, mouseEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRightMouseUp_Handle, mouseEvent.Handle);
		}
	}

	[Export("rotateWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Rotate(NSEvent rotateEvent)
	{
		NSApplication.EnsureUIThread();
		if (rotateEvent == null)
		{
			throw new ArgumentNullException("rotateEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRotateWithEvent_Handle, rotateEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRotateWithEvent_Handle, rotateEvent.Handle);
		}
	}

	[Export("shouldBeRequiredToFailByGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldBeRequiredToFailByGestureRecognizer(NSGestureRecognizer otherGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (otherGestureRecognizer == null)
		{
			throw new ArgumentNullException("otherGestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldBeRequiredToFailByGestureRecognizer_Handle, otherGestureRecognizer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldBeRequiredToFailByGestureRecognizer_Handle, otherGestureRecognizer.Handle);
	}

	[Export("shouldRequireFailureOfGestureRecognizer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRequireFailureOfGestureRecognizer(NSGestureRecognizer otherGestureRecognizer)
	{
		NSApplication.EnsureUIThread();
		if (otherGestureRecognizer == null)
		{
			throw new ArgumentNullException("otherGestureRecognizer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldRequireFailureOfGestureRecognizer_Handle, otherGestureRecognizer.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldRequireFailureOfGestureRecognizer_Handle, otherGestureRecognizer.Handle);
	}

	[Export("tabletPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TabletPoint(NSEvent tabletEvent)
	{
		NSApplication.EnsureUIThread();
		if (tabletEvent == null)
		{
			throw new ArgumentNullException("tabletEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTabletPoint_Handle, tabletEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTabletPoint_Handle, tabletEvent.Handle);
		}
	}

	[Export("touchesBeganWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesBegan(NSEvent touchEvent)
	{
		NSApplication.EnsureUIThread();
		if (touchEvent == null)
		{
			throw new ArgumentNullException("touchEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesBeganWithEvent_Handle, touchEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesBeganWithEvent_Handle, touchEvent.Handle);
		}
	}

	[Export("touchesCancelledWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesCancelled(NSEvent touchEvent)
	{
		NSApplication.EnsureUIThread();
		if (touchEvent == null)
		{
			throw new ArgumentNullException("touchEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesCancelledWithEvent_Handle, touchEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesCancelledWithEvent_Handle, touchEvent.Handle);
		}
	}

	[Export("touchesEndedWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesEnded(NSEvent touchEvent)
	{
		NSApplication.EnsureUIThread();
		if (touchEvent == null)
		{
			throw new ArgumentNullException("touchEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesEndedWithEvent_Handle, touchEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesEndedWithEvent_Handle, touchEvent.Handle);
		}
	}

	[Export("touchesMovedWithEvent:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TouchesMoved(NSEvent touchEvent)
	{
		NSApplication.EnsureUIThread();
		if (touchEvent == null)
		{
			throw new ArgumentNullException("touchEvent");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTouchesMovedWithEvent_Handle, touchEvent.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesMovedWithEvent_Handle, touchEvent.Handle);
		}
	}

	internal virtual _NSGestureRecognizerDelegate CreateInternalEventDelegateType()
	{
		return new _NSGestureRecognizerDelegate();
	}

	internal _NSGestureRecognizerDelegate EnsureNSGestureRecognizerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSGestureRecognizerDelegate nSGestureRecognizerDelegate = Delegate as _NSGestureRecognizerDelegate;
		if (nSGestureRecognizerDelegate == null)
		{
			nSGestureRecognizerDelegate = (_NSGestureRecognizerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSGestureRecognizerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
