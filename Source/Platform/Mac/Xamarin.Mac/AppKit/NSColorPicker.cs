using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorPicker", true)]
public class NSColorPicker : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachColorList_ = "attachColorList:";

	private static readonly IntPtr selAttachColorList_Handle = Selector.GetHandle("attachColorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonToolTip = "buttonToolTip";

	private static readonly IntPtr selButtonToolTipHandle = Selector.GetHandle("buttonToolTip");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPanel = "colorPanel";

	private static readonly IntPtr selColorPanelHandle = Selector.GetHandle("colorPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDetachColorList_ = "detachColorList:";

	private static readonly IntPtr selDetachColorList_Handle = Selector.GetHandle("detachColorList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPickerMask_ColorPanel_ = "initWithPickerMask:colorPanel:";

	private static readonly IntPtr selInitWithPickerMask_ColorPanel_Handle = Selector.GetHandle("initWithPickerMask:colorPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertNewButtonImage_In_ = "insertNewButtonImage:in:";

	private static readonly IntPtr selInsertNewButtonImage_In_Handle = Selector.GetHandle("insertNewButtonImage:in:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinContentSize = "minContentSize";

	private static readonly IntPtr selMinContentSizeHandle = Selector.GetHandle("minContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvideNewButtonImage = "provideNewButtonImage";

	private static readonly IntPtr selProvideNewButtonImageHandle = Selector.GetHandle("provideNewButtonImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewSizeChanged_ = "viewSizeChanged:";

	private static readonly IntPtr selViewSizeChanged_Handle = Selector.GetHandle("viewSizeChanged:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSColorPicker");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ButtonToolTip
	{
		[Export("buttonToolTip")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonToolTipHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonToolTipHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorPanel ColorPanel
	{
		[Export("colorPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorPanel>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorPanelHandle));
			}
			return Runtime.GetNSObject<NSColorPanel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinContentSize
	{
		[Export("minContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinContentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorPicker()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSColorPicker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSColorPicker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPickerMask:colorPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSColorPicker(NSColorPanelFlags mask, NSColorPanel owningColorPanel)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (owningColorPanel == null)
		{
			throw new ArgumentNullException("owningColorPanel");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr(base.Handle, selInitWithPickerMask_ColorPanel_Handle, (ulong)mask, owningColorPanel.Handle), "initWithPickerMask:colorPanel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selInitWithPickerMask_ColorPanel_Handle, (ulong)mask, owningColorPanel.Handle), "initWithPickerMask:colorPanel:");
		}
	}

	[Export("attachColorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AttachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAttachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachColorList_Handle, colorList.Handle);
		}
	}

	[Export("detachColorList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DetachColorList(NSColorList colorList)
	{
		NSApplication.EnsureUIThread();
		if (colorList == null)
		{
			throw new ArgumentNullException("colorList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDetachColorList_Handle, colorList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDetachColorList_Handle, colorList.Handle);
		}
	}

	[Export("insertNewButtonImage:in:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertNewButtonImage_In_Handle, newButtonImage.Handle, buttonCell.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertNewButtonImage_In_Handle, newButtonImage.Handle, buttonCell.Handle);
		}
	}

	[Export("provideNewButtonImage")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage ProvideNewButtonImage()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selProvideNewButtonImageHandle));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProvideNewButtonImageHandle));
	}

	[Export("setMode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMode(NSColorPanelMode mode)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)mode);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)mode);
		}
	}

	[Export("viewSizeChanged:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ViewSizeChanged(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewSizeChanged_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewSizeChanged_Handle, sender.Handle);
		}
	}
}
