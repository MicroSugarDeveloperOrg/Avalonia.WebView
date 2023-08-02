using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSegmentedControl", true)]
public class NSSegmentedControl : NSControl
{
	private static readonly IntPtr selSegmentCountHandle = Selector.GetHandle("segmentCount");

	private static readonly IntPtr selSetSegmentCount_Handle = Selector.GetHandle("setSegmentCount:");

	private static readonly IntPtr selSelectedSegmentHandle = Selector.GetHandle("selectedSegment");

	private static readonly IntPtr selSetSelectedSegment_Handle = Selector.GetHandle("setSelectedSegment:");

	private static readonly IntPtr selSegmentStyleHandle = Selector.GetHandle("segmentStyle");

	private static readonly IntPtr selSetSegmentStyle_Handle = Selector.GetHandle("setSegmentStyle:");

	private static readonly IntPtr selTrackingModeHandle = Selector.GetHandle("trackingMode");

	private static readonly IntPtr selSetTrackingMode_Handle = Selector.GetHandle("setTrackingMode:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selSelectSegmentWithTag_Handle = Selector.GetHandle("selectSegmentWithTag:");

	private static readonly IntPtr selSetWidthForSegment_Handle = Selector.GetHandle("setWidth:forSegment:");

	private static readonly IntPtr selWidthForSegment_Handle = Selector.GetHandle("widthForSegment:");

	private static readonly IntPtr selSetImageForSegment_Handle = Selector.GetHandle("setImage:forSegment:");

	private static readonly IntPtr selImageForSegment_Handle = Selector.GetHandle("imageForSegment:");

	private static readonly IntPtr selSetImageScalingForSegment_Handle = Selector.GetHandle("setImageScaling:forSegment:");

	private static readonly IntPtr selImageScalingForSegment_Handle = Selector.GetHandle("imageScalingForSegment:");

	private static readonly IntPtr selSetLabelForSegment_Handle = Selector.GetHandle("setLabel:forSegment:");

	private static readonly IntPtr selLabelForSegment_Handle = Selector.GetHandle("labelForSegment:");

	private static readonly IntPtr selSetMenuForSegment_Handle = Selector.GetHandle("setMenu:forSegment:");

	private static readonly IntPtr selMenuForSegment_Handle = Selector.GetHandle("menuForSegment:");

	private static readonly IntPtr selSetSelectedForSegment_Handle = Selector.GetHandle("setSelected:forSegment:");

	private static readonly IntPtr selIsSelectedForSegment_Handle = Selector.GetHandle("isSelectedForSegment:");

	private static readonly IntPtr selSetEnabledForSegment_Handle = Selector.GetHandle("setEnabled:forSegment:");

	private static readonly IntPtr selIsEnabledForSegment_Handle = Selector.GetHandle("isEnabledForSegment:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSegmentedControl");

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

	public virtual long SegmentCount
	{
		[Export("segmentCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSegmentCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSegmentCountHandle);
		}
		[Export("setSegmentCount:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSegmentCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSegmentCount_Handle, value);
			}
		}
	}

	public virtual long SelectedSegment
	{
		[Export("selectedSegment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selSelectedSegmentHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSelectedSegmentHandle);
		}
		[Export("setSelectedSegment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSelectedSegment_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSelectedSegment_Handle, value);
			}
		}
	}

	public virtual NSSegmentStyle SegmentStyle
	{
		[Export("segmentStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSSegmentStyle)Messaging.Int64_objc_msgSend(base.Handle, selSegmentStyleHandle);
			}
			return (NSSegmentStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSegmentStyleHandle);
		}
		[Export("setSegmentStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSegmentStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSegmentStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSSegmentSwitchTracking TrackingMode
	{
		[Export("trackingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSSegmentSwitchTracking)Messaging.UInt64_objc_msgSend(base.Handle, selTrackingModeHandle);
			}
			return (NSSegmentSwitchTracking)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTrackingModeHandle);
		}
		[Export("setTrackingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTrackingMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTrackingMode_Handle, (ulong)value);
			}
		}
	}

	public void UnselectAllSegments()
	{
		NSSegmentSwitchTracking trackingMode = Cell.TrackingMode;
		Cell.TrackingMode = NSSegmentSwitchTracking.Momentary;
		for (int i = 0; i < SegmentCount; i++)
		{
			SetSelected(selected: false, i);
		}
		Cell.TrackingMode = trackingMode;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSegmentedControl()
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
	public NSSegmentedControl(NSCoder coder)
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
	public NSSegmentedControl(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSegmentedControl(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSSegmentedControl(CGRect frameRect)
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

	[Export("selectSegmentWithTag:")]
	public virtual bool SelectSegment(long tag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selSelectSegmentWithTag_Handle, tag);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selSelectSegmentWithTag_Handle, tag);
	}

	[Export("setWidth:forSegment:")]
	public virtual void SetWidth(double width, long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Int64(base.Handle, selSetWidthForSegment_Handle, width, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Int64(base.SuperHandle, selSetWidthForSegment_Handle, width, segment);
		}
	}

	[Export("widthForSegment:")]
	public virtual double GetWidth(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selWidthForSegment_Handle, segment);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selWidthForSegment_Handle, segment);
	}

	[Export("setImage:forSegment:")]
	public virtual void SetImage(NSImage image, long segment)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetImageForSegment_Handle, image.Handle, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetImageForSegment_Handle, image.Handle, segment);
		}
	}

	[Export("imageForSegment:")]
	public virtual NSImage GetImage(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selImageForSegment_Handle, segment));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selImageForSegment_Handle, segment));
	}

	[Export("setImageScaling:forSegment:")]
	public virtual void SetImageScaling(NSImageScaling scaling, long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Int64(base.Handle, selSetImageScalingForSegment_Handle, (ulong)scaling, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Int64(base.SuperHandle, selSetImageScalingForSegment_Handle, (ulong)scaling, segment);
		}
	}

	[Export("imageScalingForSegment:")]
	public virtual NSImageScaling GetImageScaling(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImageScaling)Messaging.UInt64_objc_msgSend_Int64(base.Handle, selImageScalingForSegment_Handle, segment);
		}
		return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selImageScalingForSegment_Handle, segment);
	}

	[Export("setLabel:forSegment:")]
	public virtual void SetLabel(string label, long segment)
	{
		NSApplication.EnsureUIThread();
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetLabelForSegment_Handle, arg, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetLabelForSegment_Handle, arg, segment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("labelForSegment:")]
	public virtual string GetLabel(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selLabelForSegment_Handle, segment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selLabelForSegment_Handle, segment));
	}

	[Export("setMenu:forSegment:")]
	public virtual void SetMenu(NSMenu menu, long segment)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetMenuForSegment_Handle, menu.Handle, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetMenuForSegment_Handle, menu.Handle, segment);
		}
	}

	[Export("menuForSegment:")]
	public virtual NSMenu GetMenu(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selMenuForSegment_Handle, segment));
		}
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selMenuForSegment_Handle, segment));
	}

	[Export("setSelected:forSegment:")]
	public virtual void SetSelected(bool selected, long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetSelectedForSegment_Handle, selected, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetSelectedForSegment_Handle, selected, segment);
		}
	}

	[Export("isSelectedForSegment:")]
	public virtual bool IsSelectedForSegment(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsSelectedForSegment_Handle, segment);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsSelectedForSegment_Handle, segment);
	}

	[Export("setEnabled:forSegment:")]
	public virtual void SetEnabled(bool enabled, long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetEnabledForSegment_Handle, enabled, segment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetEnabledForSegment_Handle, enabled, segment);
		}
	}

	[Export("isEnabledForSegment:")]
	public virtual bool IsEnabled(long segment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsEnabledForSegment_Handle, segment);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsEnabledForSegment_Handle, segment);
	}
}
