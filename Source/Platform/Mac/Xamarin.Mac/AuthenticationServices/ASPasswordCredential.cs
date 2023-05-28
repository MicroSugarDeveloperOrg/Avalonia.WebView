using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASPasswordCredential", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class ASPasswordCredential : NSObject, IASAuthorizationCredential, INativeObject, IDisposable, INSCoding, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredentialWithUser_Password_ = "credentialWithUser:password:";

	private static readonly IntPtr selCredentialWithUser_Password_Handle = Selector.GetHandle("credentialWithUser:password:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUser_Password_ = "initWithUser:password:";

	private static readonly IntPtr selInitWithUser_Password_Handle = Selector.GetHandle("initWithUser:password:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPassword = "password";

	private static readonly IntPtr selPasswordHandle = Selector.GetHandle("password");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUser = "user";

	private static readonly IntPtr selUserHandle = Selector.GetHandle("user");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASPasswordCredential");

	public override IntPtr ClassHandle => class_ptr;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public ASPasswordCredential(NSCoder coder)
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
	protected ASPasswordCredential(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASPasswordCredential(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUser:password:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ASPasswordCredential(string user, string password)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithUser_Password_Handle, arg, arg2), "initWithUser:password:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithUser_Password_Handle, arg, arg2), "initWithUser:password:");
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

	[Export("credentialWithUser:password:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ASPasswordCredential Create(string user, string password)
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
		ASPasswordCredential nSObject = Runtime.GetNSObject<ASPasswordCredential>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selCredentialWithUser_Password_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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
}
