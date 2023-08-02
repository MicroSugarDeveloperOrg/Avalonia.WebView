using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSegmentedCell", true)]
public class NSSegmentedCell : NSActionCell
{
	private static readonly IntPtr selSegmentCountHandle = Selector.GetHandle("segmentCount");

	private static readonly IntPtr selSetSegmentCount_Handle = Selector.GetHandle("setSegmentCount:");

	private static readonly IntPtr selSelectedSegmentHandle = Selector.GetHandle("selectedSegment");

	private static readonly IntPtr selSetSelectedSegment_Handle = Selector.GetHandle("setSelectedSegment:");

	private static readonly IntPtr selTrackingModeHandle = Selector.GetHandle("trackingMode");

	private static readonly IntPtr selSetTrackingMode_Handle = Selector.GetHandle("setTrackingMode:");

	private static readonly IntPtr selSegmentStyleHandle = Selector.GetHandle("segmentStyle");

	private static readonly IntPtr selSetSegmentStyle_Handle = Selector.GetHandle("setSegmentStyle:");

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	private static readonly IntPtr selSelectSegmentWithTag_Handle = Selector.GetHandle("selectSegmentWithTag:");

	private static readonly IntPtr selMakeNextSegmentKeyHandle = Selector.GetHandle("makeNextSegmentKey");

	private static readonly IntPtr selMakePreviousSegmentKeyHandle = Selector.GetHandle("makePreviousSegmentKey");

	private static readonly IntPtr selSetWidthForSegment_Handle = Selector.GetHandle("setWidth:forSegment:");

	private static readonly IntPtr selWidthForSegment_Handle = Selector.GetHandle("widthForSegment:");

	private static readonly IntPtr selSetImageForSegment_Handle = Selector.GetHandle("setImage:forSegment:");

	private static readonly IntPtr selImageForSegment_Handle = Selector.GetHandle("imageForSegment:");

	private static readonly IntPtr selSetImageScalingForSegment_Handle = Selector.GetHandle("setImageScaling:forSegment:");

	private static readonly IntPtr selImageScalingForSegment_Handle = Selector.GetHandle("imageScalingForSegment:");

	private static readonly IntPtr selSetLabelForSegment_Handle = Selector.GetHandle("setLabel:forSegment:");

	private static readonly IntPtr selLabelForSegment_Handle = Selector.GetHandle("labelForSegment:");

	private static readonly IntPtr selSetSelectedForSegment_Handle = Selector.GetHandle("setSelected:forSegment:");

	private static readonly IntPtr selIsSelectedForSegment_Handle = Selector.GetHandle("isSelectedForSegment:");

	private static readonly IntPtr selSetEnabledForSegment_Handle = Selector.GetHandle("setEnabled:forSegment:");

	private static readonly IntPtr selIsEnabledForSegment_Handle = Selector.GetHandle("isEnabledForSegment:");

	private static readonly IntPtr selSetMenuForSegment_Handle = Selector.GetHandle("setMenu:forSegment:");

	private static readonly IntPtr selMenuForSegment_Handle = Selector.GetHandle("menuForSegment:");

	private static readonly IntPtr selSetToolTipForSegment_Handle = Selector.GetHandle("setToolTip:forSegment:");

	private static readonly IntPtr selToolTipForSegment_Handle = Selector.GetHandle("toolTipForSegment:");

	private static readonly IntPtr selSetTagForSegment_Handle = Selector.GetHandle("setTag:forSegment:");

	private static readonly IntPtr selTagForSegment_Handle = Selector.GetHandle("tagForSegment:");

