using System;
using System.ComponentModel;
using ObjCRuntime;
using Security;

namespace Foundation;

[Register("NSURLCredential", true)]
public class NSUrlCredential : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCertificates = "certificates";

	private static readonly IntPtr selCertificatesHandle = Selector.GetHandle("certificates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredentialForTrust_ = "credentialForTrust:";

	private static readonly IntPtr selCredentialForTrust_Handle = Selector.GetHandle("credentialForTrust:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredentialWithIdentity_Certificates_Persistence_ = "credentialWithIdentity:certificates:persistence:";

	private static readonly IntPtr selCredentialWithIdentity_Certificates_Persistence_Handle = Selector.GetHandle("credentialWithIdentity:certificates:persistence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredentialWithUser_Password_Persistence_ = "credentialWithUser:password:persistence:";

	private static readonly IntPtr selCredentialWithUser_Password_Persistence_Handle = Selector.GetHandle("credentialWithUser:password:persistence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasPassword = "hasPassword";

	private static readonly IntPtr selHasPasswordHandle = Selector.GetHandle("hasPassword");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentity = "identity";

	private static readonly IntPtr selIdentityHandle = Selector.GetHandle("identity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentity_Certificates_Persistence_ = "initWithIdentity:certificates:persistence:";

	private static readonly IntPtr selInitWithIdentity_Certificates_Persistence_Handle = Selector.GetHandle("initWithIdentity:certificates:persistence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTrust_ = "initWithTrust:";

	private static readonly IntPtr selInitWithTrust_Handle = Selector.GetHandle("initWithTrust:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUser_Password_Persistence_ = "initWithUser:password:persistence:";

	private static readonly IntPtr selInitWithUser_Password_Persistence_Handle = Selector.GetHandle("initWithUser:password:persistence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPassword = "password";

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersistence = "persistence";

	private static readonly IntPtr selPersistenceHandle = Selector.GetHandle("persistence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUser = "user";

	private static readonly IntPtr selUserHandle = Selector.GetHandle("user");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLCredential");

	public SecIdentity SecIdentity
	{
		get
		{
			IntPtr identity = Identity;
			return (identity == IntPtr.Zero) ? null : new SecIdentity(identity, owns: false);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SecCertificate[] Certificates
	{
		[Export("certificates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCertificatesHandle));
			}
			return NSArray.ArrayFromHandle<SecCertificate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCertificatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasPassword
	{
		[Export("hasPassword")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasPasswordHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasPasswordHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr Identity
	{
		[Export("identity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selIdentityHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Password
	{
		[Export("password")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPasswordHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasswordHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlCredentialPersistence Persistence
	{
		[Export("persistence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlCredentialPersistence)Messaging.UInt64_objc_msgSend(base.Handle, selPersistenceHandle);
			}
			return (NSUrlCredentialPersistence)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPersistenceHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string User
	{
		[Export("user")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserHandle));
		}
	}

	public NSUrlCredential(SecIdentity identity, SecCertificate[] certificates, NSUrlCredentialPersistence persistence)
		: this(identity.Handle, NSArray.FromNativeObjects(certificates).Handle, persistence)
	{
	}

	public static NSUrlCredential FromIdentityCertificatesPersistance(SecIdentity identity, SecCertificate[] certificates, NSUrlCredentialPersistence persistence)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		if (certificates == null)
		{
			throw new ArgumentNullException("certificates");
		}
		using NSArray nSArray = NSArray.FromNativeObjects(certificates);
		return FromIdentityCertificatesPersistanceInternal(identity.Handle, nSArray.Handle, persistence);
	}

	public static NSUrlCredential FromTrust(SecTrust trust)
	{
		if (trust == null)
		{
			throw new ArgumentNullException("trust");
		}
		return FromTrust(trust.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlCredential(NSCoder coder)
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
	protected NSUrlCredential(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlCredential(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTrust:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlCredential(SecTrust trust)
		: base(NSObjectFlag.Empty)
	{
		if (trust == null)
		{
			throw new ArgumentNullException("trust");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTrust_Handle, trust.Handle), "initWithTrust:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTrust_Handle, trust.Handle), "initWithTrust:");
		}
	}

	[Export("initWithUser:password:persistence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithUser_Password_Persistence_Handle, arg, arg2, (ulong)persistence), "initWithUser:password:persistence:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithUser_Password_Persistence_Handle, arg, arg2, (ulong)persistence), "initWithUser:password:persistence:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithIdentity:certificates:persistence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSUrlCredential(IntPtr identity, IntPtr certificates, NSUrlCredentialPersistence persistance)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selInitWithIdentity_Certificates_Persistence_Handle, identity, certificates, (ulong)persistance), "initWithIdentity:certificates:persistence:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selInitWithIdentity_Certificates_Persistence_Handle, identity, certificates, (ulong)persistance), "initWithIdentity:certificates:persistence:");
		}
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

	[Export("credentialWithIdentity:certificates:persistence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlCredential FromIdentityCertificatesPersistanceInternal(IntPtr identity, IntPtr certificates, NSUrlCredentialPersistence persistence)
	{
		return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(class_ptr, selCredentialWithIdentity_Certificates_Persistence_Handle, identity, certificates, (ulong)persistence));
	}

	[Export("credentialForTrust:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSUrlCredential FromTrust(IntPtr trust)
	{
		return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCredentialForTrust_Handle, trust));
	}

	[Export("credentialWithUser:password:persistence:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSUrlCredential nSObject = Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(class_ptr, selCredentialWithUser_Password_Persistence_Handle, arg, arg2, (ulong)persistence));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}
}
