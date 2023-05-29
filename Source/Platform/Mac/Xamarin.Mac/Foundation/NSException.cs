using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSException", true)]
public class NSException : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selReasonHandle = Selector.GetHandle("reason");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selCallStackReturnAddressesHandle = Selector.GetHandle("callStackReturnAddresses");

	private static readonly IntPtr selInitWithNameReasonUserInfo_Handle = Selector.GetHandle("initWithName:reason:userInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSException");

	private object __mt_UserInfo_var;

	private object __mt_CallStackReturnAddresses_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual string Reason
	{
		[Export("reason")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReasonHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReasonHandle));
		}
	}

	public virtual NSObject UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSObject)(__mt_UserInfo_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle))));
		}
	}

	public virtual NSNumber[] CallStackReturnAddresses
	{
		[Export("callStackReturnAddresses")]
		get
		{
			return (NSNumber[])(__mt_CallStackReturnAddresses_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCallStackReturnAddressesHandle)) : NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selCallStackReturnAddressesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSException(NSCoder coder)
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
	public NSException(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSException(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:reason:userInfo:")]
	public NSException(string name, string reason, NSDictionary userInfo)
		: base(NSObjectFlag.Empty)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (reason == null)
		{
			throw new ArgumentNullException("reason");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(reason);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithNameReasonUserInfo_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithNameReasonUserInfo_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_UserInfo_var = null;
			__mt_CallStackReturnAddresses_var = null;
		}
	}
}
