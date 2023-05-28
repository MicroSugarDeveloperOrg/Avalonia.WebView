using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Register("VSAccountMetadataRequest", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public class VSAccountMetadataRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountProviderAuthenticationToken = "accountProviderAuthenticationToken";

	private static readonly IntPtr selAccountProviderAuthenticationTokenHandle = Selector.GetHandle("accountProviderAuthenticationToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeNames = "attributeNames";

	private static readonly IntPtr selAttributeNamesHandle = Selector.GetHandle("attributeNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelIdentifier = "channelIdentifier";

	private static readonly IntPtr selChannelIdentifierHandle = Selector.GetHandle("channelIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFeaturedAccountProviderIdentifiers = "featuredAccountProviderIdentifiers";

	private static readonly IntPtr selFeaturedAccountProviderIdentifiersHandle = Selector.GetHandle("featuredAccountProviderIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForceAuthentication = "forceAuthentication";

	private static readonly IntPtr selForceAuthenticationHandle = Selector.GetHandle("forceAuthentication");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludeAccountProviderIdentifier = "includeAccountProviderIdentifier";

	private static readonly IntPtr selIncludeAccountProviderIdentifierHandle = Selector.GetHandle("includeAccountProviderIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludeAuthenticationExpirationDate = "includeAuthenticationExpirationDate";

	private static readonly IntPtr selIncludeAuthenticationExpirationDateHandle = Selector.GetHandle("includeAuthenticationExpirationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInterruptionAllowed = "isInterruptionAllowed";

	private static readonly IntPtr selIsInterruptionAllowedHandle = Selector.GetHandle("isInterruptionAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedVideoTitle = "localizedVideoTitle";

	private static readonly IntPtr selLocalizedVideoTitleHandle = Selector.GetHandle("localizedVideoTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccountProviderAuthenticationToken_ = "setAccountProviderAuthenticationToken:";

	private static readonly IntPtr selSetAccountProviderAuthenticationToken_Handle = Selector.GetHandle("setAccountProviderAuthenticationToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeNames_ = "setAttributeNames:";

	private static readonly IntPtr selSetAttributeNames_Handle = Selector.GetHandle("setAttributeNames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannelIdentifier_ = "setChannelIdentifier:";

	private static readonly IntPtr selSetChannelIdentifier_Handle = Selector.GetHandle("setChannelIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFeaturedAccountProviderIdentifiers_ = "setFeaturedAccountProviderIdentifiers:";

	private static readonly IntPtr selSetFeaturedAccountProviderIdentifiers_Handle = Selector.GetHandle("setFeaturedAccountProviderIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForceAuthentication_ = "setForceAuthentication:";

	private static readonly IntPtr selSetForceAuthentication_Handle = Selector.GetHandle("setForceAuthentication:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludeAccountProviderIdentifier_ = "setIncludeAccountProviderIdentifier:";

	private static readonly IntPtr selSetIncludeAccountProviderIdentifier_Handle = Selector.GetHandle("setIncludeAccountProviderIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludeAuthenticationExpirationDate_ = "setIncludeAuthenticationExpirationDate:";

	private static readonly IntPtr selSetIncludeAuthenticationExpirationDate_Handle = Selector.GetHandle("setIncludeAuthenticationExpirationDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterruptionAllowed_ = "setInterruptionAllowed:";

	private static readonly IntPtr selSetInterruptionAllowed_Handle = Selector.GetHandle("setInterruptionAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedVideoTitle_ = "setLocalizedVideoTitle:";

	private static readonly IntPtr selSetLocalizedVideoTitle_Handle = Selector.GetHandle("setLocalizedVideoTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportedAccountProviderIdentifiers_ = "setSupportedAccountProviderIdentifiers:";

	private static readonly IntPtr selSetSupportedAccountProviderIdentifiers_Handle = Selector.GetHandle("setSupportedAccountProviderIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportedAuthenticationSchemes_ = "setSupportedAuthenticationSchemes:";

	private static readonly IntPtr selSetSupportedAuthenticationSchemes_Handle = Selector.GetHandle("setSupportedAuthenticationSchemes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVerificationToken_ = "setVerificationToken:";

	private static readonly IntPtr selSetVerificationToken_Handle = Selector.GetHandle("setVerificationToken:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedAccountProviderIdentifiers = "supportedAccountProviderIdentifiers";

	private static readonly IntPtr selSupportedAccountProviderIdentifiersHandle = Selector.GetHandle("supportedAccountProviderIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedAuthenticationSchemes = "supportedAuthenticationSchemes";

	private static readonly IntPtr selSupportedAuthenticationSchemesHandle = Selector.GetHandle("supportedAuthenticationSchemes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerificationToken = "verificationToken";

	private static readonly IntPtr selVerificationTokenHandle = Selector.GetHandle("verificationToken");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VSAccountMetadataRequest");

	[TV(10, 1)]
	[iOS(10, 2)]
	public VSAccountProviderAuthenticationScheme[] SupportedAuthenticationSchemes
	{
		get
		{
			return VSAccountProviderAuthenticationSchemeExtensions.GetValues(SupportedAuthenticationSchemesString);
		}
		set
		{
			SupportedAuthenticationSchemesString = value?.GetConstants();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual string? AccountProviderAuthenticationToken
	{
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("accountProviderAuthenticationToken")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountProviderAuthenticationTokenHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountProviderAuthenticationTokenHandle));
		}
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setAccountProviderAuthenticationToken:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccountProviderAuthenticationToken_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccountProviderAuthenticationToken_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AttributeNames
	{
		[Export("attributeNames", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeNamesHandle));
		}
		[Export("setAttributeNames:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeNames_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeNames_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ChannelIdentifier
	{
		[Export("channelIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelIdentifierHandle));
		}
		[Export("setChannelIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChannelIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChannelIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string[] FeaturedAccountProviderIdentifiers
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("featuredAccountProviderIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFeaturedAccountProviderIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFeaturedAccountProviderIdentifiersHandle));
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFeaturedAccountProviderIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFeaturedAccountProviderIdentifiers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFeaturedAccountProviderIdentifiers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ForceAuthentication
	{
		[Export("forceAuthentication")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selForceAuthenticationHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selForceAuthenticationHandle);
		}
		[Export("setForceAuthentication:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetForceAuthentication_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetForceAuthentication_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludeAccountProviderIdentifier
	{
		[Export("includeAccountProviderIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludeAccountProviderIdentifierHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludeAccountProviderIdentifierHandle);
		}
		[Export("setIncludeAccountProviderIdentifier:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludeAccountProviderIdentifier_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludeAccountProviderIdentifier_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludeAuthenticationExpirationDate
	{
		[Export("includeAuthenticationExpirationDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludeAuthenticationExpirationDateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludeAuthenticationExpirationDateHandle);
		}
		[Export("setIncludeAuthenticationExpirationDate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludeAuthenticationExpirationDate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludeAuthenticationExpirationDate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InterruptionAllowed
	{
		[Export("isInterruptionAllowed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInterruptionAllowedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInterruptionAllowedHandle);
		}
		[Export("setInterruptionAllowed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInterruptionAllowed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInterruptionAllowed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedVideoTitle
	{
		[Export("localizedVideoTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedVideoTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedVideoTitleHandle));
		}
		[Export("setLocalizedVideoTitle:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedVideoTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedVideoTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] SupportedAccountProviderIdentifiers
	{
		[Export("supportedAccountProviderIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedAccountProviderIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedAccountProviderIdentifiersHandle));
		}
		[Export("setSupportedAccountProviderIdentifiers:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupportedAccountProviderIdentifiers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupportedAccountProviderIdentifiers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	protected virtual NSString[] SupportedAuthenticationSchemesString
	{
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("supportedAuthenticationSchemes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedAuthenticationSchemesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedAuthenticationSchemesHandle));
		}
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Export("setSupportedAuthenticationSchemes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupportedAuthenticationSchemes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupportedAuthenticationSchemes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? VerificationToken
	{
		[Export("verificationToken")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVerificationTokenHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVerificationTokenHandle));
		}
		[Export("setVerificationToken:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVerificationToken_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVerificationToken_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public VSAccountMetadataRequest()
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
	protected VSAccountMetadataRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VSAccountMetadataRequest(IntPtr handle)
		: base(handle)
	{
	}
}
