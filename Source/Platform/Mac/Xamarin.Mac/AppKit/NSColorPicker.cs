using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorPicker", true)]
public class NSColorPicker : NSObject
{
	private static readonly IntPtr selColorPanelHandle = Selector.GetHandle("colorPanel");

	private static readonly IntPtr selButtonToolTipHandle = Selector.GetHandle("buttonToolTip");

	private static readonly IntPtr selMinContentSizeHandle = Selector.GetHandle("minContentSize");

	private static readonly IntPtr selInitWithPickerMaskColorPanel_Handle = Selector.GetHandle("initWithPickerMask:colorPanel:");

	private static readonly IntPtr selProvideNewButtonImageHandle = Selector.GetHandle("provideNewButtonImage");

	private static readonly IntPtr selInsertNewButtonImageIn_Handle = Selector.GetHandle("insertNewButtonImage:in:");

	private static readonly IntPtr selViewSizeChanged_Handle = Selector.GetHandle("viewSizeChanged:");

	private static readonly IntPtr selAttachColorList_Handle = Selector.GetHandle("attachColorList:");

	private static readonly IntPtr selDetachColorList_Handle = Selector.GetHandle("detachColorList:");

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColorPicker");

	private object __mt_ColorPanel_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSColorPanel ColorPanel
	{
		[Export("colorPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorPanel)(__mt_ColorPanel_var = ((!IsDirectBinding) ? ((NSColorPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorPanelHandle))) : ((NSColorPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorPanelHandle)))));
		}
	}

	public virtual string ButtonToolTip
	{
		[Export("buttonToolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonToolTipHandle));
		}
	}

	public virtual CGSize MinContentSize
	{
		[Export("minContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinContentSizeHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorPicker()
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
	public NSColorPicker(NSCoder coder)
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
	public NSColorPicker(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColorPicker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPickerMask:colorPanel:")]
	public NSColorPicker(NSColorPanelFlags mask, NSColorPanel owningColorPanel)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (owningColorPanel == null)
		{
			throw new ArgumentNullException("owningColorPanel");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int_IntPtr(base.Handle, selInitWithPickerMaskColorPanel_Handle, (int)mask, owningColorPanel.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int_IntPtr(base.SuperHandle, selInitWithPickerMaskColorPanel_Handle, (int)mask, owningColorPanel.Handle);
		}
	}

	[Export("provideNewButtonImage")]
	public virtual NSImage ProvideNewButtonImage()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selProvideNewButtonImageHandle));
		}
		return (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProvideNewButtonImageHandle));
	}

	[Export("insertNewButtonImage:in:")]
	public virtual void InsertNewButtonImage(NSImage newButtonImage, NSButtonCell buttonCell)
	{
		NSApplication.EnsureUIThread();
		if (newButtonImage == null)
		{
			throw new ArgumentNullException("newButtonImage");
		}
		if (buttonCell == null)
		{
			throw new ArgumentNullException("buttonCell");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertNewButtonImageIn_Handle, newButtonImage.Handle, buttonCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertNewButtonImageIn_Handle, newButtonImage.Handle, buttonCell.Handle);
		}
	}

	[Export("viewSizeChanged:")]
	public virtual void ViewSizeChanged(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewSizeChanged_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewSizeChanged_Handle, sender.Handle);
		}
	}

	[Export("attachColorList:")]
	public virtual void AttachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAttachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachColorList_Handle, colorList.Handle);
		}
	}

	[Export("detachColorList:")]
	public virtual void DetachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetachColorList_Handle, colorList.Handle);
		}
	}

	[Export("setMode:")]
	public virtual void SetMode(NSColorPanelMode mode)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)mode);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ColorPanel_var = null;
		}
	}
}
