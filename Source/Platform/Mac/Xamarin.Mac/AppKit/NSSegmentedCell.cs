using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSegmentedCell", true)]
public class NSSegmentedCell : NSActionCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawSegment_InFrame_WithView_ = "drawSegment:inFrame:withView:";

	private static readonly IntPtr selDrawSegment_InFrame_WithView_Handle = Selector.GetHandle("drawSegment:inFrame:withView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageForSegment_ = "imageForSegment:";

	private static readonly IntPtr selImageForSegment_Handle = Selector.GetHandle("imageForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageScalingForSegment_ = "imageScalingForSegment:";

	private static readonly IntPtr selImageScalingForSegment_Handle = Selector.GetHandle("imageScalingForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabledForSegment_ = "isEnabledForSegment:";

	private static readonly IntPtr selIsEnabledForSegment_Handle = Selector.GetHandle("isEnabledForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSelectedForSegment_ = "isSelectedForSegment:";

	private static readonly IntPtr selIsSelectedForSegment_Handle = Selector.GetHandle("isSelectedForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelForSegment_ = "labelForSegment:";

	private static readonly IntPtr selLabelForSegment_Handle = Selector.GetHandle("labelForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeNextSegmentKey = "makeNextSegmentKey";

	private static readonly IntPtr selMakeNextSegmentKeyHandle = Selector.GetHandle("makeNextSegmentKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakePreviousSegmentKey = "makePreviousSegmentKey";

	private static readonly IntPtr selMakePreviousSegmentKeyHandle = Selector.GetHandle("makePreviousSegmentKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuForSegment_ = "menuForSegment:";

	private static readonly IntPtr selMenuForSegment_Handle = Selector.GetHandle("menuForSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentCount = "segmentCount";

	private static readonly IntPtr selSegmentCountHandle = Selector.GetHandle("segmentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegmentStyle = "segmentStyle";

	private static readonly IntPtr selSegmentStyleHandle = Selector.GetHandle("segmentStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectSegmentWithTag_ = "selectSegmentWithTag:";

	private static readonly IntPtr selSelectSegmentWithTag_Handle = Selector.GetHandle("selectSegmentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedSegment = "selectedSegment";

	private static readonly IntPtr selSelectedSegmentHandle = Selector.GetHandle("selectedSegment");

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
	private const string selSetSegmentStyle_ = "setSegmentStyle:";

	private static readonly IntPtr selSetSegmentStyle_Handle = Selector.GetHandle("setSegmentStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelected_ForSegment_ = "setSelected:forSegment:";

	private static readonly IntPtr selSetSelected_ForSegment_Handle = Selector.GetHandle("setSelected:forSegment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedSegment_ = "setSelectedSegment:";

	private static readonly IntPtr selSetSelectedSegment_Handle = Selector.GetHandle("setSelectedSegment:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSegmentedCell");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual NSSegmentSwitchTracking TrackingMode
	{
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSegmentedCell()
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
	public NSSegmentedCell(NSCoder coder)
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
	protected NSSegmentedCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSegmentedCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSegmentedCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSegmentedCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("drawSegment:inFrame:withView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawSegment(nint segment, CGRect frame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_CGRect_IntPtr(base.Handle, selDrawSegment_InFrame_WithView_Handle, segment, frame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_CGRect_IntPtr(base.SuperHandle, selDrawSegment_InFrame_WithView_Handle, segment, frame, controlView.Handle);
		}
	}

	[Export("imageForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetImageForSegment(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selImageForSegment_Handle, forSegment));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selImageForSegment_Handle, forSegment));
	}

	[Export("imageScalingForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageScaling GetImageScaling(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSImageScaling)Messaging.UInt64_objc_msgSend_nint(base.Handle, selImageScalingForSegment_Handle, forSegment);
		}
		return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper_nint(base.SuperHandle, selImageScalingForSegment_Handle, forSegment);
	}

	[Export("labelForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLabel(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selLabelForSegment_Handle, forSegment));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selLabelForSegment_Handle, forSegment));
	}

	[Export("menuForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu GetMenu(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selMenuForSegment_Handle, forSegment));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selMenuForSegment_Handle, forSegment));
	}

	[Export("tagForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetTag(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nint(base.Handle, selTagForSegment_Handle, forSegment);
		}
		return Messaging.nint_objc_msgSendSuper_nint(base.SuperHandle, selTagForSegment_Handle, forSegment);
	}

	[Export("toolTipForSegment:")]
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

	[Export("widthForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetWidth(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nint(base.Handle, selWidthForSegment_Handle, forSegment);
		}
		return Messaging.nfloat_objc_msgSendSuper_nint(base.SuperHandle, selWidthForSegment_Handle, forSegment);
	}

	[Export("makeNextSegmentKey")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentAfterSelection()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeNextSegmentKeyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeNextSegmentKeyHandle);
		}
	}

	[Export("makePreviousSegmentKey")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertSegmentBeforeSelection()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakePreviousSegmentKeyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakePreviousSegmentKeyHandle);
		}
	}

	[Export("isEnabledForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEnabled(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsEnabledForSegment_Handle, forSegment);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsEnabledForSegment_Handle, forSegment);
	}

	[Export("isSelectedForSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSelected(nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nint(base.Handle, selIsSelectedForSegment_Handle, forSegment);
		}
		return Messaging.bool_objc_msgSendSuper_nint(base.SuperHandle, selIsSelectedForSegment_Handle, forSegment);
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

	[Export("setEnabled:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetEnabled(bool enabled, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetEnabled_ForSegment_Handle, enabled, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetEnabled_ForSegment_Handle, enabled, forSegment);
		}
	}

	[Export("setImage:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImage(NSImage image, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetImage_ForSegment_Handle, image.Handle, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetImage_ForSegment_Handle, image.Handle, forSegment);
		}
	}

	[Export("setImageScaling:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetImageScaling(NSImageScaling scaling, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_nint(base.Handle, selSetImageScaling_ForSegment_Handle, (ulong)scaling, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_nint(base.SuperHandle, selSetImageScaling_ForSegment_Handle, (ulong)scaling, forSegment);
		}
	}

	[Export("setLabel:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLabel(string label, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		IntPtr arg = NSString.CreateNative(label);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetLabel_ForSegment_Handle, arg, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetLabel_ForSegment_Handle, arg, forSegment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setMenu:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMenu(NSMenu menu, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (menu == null)
		{
			throw new ArgumentNullException("menu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetMenu_ForSegment_Handle, menu.Handle, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetMenu_ForSegment_Handle, menu.Handle, forSegment);
		}
	}

	[Export("setSelected:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelected(bool selected, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_nint(base.Handle, selSetSelected_ForSegment_Handle, selected, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_nint(base.SuperHandle, selSetSelected_ForSegment_Handle, selected, forSegment);
		}
	}

	[Export("setTag:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTag(nint tag, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selSetTag_ForSegment_Handle, tag, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selSetTag_ForSegment_Handle, tag, forSegment);
		}
	}

	[Export("setToolTip:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetToolTip(string? toolTip, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(toolTip);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetToolTip_ForSegment_Handle, arg, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetToolTip_ForSegment_Handle, arg, forSegment);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setWidth:forSegment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWidth(nfloat width, nint forSegment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nint(base.Handle, selSetWidth_ForSegment_Handle, width, forSegment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nint(base.SuperHandle, selSetWidth_ForSegment_Handle, width, forSegment);
		}
	}
}
