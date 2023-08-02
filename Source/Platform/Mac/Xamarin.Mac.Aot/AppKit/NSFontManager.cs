using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontManager", true)]
public class NSFontManager : NSObject
{
	private static readonly IntPtr selSharedFontManagerHandle = Selector.GetHandle("sharedFontManager");

	private static readonly IntPtr selIsMultipleHandle = Selector.GetHandle("isMultiple");

	private static readonly IntPtr selSelectedFontHandle = Selector.GetHandle("selectedFont");

	private static readonly IntPtr selAvailableFontsHandle = Selector.GetHandle("availableFonts");

	private static readonly IntPtr selAvailableFontFamiliesHandle = Selector.GetHandle("availableFontFamilies");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCollectionNamesHandle = Selector.GetHandle("collectionNames");

	private static readonly IntPtr selCurrentFontActionHandle = Selector.GetHandle("currentFontAction");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selSetFontPanelFactory_Handle = Selector.GetHandle("setFontPanelFactory:");

	private static readonly IntPtr selSetFontManagerFactory_Handle = Selector.GetHandle("setFontManagerFactory:");

	private static readonly IntPtr selSetSelectedFontIsMultiple_Handle = Selector.GetHandle("setSelectedFont:isMultiple:");

	private static readonly IntPtr selSetFontMenu_Handle = Selector.GetHandle("setFontMenu:");

	private static readonly IntPtr selFontMenu_Handle = Selector.GetHandle("fontMenu:");

	private static readonly IntPtr selFontPanel_Handle = Selector.GetHandle("fontPanel:");

	private static readonly IntPtr selFontWithFamilyTraitsWeightSize_Handle = Selector.GetHandle("fontWithFamily:traits:weight:size:");

	private static readonly IntPtr selTraitsOfFont_Handle = Selector.GetHandle("traitsOfFont:");

	private static readonly IntPtr selWeightOfFont_Handle = Selector.GetHandle("weightOfFont:");

	private static readonly IntPtr selAvailableMembersOfFontFamily_Handle = Selector.GetHandle("availableMembersOfFontFamily:");

	private static readonly IntPtr selConvertFont_Handle = Selector.GetHandle("convertFont:");

	private static readonly IntPtr selConvertFontToSize_Handle = Selector.GetHandle("convertFont:toSize:");

	private static readonly IntPtr selConvertFontToFace_Handle = Selector.GetHandle("convertFont:toFace:");

	private static readonly IntPtr selConvertFontToFamily_Handle = Selector.GetHandle("convertFont:toFamily:");

	private static readonly IntPtr selConvertFontToHaveTrait_Handle = Selector.GetHandle("convertFont:toHaveTrait:");

	private static readonly IntPtr selConvertFontToNotHaveTrait_Handle = Selector.GetHandle("convertFont:toNotHaveTrait:");

	private static readonly IntPtr selConvertWeightOfFont_Handle = Selector.GetHandle("convertWeight:ofFont:");

	private static readonly IntPtr selLocalizedNameForFamilyFace_Handle = Selector.GetHandle("localizedNameForFamily:face:");

	private static readonly IntPtr selSetSelectedAttributesIsMultiple_Handle = Selector.GetHandle("setSelectedAttributes:isMultiple:");

	private static readonly IntPtr selConvertAttributes_Handle = Selector.GetHandle("convertAttributes:");

	private static readonly IntPtr selAvailableFontNamesMatchingFontDescriptor_Handle = Selector.GetHandle("availableFontNamesMatchingFontDescriptor:");

	private static readonly IntPtr selFontDescriptorsInCollection_Handle = Selector.GetHandle("fontDescriptorsInCollection:");

	private static readonly IntPtr selAddCollectionOptions_Handle = Selector.GetHandle("addCollection:options:");

	private static readonly IntPtr selRemoveCollection_Handle = Selector.GetHandle("removeCollection:");

	private static readonly IntPtr selAddFontDescriptorsToCollection_Handle = Selector.GetHandle("addFontDescriptors:toCollection:");

	private static readonly IntPtr selRemoveFontDescriptorFromCollection_Handle = Selector.GetHandle("removeFontDescriptor:fromCollection:");

	private static readonly IntPtr selConvertFontTraits_Handle = Selector.GetHandle("convertFontTraits:");

	private static readonly IntPtr selFontNamedHasTraits_Handle = Selector.GetHandle("fontNamed:hasTraits:");

