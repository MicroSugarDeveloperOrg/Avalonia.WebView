using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMediaSelectionGroup", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMediaSelectionGroup : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsEmptySelection = "allowsEmptySelection";

	private static readonly IntPtr selAllowsEmptySelectionHandle = Selector.GetHandle("allowsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultOption = "defaultOption";

	private static readonly IntPtr selDefaultOptionHandle = Selector.GetHandle("defaultOption");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionWithPropertyList_ = "mediaSelectionOptionWithPropertyList:";

	private static readonly IntPtr selMediaSelectionOptionWithPropertyList_Handle = Selector.GetHandle("mediaSelectionOptionWithPropertyList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionsFromArray_FilteredAndSortedAccordingToPreferredLanguages_ = "mediaSelectionOptionsFromArray:filteredAndSortedAccordingToPreferredLanguages:";

	private static readonly IntPtr selMediaSelectionOptionsFromArray_FilteredAndSortedAccordingToPreferredLanguages_Handle = Selector.GetHandle("mediaSelectionOptionsFromArray:filteredAndSortedAccordingToPreferredLanguages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionsFromArray_WithLocale_ = "mediaSelectionOptionsFromArray:withLocale:";

	private static readonly IntPtr selMediaSelectionOptionsFromArray_WithLocale_Handle = Selector.GetHandle("mediaSelectionOptionsFromArray:withLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionsFromArray_WithMediaCharacteristics_ = "mediaSelectionOptionsFromArray:withMediaCharacteristics:";

	private static readonly IntPtr selMediaSelectionOptionsFromArray_WithMediaCharacteristics_Handle = Selector.GetHandle("mediaSelectionOptionsFromArray:withMediaCharacteristics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSelectionOptionsFromArray_WithoutMediaCharacteristics_ = "mediaSelectionOptionsFromArray:withoutMediaCharacteristics:";

	private static readonly IntPtr selMediaSelectionOptionsFromArray_WithoutMediaCharacteristics_Handle = Selector.GetHandle("mediaSelectionOptionsFromArray:withoutMediaCharacteristics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayableMediaSelectionOptionsFromArray_ = "playableMediaSelectionOptionsFromArray:";

	private static readonly IntPtr selPlayableMediaSelectionOptionsFromArray_Handle = Selector.GetHandle("playableMediaSelectionOptionsFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMediaSelectionGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsEmptySelection
	{
		[Export("allowsEmptySelection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEmptySelectionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual AVMediaSelectionOption? DefaultOption
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("defaultOption")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultOptionHandle));
			}
			return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultOptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption[] Options
	{
		[Export("options")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMediaSelectionGroup()
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
	protected AVMediaSelectionGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMediaSelectionGroup(IntPtr handle)
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

	[Export("mediaSelectionOptionWithPropertyList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMediaSelectionOption? GetMediaSelectionOptionForPropertyList(NSObject propertyList)
	{
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMediaSelectionOptionWithPropertyList_Handle, propertyList.Handle));
		}
		return Runtime.GetNSObject<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMediaSelectionOptionWithPropertyList_Handle, propertyList.Handle));
	}

	[Export("mediaSelectionOptionsFromArray:withLocale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMediaSelectionOption[] MediaSelectionOptions(AVMediaSelectionOption[] source, NSLocale locale)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		AVMediaSelectionOption[] result = NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMediaSelectionOptionsFromArray_WithLocale_Handle, nSArray.Handle, locale.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("mediaSelectionOptionsFromArray:withMediaCharacteristics:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMediaSelectionOption[] MediaSelectionOptions(AVMediaSelectionOption[] source, NSString[] avmediaCharacteristics)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (avmediaCharacteristics == null)
		{
			throw new ArgumentNullException("avmediaCharacteristics");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		NSArray nSArray2 = NSArray.FromNSObjects(avmediaCharacteristics);
		AVMediaSelectionOption[] result = NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMediaSelectionOptionsFromArray_WithMediaCharacteristics_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("mediaSelectionOptionsFromArray:withoutMediaCharacteristics:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMediaSelectionOption[] MediaSelectionOptionsExcludingCharacteristics(AVMediaSelectionOption[] source, NSString[] avmediaCharacteristics)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (avmediaCharacteristics == null)
		{
			throw new ArgumentNullException("avmediaCharacteristics");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		NSArray nSArray2 = NSArray.FromNSObjects(avmediaCharacteristics);
		AVMediaSelectionOption[] result = NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMediaSelectionOptionsFromArray_WithoutMediaCharacteristics_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("mediaSelectionOptionsFromArray:filteredAndSortedAccordingToPreferredLanguages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMediaSelectionOption[] MediaSelectionOptionsFilteredAndSorted(AVMediaSelectionOption[] mediaSelectionOptions, string[] preferredLanguages)
	{
		if (mediaSelectionOptions == null)
		{
			throw new ArgumentNullException("mediaSelectionOptions");
		}
		if (preferredLanguages == null)
		{
			throw new ArgumentNullException("preferredLanguages");
		}
		NSArray nSArray = NSArray.FromNSObjects(mediaSelectionOptions);
		NSArray nSArray2 = NSArray.FromStrings(preferredLanguages);
		AVMediaSelectionOption[] result = NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMediaSelectionOptionsFromArray_FilteredAndSortedAccordingToPreferredLanguages_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}

	[Export("playableMediaSelectionOptionsFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMediaSelectionOption[] PlayableMediaSelectionOptions(AVMediaSelectionOption[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		AVMediaSelectionOption[] result = NSArray.ArrayFromHandle<AVMediaSelectionOption>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayableMediaSelectionOptionsFromArray_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}
}
