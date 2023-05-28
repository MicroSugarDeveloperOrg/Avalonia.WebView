using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Register("CW8021XProfile", true)]
[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CW8021XProfile : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllUser8021XProfiles = "allUser8021XProfiles";

	private static readonly IntPtr selAllUser8021XProfilesHandle = Selector.GetHandle("allUser8021XProfiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysPromptForPassword = "alwaysPromptForPassword";

	private static readonly IntPtr selAlwaysPromptForPasswordHandle = Selector.GetHandle("alwaysPromptForPassword");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToProfile_ = "isEqualToProfile:";

	private static readonly IntPtr selIsEqualToProfile_Handle = Selector.GetHandle("isEqualToProfile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPassword = "password";

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProfile = "profile";

	private static readonly IntPtr selProfileHandle = Selector.GetHandle("profile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysPromptForPassword_ = "setAlwaysPromptForPassword:";

	private static readonly IntPtr selSetAlwaysPromptForPassword_Handle = Selector.GetHandle("setAlwaysPromptForPassword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPassword_ = "setPassword:";

	private static readonly IntPtr selSetPassword_Handle = Selector.GetHandle("setPassword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSsid_ = "setSsid:";

	private static readonly IntPtr selSetSsid_Handle = Selector.GetHandle("setSsid:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserDefinedName_ = "setUserDefinedName:";

	private static readonly IntPtr selSetUserDefinedName_Handle = Selector.GetHandle("setUserDefinedName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsername_ = "setUsername:";

	private static readonly IntPtr selSetUsername_Handle = Selector.GetHandle("setUsername:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSsid = "ssid";

	private static readonly IntPtr selSsidHandle = Selector.GetHandle("ssid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserDefinedName = "userDefinedName";

	private static readonly IntPtr selUserDefinedNameHandle = Selector.GetHandle("userDefinedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsername = "username";

	private static readonly IntPtr selUsernameHandle = Selector.GetHandle("username");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CW8021XProfile");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static CW8021XProfile[] AllUser8021XProfiles
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("allUser8021XProfiles")]
		get
		{
			return NSArray.ArrayFromHandle<CW8021XProfile>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllUser8021XProfilesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual bool AlwaysPromptForPassword
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("alwaysPromptForPassword")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysPromptForPasswordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysPromptForPasswordHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("setAlwaysPromptForPassword:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysPromptForPassword_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysPromptForPassword_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual string Password
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("password", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPasswordHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasswordHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("setPassword:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static CW8021XProfile Profile
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("profile")]
		get
		{
			return Runtime.GetNSObject<CW8021XProfile>(Messaging.IntPtr_objc_msgSend(class_ptr, selProfileHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual string Ssid
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("ssid", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSsidHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSsidHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("setSsid:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual string UserDefinedName
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("userDefinedName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDefinedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDefinedNameHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("setUserDefinedName:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual string Username
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("username", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUsernameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUsernameHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("setUsername:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CW8021XProfile()
		: base(NSObjectFlag.Empty)
	{
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
	public CW8021XProfile(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected CW8021XProfile(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CW8021XProfile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("isEqualToProfile:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	[Obsoleted(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualToProfile(CW8021XProfile profile)
	{
		if (profile == null)
		{
			throw new ArgumentNullException("profile");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToProfile_Handle, profile.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToProfile_Handle, profile.Handle);
	}
}
