using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSShadow", true)]
public class NSShadow : NSObject
{
	private static readonly IntPtr selShadowOffsetHandle = Selector.GetHandle("shadowOffset");

	private static readonly IntPtr selSetShadowOffset_Handle = Selector.GetHandle("setShadowOffset:");

	private static readonly IntPtr selShadowBlurRadiusHandle = Selector.GetHandle("shadowBlurRadius");

	private static readonly IntPtr selSetShadowBlurRadius_Handle = Selector.GetHandle("setShadowBlurRadius:");

	private static readonly IntPtr selShadowColorHandle = Selector.GetHandle("shadowColor");

	private static readonly IntPtr selSetShadowColor_Handle = Selector.GetHandle("setShadowColor:");

	private static readonly IntPtr selSetHandle = Selector.GetHandle("set");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSShadow");

	private object __mt_ShadowColor_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGSize ShadowOffset
	{
		[Export("shadowOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selShadowOffsetHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selShadowOffsetHandle);
		}
		[Export("setShadowOffset:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetShadowOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetShadowOffset_Handle, value);
			}
		}
	}

	public virtual double ShadowBlurRadius
	{
		[Export("shadowBlurRadius")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selShadowBlurRadiusHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selShadowBlurRadiusHandle);
		}
		[Export("setShadowBlurRadius:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetShadowBlurRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetShadowBlurRadius_Handle, value);
			}
		}
	}

	public virtual NSColor ShadowColor
	{
		[Export("shadowColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_ShadowColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShadowColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selShadowColorHandle)))));
		}
		[Export("setShadowColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetShadowColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetShadowColor_Handle, value.Handle);
			}
			__mt_ShadowColor_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSShadow()
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
	public NSShadow(NSCoder coder)
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
	public NSShadow(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSShadow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("set")]
	public virtual void Set()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSetHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ShadowColor_var = null;
		}
	}
}
