using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNSocialProfile", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNSocialProfile : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
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
	private const string selInitWithUrlString_Username_UserIdentifier_Service_ = "initWithUrlString:username:userIdentifier:service:";

	private static readonly IntPtr selInitWithUrlString_Username_UserIdentifier_Service_Handle = Selector.GetHandle("initWithUrlString:username:userIdentifier:service:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForKey_ = "localizedStringForKey:";

	private static readonly IntPtr selLocalizedStringForKey_Handle = Selector.GetHandle("localizedStringForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringForService_ = "localizedStringForService:";

	private static readonly IntPtr selLocalizedStringForService_Handle = Selector.GetHandle("localizedStringForService:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selService = "service";

	private static readonly IntPtr selServiceHandle = Selector.GetHandle("service");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrlString = "urlString";

	private static readonly IntPtr selUrlStringHandle = Selector.GetHandle("urlString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserIdentifier = "userIdentifier";

	private static readonly IntPtr selUserIdentifierHandle = Selector.GetHandle("userIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsername = "username";

	private static readonly IntPtr selUsernameHandle = Selector.GetHandle("username");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNSocialProfile");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Service
	{
		[Export("service")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServiceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServiceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UrlString
	{
		[Export("urlString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UserIdentifier
	{
		[Export("userIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Username
	{
		[Export("username")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUsernameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUsernameHandle));
		}
	}

	public static string LocalizeProperty(CNSocialProfileOption option)
	{
		return option switch
		{
			CNSocialProfileOption.UrlString => LocalizeProperty(CNSocialProfileKey.UrlString), 
			CNSocialProfileOption.Username => LocalizeProperty(CNSocialProfileKey.Username), 
			CNSocialProfileOption.UserIdentifier => LocalizeProperty(CNSocialProfileKey.UserIdentifier), 
			CNSocialProfileOption.Service => LocalizeProperty(CNSocialProfileKey.Service), 
			_ => throw new ArgumentOutOfRangeException("option"), 
		};
	}

	public static string LocalizeService(CNSocialProfileServiceOption serviceOption)
	{
		NSString service = ServiceOptionsToNSString(serviceOption);
		return LocalizeService(service);
	}

	private static NSString ServiceOptionsToNSString(CNSocialProfileServiceOption serviceOption)
	{
		return serviceOption switch
		{
			CNSocialProfileServiceOption.Facebook => CNSocialProfileServiceKey.Facebook, 
			CNSocialProfileServiceOption.Flickr => CNSocialProfileServiceKey.Flickr, 
			CNSocialProfileServiceOption.LinkedIn => CNSocialProfileServiceKey.LinkedIn, 
			CNSocialProfileServiceOption.MySpace => CNSocialProfileServiceKey.MySpace, 
			CNSocialProfileServiceOption.SinaWeibo => CNSocialProfileServiceKey.SinaWeibo, 
			CNSocialProfileServiceOption.TencentWeibo => CNSocialProfileServiceKey.TencentWeibo, 
			CNSocialProfileServiceOption.Twitter => CNSocialProfileServiceKey.Twitter, 
			CNSocialProfileServiceOption.Yelp => CNSocialProfileServiceKey.Yelp, 
			CNSocialProfileServiceOption.GameCenter => CNSocialProfileServiceKey.GameCenter, 
			_ => throw new ArgumentOutOfRangeException("serviceOption"), 
		};
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNSocialProfile()
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
	public CNSocialProfile(NSCoder coder)
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
	protected CNSocialProfile(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNSocialProfile(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUrlString:username:userIdentifier:service:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CNSocialProfile(string? url, string? username, string? userIdentifier, string? service)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(url);
		IntPtr arg2 = NSString.CreateNative(username);
		IntPtr arg3 = NSString.CreateNative(userIdentifier);
		IntPtr arg4 = NSString.CreateNative(service);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithUrlString_Username_UserIdentifier_Service_Handle, arg, arg2, arg3, arg4), "initWithUrlString:username:userIdentifier:service:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithUrlString_Username_UserIdentifier_Service_Handle, arg, arg2, arg3, arg4), "initWithUrlString:username:userIdentifier:service:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
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

	[Export("localizedStringForKey:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeProperty(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedStringForKey_Handle, key.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeProperty(CNPostalAddressKeyOption key)
	{
		return LocalizeProperty(key.GetConstant());
	}

	[Export("localizedStringForService:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeService(NSString service)
	{
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedStringForService_Handle, service.Handle));
	}
}
