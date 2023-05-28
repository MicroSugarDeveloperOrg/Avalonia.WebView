using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKPaymentDiscount", true)]
[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKPaymentDiscount : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_KeyIdentifier_Nonce_Signature_Timestamp_ = "initWithIdentifier:keyIdentifier:nonce:signature:timestamp:";

	private static readonly IntPtr selInitWithIdentifier_KeyIdentifier_Nonce_Signature_Timestamp_Handle = Selector.GetHandle("initWithIdentifier:keyIdentifier:nonce:signature:timestamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyIdentifier = "keyIdentifier";

	private static readonly IntPtr selKeyIdentifierHandle = Selector.GetHandle("keyIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonce = "nonce";

	private static readonly IntPtr selNonceHandle = Selector.GetHandle("nonce");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSignature = "signature";

	private static readonly IntPtr selSignatureHandle = Selector.GetHandle("signature");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimestamp = "timestamp";

	private static readonly IntPtr selTimestampHandle = Selector.GetHandle("timestamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPaymentDiscount");

	public override IntPtr ClassHandle => class_ptr;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string KeyIdentifier
	{
		[Export("keyIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUuid Nonce
	{
		[Export("nonce", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUuid>(Messaging.IntPtr_objc_msgSend(base.Handle, selNonceHandle));
			}
			return Runtime.GetNSObject<NSUuid>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNonceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Signature
	{
		[Export("signature")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSignatureHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSignatureHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber Timestamp
	{
		[Export("timestamp", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimestampHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimestampHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKPaymentDiscount(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPaymentDiscount(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:keyIdentifier:nonce:signature:timestamp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKPaymentDiscount(string identifier, string keyIdentifier, NSUuid nonce, string signature, NSNumber timestamp)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (keyIdentifier == null)
		{
			throw new ArgumentNullException("keyIdentifier");
		}
		if (nonce == null)
		{
			throw new ArgumentNullException("nonce");
		}
		if (signature == null)
		{
			throw new ArgumentNullException("signature");
		}
		if (timestamp == null)
		{
			throw new ArgumentNullException("timestamp");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(keyIdentifier);
		IntPtr arg3 = NSString.CreateNative(signature);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_KeyIdentifier_Nonce_Signature_Timestamp_Handle, arg, arg2, nonce.Handle, arg3, timestamp.Handle), "initWithIdentifier:keyIdentifier:nonce:signature:timestamp:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_KeyIdentifier_Nonce_Signature_Timestamp_Handle, arg, arg2, nonce.Handle, arg3, timestamp.Handle), "initWithIdentifier:keyIdentifier:nonce:signature:timestamp:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}
}
