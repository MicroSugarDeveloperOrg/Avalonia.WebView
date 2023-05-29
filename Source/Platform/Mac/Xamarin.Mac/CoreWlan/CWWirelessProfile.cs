using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CWWirelessProfile", true)]
public class CWWirelessProfile : NSObject
{
	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	private static readonly IntPtr selSetSsid_Handle = Selector.GetHandle("setSsid:");

	private static readonly IntPtr selSecurityModeHandle = Selector.GetHandle("securityMode");

	private static readonly IntPtr selSetSecurityMode_Handle = Selector.GetHandle("setSecurityMode:");

	private static readonly IntPtr selPassphraseHandle = Selector.GetHandle("passphrase");

	private static readonly IntPtr selSetPassphrase_Handle = Selector.GetHandle("setPassphrase:");

	private static readonly IntPtr selUser8021XProfileHandle = Selector.GetHandle("user8021XProfile");

	private static readonly IntPtr selSetUser8021XProfile_Handle = Selector.GetHandle("setUser8021XProfile:");

	private static readonly IntPtr selIsEqualToProfile_Handle = Selector.GetHandle("isEqualToProfile:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CWWirelessProfile");

	private object __mt_SecurityMode_var;

	private object __mt_User8021XProfile_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Ssid
	{
		[Export("ssid")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSsidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSsidHandle));
		}
		[Export("setSsid:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSsid_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSsid_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSNumber SecurityMode
	{
		[Export("securityMode")]
		get
		{
			return (NSNumber)(__mt_SecurityMode_var = ((!IsDirectBinding) ? ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSecurityModeHandle))) : ((NSNumber)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSecurityModeHandle)))));
		}
		[Export("setSecurityMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSecurityMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSecurityMode_Handle, value.Handle);
			}
			__mt_SecurityMode_var = value;
		}
	}

	public virtual string Passphrase
	{
		[Export("passphrase")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPassphraseHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPassphraseHandle));
		}
		[Export("setPassphrase:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPassphrase_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPassphrase_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual CW8021XProfile User8021XProfile
	{
		[Export("user8021XProfile")]
		get
		{
			return (CW8021XProfile)(__mt_User8021XProfile_var = ((!IsDirectBinding) ? ((CW8021XProfile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUser8021XProfileHandle))) : ((CW8021XProfile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUser8021XProfileHandle)))));
		}
		[Export("setUser8021XProfile:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUser8021XProfile_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUser8021XProfile_Handle, value.Handle);
			}
			__mt_User8021XProfile_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CWWirelessProfile()
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
	public CWWirelessProfile(NSCoder coder)
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
	public CWWirelessProfile(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CWWirelessProfile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isEqualToProfile:")]
	public virtual bool IsEqualToProfile(CWWirelessProfile profile)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToProfile_Handle, profile.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToProfile_Handle, profile.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SecurityMode_var = null;
			__mt_User8021XProfile_var = null;
		}
	}
}
