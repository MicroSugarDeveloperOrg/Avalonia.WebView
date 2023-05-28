using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMediaSelectionOption", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMediaSelectionOption : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssociatedMediaSelectionOptionInMediaSelectionGroup_ = "associatedMediaSelectionOptionInMediaSelectionGroup:";

	private static readonly IntPtr selAssociatedMediaSelectionOptionInMediaSelectionGroup_Handle = Selector.GetHandle("associatedMediaSelectionOptionInMediaSelectionGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMetadataFormats = "availableMetadataFormats";

	private static readonly IntPtr selAvailableMetadataFormatsHandle = Selector.GetHandle("availableMetadataFormats");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonMetadata = "commonMetadata";

	private static readonly IntPtr selCommonMetadataHandle = Selector.GetHandle("commonMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameWithLocale_ = "displayNameWithLocale:";

	private static readonly IntPtr selDisplayNameWithLocale_Handle = Selector.GetHandle("displayNameWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMediaCharacteristic_ = "hasMediaCharacteristic:";

	private static readonly IntPtr selHasMediaCharacteristic_Handle = Selector.GetHandle("hasMediaCharacteristic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayable = "isPlayable";

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSubTypes = "mediaSubTypes";

	private static readonly IntPtr selMediaSubTypesHandle = Selector.GetHandle("mediaSubTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaType = "mediaType";

	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataForFormat_ = "metadataForFormat:";

	private static readonly IntPtr selMetadataForFormat_Handle = Selector.GetHandle("metadataForFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyList = "propertyList";

	private static readonly IntPtr selPropertyListHandle = Selector.GetHandle("propertyList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMediaSelectionOption");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableMetadataFormats
	{
		[Export("availableMetadataFormats")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableMetadataFormatsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableMetadataFormatsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] CommonMetadata
	{
		[Export("commonMetadata")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonMetadataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string DisplayName
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string? ExtendedLanguageTag
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("extendedLanguageTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale? Locale
	{
		[Export("locale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] MediaSubTypes
	{
		[Export("mediaSubTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaSubTypesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaSubTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Playable
	{
		[Export("isPlayable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PropertyList
	{
		[Export("propertyList")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPropertyListHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPropertyListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMediaSelectionOption()
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
	protected AVMediaSelectionOption(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMediaSelectionOption(IntPtr handle)
		: base(handle)
	{
	}

	[Export("associatedMediaSelectionOptionInMediaSelectionGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption? AssociatedMediaSelectionOptionInMediaSelectionGroup(AVMediaSelectionGroup mediaSelectionGroup)
	{
		if (mediaSelectionGroup == null)
		{
			throw new ArgumentNullException("mediaSelectionGroup");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAssociatedMediaSelectionOptionInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
		}
		return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAssociatedMediaSelectionOptionInMediaSelectionGroup_Handle, mediaSelectionGroup.Handle));
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

	[Export("displayNameWithLocale:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetDisplayName(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameWithLocale_Handle, locale.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameWithLocale_Handle, locale.Handle));
	}

	[Export("metadataForFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] GetMetadataForFormat(string format)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		IntPtr arg = NSString.CreateNative(format);
		AVMetadataItem[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMetadataForFormat_Handle, arg)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMetadataForFormat_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasMediaCharacteristic:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMediaCharacteristic(string mediaCharacteristic)
	{
		if (mediaCharacteristic == null)
		{
			throw new ArgumentNullException("mediaCharacteristic");
		}
		IntPtr arg = NSString.CreateNative(mediaCharacteristic);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasMediaCharacteristic_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasMediaCharacteristic_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}
