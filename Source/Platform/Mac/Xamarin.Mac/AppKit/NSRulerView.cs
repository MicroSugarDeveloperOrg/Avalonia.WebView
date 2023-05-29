using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRulerView", true)]
public class NSRulerView : NSView
{
	private static readonly IntPtr selBaselineLocationHandle = Selector.GetHandle("baselineLocation");

	private static readonly IntPtr selRequiredThicknessHandle = Selector.GetHandle("requiredThickness");

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	private static readonly IntPtr selScrollViewHandle = Selector.GetHandle("scrollView");

	private static readonly IntPtr selSetScrollView_Handle = Selector.GetHandle("setScrollView:");

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	private static readonly IntPtr selRuleThicknessHandle = Selector.GetHandle("ruleThickness");

	private static readonly IntPtr selSetRuleThickness_Handle = Selector.GetHandle("setRuleThickness:");

	private static readonly IntPtr selReservedThicknessForMarkersHandle = Selector.GetHandle("reservedThicknessForMarkers");

	private static readonly IntPtr selSetReservedThicknessForMarkers_Handle = Selector.GetHandle("setReservedThicknessForMarkers:");

	private static readonly IntPtr selReservedThicknessForAccessoryViewHandle = Selector.GetHandle("reservedThicknessForAccessoryView");

	private static readonly IntPtr selSetReservedThicknessForAccessoryView_Handle = Selector.GetHandle("setReservedThicknessForAccessoryView:");

	private static readonly IntPtr selMeasurementUnitsHandle = Selector.GetHandle("measurementUnits");

	private static readonly IntPtr selSetMeasurementUnits_Handle = Selector.GetHandle("setMeasurementUnits:");

	private static readonly IntPtr selOriginOffsetHandle = Selector.GetHandle("originOffset");

	private static readonly IntPtr selSetOriginOffset_Handle = Selector.GetHandle("setOriginOffset:");

	private static readonly IntPtr selClientViewHandle = Selector.GetHandle("clientView");

	private static readonly IntPtr selSetClientView_Handle = Selector.GetHandle("setClientView:");

	private static readonly IntPtr selMarkersHandle = Selector.GetHandle("markers");

	private static readonly IntPtr selSetMarkers_Handle = Selector.GetHandle("setMarkers:");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selRegisterUnitWithNameAbbreviationUnitToPointsConversionFactorStepUpCycleStepDownCycle_Handle = Selector.GetHandle("registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:");

	private static readonly IntPtr selInitWithScrollViewOrientation_Handle = Selector.GetHandle("initWithScrollView:orientation:");

	private static readonly IntPtr selAddMarker_Handle = Selector.GetHandle("addMarker:");

	private static readonly IntPtr selRemoveMarker_Handle = Selector.GetHandle("removeMarker:");

	private static readonly IntPtr selTrackMarkerWithMouseEvent_Handle = Selector.GetHandle("trackMarker:withMouseEvent:");

	private static readonly IntPtr selMoveRulerlineFromLocationToLocation_Handle = Selector.GetHandle("moveRulerlineFromLocation:toLocation:");

	private static readonly IntPtr selInvalidateHashMarksHandle = Selector.GetHandle("invalidateHashMarks");

	private static readonly IntPtr selDrawHashMarksAndLabelsInRect_Handle = Selector.GetHandle("drawHashMarksAndLabelsInRect:");

	private static readonly IntPtr selDrawMarkersInRect_Handle = Selector.GetHandle("drawMarkersInRect:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSRulerView");

	private object __mt_ScrollView_var;

	private object __mt_ClientView_var;

	private object __mt_Markers_var;

	private object __mt_AccessoryView_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual double BaselineLocation
	{
		[Export("baselineLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBaselineLocationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBaselineLocationHandle);
		}
	}

