using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSegmentedControl", true)]
public class NSSegmentedControl : NSControl, INSUserInterfaceCompression, INativeObject, IDisposable
{
	private NSActionDispatcher dispatcher;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveCompressionOptions = "activeCompressionOptions";

	private static readonly IntPtr selActiveCompressionOptionsHandle = Selector.GetHandle("activeCompressionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentForSegment_ = "alignmentForSegment:";

	private static readonly IntPtr selAlignmentForSegment_Handle = Selector.GetHandle("alignmentForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompressWithPrioritizedCompressionOptions_ = "compressWithPrioritizedCompressionOptions:";

	private static readonly IntPtr selCompressWithPrioritizedCompressionOptions_Handle = Selector.GetHandle("compressWithPrioritizedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValueForSelectedSegment = "doubleValueForSelectedSegment";

	private static readonly IntPtr selDoubleValueForSelectedSegmentHandle = Selector.GetHandle("doubleValueForSelectedSegment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageForSegment_ = "imageForSegment:";

	private static readonly IntPtr selImageForSegment_Handle = Selector.GetHandle("imageForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageScalingForSegment_ = "imageScalingForSegment:";

	private static readonly IntPtr selImageScalingForSegment_Handle = Selector.GetHandle("imageScalingForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabledForSegment_ = "isEnabledForSegment:";

	private static readonly IntPtr selIsEnabledForSegment_Handle = Selector.GetHandle("isEnabledForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectedForSegment_ = "isSelectedForSegment:";

	private static readonly IntPtr selIsSelectedForSegment_Handle = Selector.GetHandle("isSelectedForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSpringLoaded = "isSpringLoaded";

	private static readonly IntPtr selIsSpringLoadedHandle = Selector.GetHandle("isSpringLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelForSegment_ = "labelForSegment:";

	private static readonly IntPtr selLabelForSegment_Handle = Selector.GetHandle("labelForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuForSegment_ = "menuForSegment:";

	private static readonly IntPtr selMenuForSegment_Handle = Selector.GetHandle("menuForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumSizeWithPrioritizedCompressionOptions_ = "minimumSizeWithPrioritizedCompressionOptions:";

	private static readonly IntPtr selMinimumSizeWithPrioritizedCompressionOptions_Handle = Selector.GetHandle("minimumSizeWithPrioritizedCompressionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentCount = "segmentCount";

	private static readonly IntPtr selSegmentCountHandle = Selector.GetHandle("segmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentDistribution = "segmentDistribution";

	private static readonly IntPtr selSegmentDistributionHandle = Selector.GetHandle("segmentDistribution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentStyle = "segmentStyle";

	private static readonly IntPtr selSegmentStyleHandle = Selector.GetHandle("segmentStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentedControlWithImages_TrackingMode_Target_Action_ = "segmentedControlWithImages:trackingMode:target:action:";

	private static readonly IntPtr selSegmentedControlWithImages_TrackingMode_Target_Action_Handle = Selector.GetHandle("segmentedControlWithImages:trackingMode:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentedControlWithLabels_TrackingMode_Target_Action_ = "segmentedControlWithLabels:trackingMode:target:action:";

	private static readonly IntPtr selSegmentedControlWithLabels_TrackingMode_Target_Action_Handle = Selector.GetHandle("segmentedControlWithLabels:trackingMode:target:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectSegmentWithTag_ = "selectSegmentWithTag:";

	private static readonly IntPtr selSelectSegmentWithTag_Handle = Selector.GetHandle("selectSegmentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedSegment = "selectedSegment";

	private static readonly IntPtr selSelectedSegmentHandle = Selector.GetHandle("selectedSegment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedSegmentBezelColor = "selectedSegmentBezelColor";

	private static readonly IntPtr selSelectedSegmentBezelColorHandle = Selector.GetHandle("selectedSegmentBezelColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_ForSegment_ = "setAlignment:forSegment:";

	private static readonly IntPtr selSetAlignment_ForSegment_Handle = Selector.GetHandle("setAlignment:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ForSegment_ = "setEnabled:forSegment:";

	private static readonly IntPtr selSetEnabled_ForSegment_Handle = Selector.GetHandle("setEnabled:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImage_ForSegment_ = "setImage:forSegment:";

	private static readonly IntPtr selSetImage_ForSegment_Handle = Selector.GetHandle("setImage:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageScaling_ForSegment_ = "setImageScaling:forSegment:";

	private static readonly IntPtr selSetImageScaling_ForSegment_Handle = Selector.GetHandle("setImageScaling:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ForSegment_ = "setLabel:forSegment:";

	private static readonly IntPtr selSetLabel_ForSegment_Handle = Selector.GetHandle("setLabel:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMenu_ForSegment_ = "setMenu:forSegment:";

	private static readonly IntPtr selSetMenu_ForSegment_Handle = Selector.GetHandle("setMenu:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSegmentCount_ = "setSegmentCount:";

	private static readonly IntPtr selSetSegmentCount_Handle = Selector.GetHandle("setSegmentCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSegmentDistribution_ = "setSegmentDistribution:";

	private static readonly IntPtr selSetSegmentDistribution_Handle = Selector.GetHandle("setSegmentDistribution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSegmentStyle_ = "setSegmentStyle:";

	private static readonly IntPtr selSetSegmentStyle_Handle = Selector.GetHandle("setSegmentStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_ForSegment_ = "setSelected:forSegment:";

	private static readonly IntPtr selSetSelected_ForSegment_Handle = Selector.GetHandle("setSelected:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedSegment_ = "setSelectedSegment:";

	private static readonly IntPtr selSetSelectedSegment_Handle = Selector.GetHandle("setSelectedSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedSegmentBezelColor_ = "setSelectedSegmentBezelColor:";

	private static readonly IntPtr selSetSelectedSegmentBezelColor_Handle = Selector.GetHandle("setSelectedSegmentBezelColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsMenuIndicator_ForSegment_ = "setShowsMenuIndicator:forSegment:";

	private static readonly IntPtr selSetShowsMenuIndicator_ForSegment_Handle = Selector.GetHandle("setShowsMenuIndicator:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpringLoaded_ = "setSpringLoaded:";

	private static readonly IntPtr selSetSpringLoaded_Handle = Selector.GetHandle("setSpringLoaded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTag_ForSegment_ = "setTag:forSegment:";

	private static readonly IntPtr selSetTag_ForSegment_Handle = Selector.GetHandle("setTag:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolTip_ForSegment_ = "setToolTip:forSegment:";

	private static readonly IntPtr selSetToolTip_ForSegment_Handle = Selector.GetHandle("setToolTip:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrackingMode_ = "setTrackingMode:";

	private static readonly IntPtr selSetTrackingMode_Handle = Selector.GetHandle("setTrackingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidth_ForSegment_ = "setWidth:forSegment:";

	private static readonly IntPtr selSetWidth_ForSegment_Handle = Selector.GetHandle("setWidth:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsMenuIndicatorForSegment_ = "showsMenuIndicatorForSegment:";

	private static readonly IntPtr selShowsMenuIndicatorForSegment_Handle = Selector.GetHandle("showsMenuIndicatorForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagForSegment_ = "tagForSegment:";

	private static readonly IntPtr selTagForSegment_Handle = Selector.GetHandle("tagForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selToolTipForSegment_ = "toolTipForSegment:";

	private static readonly IntPtr selToolTipForSegment_Handle = Selector.GetHandle("toolTipForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackingMode = "trackingMode";

	private static readonly IntPtr selTrackingModeHandle = Selector.GetHandle("trackingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthForSegment_ = "widthForSegment:";

	private static readonly IntPtr selWidthForSegment_Handle = Selector.GetHandle("widthForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSegmentedControl");

	public new NSSegmentedCell Cell
	{
		get
		{
			return (NSSegmentedCell)base.Cell;
		}
		set
		{
			base.Cell = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSUserInterfaceCompressionOptions ActiveCompressionOptions
	{
		[Export("activeCompressionOptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveCompressionOptionsHandle));
			}
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveCompressionOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	public virtual bool IsSpringLoaded
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("isSpringLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpringLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpringLoadedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("setSpringLoaded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSpringLoaded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSpringLoaded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SegmentCount
	{
		[Export("segmentCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSegmentCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSegmentCountHandle);
		}
		[Export("setSegmentCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSegmentCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSegmentCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSSegmentDistribution SegmentDistribution
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("segmentDistribution", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSegmentDistribution)Messaging.Int64_objc_msgSend(base.Handle, selSegmentDistributionHandle);
			}
			return (NSSegmentDistribution)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSegmentDistributionHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("setSegmentDistribution:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSegmentDistribution_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSegmentDistribution_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSegmentStyle SegmentStyle
	{
		[Export("segmentStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSegmentStyle)Messaging.Int64_objc_msgSend(base.Handle, selSegmentStyleHandle);
			}
			return (NSSegmentStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSegmentStyleHandle);
		}
		[Export("setSegmentStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSegmentStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSegmentStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedSegment
	{
		[Export("selectedSegment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedSegmentHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedSegmentHandle);
		}
		[Export("setSelectedSegment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSelectedSegment_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSelectedSegment_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual NSColor? SelectedSegmentBezelColor
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("selectedSegmentBezelColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedSegmentBezelColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedSegmentBezelColorHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("setSelectedSegmentBezelColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedSegmentBezelColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedSegmentBezelColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	public virtual NSSegmentSwitchTracking TrackingMode
	{
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("trackingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSSegmentSwitchTracking)Messaging.UInt64_objc_msgSend(base.Handle, selTrackingModeHandle);
			}
			return (NSSegmentSwitchTracking)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTrackingModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
		[Export("setTrackingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTrackingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTrackingMode_Handle, (ulong)value);
			}
		}
	}

	[Mac(10, 12)]
	public static NSSegmentedControl FromLabels(string[] labels, NSSegmentSwitchTracking trackingMode, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSSegmentedControl nSSegmentedControl = _FromLabels(labels, trackingMode, nSActionDispatcher, NSDispatcher.Selector);
		nSSegmentedControl.dispatcher = nSActionDispatcher;
		return nSSegmentedControl;
	}

	[Mac(10, 12)]
	public static NSSegmentedControl FromImages(NSImage[] images, NSSegmentSwitchTracking trackingMode, Action action)
	{
		NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
		NSSegmentedControl nSSegmentedControl = _FromImages(images, trackingMode, nSActionDispatcher, NSDispatcher.Selector);
		nSSegmentedControl.dispatcher = nSActionDispatcher;
		return nSSegmentedControl;
	}

	public void UnselectAllSegments()
	{
		NSSegmentSwitchTracking trackingMode = Cell.TrackingMode;
		Cell.TrackingMode = NSSegmentSwitchTracking.Momentary;
		for (nint nint = 0; nint < SegmentCount; ++nint)
		{
			SetSelected(selected: false, nint);
		}
		Cell.TrackingMode = trackingMode;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSegmentedControl()
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
	public NSSegmentedControl(NSCoder coder)
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
	protected NSSegmentedControl(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSegmentedControl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSegmentedControl(CGRect frameRect)
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

	[Export("compressWithPrioritizedCompressionOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Compress(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCompressWithPrioritizedCompressionOptions_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompressWithPrioritizedCompressionOptions_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("alignmentForSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextAlignment GetAlignment(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSTextAlignment)Messaging.UInt64_objc_msgSend_nint(base.Handle, selAlignmentForSegment_Handle, segment);
		}
		return (NSTextAlignment)Messaging.UInt64_objc_msgSendSuper_nint(base.SuperHandle, selAlignmentForSegment_Handle, segment);
	}

	[Export("imageForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetImage(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selImageForSegment_Handle, segment));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selImageForSegment_Handle, segment));
	}

	[Export("imageScalingForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageScaling GetImageScaling(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSImageScaling)Messaging.UInt64_objc_msgSend_nint(base.Handle, selImageScalingForSegment_Handle, segment);
		}
		return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper_nint(base.SuperHandle, selImageScalingForSegment_Handle, segment);
	}

	[Export("labelForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLabel(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selLabelForSegment_Handle, segment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selLabelForSegment_Handle, segment));
	}

	[Export("menuForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu GetMenu(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selMenuForSegment_Handle, segment));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selMenuForSegment_Handle, segment));
	}

	[Export("minimumSizeWithPrioritizedCompressionOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize GetMinimumSize(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		CGSize result = ((!base.IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selMinimumSizeWithPrioritizedCompressionOptions_Handle, nSArray.Handle) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selMinimumSizeWithPrioritizedCompressionOptions_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("tagForSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetTag(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selTagForSegment_Handle, segment);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selTagForSegment_Handle, segment);
	}

	[Export("toolTipForSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetToolTip(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selToolTipForSegment_Handle, forSegment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selToolTipForSegment_Handle, forSegment));
	}

	[Export("doubleValueForSelectedSegment")]
	[Introduced(PlatformName.MacOSX, 10, 10, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetValueForSelectedSegment()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueForSelectedSegmentHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueForSelectedSegmentHandle);
	}

	[Export("widthForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetWidth(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selWidthForSegment_Handle, segment);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selWidthForSegment_Handle, segment);
	}

	[Export("isEnabledForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEnabled(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsEnabledForSegment_Handle, segment);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsEnabledForSegment_Handle, segment);
	}

	[Export("isSelectedForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSelectedForSegment(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsSelectedForSegment_Handle, segment);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsSelectedForSegment_Handle, segment);
	}

	[Export("selectSegmentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectSegment(nint tag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selSelectSegmentWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selSelectSegmentWithTag_Handle, tag);
	}

	[Export("setAlignment:forSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAlignment(NSTextAlignment alignment, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_nint(base.Handle, selSetAlignment_ForSegment_Handle, (ulong)alignment, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_nint(base.SuperHandle, selSetAlignment_ForSegment_Handle, (ulong)alignment, segment);
		}
	}

	[Export("setEnabled:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEnabled(bool enabled, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetEnabled_ForSegment_Handle, enabled, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetEnabled_ForSegment_Handle, enabled, segment);
		}
	}

	[Export("setImage:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImage(NSImage? image, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetImage_ForSegment_Handle, image?.Handle ?? IntPtr.Zero, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetImage_ForSegment_Handle, image?.Handle ?? IntPtr.Zero, segment);
		}
	}

	[Export("setImageScaling:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageScaling(NSImageScaling scaling, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_nint(base.Handle, selSetImageScaling_ForSegment_Handle, (ulong)scaling, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_nint(base.SuperHandle, selSetImageScaling_ForSegment_Handle, (ulong)scaling, segment);
		}
	}

	[Export("setLabel:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLabel(string? label, nint segment)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(label);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetLabel_ForSegment_Handle, arg, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetLabel_ForSegment_Handle, arg, segment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setMenu:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMenu(NSMenu? menu, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetMenu_ForSegment_Handle, menu?.Handle ?? IntPtr.Zero, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetMenu_ForSegment_Handle, menu?.Handle ?? IntPtr.Zero, segment);
		}
	}

	[Export("setSelected:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelected(bool selected, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetSelected_ForSegment_Handle, selected, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetSelected_ForSegment_Handle, selected, segment);
		}
	}

	[Export("setShowsMenuIndicator:forSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetShowsMenuIndicator(bool showsMenuIndicator, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetShowsMenuIndicator_ForSegment_Handle, showsMenuIndicator, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetShowsMenuIndicator_ForSegment_Handle, showsMenuIndicator, segment);
		}
	}

	[Export("setTag:forSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTag(nint tag, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selSetTag_ForSegment_Handle, tag, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selSetTag_ForSegment_Handle, tag, segment);
		}
	}

	[Export("setToolTip:forSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetToolTip(string? toolTip, nint segment)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(toolTip);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetToolTip_ForSegment_Handle, arg, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetToolTip_ForSegment_Handle, arg, segment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setWidth:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWidth(nfloat width, nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selSetWidth_ForSegment_Handle, width, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selSetWidth_ForSegment_Handle, width, segment);
		}
	}

	[Export("showsMenuIndicatorForSegment:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsMenuIndicator(nint segment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selShowsMenuIndicatorForSegment_Handle, segment);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selShowsMenuIndicatorForSegment_Handle, segment);
	}

	[Export("segmentedControlWithImages:trackingMode:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSSegmentedControl _FromImages(NSImage[] images, NSSegmentSwitchTracking trackingMode, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (images == null)
		{
			throw new ArgumentNullException("images");
		}
		NSArray nSArray = NSArray.FromNSObjects(images);
		NSSegmentedControl nSObject = Runtime.GetNSObject<NSSegmentedControl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selSegmentedControlWithImages_TrackingMode_Target_Action_Handle, nSArray.Handle, (ulong)trackingMode, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("segmentedControlWithLabels:trackingMode:target:action:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSSegmentedControl _FromLabels(string[] labels, NSSegmentSwitchTracking trackingMode, NSObject? target, Selector? action)
	{
		NSApplication.EnsureUIThread();
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		NSArray nSArray = NSArray.FromStrings(labels);
		NSSegmentedControl nSObject = Runtime.GetNSObject<NSSegmentedControl>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selSegmentedControlWithLabels_TrackingMode_Target_Action_Handle, nSArray.Handle, (ulong)trackingMode, target?.Handle ?? IntPtr.Zero, (action == null) ? IntPtr.Zero : action.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
