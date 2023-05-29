using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontCollection", true)]
public class NSFontCollection : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveChanged(EventHandler<NSFontCollectionChangedEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSFontCollectionChangedEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selAllFontCollectionNamesHandle = Selector.GetHandle("allFontCollectionNames");

	private static readonly IntPtr selFontCollectionWithDescriptors_Handle = Selector.GetHandle("fontCollectionWithDescriptors:");

	private static readonly IntPtr selFontCollectionWithAllAvailableDescriptorsHandle = Selector.GetHandle("fontCollectionWithAllAvailableDescriptors");

	private static readonly IntPtr selFontCollectionWithLocale_Handle = Selector.GetHandle("fontCollectionWithLocale:");

	private static readonly IntPtr selShowFontCollectionWithNameVisibilityError_Handle = Selector.GetHandle("showFontCollection:withName:visibility:error:");

	private static readonly IntPtr selHideFontCollectionWithNameVisibilityError_Handle = Selector.GetHandle("hideFontCollectionWithName:visibility:error:");

	private static readonly IntPtr selRenameFontCollectionWithNameVisibilityToNameError_Handle = Selector.GetHandle("renameFontCollectionWithName:visibility:toName:error:");

	private static readonly IntPtr selFontCollectionWithName_Handle = Selector.GetHandle("fontCollectionWithName:");

	private static readonly IntPtr selFontCollectionWithNameVisibility_Handle = Selector.GetHandle("fontCollectionWithName:visibility:");

	private static readonly IntPtr selQueryDescriptorsHandle = Selector.GetHandle("queryDescriptors");

	private static readonly IntPtr selExclusionDescriptorsHandle = Selector.GetHandle("exclusionDescriptors");

	private static readonly IntPtr selMatchingDescriptorsHandle = Selector.GetHandle("matchingDescriptors");

	private static readonly IntPtr selMatchingDescriptorsWithOptions_Handle = Selector.GetHandle("matchingDescriptorsWithOptions:");

	private static readonly IntPtr selMatchingDescriptorsForFamily_Handle = Selector.GetHandle("matchingDescriptorsForFamily:");

	private static readonly IntPtr selMatchingDescriptorsForFamilyOptions_Handle = Selector.GetHandle("matchingDescriptorsForFamily:options:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFontCollection");

	private static NSString _IncludeDisabledFontsOption;

	private static NSString _RemoveDuplicatesOption;

	private static NSString _DisallowAutoActivationOption;

	private static NSString _ChangedNotification;

	private static NSString _ActionKey;

	private static NSString _NameKey;

	private static NSString _OldNameKey;

	private static NSString _VisibilityKey;

	private static NSString _ActionWasShown;

	private static NSString _ActionWasHidden;

	private static NSString _ActionWasRenamed;

	private static NSString _NameAllFonts;

	private static NSString _NameUser;

	private static NSString _NameFavorites;

	private static NSString _NameRecentlyUsed;

	public override IntPtr ClassHandle => class_ptr;

	public static string[] AllFontCollectionNames
	{
		[Export("allFontCollectionNames")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selAllFontCollectionNamesHandle));
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

	[Field("NSFontCollectionDidChangeNotification", "AppKit")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontCollection()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFontCollection(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFontCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFontCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("fontCollectionWithDescriptors:")]
	public static NSFontCollection FromDescriptors(NSFontDescriptor[] queryDescriptors)
	{
		NSApplication.EnsureUIThread();
		if (queryDescriptors == null)
		{
			throw new ArgumentNullException("queryDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(queryDescriptors);
		NSFontCollection result = (NSFontCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithDescriptors_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("fontCollectionWithAllAvailableDescriptors")]
	public static NSFontCollection GetAllAvailableFonts()
	{
		NSApplication.EnsureUIThread();
		return (NSFontCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFontCollectionWithAllAvailableDescriptorsHandle));
	}

	[Export("fontCollectionWithLocale:")]
	public static NSFontCollection FromLocale(NSLocale locale)
	{
		NSApplication.EnsureUIThread();
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		return (NSFontCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithLocale_Handle, locale.Handle));
	}

	[Export("showFontCollection:withName:visibility:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(name);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(class_ptr, selShowFontCollectionWithNameVisibilityError_Handle, fontCollection.Handle, arg, (ulong)visibility, intPtr);
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("hideFontCollectionWithName:visibility:error:")]
	public static bool HideFontCollection(string name, NSFontCollectionVisibility visibility, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(name);
		bool result = Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selHideFontCollectionWithNameVisibilityError_Handle, arg, (ulong)visibility, intPtr);
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("renameFontCollectionWithName:visibility:toName:error:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(fromName);
		IntPtr arg2 = NSString.CreateNative(toName);
		bool result = Messaging.bool_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selRenameFontCollectionWithNameVisibilityToNameError_Handle, arg, (ulong)visibility, arg2, intPtr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("fontCollectionWithName:")]
	public static NSFontCollection FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFontCollection result = (NSFontCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFontCollectionWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontCollectionWithName:visibility:")]
	public static NSFontCollection FromName(string name, NSFontCollectionVisibility visibility)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSFontCollection result = (NSFontCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selFontCollectionWithNameVisibility_Handle, arg, (ulong)visibility));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryDescriptors")]
	public virtual NSFontDescriptor[] GetQueryDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selQueryDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selQueryDescriptorsHandle));
	}

	[Export("exclusionDescriptors")]
	public virtual NSFontDescriptor[] GetExclusionDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selExclusionDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExclusionDescriptorsHandle));
	}

	[Export("matchingDescriptors")]
	public virtual NSFontDescriptor[] GetMatchingDescriptors()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchingDescriptorsHandle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchingDescriptorsHandle));
	}

	[Export("matchingDescriptorsWithOptions:")]
	public virtual NSFontDescriptor[] GetMatchingDescriptors(NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingDescriptorsWithOptions_Handle, options.Handle));
		}
		return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingDescriptorsWithOptions_Handle, options.Handle));
	}

	[Export("matchingDescriptorsForFamily:")]
	public virtual NSFontDescriptor[] GetMatchingDescriptors(string family)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFontDescriptor[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMatchingDescriptorsForFamily_Handle, arg)) : NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMatchingDescriptorsForFamily_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("matchingDescriptorsForFamily:options:")]
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
		NSFontDescriptor[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMatchingDescriptorsForFamilyOptions_Handle, arg, options.Handle)) : NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMatchingDescriptorsForFamilyOptions_Handle, arg, options.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
