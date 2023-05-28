using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontCollection", true)]
public class NSFontCollection : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveChanged(EventHandler<NSFontCollectionChangedEventArgs> handler)
		{
			EventHandler<NSFontCollectionChangedEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFontCollectionChangedEventArgs(notification));
			});
		}

		public static NSObject ObserveChanged(NSObject objectToObserve, EventHandler<NSFontCollectionChangedEventArgs> handler)
		{
			EventHandler<NSFontCollectionChangedEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFontCollectionChangedEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllFontCollectionNames = "allFontCollectionNames";

	private static readonly IntPtr selAllFontCollectionNamesHandle = Selector.GetHandle("allFontCollectionNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExclusionDescriptors = "exclusionDescriptors";

	private static readonly IntPtr selExclusionDescriptorsHandle = Selector.GetHandle("exclusionDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithAllAvailableDescriptors = "fontCollectionWithAllAvailableDescriptors";

	private static readonly IntPtr selFontCollectionWithAllAvailableDescriptorsHandle = Selector.GetHandle("fontCollectionWithAllAvailableDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithDescriptors_ = "fontCollectionWithDescriptors:";

	private static readonly IntPtr selFontCollectionWithDescriptors_Handle = Selector.GetHandle("fontCollectionWithDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithLocale_ = "fontCollectionWithLocale:";

	private static readonly IntPtr selFontCollectionWithLocale_Handle = Selector.GetHandle("fontCollectionWithLocale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithName_ = "fontCollectionWithName:";

	private static readonly IntPtr selFontCollectionWithName_Handle = Selector.GetHandle("fontCollectionWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontCollectionWithName_Visibility_ = "fontCollectionWithName:visibility:";

	private static readonly IntPtr selFontCollectionWithName_Visibility_Handle = Selector.GetHandle("fontCollectionWithName:visibility:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHideFontCollectionWithName_Visibility_Error_ = "hideFontCollectionWithName:visibility:error:";

	private static readonly IntPtr selHideFontCollectionWithName_Visibility_Error_Handle = Selector.GetHandle("hideFontCollectionWithName:visibility:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingDescriptors = "matchingDescriptors";

	private static readonly IntPtr selMatchingDescriptorsHandle = Selector.GetHandle("matchingDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingDescriptorsForFamily_ = "matchingDescriptorsForFamily:";

	private static readonly IntPtr selMatchingDescriptorsForFamily_Handle = Selector.GetHandle("matchingDescriptorsForFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingDescriptorsForFamily_Options_ = "matchingDescriptorsForFamily:options:";

	private static readonly IntPtr selMatchingDescriptorsForFamily_Options_Handle = Selector.GetHandle("matchingDescriptorsForFamily:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchingDescriptorsWithOptions_ = "matchingDescriptorsWithOptions:";

	private static readonly IntPtr selMatchingDescriptorsWithOptions_Handle = Selector.GetHandle("matchingDescriptorsWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryDescriptors = "queryDescriptors";

	private static readonly IntPtr selQueryDescriptorsHandle = Selector.GetHandle("queryDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenameFontCollectionWithName_Visibility_ToName_Error_ = "renameFontCollectionWithName:visibility:toName:error:";

	private static readonly IntPtr selRenameFontCollectionWithName_Visibility_ToName_Error_Handle = Selector.GetHandle("renameFontCollectionWithName:visibility:toName:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowFontCollection_WithName_Visibility_Error_ = "showFontCollection:withName:visibility:error:";

	private static readonly IntPtr selShowFontCollection_WithName_Visibility_Error_Handle = Selector.GetHandle("showFontCollection:withName:visibility:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFontCollection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActionKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActionWasHidden;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActionWasRenamed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ActionWasShown;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DisallowAutoActivationOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IncludeDisabledFontsOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameAllFonts;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameFavorites;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameRecentlyUsed;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NameUser;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OldNameKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemoveDuplicatesOption;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _VisibilityKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] AllFontCollectionNames
	{
		[Export("allFontCollectionNames", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAllFontCollectionNamesHandle));
		}
	}

	[Field("NSFontCollectionActionKey", "AppKit")]
	public static NSString ActionKey
	{
		get
		{
			if (_ActionKey == null)
			{
				_ActionKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionActionKey");
			}
			return _ActionKey;
		}
	}

	[Field("NSFontCollectionWasHidden", "AppKit")]
	public static NSString ActionWasHidden
	{
		get
		{
			if (_ActionWasHidden == null)
			{
				_ActionWasHidden = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionWasHidden");
			}
			return _ActionWasHidden;
		}
	}

	[Field("NSFontCollectionWasRenamed", "AppKit")]
	public static NSString ActionWasRenamed
	{
		get
		{
			if (_ActionWasRenamed == null)
			{
				_ActionWasRenamed = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionWasRenamed");
			}
			return _ActionWasRenamed;
		}
	}

	[Field("NSFontCollectionWasShown", "AppKit")]
	public static NSString ActionWasShown
	{
		get
		{
			if (_ActionWasShown == null)
			{
				_ActionWasShown = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionWasShown");
			}
			return _ActionWasShown;
		}
	}

	[Field("NSFontCollectionDidChangeNotification", "AppKit")]
	[Advice("Use NSFontCollection.Notifications.ObserveChanged helper method instead.")]
	public static NSString ChangedNotification
	{
		get
		{
			if (_ChangedNotification == null)
			{
				_ChangedNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionDidChangeNotification");
			}
			return _ChangedNotification;
		}
	}

	[Field("NSFontCollectionDisallowAutoActivationOption", "AppKit")]
	public static NSString DisallowAutoActivationOption
	{
		get
		{
			if (_DisallowAutoActivationOption == null)
			{
				_DisallowAutoActivationOption = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionDisallowAutoActivationOption");
			}
			return _DisallowAutoActivationOption;
		}
	}

	[Field("NSFontCollectionIncludeDisabledFontsOption", "AppKit")]
	public static NSString IncludeDisabledFontsOption
	{
		get
		{
			if (_IncludeDisabledFontsOption == null)
			{
				_IncludeDisabledFontsOption = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionIncludeDisabledFontsOption");
			}
			return _IncludeDisabledFontsOption;
		}
	}

	[Field("NSFontCollectionAllFonts", "AppKit")]
	public static NSString NameAllFonts
	{
		get
		{
			if (_NameAllFonts == null)
			{
				_NameAllFonts = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionAllFonts");
			}
			return _NameAllFonts;
		}
	}

	[Field("NSFontCollectionFavorites", "AppKit")]
	public static NSString NameFavorites
	{
		get
		{
			if (_NameFavorites == null)
			{
				_NameFavorites = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionFavorites");
			}
			return _NameFavorites;
		}
	}

	[Field("NSFontCollectionNameKey", "AppKit")]
	public static NSString NameKey
	{
		get
		{
			if (_NameKey == null)
			{
				_NameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionNameKey");
			}
			return _NameKey;
		}
	}

	[Field("NSFontCollectionRecentlyUsed", "AppKit")]
	public static NSString NameRecentlyUsed
	{
		get
		{
			if (_NameRecentlyUsed == null)
			{
				_NameRecentlyUsed = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionRecentlyUsed");
			}
			return _NameRecentlyUsed;
		}
	}

	[Field("NSFontCollectionUser", "AppKit")]
	public static NSString NameUser
	{
		get
		{
			if (_NameUser == null)
			{
				_NameUser = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionUser");
			}
			return _NameUser;
		}
	}

	[Field("NSFontCollectionOldNameKey", "AppKit")]
	public static NSString OldNameKey
	{
		get
		{
			if (_OldNameKey == null)
			{
				_OldNameKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionOldNameKey");
			}
			return _OldNameKey;
		}
	}

	[Field("NSFontCollectionRemoveDuplicatesOption", "AppKit")]
	public static NSString RemoveDuplicatesOption
	{
		get
		{
			if (_RemoveDuplicatesOption == null)
			{
				_RemoveDuplicatesOption = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionRemoveDuplicatesOption");
			}
			return _RemoveDuplicatesOption;
		}
	}

	[Field("NSFontCollectionVisibilityKey", "AppKit")]
	public static NSString VisibilityKey
	{
		get
		{
			if (_VisibilityKey == null)
			{
				_VisibilityKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontCollectionVisibilityKey");
			}
			return _VisibilityKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontCollection()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSFontCollection(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSFontCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFontCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
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
		NSApplication.EnsureUIThread();
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

	[Export("fontCollectionWithDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontCollection FromDescriptors(NSFontDescriptor[] queryDescriptors)
	{
		NSApplication.EnsureUIThread();
		if (queryDescriptors == null)
		{
			throw new ArgumentNullException("queryDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(queryDescriptors);
		NSFontCollection nSObject = Runtime.GetNSObject<NSFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithDescriptors_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("fontCollectionWithLocale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontCollection FromLocale(NSLocale locale)
	{
		NSApplication.EnsureUIThread();
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		return Runtime.GetNSObject<NSFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithLocale_Handle, locale.Handle));
	}

	[Export("fontCollectionWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontCollection FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFontCollection nSObject = Runtime.GetNSObject<NSFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fontCollectionWithName:visibility:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontCollection FromName(string name, NSFontCollectionVisibility visibility)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFontCollection nSObject = Runtime.GetNSObject<NSFontCollection>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selFontCollectionWithName_Visibility_Handle, arg, (ulong)visibility));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fontCollectionWithAllAvailableDescriptors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontCollection GetAllAvailableFonts()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSFontCollection>(Messaging.IntPtr_objc_msgSend(class_ptr, selFontCollectionWithAllAvailableDescriptorsHandle));
	}

	[Export("exclusionDescriptors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetExclusionDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selExclusionDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExclusionDescriptorsHandle));
	}

	[Export("matchingDescriptors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetMatchingDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchingDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchingDescriptorsHandle));
	}

	[Export("matchingDescriptorsWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetMatchingDescriptors(NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingDescriptorsWithOptions_Handle, options.Handle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingDescriptorsWithOptions_Handle, options.Handle));
	}

	[Export("matchingDescriptorsForFamily:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetMatchingDescriptors(string family)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFontDescriptor[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingDescriptorsForFamily_Handle, arg)) : NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingDescriptorsForFamily_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("matchingDescriptorsForFamily:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetMatchingDescriptors(string family, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFontDescriptor[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMatchingDescriptorsForFamily_Options_Handle, arg, options.Handle)) : NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMatchingDescriptorsForFamily_Options_Handle, arg, options.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryDescriptors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] GetQueryDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selQueryDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueryDescriptorsHandle));
	}

	[Export("hideFontCollectionWithName:visibility:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool HideFontCollection(string name, NSFontCollectionVisibility visibility, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		bool result = Messaging.bool_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selHideFontCollectionWithName_Visibility_Error_Handle, arg2, (ulong)visibility, ref arg);
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("renameFontCollectionWithName:visibility:toName:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool RenameFontCollection(string fromName, NSFontCollectionVisibility visibility, string toName, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (fromName == null)
		{
			throw new ArgumentNullException("fromName");
		}
		if (toName == null)
		{
			throw new ArgumentNullException("toName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(fromName);
		IntPtr arg3 = NSString.CreateNative(toName);
		bool result = Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_ref_IntPtr(class_ptr, selRenameFontCollectionWithName_Visibility_ToName_Error_Handle, arg2, (ulong)visibility, arg3, ref arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("showFontCollection:withName:visibility:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShowFontCollection(NSFontCollection fontCollection, string name, NSFontCollectionVisibility visibility, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (fontCollection == null)
		{
			throw new ArgumentNullException("fontCollection");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(class_ptr, selShowFontCollection_WithName_Visibility_Error_Handle, fontCollection.Handle, arg2, (ulong)visibility, ref arg);
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
