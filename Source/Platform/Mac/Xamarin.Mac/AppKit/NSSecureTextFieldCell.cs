using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSecureTextFieldCell", true)]
public class NSSecureTextFieldCell : NSTextFieldCell
{
	private static readonly IntPtr selEchosBulletsHandle = Selector.GetHandle("echosBullets");

	private static readonly IntPtr selSetEchosBullets_Handle = Selector.GetHandle("setEchosBullets:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSecureTextFieldCell");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool EchosBullets
	{
		[Export("echosBullets")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEchosBulletsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEchosBulletsHandle);
		}
		[Export("setEchosBullets:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEchosBullets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEchosBullets_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSecureTextFieldCell()
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
	public NSSecureTextFieldCell(NSCoder coder)
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
	public NSSecureTextFieldCell(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSecureTextFieldCell(IntPtr handle)
		: base(handle)
	{
	}
}
