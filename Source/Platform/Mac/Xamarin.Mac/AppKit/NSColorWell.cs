using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorWell", true)]
public class NSColorWell : NSControl
{
	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	private static readonly IntPtr selIsBorderedHandle = Selector.GetHandle("isBordered");

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selDeactivateHandle = Selector.GetHandle("deactivate");

	private static readonly IntPtr selActivate_Handle = Selector.GetHandle("activate:");

	private static readonly IntPtr selDrawWellInside_Handle = Selector.GetHandle("drawWellInside:");

	private static readonly IntPtr selTakeColorFrom_Handle = Selector.GetHandle("takeColorFrom:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColorWell");

	private object __mt_Color_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool IsActive
	{
		[Export("isActive")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	public virtual bool Bordered
	{
		[Export("isBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBorderedHandle);
		}
		[Export("setBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, value);
			}
		}
	}

	public virtual NSColor Color
	{
		[Export("color")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_Color_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle)))));
		}
		[Export("setColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
			__mt_Color_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorWell()
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
	public NSColorWell(NSCoder coder)
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
	public NSColorWell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColorWell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSColorWell(CGRect frameRect)
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

	[Export("deactivate")]
	public virtual void Deactivate()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeactivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeactivateHandle);
		}
	}

	[Export("activate:")]
	public virtual void Activate(bool exclusive)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selActivate_Handle, exclusive);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selActivate_Handle, exclusive);
		}
	}

	[Export("drawWellInside:")]
	public virtual void DrawWellInside(CGRect insideRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawWellInside_Handle, insideRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawWellInside_Handle, insideRect);
		}
	}

	[Export("takeColorFrom:")]
	public virtual void TakeColorFrom(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTakeColorFrom_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTakeColorFrom_Handle, sender.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Color_var = null;
		}
	}
}
