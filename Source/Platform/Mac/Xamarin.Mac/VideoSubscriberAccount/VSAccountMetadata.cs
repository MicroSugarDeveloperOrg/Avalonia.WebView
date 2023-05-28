using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Register("VSAccountMetadata", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public class VSAccountMetadata : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSAMLAttributeQueryResponse = "SAMLAttributeQueryResponse";

	private static readonly IntPtr selSAMLAttributeQueryResponseHandle = Selector.GetHandle("SAMLAttributeQueryResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountProviderIdentifier = "accountProviderIdentifier";

	private static readonly IntPtr selAccountProviderIdentifierHandle = Selector.GetHandle("accountProviderIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountProviderResponse = "accountProviderResponse";

	private static readonly IntPtr selAccountProviderResponseHandle = Selector.GetHandle("accountProviderResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthenticationExpirationDate = "authenticationExpirationDate";

	private static readonly IntPtr selAuthenticationExpirationDateHandle = Selector.GetHandle("authenticationExpirationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerificationData = "verificationData";

	private static readonly IntPtr selVerificationDataHandle = Selector.GetHandle("verificationData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VSAccountMetadata");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? AccountProviderIdentifier
	{
		[Export("accountProviderIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountProviderIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountProviderIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	public virtual VSAccountProviderResponse? AccountProviderResponse
	{
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("accountProviderResponse", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VSAccountProviderResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountProviderResponseHandle));
			}
			return Runtime.GetNSObject<VSAccountProviderResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountProviderResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? AuthenticationExpirationDate
	{
		[Export("authenticationExpirationDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selAuthenticationExpirationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthenticationExpirationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SamlAttributeQueryResponse
	{
		[Export("SAMLAttributeQueryResponse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSAMLAttributeQueryResponseHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSAMLAttributeQueryResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? VerificationData
	{
		[Export("verificationData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selVerificationDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerificationDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public VSAccountMetadata()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VSAccountMetadata(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VSAccountMetadata(IntPtr handle)
		: base(handle)
	{
	}
}