	public virtual double RequiredThickness
	{
		[Export("requiredThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRequiredThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRequiredThicknessHandle);
		}
	}

	public new virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	public virtual NSScrollView ScrollView
	{
		[Export("scrollView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScrollView)(__mt_ScrollView_var = ((!IsDirectBinding) ? ((NSScrollView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrollViewHandle))) : ((NSScrollView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selScrollViewHandle)))));
		}
		[Export("setScrollView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrollView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrollView_Handle, value.Handle);
			}
			__mt_ScrollView_var = value;
		}
	}

	public virtual NSRulerOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSRulerOrientation)Messaging.int_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (NSRulerOrientation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetOrientation_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetOrientation_Handle, (int)value);
			}
		}
	}

	public virtual double RuleThickness
	{
		[Export("ruleThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRuleThicknessHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRuleThicknessHandle);
		}
		[Export("setRuleThickness:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetRuleThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetRuleThickness_Handle, value);
			}
		}
	}

	public virtual double ReservedThicknessForMarkers
	{
		[Export("reservedThicknessForMarkers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selReservedThicknessForMarkersHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selReservedThicknessForMarkersHandle);
		}
		[Export("setReservedThicknessForMarkers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetReservedThicknessForMarkers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetReservedThicknessForMarkers_Handle, value);
			}
		}
	}

	public virtual double ReservedThicknessForAccessoryView
	{
		[Export("reservedThicknessForAccessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selReservedThicknessForAccessoryViewHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selReservedThicknessForAccessoryViewHandle);
		}
		[Export("setReservedThicknessForAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetReservedThicknessForAccessoryView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetReservedThicknessForAccessoryView_Handle, value);
			}
		}
	}

	public virtual string MeasurementUnits
	{
		[Export("measurementUnits")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMeasurementUnitsHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMeasurementUnitsHandle));
		}
		[Export("setMeasurementUnits:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMeasurementUnits_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMeasurementUnits_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual double OriginOffset
	{
		[Export("originOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selOriginOffsetHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selOriginOffsetHandle);
		}
		[Export("setOriginOffset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetOriginOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetOriginOffset_Handle, value);
			}
		}
	}

	public virtual NSView ClientView
	{
		[Export("clientView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_ClientView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selClientViewHandle)))));
		}
		[Export("setClientView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClientView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClientView_Handle, value.Handle);
			}
			__mt_ClientView_var = value;
		}
	}

	public virtual NSRulerMarker[] Markers
	{
		[Export("markers")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSRulerMarker[])(__mt_Markers_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSRulerMarker>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkersHandle)) : NSArray.ArrayFromHandle<NSRulerMarker>(Messaging.IntPtr_objc_msgSend(base.Handle, selMarkersHandle))));
		}
		[Export("setMarkers:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarkers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarkers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
			__mt_Markers_var = value;
		}
	}

	public virtual NSView AccessoryView
	{
		[Export("accessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_AccessoryView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle)))));
		}
		[Export("setAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_AccessoryView_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRulerView()
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
	public NSRulerView(NSCoder coder)
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
	public NSRulerView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSRulerView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSRulerView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:")]
	public static void RegisterUnit(string unitName, string abbreviation, double conversionFactor, NSNumber[] stepUpCycle, NSNumber[] stepDownCycle)
	{
		NSApplication.EnsureUIThread();
		if (unitName == null)
		{
			throw new ArgumentNullException("unitName");
		}
		if (abbreviation == null)
		{
			throw new ArgumentNullException("abbreviation");
		}
		if (stepUpCycle == null)
		{
			throw new ArgumentNullException("stepUpCycle");
		}
		if (stepDownCycle == null)
		{
			throw new ArgumentNullException("stepDownCycle");
		}
		IntPtr arg = NSString.CreateNative(unitName);
		IntPtr arg2 = NSString.CreateNative(abbreviation);
		NSArray nSArray = NSArray.FromNSObjects(stepUpCycle);
		NSArray nSArray2 = NSArray.FromNSObjects(stepDownCycle);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr_IntPtr(class_ptr, selRegisterUnitWithNameAbbreviationUnitToPointsConversionFactorStepUpCycleStepDownCycle_Handle, arg, arg2, conversionFactor, nSArray.Handle, nSArray2.Handle);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("initWithScrollView:orientation:")]
	public NSRulerView(NSScrollView scrollView, NSRulerOrientation orientation)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (scrollView == null)
		{
			throw new ArgumentNullException("scrollView");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_int(base.Handle, selInitWithScrollViewOrientation_Handle, scrollView.Handle, (int)orientation);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInitWithScrollViewOrientation_Handle, scrollView.Handle, (int)orientation);
		}
	}

	[Export("addMarker:")]
	public virtual void AddMarker(NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddMarker_Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddMarker_Handle, marker.Handle);
		}
		_ = Markers;
	}

	[Export("removeMarker:")]
	public virtual void RemoveMarker(NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveMarker_Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveMarker_Handle, marker.Handle);
		}
		_ = Markers;
	}

	[Export("trackMarker:withMouseEvent:")]
	public virtual bool TrackMarker(NSRulerMarker marker, NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTrackMarkerWithMouseEvent_Handle, marker.Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTrackMarkerWithMouseEvent_Handle, marker.Handle, theEvent.Handle);
	}

	[Export("moveRulerlineFromLocation:toLocation:")]
	public virtual void MoveRulerline(double oldLocation, double newLocation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double(base.Handle, selMoveRulerlineFromLocationToLocation_Handle, oldLocation, newLocation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double(base.SuperHandle, selMoveRulerlineFromLocationToLocation_Handle, oldLocation, newLocation);
		}
	}

	[Export("invalidateHashMarks")]
	public virtual void InvalidateHashMarks()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHashMarksHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHashMarksHandle);
		}
	}

	[Export("drawHashMarksAndLabelsInRect:")]
	public virtual void DrawHashMarksAndLabels(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawHashMarksAndLabelsInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawHashMarksAndLabelsInRect_Handle, rect);
		}
	}

	[Export("drawMarkersInRect:")]
	public virtual void DrawMarkers(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawMarkersInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawMarkersInRect_Handle, rect);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ScrollView_var = null;
			__mt_ClientView_var = null;
			__mt_Markers_var = null;
			__mt_AccessoryView_var = null;
		}
	}
}
