using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLCredentialStorage", true)]
public class NSUrlCredentialStorage : NSObject
{
	private static readonly IntPtr selSharedCredentialStorageHandle = Selector.GetHandle("sharedCredentialStorage");

	private static readonly IntPtr selAllCredentialsHandle = Selector.GetHandle("allCredentials");

	private static readonly IntPtr selCredentialsForProtectionSpace_Handle = Selector.GetHandle("credentialsForProtectionSpace:");

	private static readonly IntPtr selSetCredentialForProtectionSpace_Handle = Selector.GetHandle("setCredential:forProtectionSpace:");

	private static readonly IntPtr selRemoveCredentialForProtectionSpace_Handle = Selector.GetHandle("removeCredential:forProtectionSpace:");

	private static readonly IntPtr selDefaultCredentialForProtectionSpace_Handle = Selector.GetHandle("defaultCredentialForProtectionSpace:");

	private static readonly IntPtr selSetDefaultCredentialForProtectionSpace_Handle = Selector.GetHandle("setDefaultCredential:forProtectionSpace:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLCredentialStorage");

	private static object __mt_SharedCredentialStorage_var_static;

	private object __mt_AllCredentials_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSUrlCredentialStorage SharedCredentialStorage
	{
		[Export("sharedCredentialStorage")]
		get
		{
			return (NSUrlCredentialStorage)(__mt_SharedCredentialStorage_var_static = (NSUrlCredentialStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCredentialStorageHandle)));
		}
	}

	public virtual NSDictionary AllCredentials
	{
		[Export("allCredentials")]
		get
		{
			return (NSDictionary)(__mt_AllCredentials_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllCredentialsHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAllCredentialsHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlCredentialStorage(NSCoder coder)
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
	public NSUrlCredentialStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlCredentialStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("credentialsForProtectionSpace:")]
	public virtual NSDictionary GetCredentials(NSUrlProtectionSpace forProtectionSpace)
	{
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCredentialsForProtectionSpace_Handle, forProtectionSpace.Handle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCredentialsForProtectionSpace_Handle, forProtectionSpace.Handle));
	}

	[Export("setCredential:forProtectionSpace:")]
	public virtual void SetCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	[Export("removeCredential:forProtectionSpace:")]
	public virtual void RemoveCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	[Export("defaultCredentialForProtectionSpace:")]
	public virtual NSUrlCredential GetDefaultCredential(NSUrlProtectionSpace forProtectionSpace)
	{
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (IsDirectBinding)
		{
			return (NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDefaultCredentialForProtectionSpace_Handle, forProtectionSpace.Handle));
		}
		return (NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultCredentialForProtectionSpace_Handle, forProtectionSpace.Handle));
	}

	[Export("setDefaultCredential:forProtectionSpace:")]
	public virtual void SetDefaultCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDefaultCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDefaultCredentialForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AllCredentials_var = null;
		}
	}
}
