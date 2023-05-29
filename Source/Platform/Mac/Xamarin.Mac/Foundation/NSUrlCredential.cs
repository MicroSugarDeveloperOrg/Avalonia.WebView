using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLCredential", true)]
public class NSUrlCredential : NSObject
{
	private static readonly IntPtr selPersistenceHandle = Selector.GetHandle("persistence");

	private static readonly IntPtr selUserHandle = Selector.GetHandle("user");

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	private static readonly IntPtr selHasPasswordHandle = Selector.GetHandle("hasPassword");

	private static readonly IntPtr selIdentityHandle = Selector.GetHandle("identity");

	private static readonly IntPtr selInitWithUserPasswordPersistence_Handle = Selector.GetHandle("initWithUser:password:persistence:");

	private static readonly IntPtr selCredentialWithUserPasswordPersistence_Handle = Selector.GetHandle("credentialWithUser:password:persistence:");

	private static readonly IntPtr selCredentialForTrust_Handle = Selector.GetHandle("credentialForTrust:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLCredential");

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrlCredentialPersistence Persistence
	{
		[Export("persistence")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSUrlCredentialPersistence)Messaging.UInt64_objc_msgSend(base.Handle, selPersistenceHandle);
			}
			return (NSUrlCredentialPersistence)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPersistenceHandle);
		}
	}

	public virtual string User
	{
		[Export("user")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserHandle));
		}
	}

	public virtual string Password
	{
		[Export("password")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPasswordHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasswordHandle));
		}
	}

	public virtual bool HasPassword
	{
		[Export("hasPassword")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasPasswordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasPasswordHandle);
		}
	}

	public virtual IntPtr Identity
	{
		[Export("identity")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selIdentityHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentityHandle);
		}
	}

	public NSUrlCredential(IntPtr trust, bool ignored)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithTrust:"), trust);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithTrust:"), trust);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlCredential(NSCoder coder)
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
	public NSUrlCredential(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlCredential(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUser:password:persistence:")]
	public NSUrlCredential(string user, string password, NSUrlCredentialPersistence persistence)
		: base(NSObjectFlag.Empty)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = NSString.CreateNative(user);
		IntPtr arg2 = NSString.CreateNative(password);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithUserPasswordPersistence_Handle, arg, arg2, (ulong)persistence);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithUserPasswordPersistence_Handle, arg, arg2, (ulong)persistence);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("credentialWithUser:password:persistence:")]
	public static NSUrlCredential FromUserPasswordPersistance(string user, string password, NSUrlCredentialPersistence persistence)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = NSString.CreateNative(user);
		IntPtr arg2 = NSString.CreateNative(password);
		NSUrlCredential result = (NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(class_ptr, selCredentialWithUserPasswordPersistence_Handle, arg, arg2, (ulong)persistence));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("credentialForTrust:")]
	public static NSUrlCredential FromTrust(IntPtr SecTrustRef_trust)
	{
		return (NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCredentialForTrust_Handle, SecTrustRef_trust));
	}
}
