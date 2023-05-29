using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableCellView", true)]
public class NSTableCellView : NSView
{
	private static readonly IntPtr selBackgroundStyleHandle = Selector.GetHandle("backgroundStyle");

	private static readonly IntPtr selSetBackgroundStyle_Handle = Selector.GetHandle("setBackgroundStyle:");

	private static readonly IntPtr selImageViewHandle = Selector.GetHandle("imageView");

	private static readonly IntPtr selSetImageView_Handle = Selector.GetHandle("setImageView:");

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	private static readonly IntPtr selRowSizeStyleHandle = Selector.GetHandle("rowSizeStyle");

	private static readonly IntPtr selSetRowSizeStyle_Handle = Selector.GetHandle("setRowSizeStyle:");

	private static readonly IntPtr selTextFieldHandle = Selector.GetHandle("textField");

	private static readonly IntPtr selSetTextField_Handle = Selector.GetHandle("setTextField:");

	private static readonly IntPtr selDraggingImageComponentsHandle = Selector.GetHandle("draggingImageComponents");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTableCellView");

	private object __mt_ImageView_var;

	private object __mt_ObjectValue_var;

	private object __mt_TextField_var;

	private object __mt_DraggingImageComponents_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSBackgroundStyle BackgroundStyle
	{
		[Export("backgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBackgroundStyleHandle);
		}
		[Export("setBackgroundStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBackgroundStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBackgroundStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSImageView ImageView
	{
		[Export("imageView", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImageView)(__mt_ImageView_var = ((!IsDirectBinding) ? ((NSImageView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageViewHandle))) : ((NSImageView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImageViewHandle)))));
		}
		[Export("setImageView:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageView_Handle, value.Handle);
			}
			__mt_ImageView_var = value;
		}
	}

	public virtual NSObject ObjectValue
	{
		[Export("objectValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ObjectValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle))));
		}
		[Export("setObjectValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value.Handle);
			}
			__mt_ObjectValue_var = value;
		}
	}

	public virtual NSTableViewRowSizeStyle RowSizeStyle
	{
		[Export("rowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowSizeStyleHandle);
		}
		[Export("setRowSizeStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowSizeStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowSizeStyle_Handle, (long)value);
			}
		}
	}

	public virtual NSTextField TextField
	{
		[Export("textField", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextField)(__mt_TextField_var = ((!IsDirectBinding) ? ((NSTextField)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextFieldHandle))) : ((NSTextField)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextFieldHandle)))));
		}
		[Export("setTextField:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextField_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextField_Handle, value.Handle);
			}
			__mt_TextField_var = value;
		}
	}

	public virtual NSArray DraggingImageComponents
	{
		[Export("draggingImageComponents", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSArray)(__mt_DraggingImageComponents_var = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingImageComponentsHandle))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingImageComponentsHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableCellView()
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
	public NSTableCellView(NSCoder coder)
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
	public NSTableCellView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTableCellView(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ImageView_var = null;
			__mt_ObjectValue_var = null;
			__mt_TextField_var = null;
			__mt_DraggingImageComponents_var = null;
		}
	}
}
