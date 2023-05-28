using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPNowPlayingInfoLanguageOption", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPNowPlayingInfoLanguageOption : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_LanguageTag_Characteristics_DisplayName_Identifier_ = "initWithType:languageTag:characteristics:displayName:identifier:";

	private static readonly IntPtr selInitWithType_LanguageTag_Characteristics_DisplayName_Identifier_Handle = Selector.GetHandle("initWithType:languageTag:characteristics:displayName:identifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticAudibleLanguageOption = "isAutomaticAudibleLanguageOption";

	private static readonly IntPtr selIsAutomaticAudibleLanguageOptionHandle = Selector.GetHandle("isAutomaticAudibleLanguageOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticLegibleLanguageOption = "isAutomaticLegibleLanguageOption";

	private static readonly IntPtr selIsAutomaticLegibleLanguageOptionHandle = Selector.GetHandle("isAutomaticLegibleLanguageOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageOptionCharacteristics = "languageOptionCharacteristics";

	private static readonly IntPtr selLanguageOptionCharacteristicsHandle = Selector.GetHandle("languageOptionCharacteristics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageOptionType = "languageOptionType";

	private static readonly IntPtr selLanguageOptionTypeHandle = Selector.GetHandle("languageOptionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageTag = "languageTag";

	private static readonly IntPtr selLanguageTagHandle = Selector.GetHandle("languageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPNowPlayingInfoLanguageOption");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Identifier
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
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual bool IsAutomaticAudibleLanguageOption
	{
		[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("isAutomaticAudibleLanguageOption")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticAudibleLanguageOptionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticAudibleLanguageOptionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAutomaticLegibleLanguageOption
	{
		[Export("isAutomaticLegibleLanguageOption")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAutomaticLegibleLanguageOptionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAutomaticLegibleLanguageOptionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[]? LanguageOptionCharacteristics
	{
		[Export("languageOptionCharacteristics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageOptionCharacteristicsHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageOptionCharacteristicsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPNowPlayingInfoLanguageOptionType LanguageOptionType
	{
		[Export("languageOptionType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPNowPlayingInfoLanguageOptionType)Messaging.UInt64_objc_msgSend(base.Handle, selLanguageOptionTypeHandle);
			}
			return (MPNowPlayingInfoLanguageOptionType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLanguageOptionTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LanguageTag
	{
		[Export("languageTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageTagHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPNowPlayingInfoLanguageOption(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPNowPlayingInfoLanguageOption(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:languageTag:characteristics:displayName:identifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPNowPlayingInfoLanguageOption(MPNowPlayingInfoLanguageOptionType languageOptionType, string languageTag, NSString[]? languageOptionCharacteristics, string displayName, string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (languageTag == null)
		{
			throw new ArgumentNullException("languageTag");
		}
		if (displayName == null)
		{
			throw new ArgumentNullException("displayName");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(languageTag);
		NSArray nSArray = ((languageOptionCharacteristics == null) ? null : NSArray.FromNSObjects(languageOptionCharacteristics));
		IntPtr arg2 = NSString.CreateNative(displayName);
		IntPtr arg3 = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithType_LanguageTag_Characteristics_DisplayName_Identifier_Handle, (ulong)languageOptionType, arg, nSArray?.Handle ?? IntPtr.Zero, arg2, arg3), "initWithType:languageTag:characteristics:displayName:identifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithType_LanguageTag_Characteristics_DisplayName_Identifier_Handle, (ulong)languageOptionType, arg, nSArray?.Handle ?? IntPtr.Zero, arg2, arg3), "initWithType:languageTag:characteristics:displayName:identifier:");
		}
		NSString.ReleaseNative(arg);
		nSArray?.Dispose();
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}
}