	private static readonly IntPtr selAvailableFontNamesWithTraits_Handle = Selector.GetHandle("availableFontNamesWithTraits:");

	private static readonly IntPtr selAddFontTrait_Handle = Selector.GetHandle("addFontTrait:");

	private static readonly IntPtr selRemoveFontTrait_Handle = Selector.GetHandle("removeFontTrait:");

	private static readonly IntPtr selModifyFontViaPanel_Handle = Selector.GetHandle("modifyFontViaPanel:");

	private static readonly IntPtr selModifyFont_Handle = Selector.GetHandle("modifyFont:");

	private static readonly IntPtr selOrderFrontFontPanel_Handle = Selector.GetHandle("orderFrontFontPanel:");

	private static readonly IntPtr selOrderFrontStylesPanel_Handle = Selector.GetHandle("orderFrontStylesPanel:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFontManager");

	private static object __mt_SharedFontManager_var_static;

	private object __mt_SelectedFont_var;

	private object __mt_WeakDelegate_var;

	private object __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSFontManager SharedFontManager
	{
		[Export("sharedFontManager")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFontManager)(__mt_SharedFontManager_var_static = (NSFontManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedFontManagerHandle)));
		}
	}

	public virtual bool IsMultiple
	{
		[Export("isMultiple")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMultipleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMultipleHandle);
		}
	}

	public virtual NSFont SelectedFont
	{
		[Export("selectedFont")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSFont)(__mt_SelectedFont_var = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedFontHandle))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedFontHandle)))));
		}
	}

	public virtual string[] AvailableFonts
	{
		[Export("availableFonts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableFontsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableFontsHandle));
		}
	}

	public virtual string[] AvailableFontFamilies
	{
		[Export("availableFontFamilies")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableFontFamiliesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableFontFamiliesHandle));
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	public virtual Selector Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	public virtual bool SendAction
	{
		[Export("sendAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendActionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendActionHandle);
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public virtual string[] CollectionNames
	{
		[Export("collectionNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionNamesHandle));
		}
	}

	public virtual long CurrentFontAction
	{
		[Export("currentFontAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCurrentFontActionHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCurrentFontActionHandle);
		}
	}

	public virtual NSObject Target
	{
		[Export("target")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Target_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle))));
		}
		[Export("setTarget:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_Target_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontManager()
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
	public NSFontManager(NSCoder coder)
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
	public NSFontManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFontManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setFontPanelFactory:")]
	public static void SetFontPanelFactory(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetFontPanelFactory_Handle, factoryId.Handle);
	}

	[Export("setFontManagerFactory:")]
	public static void SetFontManagerFactory(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetFontManagerFactory_Handle, factoryId.Handle);
	}

	[Export("setSelectedFont:isMultiple:")]
	public virtual void SetSelectedFont(NSFont fontObj, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectedFontIsMultiple_Handle, fontObj.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectedFontIsMultiple_Handle, fontObj.Handle, isMultiple);
		}
	}

	[Export("setFontMenu:")]
	public virtual void SetFontMenu(NSMenu newMenu)
	{
		NSApplication.EnsureUIThread();
		if (newMenu == null)
		{
			throw new ArgumentNullException("newMenu");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFontMenu_Handle, newMenu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFontMenu_Handle, newMenu.Handle);
		}
	}

	[Export("fontMenu:")]
	public virtual NSMenu FontMenu(bool create)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selFontMenu_Handle, create));
		}
		return (NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selFontMenu_Handle, create));
	}

	[Export("fontPanel:")]
	public virtual NSFontPanel FontPanel(bool create)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFontPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selFontPanel_Handle, create));
		}
		return (NSFontPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selFontPanel_Handle, create));
	}

	[Export("fontWithFamily:traits:weight:size:")]
	public virtual NSFont FontWithFamily(string family, NSFontTraitMask traits, long weight, double size)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFont result = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_Int64_Double(base.SuperHandle, selFontWithFamilyTraitsWeightSize_Handle, arg, (ulong)traits, weight, size))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_Int64_Double(base.Handle, selFontWithFamilyTraitsWeightSize_Handle, arg, (ulong)traits, weight, size))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("traitsOfFont:")]
	public virtual NSFontTraitMask TraitsOfFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFontTraitMask)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selTraitsOfFont_Handle, fontObj.Handle);
		}
		return (NSFontTraitMask)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selTraitsOfFont_Handle, fontObj.Handle);
	}

	[Export("weightOfFont:")]
	public virtual long WeightOfFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selWeightOfFont_Handle, fontObj.Handle);
		}
		return Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selWeightOfFont_Handle, fontObj.Handle);
	}

	[Export("availableMembersOfFontFamily:")]
	public virtual NSArray[] AvailableMembersOfFontFamily(string fam)
	{
		NSApplication.EnsureUIThread();
		if (fam == null)
		{
			throw new ArgumentNullException("fam");
		}
		IntPtr arg = NSString.CreateNative(fam);
		NSArray[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableMembersOfFontFamily_Handle, arg)) : NSArray.ArrayFromHandle<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableMembersOfFontFamily_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertFont:")]
	public virtual NSFont ConvertFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConvertFont_Handle, fontObj.Handle));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConvertFont_Handle, fontObj.Handle));
	}

	[Export("convertFont:toSize:")]
	public virtual NSFont ConvertFont(NSFont fontObj, double size)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_Double(base.Handle, selConvertFontToSize_Handle, fontObj.Handle, size));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selConvertFontToSize_Handle, fontObj.Handle, size));
	}

	[Export("convertFont:toFace:")]
	public virtual NSFont ConvertFont(NSFont fontObj, string typeface)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (typeface == null)
		{
			throw new ArgumentNullException("typeface");
		}
		IntPtr arg = NSString.CreateNative(typeface);
		NSFont result = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConvertFontToFace_Handle, fontObj.Handle, arg))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selConvertFontToFace_Handle, fontObj.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertFont:toFamily:")]
	public virtual NSFont ConvertFontToFamily(NSFont fontObj, string family)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFont result = ((!IsDirectBinding) ? ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConvertFontToFamily_Handle, fontObj.Handle, arg))) : ((NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selConvertFontToFamily_Handle, fontObj.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertFont:toHaveTrait:")]
	public virtual NSFont ConvertFont(NSFont fontObj, NSFontTraitMask trait)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selConvertFontToHaveTrait_Handle, fontObj.Handle, (ulong)trait));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selConvertFontToHaveTrait_Handle, fontObj.Handle, (ulong)trait));
	}

	[Export("convertFont:toNotHaveTrait:")]
	public virtual NSFont ConvertFontToNotHaveTrait(NSFont fontObj, NSFontTraitMask trait)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selConvertFontToNotHaveTrait_Handle, fontObj.Handle, (ulong)trait));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selConvertFontToNotHaveTrait_Handle, fontObj.Handle, (ulong)trait));
	}

	[Export("convertWeight:ofFont:")]
	public virtual NSFont ConvertWeight(bool increaseWeight, NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool_IntPtr(base.Handle, selConvertWeightOfFont_Handle, increaseWeight, fontObj.Handle));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selConvertWeightOfFont_Handle, increaseWeight, fontObj.Handle));
	}

	[Export("localizedNameForFamily:face:")]
	public virtual string LocalizedNameForFamily(string family, string faceKey)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		if (faceKey == null)
		{
			throw new ArgumentNullException("faceKey");
		}
		IntPtr arg = NSString.CreateNative(family);
		IntPtr arg2 = NSString.CreateNative(faceKey);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLocalizedNameForFamilyFace_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLocalizedNameForFamilyFace_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setSelectedAttributes:isMultiple:")]
	public virtual void SetSelectedAttributes(NSDictionary attributes, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectedAttributesIsMultiple_Handle, attributes.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectedAttributesIsMultiple_Handle, attributes.Handle, isMultiple);
		}
	}

	[Export("convertAttributes:")]
	public virtual NSDictionary ConvertAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConvertAttributes_Handle, attributes.Handle));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConvertAttributes_Handle, attributes.Handle));
	}

	[Export("availableFontNamesMatchingFontDescriptor:")]
	public virtual string[] AvailableFontNamesMatchingFontDescriptor(NSFontDescriptor descriptor)
	{
		NSApplication.EnsureUIThread();
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableFontNamesMatchingFontDescriptor_Handle, descriptor.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableFontNamesMatchingFontDescriptor_Handle, descriptor.Handle));
	}

	[Export("fontDescriptorsInCollection:")]
	public virtual NSArray FontDescriptorsInCollection(string collectionNames)
	{
		NSApplication.EnsureUIThread();
		if (collectionNames == null)
		{
			throw new ArgumentNullException("collectionNames");
		}
		IntPtr arg = NSString.CreateNative(collectionNames);
		NSArray result = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorsInCollection_Handle, arg))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorsInCollection_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addCollection:options:")]
	public virtual bool AddCollection(string collectionName, NSFontCollectionOptions collectionOptions)
	{
		NSApplication.EnsureUIThread();
		if (collectionName == null)
		{
			throw new ArgumentNullException("collectionName");
		}
		IntPtr arg = NSString.CreateNative(collectionName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selAddCollectionOptions_Handle, arg, (ulong)collectionOptions) : Messaging.bool_objc_msgSend_IntPtr_UInt64(base.Handle, selAddCollectionOptions_Handle, arg, (ulong)collectionOptions));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeCollection:")]
	public virtual bool RemoveCollection(string collectionName)
	{
		NSApplication.EnsureUIThread();
		if (collectionName == null)
		{
			throw new ArgumentNullException("collectionName");
		}
		IntPtr arg = NSString.CreateNative(collectionName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCollection_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveCollection_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addFontDescriptors:toCollection:")]
	public virtual void AddFontDescriptors(NSFontDescriptor[] descriptors, string collectionName)
	{
		NSApplication.EnsureUIThread();
		if (descriptors == null)
		{
			throw new ArgumentNullException("descriptors");
		}
		if (collectionName == null)
		{
			throw new ArgumentNullException("collectionName");
		}
		NSArray nSArray = NSArray.FromNSObjects(descriptors);
		IntPtr arg = NSString.CreateNative(collectionName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddFontDescriptorsToCollection_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddFontDescriptorsToCollection_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("removeFontDescriptor:fromCollection:")]
	public virtual void RemoveFontDescriptor(NSFontDescriptor descriptor, string collection)
	{
		NSApplication.EnsureUIThread();
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (collection == null)
		{
			throw new ArgumentNullException("collection");
		}
		IntPtr arg = NSString.CreateNative(collection);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFontDescriptorFromCollection_Handle, descriptor.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFontDescriptorFromCollection_Handle, descriptor.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("convertFontTraits:")]
	public virtual NSFontTraitMask ConvertFontTraits(NSFontTraitMask traits)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSFontTraitMask)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selConvertFontTraits_Handle, (ulong)traits);
		}
		return (NSFontTraitMask)Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selConvertFontTraits_Handle, (ulong)traits);
	}

	[Export("fontNamed:hasTraits:")]
	public virtual bool FontNamedHasTraits(string fName, NSFontTraitMask someTraits)
	{
		NSApplication.EnsureUIThread();
		if (fName == null)
		{
			throw new ArgumentNullException("fName");
		}
		IntPtr arg = NSString.CreateNative(fName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selFontNamedHasTraits_Handle, arg, (ulong)someTraits) : Messaging.bool_objc_msgSend_IntPtr_UInt64(base.Handle, selFontNamedHasTraits_Handle, arg, (ulong)someTraits));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("availableFontNamesWithTraits:")]
	public virtual string[] AvailableFontNamesWithTraits(NSFontTraitMask someTraits)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selAvailableFontNamesWithTraits_Handle, (ulong)someTraits));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selAvailableFontNamesWithTraits_Handle, (ulong)someTraits));
	}

	[Export("addFontTrait:")]
	public virtual void AddFontTrait(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddFontTrait_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFontTrait_Handle, sender.Handle);
		}
	}

	[Export("removeFontTrait:")]
	public virtual void RemoveFontTrait(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFontTrait_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFontTrait_Handle, sender.Handle);
		}
	}

	[Export("modifyFontViaPanel:")]
	public virtual void ModifyFontViaPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selModifyFontViaPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selModifyFontViaPanel_Handle, sender.Handle);
		}
	}

	[Export("modifyFont:")]
	public virtual void ModifyFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selModifyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selModifyFont_Handle, sender.Handle);
		}
	}

	[Export("orderFrontFontPanel:")]
	public virtual void OrderFrontFontPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontFontPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontFontPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontStylesPanel:")]
	public virtual void OrderFrontStylesPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontStylesPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontStylesPanel_Handle, sender.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_SelectedFont_var = null;
			__mt_WeakDelegate_var = null;
			__mt_Target_var = null;
		}
	}
}
