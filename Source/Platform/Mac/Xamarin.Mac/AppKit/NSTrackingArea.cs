using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTrackingArea", true)]
public class NSTrackingArea : NSObject
{
	private static readonly IntPtr selRectHandle = Selector.GetHandle("rect");

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selInitWithRectOptionsOwnerUserInfo_Handle = Selector.GetHandle("initWithRect:options:owner:userInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTrackingArea");

	private object __mt_Owner_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CGRect Rect
	{
		[Export("rect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectHandle);
			}
			return retval;
		}
	}

	public virtual NSTrackingAreaOptions Options
	{
		[Export("options")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTrackingAreaOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSTrackingAreaOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	public virtual NSObject Owner
	{
		[Export("owner")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Owner_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle))));
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTrackingArea()
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
	public NSTrackingArea(NSCoder coder)
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
	public NSTrackingArea(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTrackingArea(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRect:options:owner:userInfo:")]
	public NSTrackingArea(CGRect rect, NSTrackingAreaOptions options, NSObject owner, NSDictionary userInfo)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_UInt64_IntPtr_IntPtr(base.Handle, selInitWithRectOptionsOwnerUserInfo_Handle, rect, (ulong)options, owner.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64_IntPtr_IntPtr(base.SuperHandle, selInitWithRectOptionsOwnerUserInfo_Handle, rect, (ulong)options, owner.Handle, userInfo?.Handle ?? IntPtr.Zero);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Owner_var = null;
			__mt_UserInfo_var = null;
		}
	}
}
