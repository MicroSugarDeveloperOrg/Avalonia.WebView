using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEAppRule", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEAppRule : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
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
	private const string selInitWithSigningIdentifier_ = "initWithSigningIdentifier:";

	private static readonly IntPtr selInitWithSigningIdentifier_Handle = Selector.GetHandle("initWithSigningIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSigningIdentifier_DesignatedRequirement_ = "initWithSigningIdentifier:designatedRequirement:";

	private static readonly IntPtr selInitWithSigningIdentifier_DesignatedRequirement_Handle = Selector.GetHandle("initWithSigningIdentifier:designatedRequirement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchDesignatedRequirement = "matchDesignatedRequirement";

	private static readonly IntPtr selMatchDesignatedRequirementHandle = Selector.GetHandle("matchDesignatedRequirement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchDomains = "matchDomains";

	private static readonly IntPtr selMatchDomainsHandle = Selector.GetHandle("matchDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchPath = "matchPath";

	private static readonly IntPtr selMatchPathHandle = Selector.GetHandle("matchPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchSigningIdentifier = "matchSigningIdentifier";

	private static readonly IntPtr selMatchSigningIdentifierHandle = Selector.GetHandle("matchSigningIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchTools = "matchTools";

	private static readonly IntPtr selMatchToolsHandle = Selector.GetHandle("matchTools");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchDomains_ = "setMatchDomains:";

	private static readonly IntPtr selSetMatchDomains_Handle = Selector.GetHandle("setMatchDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchPath_ = "setMatchPath:";

	private static readonly IntPtr selSetMatchPath_Handle = Selector.GetHandle("setMatchPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchTools_ = "setMatchTools:";

	private static readonly IntPtr selSetMatchTools_Handle = Selector.GetHandle("setMatchTools:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEAppRule");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MatchDesignatedRequirement
	{
		[Export("matchDesignatedRequirement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchDesignatedRequirementHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchDesignatedRequirementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? MatchDomains
	{
		[Export("matchDomains", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchDomainsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchDomainsHandle));
		}
		[Export("setMatchDomains:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatchDomains_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatchDomains_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	public virtual string? MatchPath
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Export("matchPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchPathHandle));
		}
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Export("setMatchPath:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatchPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatchPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MatchSigningIdentifier
	{
		[Export("matchSigningIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchSigningIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchSigningIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual NEAppRule[]? MatchTools
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("matchTools", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchToolsHandle));
			}
			return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchToolsHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setMatchTools:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatchTools_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatchTools_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NEAppRule(NSCoder coder)
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
	protected NEAppRule(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEAppRule(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSigningIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NEAppRule(string signingIdentifier)
		: base(NSObjectFlag.Empty)
	{
		if (signingIdentifier == null)
		{
			throw new ArgumentNullException("signingIdentifier");
		}
		IntPtr arg = NSString.CreateNative(signingIdentifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSigningIdentifier_Handle, arg), "initWithSigningIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSigningIdentifier_Handle, arg), "initWithSigningIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithSigningIdentifier:designatedRequirement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NEAppRule(string signingIdentifier, string designatedRequirement)
		: base(NSObjectFlag.Empty)
	{
		if (signingIdentifier == null)
		{
			throw new ArgumentNullException("signingIdentifier");
		}
		if (designatedRequirement == null)
		{
			throw new ArgumentNullException("designatedRequirement");
		}
		IntPtr arg = NSString.CreateNative(signingIdentifier);
		IntPtr arg2 = NSString.CreateNative(designatedRequirement);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSigningIdentifier_DesignatedRequirement_Handle, arg, arg2), "initWithSigningIdentifier:designatedRequirement:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSigningIdentifier_DesignatedRequirement_Handle, arg, arg2), "initWithSigningIdentifier:designatedRequirement:");
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
}
