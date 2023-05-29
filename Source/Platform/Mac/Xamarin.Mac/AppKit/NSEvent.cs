using System;
using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[DebuggerTypeProxy(typeof(NSEventDebuggerProxy))]
[Register("NSEvent", true)]
public class NSEvent : NSObject
{
	private class NSEventDebuggerProxy
	{
		private NSEvent target;

		private const int TabletPointEventSubtype = 1;

		private const int TabletProximityEventSubtype = 2;

		internal NSGraphicsContext Context => target.Context;

		public CGPoint LocationInWindow => target.LocationInWindow;

		public NSEventModifierMask ModifierFlags => target.ModifierFlags;

		public double Timestamp => target.Timestamp;

		public NSEventType Type => target.Type;

		public NSWindow Window => target.Window;

		public long WindowNumber => target.WindowNumber;

		public IntPtr CGEvent => target.CGEvent;

		public string Characters
		{
			get
			{
				CheckKeyEvent();
				return target.Characters;
			}
		}

		public string CharactersIgnoringModifiers
		{
			get
			{
				CheckKeyEvent();
				return target.CharactersIgnoringModifiers;
			}
		}

		public bool IsARepeat
		{
			get
			{
				CheckKeyEvent();
				return target.IsARepeat;
			}
		}

		public ushort KeyCode
		{
			get
			{
				CheckKeyEvent();
				return target.KeyCode;
			}
		}

		public long AbsoluteX
		{
			get
			{
				CheckTabletPointingEvent();
				return target.AbsoluteX;
			}
		}

		public long AbsoluteY
		{
			get
			{
				CheckTabletPointingEvent();
				return target.AbsoluteY;
			}
		}

		public long AbsoluteZ
		{
			get
			{
				CheckTabletPointingEvent();
				return target.AbsoluteZ;
			}
		}

		public ulong ButtonMask
		{
			get
			{
				CheckTabletPointingEvent();
				return target.ButtonMask;
			}
		}

		public double Rotation
		{
			get
			{
				CheckTabletPointingEvent();
				return target.Rotation;
			}
		}

		public double TangentialPressure
		{
			get
			{
				CheckTabletPointingEvent();
				return target.TangentialPressure;
			}
		}

		public CGPoint Tilt
		{
			get
			{
				CheckTabletPointingEvent();
				return target.Tilt;
			}
		}

		public NSObject VendorDefined
		{
			get
			{
				CheckTabletPointingEvent();
				return target.VendorDefined;
			}
		}

		public long ButtonNumber
		{
			get
			{
				CheckMouseEvent();
				return target.ButtonNumber;
			}
		}

		public long ClickCount
		{
			get
			{
				CheckMouseEvent();
				return target.ClickCount;
			}
		}

		public double Pressure
		{
			get
			{
				CheckMouseEvent();
				return target.Pressure;
			}
		}

		internal long EventNumber
		{
			get
			{
				CheckMouseTrackingEvent();
				return target.EventNumber;
			}
		}

		internal long TrackingNumber
		{
			get
			{
				CheckMouseTrackingEvent();
				return target.TrackingNumber;
			}
		}

		internal NSTrackingArea TrackingArea
		{
			get
			{
				CheckMouseTrackingEvent();
				return target.TrackingArea;
			}
		}

		internal IntPtr UserData
		{
			get
			{
				CheckMouseTrackingEvent();
				return target.UserData;
			}
		}

		public short Subtype
		{
			get
			{
				CheckCustomEvent();
				return target.Subtype;
			}
		}

		public long Data1
		{
			get
			{
				CheckCustomEvent();
				return target.Data1;
			}
		}

		public long Data2
		{
			get
			{
				CheckCustomEvent();
				return target.Data1;
			}
		}

		public double DeltaX
		{
			get
			{
				CheckScrollWheelEvent();
				return target.Data1;
			}
		}

		public double DeltaY
		{
			get
			{
				CheckScrollWheelEvent();
				return target.Data1;
			}
		}

		public double DeltaZ
		{
			get
			{
				CheckScrollWheelEvent();
				return target.Data1;
			}
		}

		public ulong CapabilityMask
		{
			get
			{
				CheckTabletProximityEvent();
				return target.CapabilityMask;
			}
		}

