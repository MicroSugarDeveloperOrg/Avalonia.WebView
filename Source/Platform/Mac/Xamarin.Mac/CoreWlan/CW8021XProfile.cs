using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CW8021XProfile", true)]
public class CW8021XProfile : NSObject
{
	private static readonly IntPtr selUserDefinedNameHandle = Selector.GetHandle("userDefinedName");

	private static readonly IntPtr selSetUserDefinedName_Handle = Selector.GetHandle("setUserDefinedName:");

	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	private static readonly IntPtr selSetSsid_Handle = Selector.GetHandle("setSsid:");

	private static readonly IntPtr selUsernameHandle = Selector.GetHandle("username");

	private static readonly IntPtr selSetUsername_Handle = Selector.GetHandle("setUsername:");

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	private static readonly IntPtr selSetPassword_Handle = Selector.GetHandle("setPassword:");

	private static readonly IntPtr selAlwaysPromptForPasswordHandle = Selector.GetHandle("alwaysPromptForPassword");

	private static readonly IntPtr selSetAlwaysPromptForPassword_Handle = Selector.GetHandle("setAlwaysPromptForPassword:");

	private static readonly IntPtr selProfileHandle = Selector.GetHandle("profile");

	private static readonly IntPtr selAllUser8021XProfilesHandle = Selector.GetHandle("allUser8021XProfiles");

	private static readonly IntPtr selIsEqualToProfile_Handle = Selector.GetHandle("isEqualToProfile:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CW8021XProfile");

	private static object __mt_Profile_var_static;

	private static object __mt_AllUser8021XProfiles_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string UserDefinedName
	{
		[Export("userDefinedName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDefinedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDefinedNameHandle));
		}
		[Export("setUserDefinedName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserDefinedName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserDefinedName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

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

	public virtual string Username
	{
		[Export("username")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUsernameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUsernameHandle));
		}
		[Export("setUsername:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUsername_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUsername_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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
		[Export("setPassword:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPassword_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPassword_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool AlwaysPromptForPassword
	{
		[Export("alwaysPromptForPassword")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysPromptForPasswordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysPromptForPasswordHandle);
		}
		[Export("setAlwaysPromptForPassword:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysPromptForPassword_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysPromptForPassword_Handle, value);
			}
		}
	}

	public static CW8021XProfile Profile
	{
		[Export("profile")]
		get
		{
			return (CW8021XProfile)(__mt_Profile_var_static = (CW8021XProfile)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selProfileHandle)));
		}
	}

	public static CW8021XProfile[] AllUser8021XProfiles
	{
		[Export("allUser8021XProfiles")]
		get
		{
			return (CW8021XProfile[])(__mt_AllUser8021XProfiles_var_static = NSArray.ArrayFromHandle<CW8021XProfile>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllUser8021XProfilesHandle)));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CW8021XProfile()
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
	public CW8021XProfile(NSCoder coder)
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
	public CW8021XProfile(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CW8021XProfile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isEqualToProfile:")]
	public virtual bool IsEqualToProfile(CW8021XProfile profile)
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
}
