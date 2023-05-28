using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRulerView", true)]
public class NSRulerView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMarker_ = "addMarker:";

	private static readonly IntPtr selAddMarker_Handle = Selector.GetHandle("addMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaselineLocation = "baselineLocation";

	private static readonly IntPtr selBaselineLocationHandle = Selector.GetHandle("baselineLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientView = "clientView";

	private static readonly IntPtr selClientViewHandle = Selector.GetHandle("clientView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawHashMarksAndLabelsInRect_ = "drawHashMarksAndLabelsInRect:";

	private static readonly IntPtr selDrawHashMarksAndLabelsInRect_Handle = Selector.GetHandle("drawHashMarksAndLabelsInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawMarkersInRect_ = "drawMarkersInRect:";

	private static readonly IntPtr selDrawMarkersInRect_Handle = Selector.GetHandle("drawMarkersInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithScrollView_Orientation_ = "initWithScrollView:orientation:";

	private static readonly IntPtr selInitWithScrollView_Orientation_Handle = Selector.GetHandle("initWithScrollView:orientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateHashMarks = "invalidateHashMarks";

	private static readonly IntPtr selInvalidateHashMarksHandle = Selector.GetHandle("invalidateHashMarks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlipped = "isFlipped";

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMarkers = "markers";

	private static readonly IntPtr selMarkersHandle = Selector.GetHandle("markers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeasurementUnits = "measurementUnits";

	private static readonly IntPtr selMeasurementUnitsHandle = Selector.GetHandle("measurementUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveRulerlineFromLocation_ToLocation_ = "moveRulerlineFromLocation:toLocation:";

	private static readonly IntPtr selMoveRulerlineFromLocation_ToLocation_Handle = Selector.GetHandle("moveRulerlineFromLocation:toLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientation = "orientation";

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginOffset = "originOffset";

	private static readonly IntPtr selOriginOffsetHandle = Selector.GetHandle("originOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterUnitWithName_Abbreviation_UnitToPointsConversionFactor_StepUpCycle_StepDownCycle_ = "registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:";

	private static readonly IntPtr selRegisterUnitWithName_Abbreviation_UnitToPointsConversionFactor_StepUpCycle_StepDownCycle_Handle = Selector.GetHandle("registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveMarker_ = "removeMarker:";

	private static readonly IntPtr selRemoveMarker_Handle = Selector.GetHandle("removeMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiredThickness = "requiredThickness";

	private static readonly IntPtr selRequiredThicknessHandle = Selector.GetHandle("requiredThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReservedThicknessForAccessoryView = "reservedThicknessForAccessoryView";

	private static readonly IntPtr selReservedThicknessForAccessoryViewHandle = Selector.GetHandle("reservedThicknessForAccessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReservedThicknessForMarkers = "reservedThicknessForMarkers";

	private static readonly IntPtr selReservedThicknessForMarkersHandle = Selector.GetHandle("reservedThicknessForMarkers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRuleThickness = "ruleThickness";

	private static readonly IntPtr selRuleThicknessHandle = Selector.GetHandle("ruleThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollView = "scrollView";

	private static readonly IntPtr selScrollViewHandle = Selector.GetHandle("scrollView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClientView_ = "setClientView:";

	private static readonly IntPtr selSetClientView_Handle = Selector.GetHandle("setClientView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMarkers_ = "setMarkers:";

	private static readonly IntPtr selSetMarkers_Handle = Selector.GetHandle("setMarkers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMeasurementUnits_ = "setMeasurementUnits:";

	private static readonly IntPtr selSetMeasurementUnits_Handle = Selector.GetHandle("setMeasurementUnits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrientation_ = "setOrientation:";

	private static readonly IntPtr selSetOrientation_Handle = Selector.GetHandle("setOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOriginOffset_ = "setOriginOffset:";

	private static readonly IntPtr selSetOriginOffset_Handle = Selector.GetHandle("setOriginOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReservedThicknessForAccessoryView_ = "setReservedThicknessForAccessoryView:";

	private static readonly IntPtr selSetReservedThicknessForAccessoryView_Handle = Selector.GetHandle("setReservedThicknessForAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReservedThicknessForMarkers_ = "setReservedThicknessForMarkers:";

	private static readonly IntPtr selSetReservedThicknessForMarkers_Handle = Selector.GetHandle("setReservedThicknessForMarkers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRuleThickness_ = "setRuleThickness:";

	private static readonly IntPtr selSetRuleThickness_Handle = Selector.GetHandle("setRuleThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollView_ = "setScrollView:";

	private static readonly IntPtr selSetScrollView_Handle = Selector.GetHandle("setScrollView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackMarker_WithMouseEvent_ = "trackMarker:withMouseEvent:";

	private static readonly IntPtr selTrackMarker_WithMouseEvent_Handle = Selector.GetHandle("trackMarker:withMouseEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRulerView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ClientView_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ScrollView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? AccessoryView
	{
		[Export("accessoryView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle));
		}
		[Export("setAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BaselineLocation
	{
		[Export("baselineLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBaselineLocationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBaselineLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView ClientView
	{
		[Export("clientView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSView nSView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientViewHandle)) : Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientViewHandle)));
			MarkDirty();
			__mt_ClientView_var = nSView;
			return nSView;
		}
		[Export("setClientView:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClientView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClientView_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ClientView_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool IsFlipped
	{
		[Export("isFlipped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRulerMarker[]? Markers
	{
		[Export("markers", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSRulerMarker>(Messaging.IntPtr_objc_msgSend(base.Handle, selMarkersHandle));
			}
			return NSArray.ArrayFromHandle<NSRulerMarker>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMarkersHandle));
		}
		[Export("setMarkers:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMarkers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMarkers_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MeasurementUnits
	{
		[Export("measurementUnits")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRulerOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSRulerOrientation)Messaging.UInt64_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (NSRulerOrientation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
		[Export("setOrientation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat OriginOffset
	{
		[Export("originOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selOriginOffsetHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selOriginOffsetHandle);
		}
		[Export("setOriginOffset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetOriginOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetOriginOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RequiredThickness
	{
		[Export("requiredThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRequiredThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRequiredThicknessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ReservedThicknessForAccessoryView
	{
		[Export("reservedThicknessForAccessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selReservedThicknessForAccessoryViewHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selReservedThicknessForAccessoryViewHandle);
		}
		[Export("setReservedThicknessForAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetReservedThicknessForAccessoryView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetReservedThicknessForAccessoryView_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat ReservedThicknessForMarkers
	{
		[Export("reservedThicknessForMarkers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selReservedThicknessForMarkersHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selReservedThicknessForMarkersHandle);
		}
		[Export("setReservedThicknessForMarkers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetReservedThicknessForMarkers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetReservedThicknessForMarkers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RuleThickness
	{
		[Export("ruleThickness")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRuleThicknessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRuleThicknessHandle);
		}
		[Export("setRuleThickness:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRuleThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRuleThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrollView ScrollView
	{
		[Export("scrollView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSScrollView nSScrollView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrollViewHandle)) : Runtime.GetNSObject<NSScrollView>(Messaging.IntPtr_objc_msgSend(base.Handle, selScrollViewHandle)));
			MarkDirty();
			__mt_ScrollView_var = nSScrollView;
			return nSScrollView;
		}
		[Export("setScrollView:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrollView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrollView_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ScrollView_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRulerView()
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
	public NSRulerView(NSCoder coder)
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
	protected NSRulerView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRulerView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRulerView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("initWithScrollView:orientation:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRulerView(NSScrollView scrollView, NSRulerOrientation orientation)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (scrollView == null)
		{
			throw new ArgumentNullException("scrollView");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithScrollView_Orientation_Handle, scrollView.Handle, (ulong)orientation), "initWithScrollView:orientation:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithScrollView_Orientation_Handle, scrollView.Handle, (ulong)orientation), "initWithScrollView:orientation:");
		}
	}

	[Export("addMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddMarker(NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddMarker_Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddMarker_Handle, marker.Handle);
		}
	}

	[Export("drawHashMarksAndLabelsInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawHashMarksAndLabels(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawHashMarksAndLabelsInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawHashMarksAndLabelsInRect_Handle, rect);
		}
	}

	[Export("drawMarkersInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawMarkers(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawMarkersInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawMarkersInRect_Handle, rect);
		}
	}

	[Export("invalidateHashMarks")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateHashMarks()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHashMarksHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHashMarksHandle);
		}
	}

	[Export("moveRulerlineFromLocation:toLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveRulerline(nfloat oldLocation, nfloat newLocation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nfloat(base.Handle, selMoveRulerlineFromLocation_ToLocation_Handle, oldLocation, newLocation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selMoveRulerlineFromLocation_ToLocation_Handle, oldLocation, newLocation);
		}
	}

	[Export("registerUnitWithName:abbreviation:unitToPointsConversionFactor:stepUpCycle:stepDownCycle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RegisterUnit(string unitName, string abbreviation, nfloat conversionFactor, NSNumber[] stepUpCycle, NSNumber[] stepDownCycle)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nfloat_IntPtr_IntPtr(class_ptr, selRegisterUnitWithName_Abbreviation_UnitToPointsConversionFactor_StepUpCycle_StepDownCycle_Handle, arg, arg2, conversionFactor, nSArray.Handle, nSArray2.Handle);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("removeMarker:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveMarker(NSRulerMarker marker)
	{
		NSApplication.EnsureUIThread();
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveMarker_Handle, marker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveMarker_Handle, marker.Handle);
		}
	}

	[Export("trackMarker:withMouseEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selTrackMarker_WithMouseEvent_Handle, marker.Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTrackMarker_WithMouseEvent_Handle, marker.Handle, theEvent.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ClientView_var = null;
			__mt_ScrollView_var = null;
		}
	}
}
