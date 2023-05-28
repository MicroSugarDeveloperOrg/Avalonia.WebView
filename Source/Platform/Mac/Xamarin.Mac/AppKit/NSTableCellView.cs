using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTableCellView", true)]
public class NSTableCellView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundStyle = "backgroundStyle";

	private static readonly IntPtr selBackgroundStyleHandle = Selector.GetHandle("backgroundStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingImageComponents = "draggingImageComponents";

	private static readonly IntPtr selDraggingImageComponentsHandle = Selector.GetHandle("draggingImageComponents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageView = "imageView";

	private static readonly IntPtr selImageViewHandle = Selector.GetHandle("imageView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectValue = "objectValue";

	private static readonly IntPtr selObjectValueHandle = Selector.GetHandle("objectValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowSizeStyle = "rowSizeStyle";

	private static readonly IntPtr selRowSizeStyleHandle = Selector.GetHandle("rowSizeStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundStyle_ = "setBackgroundStyle:";

	private static readonly IntPtr selSetBackgroundStyle_Handle = Selector.GetHandle("setBackgroundStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageView_ = "setImageView:";

	private static readonly IntPtr selSetImageView_Handle = Selector.GetHandle("setImageView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObjectValue_ = "setObjectValue:";

	private static readonly IntPtr selSetObjectValue_Handle = Selector.GetHandle("setObjectValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowSizeStyle_ = "setRowSizeStyle:";

	private static readonly IntPtr selSetRowSizeStyle_Handle = Selector.GetHandle("setRowSizeStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextField_ = "setTextField:";

	private static readonly IntPtr selSetTextField_Handle = Selector.GetHandle("setTextField:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextField = "textField";

	private static readonly IntPtr selTextFieldHandle = Selector.GetHandle("textField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTableCellView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_ImageView_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TextField_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBackgroundStyle BackgroundStyle
	{
		[Export("backgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBackgroundStyleHandle);
		}
		[Export("setBackgroundStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBackgroundStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBackgroundStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray DraggingImageComponents
	{
		[Export("draggingImageComponents", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingImageComponentsHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingImageComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageView ImageView
	{
		[Export("imageView", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSImageView nSImageView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSImageView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageViewHandle)) : Runtime.GetNSObject<NSImageView>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageViewHandle)));
			MarkDirty();
			__mt_ImageView_var = nSImageView;
			return nSImageView;
		}
		[Export("setImageView:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageView_Handle, value.Handle);
			}
			MarkDirty();
			__mt_ImageView_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ObjectValue
	{
		[Export("objectValue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectValueHandle));
		}
		[Export("setObjectValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetObjectValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetObjectValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTableViewRowSizeStyle RowSizeStyle
	{
		[Export("rowSizeStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSend(base.Handle, selRowSizeStyleHandle);
			}
			return (NSTableViewRowSizeStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRowSizeStyleHandle);
		}
		[Export("setRowSizeStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRowSizeStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRowSizeStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextField TextField
	{
		[Export("textField", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSTextField nSTextField = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextFieldHandle)) : Runtime.GetNSObject<NSTextField>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextFieldHandle)));
			MarkDirty();
			__mt_TextField_var = nSTextField;
			return nSTextField;
		}
		[Export("setTextField:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextField_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextField_Handle, value.Handle);
			}
			MarkDirty();
			__mt_TextField_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTableCellView()
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
	public NSTableCellView(NSCoder coder)
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
	protected NSTableCellView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTableCellView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTableCellView(CGRect frameRect)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ImageView_var = null;
			__mt_TextField_var = null;
		}
	}
}
