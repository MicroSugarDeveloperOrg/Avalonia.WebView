using System;
using System.ComponentModel;
using System.Diagnostics;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[DebuggerTypeProxy(typeof(NSEventDebuggerProxy))]
[Register("NSEvent", true)]
public class NSEvent : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
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

        public nint WindowNumber => target.WindowNumber;

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

        public nint AbsoluteX
        {
            get
            {
                CheckTabletPointingEvent();
                return target.AbsoluteX;
            }
        }

        public nint AbsoluteY
        {
            get
            {
                CheckTabletPointingEvent();
                return target.AbsoluteY;
            }
        }

        public nint AbsoluteZ
        {
            get
            {
                CheckTabletPointingEvent();
                return target.AbsoluteZ;
            }
        }

        public nuint ButtonMask
        {
            get
            {
                CheckTabletPointingEvent();
                return target.ButtonMask;
            }
        }

        public float Rotation
        {
            get
            {
                CheckTabletPointingEvent();
                return target.Rotation;
            }
        }

        public float TangentialPressure
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

        public nint ButtonNumber
        {
            get
            {
                CheckMouseEvent();
                return target.ButtonNumber;
            }
        }

        public nint ClickCount
        {
            get
            {
                CheckMouseEvent();
                return target.ClickCount;
            }
        }

        public float Pressure
        {
            get
            {
                CheckMouseEvent();
                return target.Pressure;
            }
        }

        internal nint EventNumber
        {
            get
            {
                CheckMouseTrackingEvent();
                return target.EventNumber;
            }
        }

        internal nint TrackingNumber
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

        public nint Data1
        {
            get
            {
                CheckCustomEvent();
                return target.Data1;
            }
        }

        public nint Data2
        {
            get
            {
                CheckCustomEvent();
                return target.Data1;
            }
        }

        public float DeltaX
        {
            get
            {
                CheckScrollWheelEvent();
                return target.Data1;
            }
        }

        public float DeltaY
        {
            get
            {
                CheckScrollWheelEvent();
                return target.Data1;
            }
        }

        public float DeltaZ
        {
            get
            {
                CheckScrollWheelEvent();
                return target.Data1;
            }
        }

        public nuint CapabilityMask
        {
            get
            {
                CheckTabletProximityEvent();
                return target.CapabilityMask;
            }
        }

        public nuint DeviceID
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

        public nuint PointingDeviceSerialNumber
        {
            get
            {
                CheckTabletProximityEvent();
                return target.PointingDeviceSerialNumber;
            }
        }

        public nuint PointingDeviceID
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

        public nuint SystemTabletID
        {
            get
            {
                CheckTabletProximityEvent();
                return target.SystemTabletID;
            }
        }

        public nuint TabletID
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

        public nuint VendorID
        {
            get
            {
                CheckTabletProximityEvent();
                return target.VendorID;
            }
        }

        public nuint VendorPointingDeviceType
        {
            get
            {
                CheckTabletProximityEvent();
                return target.VendorPointingDeviceType;
            }
        }

        internal nfloat Magnification
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

        public nfloat ScrollingDeltaX
        {
            get
            {
                CheckScrollWheelOrFlickEvent();
                return target.ScrollingDeltaX;
            }
        }

        public nfloat ScrollingDeltaY
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
            NSEventType nSEventType = type;
            if (nSEventType - 10 <= NSEventType.LeftMouseDown)
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
            NSEventType nSEventType = type;
            if (nSEventType - 1 <= NSEventType.MouseEntered || nSEventType - 25 <= NSEventType.LeftMouseUp)
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
            NSEventType nSEventType = type;
            if (nSEventType - 13 <= NSEventType.RightMouseDown)
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
            NSEventType nSEventType = type;
            if (nSEventType == NSEventType.ScrollWheel)
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

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCGEvent = "CGEvent";

    private static readonly IntPtr selCGEventHandle = Selector.GetHandle("CGEvent");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAbsoluteX = "absoluteX";

    private static readonly IntPtr selAbsoluteXHandle = Selector.GetHandle("absoluteX");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAbsoluteY = "absoluteY";

    private static readonly IntPtr selAbsoluteYHandle = Selector.GetHandle("absoluteY");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAbsoluteZ = "absoluteZ";

    private static readonly IntPtr selAbsoluteZHandle = Selector.GetHandle("absoluteZ");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAddGlobalMonitorForEventsMatchingMask_Handler_ = "addGlobalMonitorForEventsMatchingMask:handler:";

    private static readonly IntPtr selAddGlobalMonitorForEventsMatchingMask_Handler_Handle = Selector.GetHandle("addGlobalMonitorForEventsMatchingMask:handler:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAddLocalMonitorForEventsMatchingMask_Handler_ = "addLocalMonitorForEventsMatchingMask:handler:";

    private static readonly IntPtr selAddLocalMonitorForEventsMatchingMask_Handler_Handle = Selector.GetHandle("addLocalMonitorForEventsMatchingMask:handler:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAllTouches = "allTouches";

    private static readonly IntPtr selAllTouchesHandle = Selector.GetHandle("allTouches");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selAssociatedEventsMask = "associatedEventsMask";

    private static readonly IntPtr selAssociatedEventsMaskHandle = Selector.GetHandle("associatedEventsMask");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selButtonMask = "buttonMask";

    private static readonly IntPtr selButtonMaskHandle = Selector.GetHandle("buttonMask");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selButtonNumber = "buttonNumber";

    private static readonly IntPtr selButtonNumberHandle = Selector.GetHandle("buttonNumber");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCapabilityMask = "capabilityMask";

    private static readonly IntPtr selCapabilityMaskHandle = Selector.GetHandle("capabilityMask");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCharacters = "characters";

    private static readonly IntPtr selCharactersHandle = Selector.GetHandle("characters");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCharactersByApplyingModifiers_ = "charactersByApplyingModifiers:";

    private static readonly IntPtr selCharactersByApplyingModifiers_Handle = Selector.GetHandle("charactersByApplyingModifiers:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCharactersIgnoringModifiers = "charactersIgnoringModifiers";

    private static readonly IntPtr selCharactersIgnoringModifiersHandle = Selector.GetHandle("charactersIgnoringModifiers");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selClickCount = "clickCount";

    private static readonly IntPtr selClickCountHandle = Selector.GetHandle("clickCount");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCoalescedTouchesForTouch_ = "coalescedTouchesForTouch:";

    private static readonly IntPtr selCoalescedTouchesForTouch_Handle = Selector.GetHandle("coalescedTouchesForTouch:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selContext = "context";

    private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selData1 = "data1";

    private static readonly IntPtr selData1Handle = Selector.GetHandle("data1");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selData2 = "data2";

    private static readonly IntPtr selData2Handle = Selector.GetHandle("data2");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDeltaX = "deltaX";

    private static readonly IntPtr selDeltaXHandle = Selector.GetHandle("deltaX");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDeltaY = "deltaY";

    private static readonly IntPtr selDeltaYHandle = Selector.GetHandle("deltaY");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDeltaZ = "deltaZ";

    private static readonly IntPtr selDeltaZHandle = Selector.GetHandle("deltaZ");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDeviceID = "deviceID";

    private static readonly IntPtr selDeviceIDHandle = Selector.GetHandle("deviceID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDoubleClickInterval = "doubleClickInterval";

    private static readonly IntPtr selDoubleClickIntervalHandle = Selector.GetHandle("doubleClickInterval");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_ = "enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:";

    private static readonly IntPtr selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_Handle = Selector.GetHandle("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEventNumber = "eventNumber";

    private static readonly IntPtr selEventNumberHandle = Selector.GetHandle("eventNumber");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEventRef = "eventRef";

    private static readonly IntPtr selEventRefHandle = Selector.GetHandle("eventRef");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEventWithCGEvent_ = "eventWithCGEvent:";

    private static readonly IntPtr selEventWithCGEvent_Handle = Selector.GetHandle("eventWithCGEvent:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEventWithEventRef_ = "eventWithEventRef:";

    private static readonly IntPtr selEventWithEventRef_Handle = Selector.GetHandle("eventWithEventRef:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasPreciseScrollingDeltas = "hasPreciseScrollingDeltas";

    private static readonly IntPtr selHasPreciseScrollingDeltasHandle = Selector.GetHandle("hasPreciseScrollingDeltas");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsARepeat = "isARepeat";

    private static readonly IntPtr selIsARepeatHandle = Selector.GetHandle("isARepeat");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsDirectionInvertedFromDevice = "isDirectionInvertedFromDevice";

    private static readonly IntPtr selIsDirectionInvertedFromDeviceHandle = Selector.GetHandle("isDirectionInvertedFromDevice");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsEnteringProximity = "isEnteringProximity";

    private static readonly IntPtr selIsEnteringProximityHandle = Selector.GetHandle("isEnteringProximity");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsMouseCoalescingEnabled = "isMouseCoalescingEnabled";

    private static readonly IntPtr selIsMouseCoalescingEnabledHandle = Selector.GetHandle("isMouseCoalescingEnabled");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsSwipeTrackingFromScrollEventsEnabled = "isSwipeTrackingFromScrollEventsEnabled";

    private static readonly IntPtr selIsSwipeTrackingFromScrollEventsEnabledHandle = Selector.GetHandle("isSwipeTrackingFromScrollEventsEnabled");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selKeyCode = "keyCode";

    private static readonly IntPtr selKeyCodeHandle = Selector.GetHandle("keyCode");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_ = "keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:";

    private static readonly IntPtr selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_Handle = Selector.GetHandle("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selKeyRepeatDelay = "keyRepeatDelay";

    private static readonly IntPtr selKeyRepeatDelayHandle = Selector.GetHandle("keyRepeatDelay");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selKeyRepeatInterval = "keyRepeatInterval";

    private static readonly IntPtr selKeyRepeatIntervalHandle = Selector.GetHandle("keyRepeatInterval");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocationInWindow = "locationInWindow";

    private static readonly IntPtr selLocationInWindowHandle = Selector.GetHandle("locationInWindow");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMagnification = "magnification";

    private static readonly IntPtr selMagnificationHandle = Selector.GetHandle("magnification");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selModifierFlags = "modifierFlags";

    private static readonly IntPtr selModifierFlagsHandle = Selector.GetHandle("modifierFlags");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMomentumPhase = "momentumPhase";

    private static readonly IntPtr selMomentumPhaseHandle = Selector.GetHandle("momentumPhase");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_ = "mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:";

    private static readonly IntPtr selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_Handle = Selector.GetHandle("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMouseLocation = "mouseLocation";

    private static readonly IntPtr selMouseLocationHandle = Selector.GetHandle("mouseLocation");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_ = "otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:";

    private static readonly IntPtr selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_Handle = Selector.GetHandle("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPhase = "phase";

    private static readonly IntPtr selPhaseHandle = Selector.GetHandle("phase");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPointingDeviceID = "pointingDeviceID";

    private static readonly IntPtr selPointingDeviceIDHandle = Selector.GetHandle("pointingDeviceID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPointingDeviceSerialNumber = "pointingDeviceSerialNumber";

    private static readonly IntPtr selPointingDeviceSerialNumberHandle = Selector.GetHandle("pointingDeviceSerialNumber");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPointingDeviceType = "pointingDeviceType";

    private static readonly IntPtr selPointingDeviceTypeHandle = Selector.GetHandle("pointingDeviceType");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPressedMouseButtons = "pressedMouseButtons";

    private static readonly IntPtr selPressedMouseButtonsHandle = Selector.GetHandle("pressedMouseButtons");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPressure = "pressure";

    private static readonly IntPtr selPressureHandle = Selector.GetHandle("pressure");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selRemoveMonitor_ = "removeMonitor:";

    private static readonly IntPtr selRemoveMonitor_Handle = Selector.GetHandle("removeMonitor:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selRotation = "rotation";

    private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selScrollingDeltaX = "scrollingDeltaX";

    private static readonly IntPtr selScrollingDeltaXHandle = Selector.GetHandle("scrollingDeltaX");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selScrollingDeltaY = "scrollingDeltaY";

    private static readonly IntPtr selScrollingDeltaYHandle = Selector.GetHandle("scrollingDeltaY");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSetMouseCoalescingEnabled_ = "setMouseCoalescingEnabled:";

    private static readonly IntPtr selSetMouseCoalescingEnabled_Handle = Selector.GetHandle("setMouseCoalescingEnabled:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStage = "stage";

    private static readonly IntPtr selStageHandle = Selector.GetHandle("stage");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStageTransition = "stageTransition";

    private static readonly IntPtr selStageTransitionHandle = Selector.GetHandle("stageTransition");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStartPeriodicEventsAfterDelay_WithPeriod_ = "startPeriodicEventsAfterDelay:withPeriod:";

    private static readonly IntPtr selStartPeriodicEventsAfterDelay_WithPeriod_Handle = Selector.GetHandle("startPeriodicEventsAfterDelay:withPeriod:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStopPeriodicEvents = "stopPeriodicEvents";

    private static readonly IntPtr selStopPeriodicEventsHandle = Selector.GetHandle("stopPeriodicEvents");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSubtype = "subtype";

    private static readonly IntPtr selSubtypeHandle = Selector.GetHandle("subtype");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSystemTabletID = "systemTabletID";

    private static readonly IntPtr selSystemTabletIDHandle = Selector.GetHandle("systemTabletID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTabletID = "tabletID";

    private static readonly IntPtr selTabletIDHandle = Selector.GetHandle("tabletID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTangentialPressure = "tangentialPressure";

    private static readonly IntPtr selTangentialPressureHandle = Selector.GetHandle("tangentialPressure");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTilt = "tilt";

    private static readonly IntPtr selTiltHandle = Selector.GetHandle("tilt");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTimestamp = "timestamp";

    private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTouchesForView_ = "touchesForView:";

    private static readonly IntPtr selTouchesForView_Handle = Selector.GetHandle("touchesForView:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTouchesMatchingPhase_InView_ = "touchesMatchingPhase:inView:";

    private static readonly IntPtr selTouchesMatchingPhase_InView_Handle = Selector.GetHandle("touchesMatchingPhase:inView:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_ = "trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:";

    private static readonly IntPtr selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_Handle = Selector.GetHandle("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTrackingArea = "trackingArea";

    private static readonly IntPtr selTrackingAreaHandle = Selector.GetHandle("trackingArea");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selTrackingNumber = "trackingNumber";

    private static readonly IntPtr selTrackingNumberHandle = Selector.GetHandle("trackingNumber");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selType = "type";

    private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUniqueID = "uniqueID";

    private static readonly IntPtr selUniqueIDHandle = Selector.GetHandle("uniqueID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUserData = "userData";

    private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVendorDefined = "vendorDefined";

    private static readonly IntPtr selVendorDefinedHandle = Selector.GetHandle("vendorDefined");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVendorID = "vendorID";

    private static readonly IntPtr selVendorIDHandle = Selector.GetHandle("vendorID");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVendorPointingDeviceType = "vendorPointingDeviceType";

    private static readonly IntPtr selVendorPointingDeviceTypeHandle = Selector.GetHandle("vendorPointingDeviceType");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWindow = "window";

    private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWindowNumber = "windowNumber";

    private static readonly IntPtr selWindowNumberHandle = Selector.GetHandle("windowNumber");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSEvent");

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint AbsoluteX
    {
        [Export("absoluteX")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selAbsoluteXHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAbsoluteXHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint AbsoluteY
    {
        [Export("absoluteY")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selAbsoluteYHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAbsoluteYHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint AbsoluteZ
    {
        [Export("absoluteZ")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selAbsoluteZHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAbsoluteZHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
    public virtual NSSet<NSTouch> AllTouches
    {
        [Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
        [Export("allTouches")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSSet<NSTouch>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllTouchesHandle));
            }
            return Runtime.GetNSObject<NSSet<NSTouch>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllTouchesHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
    public virtual NSEventMask AssociatedEventsMask
    {
        [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
        [Export("associatedEventsMask")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSEventMask)Messaging.UInt64_objc_msgSend(base.Handle, selAssociatedEventsMaskHandle);
            }
            return (NSEventMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAssociatedEventsMaskHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint ButtonMask
    {
        [Export("buttonMask")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selButtonMaskHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selButtonMaskHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint ButtonNumber
    {
        [Export("buttonNumber")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selButtonNumberHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selButtonNumberHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual IntPtr CGEvent
    {
        [Export("CGEvent")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.IntPtr_objc_msgSend(base.Handle, selCGEventHandle);
            }
            return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGEventHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint CapabilityMask
    {
        [Export("capabilityMask")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selCapabilityMaskHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCapabilityMaskHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual string Characters
    {
        [Export("characters")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharactersHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharactersHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual string CharactersIgnoringModifiers
    {
        [Export("charactersIgnoringModifiers")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharactersIgnoringModifiersHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharactersIgnoringModifiersHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint ClickCount
    {
        [Export("clickCount")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selClickCountHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClickCountHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, "This method always returns null. If you need access to the current drawing context, use NSGraphicsContext.CurrentContext inside of a draw operation.")]
    public virtual NSGraphicsContext Context
    {
        [Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, "This method always returns null. If you need access to the current drawing context, use NSGraphicsContext.CurrentContext inside of a draw operation.")]
        [Export("context")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selContextHandle));
            }
            return Runtime.GetNSObject<NSGraphicsContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContextHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEventModifierMask CurrentModifierFlags
    {
        [Export("modifierFlags")]
        get
        {
            NSApplication.EnsureUIThread();
            return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(class_ptr, selModifierFlagsHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static CGPoint CurrentMouseLocation
    {
        [Export("mouseLocation")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.CGPoint_objc_msgSend(class_ptr, selMouseLocationHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static nuint CurrentPressedMouseButtons
    {
        [Export("pressedMouseButtons")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.nuint_objc_msgSend(class_ptr, selPressedMouseButtonsHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint Data1
    {
        [Export("data1")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selData1Handle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selData1Handle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint Data2
    {
        [Export("data2")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selData2Handle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selData2Handle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat DeltaX
    {
        [Export("deltaX")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selDeltaXHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDeltaXHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat DeltaY
    {
        [Export("deltaY")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selDeltaYHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDeltaYHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat DeltaZ
    {
        [Export("deltaZ")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selDeltaZHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDeltaZHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint DeviceID
    {
        [Export("deviceID")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selDeviceIDHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDeviceIDHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static double DoubleClickInterval
    {
        [Export("doubleClickInterval")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.Double_objc_msgSend(class_ptr, selDoubleClickIntervalHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint EventNumber
    {
        [Export("eventNumber")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selEventNumberHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selEventNumberHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual IntPtr EventRef
    {
        [Export("eventRef")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.IntPtr_objc_msgSend(base.Handle, selEventRefHandle);
            }
            return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEventRefHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool HasPreciseScrollingDeltas
    {
        [Export("hasPreciseScrollingDeltas")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selHasPreciseScrollingDeltasHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasPreciseScrollingDeltasHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsARepeat
    {
        [Export("isARepeat")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsARepeatHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsARepeatHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsDirectionInvertedFromDevice
    {
        [Export("isDirectionInvertedFromDevice")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsDirectionInvertedFromDeviceHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDirectionInvertedFromDeviceHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsEnteringProximity
    {
        [Export("isEnteringProximity")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsEnteringProximityHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnteringProximityHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static bool IsSwipeTrackingFromScrollEventsEnabled
    {
        [Export("isSwipeTrackingFromScrollEventsEnabled")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.bool_objc_msgSend(class_ptr, selIsSwipeTrackingFromScrollEventsEnabledHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual ushort KeyCode
    {
        [Export("keyCode")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.UInt16_objc_msgSend(base.Handle, selKeyCodeHandle);
            }
            return Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selKeyCodeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static double KeyRepeatDelay
    {
        [Export("keyRepeatDelay")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.Double_objc_msgSend(class_ptr, selKeyRepeatDelayHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static double KeyRepeatInterval
    {
        [Export("keyRepeatInterval")]
        get
        {
            NSApplication.EnsureUIThread();
            return Messaging.Double_objc_msgSend(class_ptr, selKeyRepeatIntervalHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual CGPoint LocationInWindow
    {
        [Export("locationInWindow")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.CGPoint_objc_msgSend(base.Handle, selLocationInWindowHandle);
            }
            return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLocationInWindowHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat Magnification
    {
        [Export("magnification")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selMagnificationHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMagnificationHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSEventModifierMask ModifierFlags
    {
        [Export("modifierFlags")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSEventModifierMask)Messaging.UInt64_objc_msgSend(base.Handle, selModifierFlagsHandle);
            }
            return (NSEventModifierMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selModifierFlagsHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual NSEventPhase MomentumPhase
    {
        [Export("momentumPhase")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSEventPhase)Messaging.UInt64_objc_msgSend(base.Handle, selMomentumPhaseHandle);
            }
            return (NSEventPhase)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMomentumPhaseHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual NSEventPhase Phase
    {
        [Export("phase")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSEventPhase)Messaging.UInt64_objc_msgSend(base.Handle, selPhaseHandle);
            }
            return (NSEventPhase)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPhaseHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint PointingDeviceSerialNumber
    {
        [Export("pointingDeviceSerialNumber")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selPointingDeviceSerialNumberHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPointingDeviceSerialNumberHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual NSPointingDeviceType PointingDeviceType
    {
        [Export("pointingDeviceType")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSPointingDeviceType)Messaging.UInt64_objc_msgSend(base.Handle, selPointingDeviceTypeHandle);
            }
            return (NSPointingDeviceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPointingDeviceTypeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual float Pressure
    {
        [Export("pressure")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.float_objc_msgSend(base.Handle, selPressureHandle);
            }
            return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPressureHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual float Rotation
    {
        [Export("rotation")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.float_objc_msgSend(base.Handle, selRotationHandle);
            }
            return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat ScrollingDeltaX
    {
        [Export("scrollingDeltaX")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selScrollingDeltaXHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScrollingDeltaXHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nfloat ScrollingDeltaY
    {
        [Export("scrollingDeltaY")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selScrollingDeltaYHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selScrollingDeltaYHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
    public virtual nint Stage
    {
        [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
        [Export("stage")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selStageHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selStageHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
    public virtual nfloat StageTransition
    {
        [Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
        [Export("stageTransition")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nfloat_objc_msgSend(base.Handle, selStageTransitionHandle);
            }
            return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStageTransitionHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual short Subtype
    {
        [Export("subtype")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.short_objc_msgSend(base.Handle, selSubtypeHandle);
            }
            return Messaging.short_objc_msgSendSuper(base.SuperHandle, selSubtypeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint SystemTabletID
    {
        [Export("systemTabletID")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selSystemTabletIDHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSystemTabletIDHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint TabletID
    {
        [Export("tabletID")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selTabletIDHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTabletIDHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual float TangentialPressure
    {
        [Export("tangentialPressure")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.float_objc_msgSend(base.Handle, selTangentialPressureHandle);
            }
            return Messaging.float_objc_msgSendSuper(base.SuperHandle, selTangentialPressureHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual CGPoint Tilt
    {
        [Export("tilt")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.CGPoint_objc_msgSend(base.Handle, selTiltHandle);
            }
            return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTiltHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual double Timestamp
    {
        [Export("timestamp")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.Double_objc_msgSend(base.Handle, selTimestampHandle);
            }
            return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimestampHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual NSTrackingArea TrackingArea
    {
        [Export("trackingArea")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSTrackingArea>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrackingAreaHandle));
            }
            return Runtime.GetNSObject<NSTrackingArea>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrackingAreaHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nint TrackingNumber
    {
        [Export("trackingNumber")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selTrackingNumberHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selTrackingNumberHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSEventType Type
    {
        [Export("type")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return (NSEventType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
            }
            return (NSEventType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual long UniqueID
    {
        [Export("uniqueID")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.Int64_objc_msgSend(base.Handle, selUniqueIDHandle);
            }
            return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUniqueIDHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual IntPtr UserData
    {
        [Export("userData")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle);
            }
            return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual NSObject VendorDefined
    {
        [Export("vendorDefined")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVendorDefinedHandle));
            }
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVendorDefinedHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint VendorID
    {
        [Export("vendorID")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selVendorIDHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVendorIDHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual nuint VendorPointingDeviceType
    {
        [Export("vendorPointingDeviceType")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nuint_objc_msgSend(base.Handle, selVendorPointingDeviceTypeHandle);
            }
            return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVendorPointingDeviceTypeHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSWindow Window
    {
        [Export("window")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle));
            }
            return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nint WindowNumber
    {
        [Export("windowNumber")]
        get
        {
            NSApplication.EnsureUIThread();
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selWindowNumberHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWindowNumberHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSEvent()
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
    public NSEvent(NSCoder coder)
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
    protected NSEvent(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSEvent(IntPtr handle)
        : base(handle)
    {
    }

    [Export("addGlobalMonitorForEventsMatchingMask:handler:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe static NSObject AddGlobalMonitorForEventsMatchingMask(NSEventMask mask, [BlockProxy(typeof(Trampolines.NIDGlobalEventHandler))] GlobalEventHandler handler)
    {
        NSApplication.EnsureUIThread();
        if (handler == null)
        {
            throw new ArgumentNullException("handler");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlockUnsafe(Trampolines.SDGlobalEventHandler.Handler, handler);
        NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(class_ptr, selAddGlobalMonitorForEventsMatchingMask_Handler_Handle, (ulong)mask, (IntPtr)ptr));
        ptr->CleanupBlock();
        return nSObject;
    }

    [Export("addLocalMonitorForEventsMatchingMask:handler:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe static NSObject AddLocalMonitorForEventsMatchingMask(NSEventMask mask, [BlockProxy(typeof(Trampolines.NIDLocalEventHandler))] LocalEventHandler handler)
    {
        NSApplication.EnsureUIThread();
        if (handler == null)
        {
            throw new ArgumentNullException("handler");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlockUnsafe(Trampolines.SDLocalEventHandler.Handler, handler);
        NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(class_ptr, selAddLocalMonitorForEventsMatchingMask_Handler_Handle, (ulong)mask, (IntPtr)ptr));
        ptr->CleanupBlock();
        return nSObject;
    }

    [Export("copyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSApplication.EnsureUIThread();
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
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

    [Export("enterExitEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:trackingNumber:userData:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent EnterExitEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, nint eNum, nint tNum, IntPtr data)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_nint_IntPtr_nint_nint_IntPtr(class_ptr, selEnterExitEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_TrackingNumber_UserData_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, eNum, tNum, data));
    }

    [Export("eventWithCGEvent:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent EventWithCGEvent(IntPtr cgEventPtr)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEventWithCGEvent_Handle, cgEventPtr));
    }

    [Export("eventWithEventRef:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent EventWithEventRef(IntPtr cgEventRef)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEventWithEventRef_Handle, cgEventRef));
    }

    [Export("charactersByApplyingModifiers:")]
    [Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string? GetCharacters(NSEventModifierFlags modifiers)
    {
        NSApplication.EnsureUIThread();
        if (base.IsDirectBinding)
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selCharactersByApplyingModifiers_Handle, (ulong)modifiers));
        }
        return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selCharactersByApplyingModifiers_Handle, (ulong)modifiers));
    }

    [Export("coalescedTouchesForTouch:")]
    [Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSTouch[] GetCoalescedTouches(NSTouch touch)
    {
        NSApplication.EnsureUIThread();
        if (touch == null)
        {
            throw new ArgumentNullException("touch");
        }
        if (base.IsDirectBinding)
        {
            return NSArray.ArrayFromHandle<NSTouch>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCoalescedTouchesForTouch_Handle, touch.Handle));
        }
        return NSArray.ArrayFromHandle<NSTouch>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCoalescedTouchesForTouch_Handle, touch.Handle));
    }

    [Export("touchesForView:")]
    [Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSSet<NSTouch> GetTouches(NSView view)
    {
        NSApplication.EnsureUIThread();
        if (view == null)
        {
            throw new ArgumentNullException("view");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSSet<NSTouch>>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTouchesForView_Handle, view.Handle));
        }
        return Runtime.GetNSObject<NSSet<NSTouch>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTouchesForView_Handle, view.Handle));
    }

    [Export("keyEventWithType:location:modifierFlags:timestamp:windowNumber:context:characters:charactersIgnoringModifiers:isARepeat:keyCode:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent KeyEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, string keys, string ukeys, bool isARepeat, ushort code)
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
        NSEvent nSObject = Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_nint_IntPtr_IntPtr_IntPtr_bool_UInt16(class_ptr, selKeyEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Characters_CharactersIgnoringModifiers_IsARepeat_KeyCode_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, arg, arg2, isARepeat, code));
        NSString.ReleaseNative(arg);
        NSString.ReleaseNative(arg2);
        return nSObject;
    }

    [Export("mouseEventWithType:location:modifierFlags:timestamp:windowNumber:context:eventNumber:clickCount:pressure:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent MouseEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, nint eNum, nint cNum, float pressure)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_nint_IntPtr_nint_nint_float(class_ptr, selMouseEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_EventNumber_ClickCount_Pressure_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, eNum, cNum, pressure));
    }

    [Export("otherEventWithType:location:modifierFlags:timestamp:windowNumber:context:subtype:data1:data2:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSEvent OtherEvent(NSEventType type, CGPoint location, NSEventModifierMask flags, double time, nint wNum, NSGraphicsContext? context, short subtype, nint d1, nint d2)
    {
        NSApplication.EnsureUIThread();
        return Runtime.GetNSObject<NSEvent>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_UInt64_Double_nint_IntPtr_short_nint_nint(class_ptr, selOtherEventWithType_Location_ModifierFlags_Timestamp_WindowNumber_Context_Subtype_Data1_Data2_Handle, (ulong)type, location, (ulong)flags, time, wNum, context?.Handle ?? IntPtr.Zero, subtype, d1, d2));
    }

    [Export("pointingDeviceID")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nuint PointingDeviceID()
    {
        NSApplication.EnsureUIThread();
        if (base.IsDirectBinding)
        {
            return Messaging.nuint_objc_msgSend(base.Handle, selPointingDeviceIDHandle);
        }
        return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPointingDeviceIDHandle);
    }

    [Export("removeMonitor:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static void RemoveMonitor(NSObject eventMonitor)
    {
        NSApplication.EnsureUIThread();
        if (eventMonitor == null)
        {
            throw new ArgumentNullException("eventMonitor");
        }
        Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveMonitor_Handle, eventMonitor.Handle);
    }

    [Export("startPeriodicEventsAfterDelay:withPeriod:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static void StartPeriodicEventsAfterDelay(double delay, double period)
    {
        NSApplication.EnsureUIThread();
        Messaging.void_objc_msgSend_Double_Double(class_ptr, selStartPeriodicEventsAfterDelay_WithPeriod_Handle, delay, period);
    }

    [Export("stopPeriodicEvents")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static void StopPeriodicEvents()
    {
        NSApplication.EnsureUIThread();
        Messaging.void_objc_msgSend(class_ptr, selStopPeriodicEventsHandle);
    }

    [Export("touchesMatchingPhase:inView:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSSet TouchesMatchingPhase(NSTouchPhase phase, NSView view)
    {
        NSApplication.EnsureUIThread();
        if (view == null)
        {
            throw new ArgumentNullException("view");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selTouchesMatchingPhase_InView_Handle, (ulong)phase, view.Handle));
        }
        return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selTouchesMatchingPhase_InView_Handle, (ulong)phase, view.Handle));
    }

    [Export("trackSwipeEventWithOptions:dampenAmountThresholdMin:max:usingHandler:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe virtual void TrackSwipeEvent(NSEventSwipeTrackingOptions options, nfloat minDampenThreshold, nfloat maxDampenThreshold, [BlockProxy(typeof(Trampolines.NIDNSEventTrackHandler))] NSEventTrackHandler trackingHandler)
    {
        NSApplication.EnsureUIThread();
        if (trackingHandler == null)
        {
            throw new ArgumentNullException("trackingHandler");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlockUnsafe(Trampolines.SDNSEventTrackHandler.Handler, trackingHandler);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64_nfloat_nfloat_IntPtr(base.Handle, selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_Handle, (ulong)options, minDampenThreshold, maxDampenThreshold, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64_nfloat_nfloat_IntPtr(base.SuperHandle, selTrackSwipeEventWithOptions_DampenAmountThresholdMin_Max_UsingHandler_Handle, (ulong)options, minDampenThreshold, maxDampenThreshold, (IntPtr)ptr);
        }
        ptr->CleanupBlock();
    }
}
