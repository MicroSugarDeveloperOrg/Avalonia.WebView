using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMetadataItem", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMetadataItem : NSObject, INSCopying, INativeObject, IDisposable, INSMutableCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommonKey = "commonKey";

	private static readonly IntPtr selCommonKeyHandle = Selector.GetHandle("commonKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataValue = "dataValue";

	private static readonly IntPtr selDataValueHandle = Selector.GetHandle("dataValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateValue = "dateValue";

	private static readonly IntPtr selDateValueHandle = Selector.GetHandle("dateValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendedLanguageTag = "extendedLanguageTag";

	private static readonly IntPtr selExtendedLanguageTagHandle = Selector.GetHandle("extendedLanguageTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtraAttributes = "extraAttributes";

	private static readonly IntPtr selExtraAttributesHandle = Selector.GetHandle("extraAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifierForKey_KeySpace_ = "identifierForKey:keySpace:";

	private static readonly IntPtr selIdentifierForKey_KeySpace_Handle = Selector.GetHandle("identifierForKey:keySpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKey = "key";

	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyForIdentifier_ = "keyForIdentifier:";

	private static readonly IntPtr selKeyForIdentifier_Handle = Selector.GetHandle("keyForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeySpace = "keySpace";

	private static readonly IntPtr selKeySpaceHandle = Selector.GetHandle("keySpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeySpaceForIdentifier_ = "keySpaceForIdentifier:";

	private static readonly IntPtr selKeySpaceForIdentifier_Handle = Selector.GetHandle("keySpaceForIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadValuesAsynchronouslyForKeys_CompletionHandler_ = "loadValuesAsynchronouslyForKeys:completionHandler:";

	private static readonly IntPtr selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle = Selector.GetHandle("loadValuesAsynchronouslyForKeys:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocale = "locale";

	private static readonly IntPtr selLocaleHandle = Selector.GetHandle("locale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_ = "metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:";

	private static readonly IntPtr selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_Handle = Selector.GetHandle("metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_ = "metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:";

	private static readonly IntPtr selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_Handle = Selector.GetHandle("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemsFromArray_FilteredByIdentifier_ = "metadataItemsFromArray:filteredByIdentifier:";

	private static readonly IntPtr selMetadataItemsFromArray_FilteredByIdentifier_Handle = Selector.GetHandle("metadataItemsFromArray:filteredByIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemsFromArray_FilteredByMetadataItemFilter_ = "metadataItemsFromArray:filteredByMetadataItemFilter:";

	private static readonly IntPtr selMetadataItemsFromArray_FilteredByMetadataItemFilter_Handle = Selector.GetHandle("metadataItemsFromArray:filteredByMetadataItemFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemsFromArray_WithKey_KeySpace_ = "metadataItemsFromArray:withKey:keySpace:";

	private static readonly IntPtr selMetadataItemsFromArray_WithKey_KeySpace_Handle = Selector.GetHandle("metadataItemsFromArray:withKey:keySpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemsFromArray_WithLocale_ = "metadataItemsFromArray:withLocale:";

	private static readonly IntPtr selMetadataItemsFromArray_WithLocale_Handle = Selector.GetHandle("metadataItemsFromArray:withLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberValue = "numberValue";

	private static readonly IntPtr selNumberValueHandle = Selector.GetHandle("numberValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusOfValueForKey_Error_ = "statusOfValueForKey:error:";

	private static readonly IntPtr selStatusOfValueForKey_Error_Handle = Selector.GetHandle("statusOfValueForKey:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTime = "time";

	private static readonly IntPtr selTimeHandle = Selector.GetHandle("time");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMetadataItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? CommonKey
	{
		[Export("commonKey", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCommonKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCommonKeyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSString? DataType
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("dataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataTypeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? DataValue
	{
		[Export("dataValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataValueHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? DateValue
	{
		[Export("dateValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateValueHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? ExtendedLanguageTag
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("extendedLanguageTag")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLanguageTagHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLanguageTagHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? ExtraAttributes
	{
		[Export("extraAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtraAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtraAttributesHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Key
	{
		[Export("key", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? KeySpace
	{
		[Export("keySpace", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeySpaceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeySpaceHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale? Locale
	{
		[Export("locale", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocaleHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSString? MetadataIdentifier
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? NumberValue
	{
		[Export("numberValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selNumberValueHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNumberValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDate? StartDate
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("startDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartDateHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? StringValue
	{
		[Export("stringValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Time
	{
		[Export("time")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeHandle);
			}
			return retval;
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Value
	{
		[Export("value", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMetadataItem()
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
	protected AVMetadataItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMetadataItem(IntPtr handle)
		: base(handle)
	{
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

	[Export("metadataItemsFromArray:filteredAndSortedAccordingToPreferredLanguages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItem[] FilterFromPreferredLanguages(AVMetadataItem[] metadataItems, string[] preferredLanguages)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		if (preferredLanguages == null)
		{
			throw new ArgumentNullException("preferredLanguages");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		NSArray nSArray2 = NSArray.FromStrings(preferredLanguages);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArray_FilteredAndSortedAccordingToPreferredLanguages_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("metadataItemsFromArray:filteredByIdentifier:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItem[] FilterWithIdentifier(AVMetadataItem[] metadataItems, NSString metadataIdentifer)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		if (metadataIdentifer == null)
		{
			throw new ArgumentNullException("metadataIdentifer");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArray_FilteredByIdentifier_Handle, nSArray.Handle, metadataIdentifer.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("metadataItemsFromArray:filteredByMetadataItemFilter:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItem[] FilterWithItemFilter(AVMetadataItem[] metadataItems, AVMetadataItemFilter metadataItemFilter)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		if (metadataItemFilter == null)
		{
			throw new ArgumentNullException("metadataItemFilter");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArray_FilteredByMetadataItemFilter_Handle, nSArray.Handle, metadataItemFilter.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("metadataItemsFromArray:withKey:keySpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItem[] FilterWithKey(AVMetadataItem[] metadataItems, NSObject? key, string? keySpace)
	{
		if (metadataItems == null)
		{
			throw new ArgumentNullException("metadataItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(metadataItems);
		IntPtr arg = NSString.CreateNative(keySpace);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArray_WithKey_KeySpace_Handle, nSArray.Handle, key?.Handle ?? IntPtr.Zero, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("metadataItemsFromArray:withLocale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItem[] FilterWithLocale(AVMetadataItem[] arrayToFilter, NSLocale locale)
	{
		if (arrayToFilter == null)
		{
			throw new ArgumentNullException("arrayToFilter");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		NSArray nSArray = NSArray.FromNSObjects(arrayToFilter);
		AVMetadataItem[] result = NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemsFromArray_WithLocale_Handle, nSArray.Handle, locale.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("keyForIdentifier:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetKeyForIdentifier(NSString identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKeyForIdentifier_Handle, identifier.Handle));
	}

	[Export("keySpaceForIdentifier:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString? GetKeySpaceForIdentifier(NSString identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKeySpaceForIdentifier_Handle, identifier.Handle));
	}

	[Export("identifierForKey:keySpace:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString? GetMetadataIdentifier(NSObject key, NSString keySpace)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (keySpace == null)
		{
			throw new ArgumentNullException("keySpace");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selIdentifierForKey_KeySpace_Handle, key.Handle, keySpace.Handle));
	}

	[Export("metadataItemWithPropertiesOfMetadataItem:valueLoadingHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static AVMetadataItem GetMetadataItem(AVMetadataItem metadataItem, [BlockProxy(typeof(Trampolines.NIDActionArity1V3))] Action<AVMetadataItemValueRequest> handler)
	{
		if (metadataItem == null)
		{
			throw new ArgumentNullException("metadataItem");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V3.Handler, handler);
		AVMetadataItem nSObject = Runtime.GetNSObject<AVMetadataItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMetadataItemWithPropertiesOfMetadataItem_ValueLoadingHandler_Handle, metadataItem.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadValuesAsynchronously(string[] keys, [BlockProxy(typeof(Trampolines.NIDAction))] Action? handler)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadValuesAsynchronouslyForKeys_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task LoadValuesTaskAsync(string[] keys)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		LoadValuesAsynchronously(keys, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("statusOfValueForKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVKeyValueStatus StatusOfValueForKeyerror(string key, out NSError error)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(key);
		AVKeyValueStatus result = (AVKeyValueStatus)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selStatusOfValueForKey_Error_Handle, arg2, ref arg) : Messaging.Int64_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selStatusOfValueForKey_Error_Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