	private static readonly IntPtr selDrawSegmentInFrameWithView_Handle = Selector.GetHandle("drawSegment:inFrame:withView:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSegmentedCell");

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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSegmentedCell()
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
	public NSSegmentedCell(NSCoder coder)
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
	public NSSegmentedCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSegmentedCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	public NSSegmentedCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	public NSSegmentedCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle);
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

	[Export("makeNextSegmentKey")]
	public virtual void InsertSegmentAfterSelection()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeNextSegmentKeyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeNextSegmentKeyHandle);
		}
	}

	[Export("makePreviousSegmentKey")]
	public virtual void InsertSegmentBeforeSelection()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakePreviousSegmentKeyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakePreviousSegmentKeyHandle);
		}
	}

	[Export("setWidth:forSegment:")]
	public virtual void SetWidth(double width, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Int64(base.Handle, selSetWidthForSegment_Handle, width, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Int64(base.SuperHandle, selSetWidthForSegment_Handle, width, forSegment);
		}
	}

	[Export("widthForSegment:")]
	public virtual double GetWidth(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Int64(base.Handle, selWidthForSegment_Handle, forSegment);
		}
		return Messaging.Double_objc_msgSendSuper_Int64(base.SuperHandle, selWidthForSegment_Handle, forSegment);
	}

	[Export("setImage:forSegment:")]
	public virtual void SetImage(NSImage image, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetImageForSegment_Handle, image.Handle, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetImageForSegment_Handle, image.Handle, forSegment);
		}
	}

	[Export("imageForSegment:")]
	public virtual NSImage GetImageForSegment(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selImageForSegment_Handle, forSegment));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selImageForSegment_Handle, forSegment));
	}

	[Export("setImageScaling:forSegment:")]
	public virtual void SetImageScaling(NSImageScaling scaling, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Int64(base.Handle, selSetImageScalingForSegment_Handle, (ulong)scaling, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Int64(base.SuperHandle, selSetImageScalingForSegment_Handle, (ulong)scaling, forSegment);
		}
	}

	[Export("imageScalingForSegment:")]
	public virtual NSImageScaling GetImageScaling(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImageScaling)Messaging.UInt64_objc_msgSend_Int64(base.Handle, selImageScalingForSegment_Handle, forSegment);
		}
		return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selImageScalingForSegment_Handle, forSegment);
	}

	[Export("setLabel:forSegment:")]
	public virtual void SetLabel(string label, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetLabelForSegment_Handle, arg, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetLabelForSegment_Handle, arg, forSegment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("labelForSegment:")]
	public virtual string GetLabel(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selLabelForSegment_Handle, forSegment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selLabelForSegment_Handle, forSegment));
	}

	[Export("setSelected:forSegment:")]
	public virtual void SetSelected(bool selected, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetSelectedForSegment_Handle, selected, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetSelectedForSegment_Handle, selected, forSegment);
		}
	}

	[Export("isSelectedForSegment:")]
	public virtual bool IsSelected(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsSelectedForSegment_Handle, forSegment);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsSelectedForSegment_Handle, forSegment);
	}

	[Export("setEnabled:forSegment:")]
	public virtual void SetEnabled(bool enabled, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetEnabledForSegment_Handle, enabled, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetEnabledForSegment_Handle, enabled, forSegment);
		}
	}

	[Export("isEnabledForSegment:")]
	public virtual bool IsEnabled(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsEnabledForSegment_Handle, forSegment);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsEnabledForSegment_Handle, forSegment);
	}

	[Export("setMenu:forSegment:")]
	public virtual void SetMenu(NSMenu menu, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetMenuForSegment_Handle, menu.Handle, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetMenuForSegment_Handle, menu.Handle, forSegment);
		}
	}

	[Export("menuForSegment:")]
	public virtual NSMenu GetMenu(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selMenuForSegment_Handle, forSegment));
		}
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selMenuForSegment_Handle, forSegment));
	}

	[Export("setToolTip:forSegment:")]
	public virtual void SetToolTip(string toolTip, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (toolTip == null)
		{
			throw new ArgumentNullException("toolTip");
		}
		IntPtr arg = NSString.CreateNative(toolTip);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetToolTipForSegment_Handle, arg, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetToolTipForSegment_Handle, arg, forSegment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("toolTipForSegment:")]
	public virtual string GetToolTip(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selToolTipForSegment_Handle, forSegment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selToolTipForSegment_Handle, forSegment));
	}

	[Export("setTag:forSegment:")]
	public virtual void SetTag(long tag, long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSetTagForSegment_Handle, tag, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSetTagForSegment_Handle, tag, forSegment);
		}
	}

	[Export("tagForSegment:")]
	public virtual long GetTag(long forSegment)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64(base.Handle, selTagForSegment_Handle, forSegment);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64(base.SuperHandle, selTagForSegment_Handle, forSegment);
	}

	[Export("drawSegment:inFrame:withView:")]
	public virtual void DrawSegment(long segment, CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_CGRect_IntPtr(base.Handle, selDrawSegmentInFrameWithView_Handle, segment, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_CGRect_IntPtr(base.SuperHandle, selDrawSegmentInFrameWithView_Handle, segment, frame, controlView.Handle);
		}
	}
}
