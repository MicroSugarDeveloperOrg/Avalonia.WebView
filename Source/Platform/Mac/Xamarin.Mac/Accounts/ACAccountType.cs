using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Accounts;

[Register("ACAccountType", true)]
public class ACAccountType : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessGranted = "accessGranted";

	private static readonly IntPtr selAccessGrantedHandle = Selector.GetHandle("accessGranted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountTypeDescription = "accountTypeDescription";

	private static readonly IntPtr selAccountTypeDescriptionHandle = Selector.GetHandle("accountTypeDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ACAccountType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Facebook;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LinkedIn;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SinaWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TencentWeibo;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Twitter;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AccessGranted
	{
		[Export("accessGranted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAccessGrantedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAccessGrantedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Description
	{
		[Export("accountTypeDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountTypeDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountTypeDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[Field("ACAccountTypeIdentifierFacebook", "Accounts")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
	public static NSString Facebook
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Facebook SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Facebook SDK instead.")]
		get
		{
			if (_Facebook == null)
			{
				_Facebook = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountTypeIdentifierFacebook");
			}
			return _Facebook;
		}
	}

	[Field("ACAccountTypeIdentifierLinkedIn", "Accounts")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use LinkedIn SDK instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString LinkedIn
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use LinkedIn SDK instead.")]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_LinkedIn == null)
			{
				_LinkedIn = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountTypeIdentifierLinkedIn");
			}
			return _LinkedIn;
		}
	}

	[Field("ACAccountTypeIdentifierSinaWeibo", "Accounts")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
	public static NSString SinaWeibo
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Sina Weibo SDK instead.")]
		get
		{
			if (_SinaWeibo == null)
			{
				_SinaWeibo = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountTypeIdentifierSinaWeibo");
			}
			return _SinaWeibo;
		}
	}

	[Field("ACAccountTypeIdentifierTencentWeibo", "Accounts")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString TencentWeibo
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Tencent Weibo SDK instead.")]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_TencentWeibo == null)
			{
				_TencentWeibo = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountTypeIdentifierTencentWeibo");
			}
			return _TencentWeibo;
		}
	}

	[Field("ACAccountTypeIdentifierTwitter", "Accounts")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Twitter SDK instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Twitter SDK instead.")]
	public static NSString Twitter
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use Twitter SDK instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use Twitter SDK instead.")]
		get
		{
			if (_Twitter == null)
			{
				_Twitter = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountTypeIdentifierTwitter");
			}
			return _Twitter;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ACAccountType()
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
	public ACAccountType(NSCoder coder)
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
	protected ACAccountType(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ACAccountType(IntPtr handle)
		: base(handle)
	{
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
