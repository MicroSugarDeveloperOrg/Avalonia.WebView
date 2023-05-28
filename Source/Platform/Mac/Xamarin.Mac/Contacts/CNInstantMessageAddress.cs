using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNInstantMessageAddress", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNInstantMessageAddress : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
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
	private const string selInitWithUsername_Service_ = "initWithUsername:service:";

	private static readonly IntPtr selInitWithUsername_Service_Handle = Selector.GetHandle("initWithUsername:service:");

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
	private const string selUsername = "username";

	private static readonly IntPtr selUsernameHandle = Selector.GetHandle("username");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNInstantMessageAddress");

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

	public static string LocalizeProperty(CNInstantMessageAddressOption property)
	{
		return property switch
		{
			CNInstantMessageAddressOption.Username => LocalizeProperty(CNInstantMessageAddressKey.Username), 
			CNInstantMessageAddressOption.Service => LocalizeProperty(CNInstantMessageAddressKey.Service), 
			_ => throw new ArgumentOutOfRangeException("serviceOption"), 
		};
	}

	public static string LocalizeService(CNInstantMessageServiceOption serviceOption)
	{
		NSString service = ServiceOptionsToNSString(serviceOption);
		return LocalizeService(service);
	}

	private static NSString ServiceOptionsToNSString(CNInstantMessageServiceOption serviceOption)
	{
		return serviceOption switch
		{
			CNInstantMessageServiceOption.Aim => CNInstantMessageServiceKey.Aim, 
			CNInstantMessageServiceOption.Facebook => CNInstantMessageServiceKey.Facebook, 
			CNInstantMessageServiceOption.GaduGadu => CNInstantMessageServiceKey.GaduGadu, 
			CNInstantMessageServiceOption.GoogleTalk => CNInstantMessageServiceKey.GoogleTalk, 
			CNInstantMessageServiceOption.Icq => CNInstantMessageServiceKey.Icq, 
			CNInstantMessageServiceOption.Jabber => CNInstantMessageServiceKey.Jabber, 
			CNInstantMessageServiceOption.Msn => CNInstantMessageServiceKey.Msn, 
			CNInstantMessageServiceOption.QQ => CNInstantMessageServiceKey.QQ, 
			CNInstantMessageServiceOption.Skype => CNInstantMessageServiceKey.Skype, 
			CNInstantMessageServiceOption.Yahoo => CNInstantMessageServiceKey.Yahoo, 
			_ => throw new ArgumentOutOfRangeException("serviceOption"), 
		};
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNInstantMessageAddress()
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
	public CNInstantMessageAddress(NSCoder coder)
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
	protected CNInstantMessageAddress(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNInstantMessageAddress(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUsername:service:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CNInstantMessageAddress(string username, string service)
		: base(NSObjectFlag.Empty)
	{
		if (username == null)
		{
			throw new ArgumentNullException("username");
		}
		if (service == null)
		{
			throw new ArgumentNullException("service");
		}
		IntPtr arg = NSString.CreateNative(username);
		IntPtr arg2 = NSString.CreateNative(service);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithUsername_Service_Handle, arg, arg2), "initWithUsername:service:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithUsername_Service_Handle, arg, arg2), "initWithUsername:service:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizeProperty(NSString propertyKey)
	{
		if (propertyKey == null)
		{
			throw new ArgumentNullException("propertyKey");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedStringForKey_Handle, propertyKey.Handle));
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
