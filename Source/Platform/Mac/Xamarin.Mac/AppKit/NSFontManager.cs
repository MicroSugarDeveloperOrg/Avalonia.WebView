using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSFontManager", true)]
public class NSFontManager : NSObject, INSMenuItemValidation, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAction = "action";

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddCollection_Options_ = "addCollection:options:";

	private static readonly IntPtr selAddCollection_Options_Handle = Selector.GetHandle("addCollection:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFontDescriptors_ToCollection_ = "addFontDescriptors:toCollection:";

	private static readonly IntPtr selAddFontDescriptors_ToCollection_Handle = Selector.GetHandle("addFontDescriptors:toCollection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFontTrait_ = "addFontTrait:";

	private static readonly IntPtr selAddFontTrait_Handle = Selector.GetHandle("addFontTrait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableFontFamilies = "availableFontFamilies";

	private static readonly IntPtr selAvailableFontFamiliesHandle = Selector.GetHandle("availableFontFamilies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableFontNamesMatchingFontDescriptor_ = "availableFontNamesMatchingFontDescriptor:";

	private static readonly IntPtr selAvailableFontNamesMatchingFontDescriptor_Handle = Selector.GetHandle("availableFontNamesMatchingFontDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableFontNamesWithTraits_ = "availableFontNamesWithTraits:";

	private static readonly IntPtr selAvailableFontNamesWithTraits_Handle = Selector.GetHandle("availableFontNamesWithTraits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableFonts = "availableFonts";

	private static readonly IntPtr selAvailableFontsHandle = Selector.GetHandle("availableFonts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableMembersOfFontFamily_ = "availableMembersOfFontFamily:";

	private static readonly IntPtr selAvailableMembersOfFontFamily_Handle = Selector.GetHandle("availableMembersOfFontFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionNames = "collectionNames";

	private static readonly IntPtr selCollectionNamesHandle = Selector.GetHandle("collectionNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertAttributes_ = "convertAttributes:";

	private static readonly IntPtr selConvertAttributes_Handle = Selector.GetHandle("convertAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ = "convertFont:";

	private static readonly IntPtr selConvertFont_Handle = Selector.GetHandle("convertFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ToFace_ = "convertFont:toFace:";

	private static readonly IntPtr selConvertFont_ToFace_Handle = Selector.GetHandle("convertFont:toFace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ToFamily_ = "convertFont:toFamily:";

	private static readonly IntPtr selConvertFont_ToFamily_Handle = Selector.GetHandle("convertFont:toFamily:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ToHaveTrait_ = "convertFont:toHaveTrait:";

	private static readonly IntPtr selConvertFont_ToHaveTrait_Handle = Selector.GetHandle("convertFont:toHaveTrait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ToNotHaveTrait_ = "convertFont:toNotHaveTrait:";

	private static readonly IntPtr selConvertFont_ToNotHaveTrait_Handle = Selector.GetHandle("convertFont:toNotHaveTrait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFont_ToSize_ = "convertFont:toSize:";

	private static readonly IntPtr selConvertFont_ToSize_Handle = Selector.GetHandle("convertFont:toSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertFontTraits_ = "convertFontTraits:";

	private static readonly IntPtr selConvertFontTraits_Handle = Selector.GetHandle("convertFontTraits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertWeight_OfFont_ = "convertWeight:ofFont:";

	private static readonly IntPtr selConvertWeight_OfFont_Handle = Selector.GetHandle("convertWeight:ofFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentFontAction = "currentFontAction";

	private static readonly IntPtr selCurrentFontActionHandle = Selector.GetHandle("currentFontAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontDescriptorsInCollection_ = "fontDescriptorsInCollection:";

	private static readonly IntPtr selFontDescriptorsInCollection_Handle = Selector.GetHandle("fontDescriptorsInCollection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontMenu_ = "fontMenu:";

	private static readonly IntPtr selFontMenu_Handle = Selector.GetHandle("fontMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontNamed_HasTraits_ = "fontNamed:hasTraits:";

	private static readonly IntPtr selFontNamed_HasTraits_Handle = Selector.GetHandle("fontNamed:hasTraits:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontPanel_ = "fontPanel:";

	private static readonly IntPtr selFontPanel_Handle = Selector.GetHandle("fontPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontWithFamily_Traits_Weight_Size_ = "fontWithFamily:traits:weight:size:";

	private static readonly IntPtr selFontWithFamily_Traits_Weight_Size_Handle = Selector.GetHandle("fontWithFamily:traits:weight:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMultiple = "isMultiple";

	private static readonly IntPtr selIsMultipleHandle = Selector.GetHandle("isMultiple");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameForFamily_Face_ = "localizedNameForFamily:face:";

	private static readonly IntPtr selLocalizedNameForFamily_Face_Handle = Selector.GetHandle("localizedNameForFamily:face:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyFont_ = "modifyFont:";

	private static readonly IntPtr selModifyFont_Handle = Selector.GetHandle("modifyFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModifyFontViaPanel_ = "modifyFontViaPanel:";

	private static readonly IntPtr selModifyFontViaPanel_Handle = Selector.GetHandle("modifyFontViaPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontFontPanel_ = "orderFrontFontPanel:";

	private static readonly IntPtr selOrderFrontFontPanel_Handle = Selector.GetHandle("orderFrontFontPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrderFrontStylesPanel_ = "orderFrontStylesPanel:";

	private static readonly IntPtr selOrderFrontStylesPanel_Handle = Selector.GetHandle("orderFrontStylesPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCollection_ = "removeCollection:";

	private static readonly IntPtr selRemoveCollection_Handle = Selector.GetHandle("removeCollection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFontDescriptor_FromCollection_ = "removeFontDescriptor:fromCollection:";

	private static readonly IntPtr selRemoveFontDescriptor_FromCollection_Handle = Selector.GetHandle("removeFontDescriptor:fromCollection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFontTrait_ = "removeFontTrait:";

	private static readonly IntPtr selRemoveFontTrait_Handle = Selector.GetHandle("removeFontTrait:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedFont = "selectedFont";

	private static readonly IntPtr selSelectedFontHandle = Selector.GetHandle("selectedFont");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendAction = "sendAction";

	private static readonly IntPtr selSendActionHandle = Selector.GetHandle("sendAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAction_ = "setAction:";

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFontManagerFactory_ = "setFontManagerFactory:";

	private static readonly IntPtr selSetFontManagerFactory_Handle = Selector.GetHandle("setFontManagerFactory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFontMenu_ = "setFontMenu:";

	private static readonly IntPtr selSetFontMenu_Handle = Selector.GetHandle("setFontMenu:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFontPanelFactory_ = "setFontPanelFactory:";

	private static readonly IntPtr selSetFontPanelFactory_Handle = Selector.GetHandle("setFontPanelFactory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedAttributes_IsMultiple_ = "setSelectedAttributes:isMultiple:";

	private static readonly IntPtr selSetSelectedAttributes_IsMultiple_Handle = Selector.GetHandle("setSelectedAttributes:isMultiple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedFont_IsMultiple_ = "setSelectedFont:isMultiple:";

	private static readonly IntPtr selSetSelectedFont_IsMultiple_Handle = Selector.GetHandle("setSelectedFont:isMultiple:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedFontManager = "sharedFontManager";

	private static readonly IntPtr selSharedFontManagerHandle = Selector.GetHandle("sharedFontManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTraitsOfFont_ = "traitsOfFont:";

	private static readonly IntPtr selTraitsOfFont_Handle = Selector.GetHandle("traitsOfFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightOfFont_ = "weightOfFont:";

	private static readonly IntPtr selWeightOfFont_Handle = Selector.GetHandle("weightOfFont:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFontManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector? Action
	{
		[Export("action")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle));
		}
		[Export("setAction:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableFontFamilies
	{
		[Export("availableFontFamilies")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableFontFamiliesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableFontFamiliesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableFonts
	{
		[Export("availableFonts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableFontsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableFontsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSFontCollection.AllFontCollectionNames' instead.")]
	public virtual string[] CollectionNames
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSFontCollection.AllFontCollectionNames' instead.")]
		[Export("collectionNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CurrentFontAction
	{
		[Export("currentFontAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCurrentFontActionHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCurrentFontActionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsMultiple
	{
		[Export("isMultiple")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMultipleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMultipleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont SelectedFont
	{
		[Export("selectedFont")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedFontHandle));
			}
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedFontHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendAction
	{
		[Export("sendAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSendActionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSendActionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontManager SharedFontManager
	{
		[Export("sharedFontManager")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSFontManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedFontManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	public virtual NSObject? WeakDelegate
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFontManager()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFontManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFontManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addCollection:options:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSFontCollection.ShowFontCollection (NSFontCollection, string, NSFontCollectionVisibility, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddCollection(string collectionName, NSFontCollectionOptions collectionOptions)
	{
		NSApplication.EnsureUIThread();
		if (collectionName == null)
		{
			throw new ArgumentNullException("collectionName");
		}
		IntPtr arg = NSString.CreateNative(collectionName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddCollection_Options_Handle, arg, (long)collectionOptions) : Messaging.bool_objc_msgSend_IntPtr_Int64(base.Handle, selAddCollection_Options_Handle, arg, (long)collectionOptions));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("addFontDescriptors:toCollection:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSMutableFontCollection.AddQueryForDescriptors' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddFontDescriptors_ToCollection_Handle, nSArray.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddFontDescriptors_ToCollection_Handle, nSArray.Handle, arg);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("addFontTrait:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddFontTrait(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddFontTrait_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFontTrait_Handle, sender.Handle);
		}
	}

	[Export("availableFontNamesMatchingFontDescriptor:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSFontDescriptor.MatchingFontDescriptors' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableFontNamesMatchingFontDescriptor(NSFontDescriptor descriptor)
	{
		NSApplication.EnsureUIThread();
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableFontNamesMatchingFontDescriptor_Handle, descriptor.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableFontNamesMatchingFontDescriptor_Handle, descriptor.Handle));
	}

	[Export("availableFontNamesWithTraits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableFontNamesWithTraits(NSFontTraitMask someTraits)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selAvailableFontNamesWithTraits_Handle, (ulong)someTraits));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selAvailableFontNamesWithTraits_Handle, (ulong)someTraits));
	}

	[Export("availableMembersOfFontFamily:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray[] AvailableMembersOfFontFamily(string fam)
	{
		NSApplication.EnsureUIThread();
		if (fam == null)
		{
			throw new ArgumentNullException("fam");
		}
		IntPtr arg = NSString.CreateNative(fam);
		NSArray[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableMembersOfFontFamily_Handle, arg)) : NSArray.ArrayFromHandle<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableMembersOfFontFamily_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ConvertAttributes(NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConvertAttributes_Handle, attributes.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConvertAttributes_Handle, attributes.Handle));
	}

	[Export("convertFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont ConvertFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selConvertFont_Handle, fontObj.Handle));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selConvertFont_Handle, fontObj.Handle));
	}

	[Export("convertFont:toSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont ConvertFont(NSFont fontObj, nfloat size)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat(base.Handle, selConvertFont_ToSize_Handle, fontObj.Handle, size));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selConvertFont_ToSize_Handle, fontObj.Handle, size));
	}

	[Export("convertFont:toFace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSFont result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConvertFont_ToFace_Handle, fontObj.Handle, arg)) : Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selConvertFont_ToFace_Handle, fontObj.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertFont:toHaveTrait:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont ConvertFont(NSFont fontObj, NSFontTraitMask trait)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selConvertFont_ToHaveTrait_Handle, fontObj.Handle, (ulong)trait));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selConvertFont_ToHaveTrait_Handle, fontObj.Handle, (ulong)trait));
	}

	[Export("convertFont:toFamily:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSFont result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selConvertFont_ToFamily_Handle, fontObj.Handle, arg)) : Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selConvertFont_ToFamily_Handle, fontObj.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("convertFont:toNotHaveTrait:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont ConvertFontToNotHaveTrait(NSFont fontObj, NSFontTraitMask trait)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selConvertFont_ToNotHaveTrait_Handle, fontObj.Handle, (ulong)trait));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selConvertFont_ToNotHaveTrait_Handle, fontObj.Handle, (ulong)trait));
	}

	[Export("convertFontTraits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontTraitMask ConvertFontTraits(NSFontTraitMask traits)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return (NSFontTraitMask)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, selConvertFontTraits_Handle, (ulong)traits);
		}
		return (NSFontTraitMask)Messaging.UInt64_objc_msgSendSuper_UInt64(base.SuperHandle, selConvertFontTraits_Handle, (ulong)traits);
	}

	[Export("convertWeight:ofFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont ConvertWeight(bool increaseWeight, NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_bool_IntPtr(base.Handle, selConvertWeight_OfFont_Handle, increaseWeight, fontObj.Handle));
		}
		return Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selConvertWeight_OfFont_Handle, increaseWeight, fontObj.Handle));
	}

	[Export("fontDescriptorsInCollection:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSFontCollection.GetMatchingDescriptors ()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray FontDescriptorsInCollection(string collectionNames)
	{
		NSApplication.EnsureUIThread();
		if (collectionNames == null)
		{
			throw new ArgumentNullException("collectionNames");
		}
		IntPtr arg = NSString.CreateNative(collectionNames);
		NSArray result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFontDescriptorsInCollection_Handle, arg)) : Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFontDescriptorsInCollection_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMenu FontMenu(bool create)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selFontMenu_Handle, create));
		}
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selFontMenu_Handle, create));
	}

	[Export("fontNamed:hasTraits:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FontNamedHasTraits(string fName, NSFontTraitMask someTraits)
	{
		NSApplication.EnsureUIThread();
		if (fName == null)
		{
			throw new ArgumentNullException("fName");
		}
		IntPtr arg = NSString.CreateNative(fName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selFontNamed_HasTraits_Handle, arg, (ulong)someTraits) : Messaging.bool_objc_msgSend_IntPtr_UInt64(base.Handle, selFontNamed_HasTraits_Handle, arg, (ulong)someTraits));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fontPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontPanel FontPanel(bool create)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFontPanel>(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selFontPanel_Handle, create));
		}
		return Runtime.GetNSObject<NSFontPanel>(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selFontPanel_Handle, create));
	}

	[Export("fontWithFamily:traits:weight:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFont FontWithFamily(string family, NSFontTraitMask traits, nint weight, nfloat size)
	{
		NSApplication.EnsureUIThread();
		if (family == null)
		{
			throw new ArgumentNullException("family");
		}
		IntPtr arg = NSString.CreateNative(family);
		NSFont result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_nint_nfloat(base.SuperHandle, selFontWithFamily_Traits_Weight_Size_Handle, arg, (ulong)traits, weight, size)) : Runtime.GetNSObject<NSFont>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_nint_nfloat(base.Handle, selFontWithFamily_Traits_Weight_Size_Handle, arg, (ulong)traits, weight, size)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedNameForFamily:face:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLocalizedNameForFamily_Face_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLocalizedNameForFamily_Face_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("modifyFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ModifyFont(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selModifyFont_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selModifyFont_Handle, sender.Handle);
		}
	}

	[Export("modifyFontViaPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ModifyFontViaPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selModifyFontViaPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selModifyFontViaPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontFontPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontFontPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontFontPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontFontPanel_Handle, sender.Handle);
		}
	}

	[Export("orderFrontStylesPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OrderFrontStylesPanel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOrderFrontStylesPanel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOrderFrontStylesPanel_Handle, sender.Handle);
		}
	}

	[Export("removeCollection:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'HideFontCollection (string, NSFontCollectionVisibility, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveCollection(string collectionName)
	{
		NSApplication.EnsureUIThread();
		if (collectionName == null)
		{
			throw new ArgumentNullException("collectionName");
		}
		IntPtr arg = NSString.CreateNative(collectionName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCollection_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveCollection_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeFontDescriptor:fromCollection:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSMutableFontCollection.RemoveQueryForDescriptors' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveFontDescriptor_FromCollection_Handle, descriptor.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveFontDescriptor_FromCollection_Handle, descriptor.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeFontTrait:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveFontTrait(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFontTrait_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFontTrait_Handle, sender.Handle);
		}
	}

	[Export("setFontManagerFactory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetFontManagerFactory(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetFontManagerFactory_Handle, factoryId.Handle);
	}

	[Export("setFontMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetFontMenu(NSMenu newMenu)
	{
		NSApplication.EnsureUIThread();
		if (newMenu == null)
		{
			throw new ArgumentNullException("newMenu");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFontMenu_Handle, newMenu.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFontMenu_Handle, newMenu.Handle);
		}
	}

	[Export("setFontPanelFactory:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetFontPanelFactory(Class factoryId)
	{
		NSApplication.EnsureUIThread();
		if (factoryId == null)
		{
			throw new ArgumentNullException("factoryId");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selSetFontPanelFactory_Handle, factoryId.Handle);
	}

	[Export("setSelectedAttributes:isMultiple:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedAttributes(NSDictionary attributes, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectedAttributes_IsMultiple_Handle, attributes.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectedAttributes_IsMultiple_Handle, attributes.Handle, isMultiple);
		}
	}

	[Export("setSelectedFont:isMultiple:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSelectedFont(NSFont fontObj, bool isMultiple)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetSelectedFont_IsMultiple_Handle, fontObj.Handle, isMultiple);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetSelectedFont_IsMultiple_Handle, fontObj.Handle, isMultiple);
		}
	}

	[Export("traitsOfFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontTraitMask TraitsOfFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return (NSFontTraitMask)Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selTraitsOfFont_Handle, fontObj.Handle);
		}
		return (NSFontTraitMask)Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selTraitsOfFont_Handle, fontObj.Handle);
	}

	[Export("validateMenuItem:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateMenuItem_Handle, menuItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateMenuItem_Handle, menuItem.Handle);
	}

	[Export("weightOfFont:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WeightOfFont(NSFont fontObj)
	{
		NSApplication.EnsureUIThread();
		if (fontObj == null)
		{
			throw new ArgumentNullException("fontObj");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selWeightOfFont_Handle, fontObj.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selWeightOfFont_Handle, fontObj.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
