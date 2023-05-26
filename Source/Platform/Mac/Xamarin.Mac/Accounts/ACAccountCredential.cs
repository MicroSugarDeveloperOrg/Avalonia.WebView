using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Accounts;

[Register("ACAccountCredential", true)]
public class ACAccountCredential : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOAuth2Token_RefreshToken_ExpiryDate_ = "initWithOAuth2Token:refreshToken:expiryDate:";

	private static readonly IntPtr selInitWithOAuth2Token_RefreshToken_ExpiryDate_Handle = Selector.GetHandle("initWithOAuth2Token:refreshToken:expiryDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOAuthToken_TokenSecret_ = "initWithOAuthToken:tokenSecret:";

	private static readonly IntPtr selInitWithOAuthToken_TokenSecret_Handle = Selector.GetHandle("initWithOAuthToken:tokenSecret:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOauthToken = "oauthToken";

	private static readonly IntPtr selOauthTokenHandle = Selector.GetHandle("oauthToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOauthToken_ = "setOauthToken:";

	private static readonly IntPtr selSetOauthToken_Handle = Selector.GetHandle("setOauthToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ACAccountCredential");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? OAuthToken
	{
		[Export("oauthToken", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOauthTokenHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOauthTokenHandle));
		}
		[Export("setOauthToken:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOauthToken_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOauthToken_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ACAccountCredential()
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
	public ACAccountCredential(NSCoder coder)
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
	protected ACAccountCredential(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ACAccountCredential(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOAuthToken:tokenSecret:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ACAccountCredential(string oauthToken, string tokenSecret)
		: base(NSObjectFlag.Empty)
	{
		if (oauthToken == null)
		{
			throw new ArgumentNullException("oauthToken");
		}
		if (tokenSecret == null)
		{
			throw new ArgumentNullException("tokenSecret");
		}
		IntPtr arg = NSString.CreateNative(oauthToken);
		IntPtr arg2 = NSString.CreateNative(tokenSecret);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithOAuthToken_TokenSecret_Handle, arg, arg2), "initWithOAuthToken:tokenSecret:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithOAuthToken_TokenSecret_Handle, arg, arg2), "initWithOAuthToken:tokenSecret:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("initWithOAuth2Token:refreshToken:expiryDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ACAccountCredential(string oauth2Token, string refreshToken, NSDate expiryDate)
		: base(NSObjectFlag.Empty)
	{
		if (oauth2Token == null)
		{
			throw new ArgumentNullException("oauth2Token");
		}
		if (refreshToken == null)
		{
			throw new ArgumentNullException("refreshToken");
		}
		if (expiryDate == null)
		{
			throw new ArgumentNullException("expiryDate");
		}
		IntPtr arg = NSString.CreateNative(oauth2Token);
		IntPtr arg2 = NSString.CreateNative(refreshToken);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithOAuth2Token_RefreshToken_ExpiryDate_Handle, arg, arg2, expiryDate.Handle), "initWithOAuth2Token:refreshToken:expiryDate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithOAuth2Token_RefreshToken_ExpiryDate_Handle, arg, arg2, expiryDate.Handle), "initWithOAuth2Token:refreshToken:expiryDate:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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