		public ulong DeviceID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.DeviceID;
			}
		}

		public bool IsEnteringProximity
		{
			get
			{
				CheckTabletProximityEvent();
				return target.IsEnteringProximity;
			}
		}

		public ulong PointingDeviceSerialNumber
		{
			get
			{
				CheckTabletProximityEvent();
				return target.PointingDeviceSerialNumber;
			}
		}

		public ulong PointingDeviceID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.PointingDeviceID();
			}
		}

		public NSPointingDeviceType PointingDeviceType
		{
			get
			{
				CheckTabletProximityEvent();
				return target.PointingDeviceType;
			}
		}

		public ulong SystemTabletID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.SystemTabletID;
			}
		}

		public ulong TabletID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.TabletID;
			}
		}

		public long UniqueID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.UniqueID;
			}
		}

		public ulong VendorID
		{
			get
			{
				CheckTabletProximityEvent();
				return target.VendorID;
			}
		}

		public ulong VendorPointingDeviceType
		{
			get
			{
				CheckTabletProximityEvent();
				return target.VendorPointingDeviceType;
			}
		}

		internal double Magnification
		{
			get
			{
				CheckTouchOrGestureEvent();
				return target.Magnification;
			}
		}

		public bool HasPreciseScrollingDeltas
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.HasPreciseScrollingDeltas;
			}
		}

		public double ScrollingDeltaX
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.ScrollingDeltaX;
			}
		}

		public double ScrollingDeltaY
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.ScrollingDeltaY;
			}
		}

		public NSEventPhase MomentumPhase
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.MomentumPhase;
			}
		}

		public NSEventPhase Phase
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.Phase;
			}
		}

		public bool IsDirectionInvertedFromDevice
		{
			get
			{
				CheckScrollWheelOrFlickEvent();
				return target.IsDirectionInvertedFromDevice;
			}
		}

		public NSEventDebuggerProxy(NSEvent target)
		{
			this.target = target;
		}

		private bool IsKeyEvent()
		{
			NSEventType type = target.Type;
			if (type - 10 <= NSEventType.LeftMouseDown)
			{
				return true;
			}
			return false;
		}

		private void CheckKeyEvent()
		{
			if (IsKeyEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a key event.");
		}

		private bool IsMouseEvent()
		{
			NSEventType type = target.Type;
			if (type - 1 <= NSEventType.MouseEntered || type - 25 <= NSEventType.LeftMouseUp)
			{
				return true;
			}
			return false;
		}

		private bool IsTabletPointingEvent()
		{
			if (IsMouseEvent())
			{
				return target.Subtype == 1;
			}
			return target.Type == NSEventType.TabletPoint;
		}

		private void CheckTabletPointingEvent()
		{
			if (IsTabletPointingEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a tablet pointing event.");
		}

		private void CheckMouseEvent()
		{
			if (IsMouseEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a mouse event.");
		}

		private bool IsMouseTrackingEvent()
		{
			return false;
		}

		private void CheckMouseTrackingEvent()
		{
			if (IsMouseTrackingEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a mouse tracking event.");
		}

		private bool IsCustomEvent()
		{
			NSEventType type = target.Type;
			if (type - 13 <= NSEventType.RightMouseDown)
			{
				return true;
			}
			return false;
		}

		private void CheckCustomEvent()
		{
			if (IsCustomEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a custom event.");
		}

		private bool IsScrollWheelEvent()
		{
			NSEventType type = target.Type;
			if (type == NSEventType.ScrollWheel)
			{
				return true;
			}
			return false;
		}

		private void CheckScrollWheelEvent()
		{
			if (IsScrollWheelEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a scroll wheel event.");
		}

		private bool IsTabletProximityEvent()
		{
			if (IsMouseEvent())
			{
				return target.Subtype == 2;
			}
			return target.Type == NSEventType.TabletProximity;
		}

		private void CheckTabletProximityEvent()
		{
			if (IsTabletProximityEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a tablet proximity event.");
		}

		private bool IsTouchOrGestureEvent()
		{
			return false;
		}

		private void CheckTouchOrGestureEvent()
		{
			if (IsTouchOrGestureEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a touch or gesture event.");
		}

		private bool IsScrollWheelOrFlickEvent()
		{
			if (IsScrollWheelEvent())
			{
				return true;
			}
			return false;
		}

		private void CheckScrollWheelOrFlickEvent()
		{
			if (IsScrollWheelOrFlickEvent())
			{
				return;
			}
			throw new InvalidOperationException("Not a scroll wheel or flick event.");
		}
	}

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selModifierFlagsHandle = Selector.GetHandle("modifierFlags");

	private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	private static readonly IntPtr selWindowNumberHandle = Selector.GetHandle("windowNumber");

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	private static readonly IntPtr selClickCountHandle = Selector.GetHandle("clickCount");

	private static readonly IntPtr selButtonNumberHandle = Selector.GetHandle("buttonNumber");

	private static readonly IntPtr selEventNumberHandle = Selector.GetHandle("eventNumber");

	private static readonly IntPtr selPressureHandle = Selector.GetHandle("pressure");

	private static readonly IntPtr selLocationInWindowHandle = Selector.GetHandle("locationInWindow");

	private static readonly IntPtr selDeltaXHandle = Selector.GetHandle("deltaX");

	private static readonly IntPtr selDeltaYHandle = Selector.GetHandle("deltaY");

	private static readonly IntPtr selDeltaZHandle = Selector.GetHandle("deltaZ");

	private static readonly IntPtr selCharactersHandle = Selector.GetHandle("characters");

	private static readonly IntPtr selCharactersIgnoringModifiersHandle = Selector.GetHandle("charactersIgnoringModifiers");

	private static readonly IntPtr selIsARepeatHandle = Selector.GetHandle("isARepeat");

	private static readonly IntPtr selKeyCodeHandle = Selector.GetHandle("keyCode");

	private static readonly IntPtr selTrackingNumberHandle = Selector.GetHandle("trackingNumber");

	private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

	private static readonly IntPtr selTrackingAreaHandle = Selector.GetHandle("trackingArea");

	private static readonly IntPtr selSubtypeHandle = Selector.GetHandle("subtype");

	private static readonly IntPtr selData1Handle = Selector.GetHandle("data1");

	private static readonly IntPtr selData2Handle = Selector.GetHandle("data2");

	private static readonly IntPtr selCGEventHandle = Selector.GetHandle("CGEvent");

	private static readonly IntPtr selMagnificationHandle = Selector.GetHandle("magnification");

	private static readonly IntPtr selDeviceIDHandle = Selector.GetHandle("deviceID");

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	private static readonly IntPtr selAbsoluteXHandle = Selector.GetHandle("absoluteX");

	private static readonly IntPtr selAbsoluteYHandle = Selector.GetHandle("absoluteY");

	private static readonly IntPtr selAbsoluteZHandle = Selector.GetHandle("absoluteZ");

	private static readonly IntPtr selButtonMaskHandle = Selector.GetHandle("buttonMask");

	private static readonly IntPtr selTiltHandle = Selector.GetHandle("tilt");

	private static readonly IntPtr selTangentialPressureHandle = Selector.GetHandle("tangentialPressure");

	private static readonly IntPtr selVendorDefinedHandle = Selector.GetHandle("vendorDefined");

	private static readonly IntPtr selVendorIDHandle = Selector.GetHandle("vendorID");

	private static readonly IntPtr selTabletIDHandle = Selector.GetHandle("tabletID");

	private static readonly IntPtr selSystemTabletIDHandle = Selector.GetHandle("systemTabletID");

	private static readonly IntPtr selVendorPointingDeviceTypeHandle = Selector.GetHandle("vendorPointingDeviceType");

	private static readonly IntPtr selPointingDeviceSerialNumberHandle = Selector.GetHandle("pointingDeviceSerialNumber");

	private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

	private static readonly IntPtr selCapabilityMaskHandle = Selector.GetHandle("capabilityMask");

	private static readonly IntPtr selPointingDeviceTypeHandle = Selector.GetHandle("pointingDeviceType");

	private static readonly IntPtr selIsEnteringProximityHandle = Selector.GetHandle("isEnteringProximity");

	private static readonly IntPtr selMouseLocationHandle = Selector.GetHandle("mouseLocation");

	private static readonly IntPtr selPressedMouseButtonsHandle = Selector.GetHandle("pressedMouseButtons");

	private static readonly IntPtr selDoubleClickIntervalHandle = Selector.GetHandle("doubleClickInterval");

	private static readonly IntPtr selKeyRepeatDelayHandle = Selector.GetHandle("keyRepeatDelay");

	private static readonly IntPtr selKeyRepeatIntervalHandle = Selector.GetHandle("keyRepeatInterval");

	private static readonly IntPtr selIsMouseCoalescingEnabledHandle = Selector.GetHandle("isMouseCoalescingEnabled");

	private static readonly IntPtr selSetMouseCoalescingEnabled_Handle = Selector.GetHandle("setMouseCoalescingEnabled:");

	private static readonly IntPtr selHasPreciseScrollingDeltasHandle = Selector.GetHandle("hasPreciseScrollingDeltas");

	private static readonly IntPtr selScrollingDeltaXHandle = Selector.GetHandle("scrollingDeltaX");

	private static readonly IntPtr selScrollingDeltaYHandle = Selector.GetHandle("scrollingDeltaY");

	private static readonly IntPtr selMomentumPhaseHandle = Selector.GetHandle("momentumPhase");

	private static readonly IntPtr selIsDirectionInvertedFromDeviceHandle = Selector.GetHandle("isDirectionInvertedFromDevice");

	private static readonly IntPtr selPhaseHandle = Selector.GetHandle("phase");

	private static readonly IntPtr selIsSwipeTrackingFromScrollEventsEnabledHandle = Selector.GetHandle("isSwipeTrackingFromScrollEventsEnabled");

	private static readonly IntPtr selEventWithEventRef_Handle = Selector.GetHandle("eventWithEventRef:");

	private static readonly IntPtr selEventWithCGEvent_Handle = Selector.GetHandle("eventWithCGEvent:");

	private static readonly IntPtr selPointingDeviceIDHandle = Selector.GetHandle("pointingDeviceID");

	private static readonly IntPtr selTouchesMatchingPhaseInView_Handle = Selector.GetHandle("touchesMatchingPhase:inView:");

	private static readonly IntPtr selStartPeriodicEventsAfterDelayWithPeriod_Handle = Selector.GetHandle("startPeriodicEventsAfterDelay:withPeriod:");

	private static readonly IntPtr selStopPeriodicEventsHandle = Selector.GetHandle("stopPeriodicEvents");

	private static readonly IntPtr selMouseEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberClickCountPressure_Handle = Selector.GetHandle("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:");

	private static readonly IntPtr selKeyEventWithTypeLocationModifierFlagsTimestampWindowNumberContextCharactersCharactersIgnoringModifiersIsARepeatKeyCode_Handle = Selector.GetHandle("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:");

	private static readonly IntPtr selEnterExitEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberTrackingNumberUserData_Handle = Selector.GetHandle("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:");

	private static readonly IntPtr selOtherEventWithTypeLocationModifierFlagsTimestampWindowNumberContextSubtypeData1Data2_Handle = Selector.GetHandle("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:");

	private static readonly IntPtr selAddGlobalMonitorForEventsMatchingMaskHandler_Handle = Selector.GetHandle("addGlobalMonitorForEventsMatchingMask:handler:");

	private static readonly IntPtr selAddLocalMonitorForEventsMatchingMaskHandler_Handle = Selector.GetHandle("addLocalMonitorForEventsMatchingMask:handler:");

	private static readonly IntPtr selRemoveMonitor_Handle = Selector.GetHandle("removeMonitor:");

	private static readonly IntPtr selTrackSwipeEventWithOptionsDampenAmountThresholdMinMaxUsingHandler_Handle = Selector.GetHandle("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSEvent");

	private object __mt_Window_var;

	private object __mt_Context_var;

	private object __mt_TrackingArea_var;

	private object __mt_VendorDefined_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSEventType Type
	{
		[Export("type")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (NSEventType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	public virtual NSEventModifierMask ModifierFlags
	{
		[Export("modifierFlags")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selModifierFlagsHandle);
			}
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModifierFlagsHandle);
		}
	}

	public virtual double Timestamp
	{
		[Export("timestamp")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimestampHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimestampHandle);
		}
	}

	public virtual NSWindow Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_Window_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle)))));
		}
	}

	public virtual long WindowNumber
	{
		[Export("windowNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selWindowNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selWindowNumberHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSGraphicsContext Context
	{
		[Export("context")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSGraphicsContext)(__mt_Context_var = ((!IsDirectBinding) ? ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle))) : ((NSGraphicsContext)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle)))));
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long ClickCount
	{
		[Export("clickCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selClickCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClickCountHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long ButtonNumber
	{
		[Export("buttonNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selButtonNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selButtonNumberHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long EventNumber
	{
		[Export("eventNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selEventNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEventNumberHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double Pressure
	{
		[Export("pressure")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPressureHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPressureHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual CGPoint LocationInWindow
	{
		[Export("locationInWindow")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selLocationInWindowHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLocationInWindowHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double DeltaX
	{
		[Export("deltaX")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDeltaXHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDeltaXHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double DeltaY
	{
		[Export("deltaY")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDeltaYHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDeltaYHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double DeltaZ
	{
		[Export("deltaZ")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDeltaZHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDeltaZHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string Characters
	{
		[Export("characters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharactersHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharactersHandle));
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual string CharactersIgnoringModifiers
	{
		[Export("charactersIgnoringModifiers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharactersIgnoringModifiersHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharactersIgnoringModifiersHandle));
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool IsARepeat
	{
		[Export("isARepeat")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsARepeatHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsARepeatHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ushort KeyCode
	{
		[Export("keyCode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt16_objc_msgSend(base.Handle, selKeyCodeHandle);
			}
			return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selKeyCodeHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long TrackingNumber
	{
		[Export("trackingNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTrackingNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTrackingNumberHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual IntPtr UserData
	{
		[Export("userData")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSTrackingArea TrackingArea
	{
		[Export("trackingArea")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTrackingArea)(__mt_TrackingArea_var = ((!IsDirectBinding) ? ((NSTrackingArea)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackingAreaHandle))) : ((NSTrackingArea)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackingAreaHandle)))));
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual short Subtype
	{
		[Export("subtype")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.short_objc_msgSend(base.Handle, selSubtypeHandle);
			}
			return Messaging.short_objc_msgSendSuper(base.SuperHandle, selSubtypeHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long Data1
	{
		[Export("data1")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selData1Handle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selData1Handle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long Data2
	{
		[Export("data2")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selData2Handle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selData2Handle);
		}
	}

	public virtual IntPtr CGEvent
	{
		[Export("CGEvent")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selCGEventHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGEventHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double Magnification
	{
		[Export("magnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMagnificationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMagnificationHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong DeviceID
	{
		[Export("deviceID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selDeviceIDHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDeviceIDHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double Rotation
	{
		[Export("rotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long AbsoluteX
	{
		[Export("absoluteX")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selAbsoluteXHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAbsoluteXHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long AbsoluteY
	{
		[Export("absoluteY")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selAbsoluteYHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAbsoluteYHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long AbsoluteZ
	{
		[Export("absoluteZ")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selAbsoluteZHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAbsoluteZHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong ButtonMask
	{
		[Export("buttonMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selButtonMaskHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selButtonMaskHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual CGPoint Tilt
	{
		[Export("tilt")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selTiltHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTiltHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double TangentialPressure
	{
		[Export("tangentialPressure")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTangentialPressureHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTangentialPressureHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSObject VendorDefined
	{
		[Export("vendorDefined")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_VendorDefined_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVendorDefinedHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVendorDefinedHandle))));
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong VendorID
	{
		[Export("vendorID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selVendorIDHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVendorIDHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong TabletID
	{
		[Export("tabletID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selTabletIDHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTabletIDHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong SystemTabletID
	{
		[Export("systemTabletID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selSystemTabletIDHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSystemTabletIDHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong VendorPointingDeviceType
	{
		[Export("vendorPointingDeviceType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selVendorPointingDeviceTypeHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selVendorPointingDeviceTypeHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong PointingDeviceSerialNumber
	{
		[Export("pointingDeviceSerialNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selPointingDeviceSerialNumberHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPointingDeviceSerialNumberHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual long UniqueID
	{
		[Export("uniqueID")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selUniqueIDHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual ulong CapabilityMask
	{
		[Export("capabilityMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCapabilityMaskHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCapabilityMaskHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSPointingDeviceType PointingDeviceType
	{
		[Export("pointingDeviceType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSPointingDeviceType)Messaging.UInt64_objc_msgSend(base.Handle, selPointingDeviceTypeHandle);
			}
			return (NSPointingDeviceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPointingDeviceTypeHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool IsEnteringProximity
	{
		[Export("isEnteringProximity")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnteringProximityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnteringProximityHandle);
		}
	}

	public static CGPoint CurrentMouseLocation
	{
		[Export("mouseLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.CGPoint_objc_msgSend(class_ptr, selMouseLocationHandle);
		}
	}

	public static NSEventModifierMask CurrentModifierFlags
	{
		[Export("modifierFlags")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(class_ptr, selModifierFlagsHandle);
		}
	}

	public static ulong CurrentPressedMouseButtons
	{
		[Export("pressedMouseButtons")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.UInt64_objc_msgSend(class_ptr, selPressedMouseButtonsHandle);
		}
	}

	public static double DoubleClickInterval
	{
		[Export("doubleClickInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selDoubleClickIntervalHandle);
		}
	}

	public static double KeyRepeatDelay
	{
		[Export("keyRepeatDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selKeyRepeatDelayHandle);
		}
	}

	public static double KeyRepeatInterval
	{
		[Export("keyRepeatInterval")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Double_objc_msgSend(class_ptr, selKeyRepeatIntervalHandle);
		}
	}

	public static bool MouseCoalescingEnabled
	{
		[Export("isMouseCoalescingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsMouseCoalescingEnabledHandle);
		}
		[Export("setMouseCoalescingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(class_ptr, selSetMouseCoalescingEnabled_Handle, value);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool HasPreciseScrollingDeltas
	{
		[Export("hasPreciseScrollingDeltas")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasPreciseScrollingDeltasHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasPreciseScrollingDeltasHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double ScrollingDeltaX
	{
		[Export("scrollingDeltaX")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScrollingDeltaXHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScrollingDeltaXHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual double ScrollingDeltaY
	{
		[Export("scrollingDeltaY")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScrollingDeltaYHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScrollingDeltaYHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSEventPhase MomentumPhase
	{
		[Export("momentumPhase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventPhase)Messaging.UInt64_objc_msgSend(base.Handle, selMomentumPhaseHandle);
			}
			return (NSEventPhase)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMomentumPhaseHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual bool IsDirectionInvertedFromDevice
	{
		[Export("isDirectionInvertedFromDevice")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDirectionInvertedFromDeviceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDirectionInvertedFromDeviceHandle);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	public virtual NSEventPhase Phase
	{
		[Export("phase")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSEventPhase)Messaging.UInt64_objc_msgSend(base.Handle, selPhaseHandle);
			}
			return (NSEventPhase)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPhaseHandle);
		}
	}

	public static bool IsSwipeTrackingFromScrollEventsEnabled
	{
		[Export("isSwipeTrackingFromScrollEventsEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsSwipeTrackingFromScrollEventsEnabledHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEvent()
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
	public NSEvent(NSCoder coder)
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
	public NSEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEvent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("eventWithEventRef:")]
	public static NSEvent EventWithEventRef(IntPtr cgEventRef)
	{
		NSApplication.EnsureUIThread();
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEventWithEventRef_Handle, cgEventRef));
	}

	[Export("eventWithCGEvent:")]
	public static NSEvent EventWithCGEvent(IntPtr cgEventPtr)
	{
		NSApplication.EnsureUIThread();
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEventWithCGEvent_Handle, cgEventPtr));
	}

	[Export("pointingDeviceID")]
	public virtual ulong PointingDeviceID()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selPointingDeviceIDHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPointingDeviceIDHandle);
	}

	[Export("touchesMatchingPhase:inView:")]
	public virtual NSSet TouchesMatchingPhase(NSTouchPhase phase, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (IsDirectBinding)
		{
			return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selTouchesMatchingPhaseInView_Handle, (ulong)phase, view.Handle));
		}
		return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selTouchesMatchingPhaseInView_Handle, (ulong)phase, view.Handle));
	}

	[Export("startPeriodicEventsAfterDelay:withPeriod:")]
	public static void StartPeriodicEventsAfterDelay(double delay, double period)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Double_Double(class_ptr, selStartPeriodicEventsAfterDelayWithPeriod_Handle, delay, period);
	}

	[Export("stopPeriodicEvents")]
	public static void StopPeriodicEvents()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(class_ptr, selStopPeriodicEventsHandle);
	}

	[Export("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:")]
	public static NSEvent MouseEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, long wNum, NSGraphicsContext context, long eNum, long cNum, double pressure)
	{
		NSApplication.EnsureUIThread();
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_Double(class_ptr, selMouseEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberClickCountPressure_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, eNum, cNum, pressure));
	}

	[Export("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:")]
	public static NSEvent KeyEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, long wNum, NSGraphicsContext context, string keys, string ukeys, bool isARepeat, ushort code)
	{
		NSApplication.EnsureUIThread();
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (ukeys == null)
		{
			throw new ArgumentNullException("ukeys");
		}
		IntPtr arg = NSString.CreateNative(keys);
		IntPtr arg2 = NSString.CreateNative(ukeys);
		NSEvent result = (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_IntPtr_IntPtr_bool_UInt16(class_ptr, selKeyEventWithTypeLocationModifierFlagsTimestampWindowNumberContextCharactersCharactersIgnoringModifiersIsARepeatKeyCode_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, arg, arg2, isARepeat, code));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:")]
	public static NSEvent EnterExitEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, long wNum, NSGraphicsContext context, long eNum, long tNum, IntPtr data)
	{
		NSApplication.EnsureUIThread();
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_Int64_Int64_IntPtr(class_ptr, selEnterExitEventWithTypeLocationModifierFlagsTimestampWindowNumberContextEventNumberTrackingNumberUserData_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, eNum, tNum, data));
	}

	[Export("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:")]
	public static NSEvent OtherEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, long wNum, NSGraphicsContext context, short subtype, long d1, long d2)
	{
		NSApplication.EnsureUIThread();
		return (NSEvent)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_Int64_IntPtr_short_Int64_Int64(class_ptr, selOtherEventWithTypeLocationModifierFlagsTimestampWindowNumberContextSubtypeData1Data2_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, subtype, d1, d2));
	}

	[Export("addGlobalMonitorForEventsMatchingMask:handler:")]
	public unsafe static NSObject AddGlobalMonitorForEventsMatchingMask(NSEventMask mask, GlobalEventHandler handler)
	{
		NSApplication.EnsureUIThread();
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDGlobalEventHandler.Handler, handler);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(class_ptr, selAddGlobalMonitorForEventsMatchingMaskHandler_Handle, (ulong)mask, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("addLocalMonitorForEventsMatchingMask:handler:")]
	public unsafe static NSObject AddLocalMonitorForEventsMatchingMask(NSEventMask mask, LocalEventHandler handler)
	{
		NSApplication.EnsureUIThread();
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDLocalEventHandler.Handler, handler);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(class_ptr, selAddLocalMonitorForEventsMatchingMaskHandler_Handle, (ulong)mask, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("removeMonitor:")]
	public static void RemoveMonitor(NSObject eventMonitor)
	{
		NSApplication.EnsureUIThread();
		if (eventMonitor == null)
		{
			throw new ArgumentNullException("eventMonitor");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveMonitor_Handle, eventMonitor.Handle);
	}

	[Export("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:")]
	public unsafe virtual void TrackSwipeEvent(NSEventSwipeTrackingOptions options, double minDampenThreshold, double maxDampenThreshold, NSEventTrackHandler trackingHandler)
	{
		NSApplication.EnsureUIThread();
		if (trackingHandler == null)
		{
			throw new ArgumentNullException("trackingHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSEventTrackHandler.Handler, trackingHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Double_Double_IntPtr(base.Handle, selTrackSwipeEventWithOptionsDampenAmountThresholdMinMaxUsingHandler_Handle, (ulong)options, minDampenThreshold, maxDampenThreshold, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Double_Double_IntPtr(base.SuperHandle, selTrackSwipeEventWithOptionsDampenAmountThresholdMinMaxUsingHandler_Handle, (ulong)options, minDampenThreshold, maxDampenThreshold, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Window_var = null;
			__mt_Context_var = null;
			__mt_TrackingArea_var = null;
			__mt_VendorDefined_var = null;
		}
	}
}
