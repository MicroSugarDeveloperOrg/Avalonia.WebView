using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboard", true)]
public class NSPasteboard : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTypes_Owner_ = "addTypes:owner:";

	private static readonly IntPtr selAddTypes_Owner_Handle = Selector.GetHandle("addTypes:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTypeFromArray_ = "availableTypeFromArray:";

	private static readonly IntPtr selAvailableTypeFromArray_Handle = Selector.GetHandle("availableTypeFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReadItemWithDataConformingToTypes_ = "canReadItemWithDataConformingToTypes:";

	private static readonly IntPtr selCanReadItemWithDataConformingToTypes_Handle = Selector.GetHandle("canReadItemWithDataConformingToTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanReadObjectForClasses_Options_ = "canReadObjectForClasses:options:";

	private static readonly IntPtr selCanReadObjectForClasses_Options_Handle = Selector.GetHandle("canReadObjectForClasses:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeCount = "changeCount";

	private static readonly IntPtr selChangeCountHandle = Selector.GetHandle("changeCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearContents = "clearContents";

	private static readonly IntPtr selClearContentsHandle = Selector.GetHandle("clearContents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataForType_ = "dataForType:";

	private static readonly IntPtr selDataForType_Handle = Selector.GetHandle("dataForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeclareTypes_Owner_ = "declareTypes:owner:";

	private static readonly IntPtr selDeclareTypes_Owner_Handle = Selector.GetHandle("declareTypes:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGeneralPasteboard = "generalPasteboard";

	private static readonly IntPtr selGeneralPasteboardHandle = Selector.GetHandle("generalPasteboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfPasteboardItem_ = "indexOfPasteboardItem:";

	private static readonly IntPtr selIndexOfPasteboardItem_Handle = Selector.GetHandle("indexOfPasteboardItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardItems = "pasteboardItems";

	private static readonly IntPtr selPasteboardItemsHandle = Selector.GetHandle("pasteboardItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardWithName_ = "pasteboardWithName:";

	private static readonly IntPtr selPasteboardWithName_Handle = Selector.GetHandle("pasteboardWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardWithUniqueName = "pasteboardWithUniqueName";

	private static readonly IntPtr selPasteboardWithUniqueNameHandle = Selector.GetHandle("pasteboardWithUniqueName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForNewContentsWithOptions_ = "prepareForNewContentsWithOptions:";

	private static readonly IntPtr selPrepareForNewContentsWithOptions_Handle = Selector.GetHandle("prepareForNewContentsWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyListForType_ = "propertyListForType:";

	private static readonly IntPtr selPropertyListForType_Handle = Selector.GetHandle("propertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadObjectsForClasses_Options_ = "readObjectsForClasses:options:";

	private static readonly IntPtr selReadObjectsForClasses_Options_Handle = Selector.GetHandle("readObjectsForClasses:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReleaseGlobally = "releaseGlobally";

	private static readonly IntPtr selReleaseGloballyHandle = Selector.GetHandle("releaseGlobally");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ForType_ = "setData:forType:";

	private static readonly IntPtr selSetData_ForType_Handle = Selector.GetHandle("setData:forType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPropertyList_ForType_ = "setPropertyList:forType:";

	private static readonly IntPtr selSetPropertyList_ForType_Handle = Selector.GetHandle("setPropertyList:forType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ForType_ = "setString:forType:";

	private static readonly IntPtr selSetString_ForType_Handle = Selector.GetHandle("setString:forType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForType_ = "stringForType:";

	private static readonly IntPtr selStringForType_Handle = Selector.GetHandle("stringForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypes = "types";

	private static readonly IntPtr selTypesHandle = Selector.GetHandle("types");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteObjects_ = "writeObjects:";

	private static readonly IntPtr selWriteObjects_Handle = Selector.GetHandle("writeObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPasteboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSColorType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSDragPasteboardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFileContentsType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFilenamesType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFilesPromiseType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFindPasteboardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFontPasteboardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSFontType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSGeneralPasteboardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSHtmlType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSMultipleTextSelectionType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardNameDrag;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardNameFind;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardNameFont;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardNameGeneral;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardNameRuler;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeColor;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeFileUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeFindPanelSearchOptions;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeFont;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeHTML;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeMultipleTextSelection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypePDF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypePNG;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeRTF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeRTFD;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeRuler;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeSound;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeString;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeTIFF;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeTabularText;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPasteboardTypeUrl;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPdfType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPictType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSPostScriptType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRtfType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRtfdType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRulerPasteboardName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSRulerType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSStringType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSTabularTextType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSTiffType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSUrlType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _NSVCardType;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PasteboardTypeTextFinderOptions;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ChangeCount
	{
		[Export("changeCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selChangeCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selChangeCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboard GeneralPasteboard
	{
		[Export("generalPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend(class_ptr, selGeneralPasteboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardItem[] PasteboardItems
	{
		[Export("pasteboardItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSPasteboardItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selPasteboardItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSPasteboardItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasteboardItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Types
	{
		[Export("types")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypesHandle));
		}
	}

	[Field("NSColorPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeColor' instead.")]
	public static NSString NSColorType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeColor' instead.")]
		get
		{
			if (_NSColorType == null)
			{
				_NSColorType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSColorPboardType");
			}
			return _NSColorType;
		}
	}

	[Field("NSDragPboard", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameDrag' instead.")]
	public static NSString NSDragPasteboardName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameDrag' instead.")]
		get
		{
			if (_NSDragPasteboardName == null)
			{
				_NSDragPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDragPboard");
			}
			return _NSDragPasteboardName;
		}
	}

	[Field("NSFileContentsPboardType", "AppKit")]
	public static NSString NSFileContentsType
	{
		get
		{
			if (_NSFileContentsType == null)
			{
				_NSFileContentsType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFileContentsPboardType");
			}
			return _NSFileContentsType;
		}
	}

	[Field("NSFilenamesPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Create multiple items with 'NSPasteboardTypeFileUrl' or 'MobileCoreServices.UTType.FileURL' instead.")]
	public static NSString NSFilenamesType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Create multiple items with 'NSPasteboardTypeFileUrl' or 'MobileCoreServices.UTType.FileURL' instead.")]
		get
		{
			if (_NSFilenamesType == null)
			{
				_NSFilenamesType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFilenamesPboardType");
			}
			return _NSFilenamesType;
		}
	}

	[Field("NSFilesPromisePboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'com.apple.pasteboard.promised-file-url' instead.")]
	public static NSString NSFilesPromiseType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'com.apple.pasteboard.promised-file-url' instead.")]
		get
		{
			if (_NSFilesPromiseType == null)
			{
				_NSFilesPromiseType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFilesPromisePboardType");
			}
			return _NSFilesPromiseType;
		}
	}

	[Field("NSFindPboard", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameFind' instead.")]
	public static NSString NSFindPasteboardName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameFind' instead.")]
		get
		{
			if (_NSFindPasteboardName == null)
			{
				_NSFindPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFindPboard");
			}
			return _NSFindPasteboardName;
		}
	}

	[Field("NSFontPboard", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameFont' instead.")]
	public static NSString NSFontPasteboardName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameFont' instead.")]
		get
		{
			if (_NSFontPasteboardName == null)
			{
				_NSFontPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontPboard");
			}
			return _NSFontPasteboardName;
		}
	}

	[Field("NSFontPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeFont' instead.")]
	public static NSString NSFontType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeFont' instead.")]
		get
		{
			if (_NSFontType == null)
			{
				_NSFontType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontPboardType");
			}
			return _NSFontType;
		}
	}

	[Field("NSGeneralPboard", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameGeneral' instead.")]
	public static NSString NSGeneralPasteboardName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameGeneral' instead.")]
		get
		{
			if (_NSGeneralPasteboardName == null)
			{
				_NSGeneralPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSGeneralPboard");
			}
			return _NSGeneralPasteboardName;
		}
	}

	[Field("NSHTMLPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeHTML' instead.")]
	public static NSString NSHtmlType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeHTML' instead.")]
		get
		{
			if (_NSHtmlType == null)
			{
				_NSHtmlType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSHTMLPboardType");
			}
			return _NSHtmlType;
		}
	}

	[Field("NSMultipleTextSelectionPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeMultipleTextSelection' instead.")]
	public static NSString NSMultipleTextSelectionType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeMultipleTextSelection' instead.")]
		get
		{
			if (_NSMultipleTextSelectionType == null)
			{
				_NSMultipleTextSelectionType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMultipleTextSelectionPboardType");
			}
			return _NSMultipleTextSelectionType;
		}
	}

	[Field("NSPasteboardNameDrag", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardNameDrag
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardNameDrag == null)
			{
				_NSPasteboardNameDrag = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardNameDrag");
			}
			return _NSPasteboardNameDrag;
		}
	}

	[Field("NSPasteboardNameFind", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardNameFind
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardNameFind == null)
			{
				_NSPasteboardNameFind = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardNameFind");
			}
			return _NSPasteboardNameFind;
		}
	}

	[Field("NSPasteboardNameFont", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardNameFont
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardNameFont == null)
			{
				_NSPasteboardNameFont = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardNameFont");
			}
			return _NSPasteboardNameFont;
		}
	}

	[Field("NSPasteboardNameGeneral", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardNameGeneral
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardNameGeneral == null)
			{
				_NSPasteboardNameGeneral = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardNameGeneral");
			}
			return _NSPasteboardNameGeneral;
		}
	}

	[Field("NSPasteboardNameRuler", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardNameRuler
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardNameRuler == null)
			{
				_NSPasteboardNameRuler = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardNameRuler");
			}
			return _NSPasteboardNameRuler;
		}
	}

	[Field("NSPasteboardTypeColor", "AppKit")]
	public static NSString NSPasteboardTypeColor
	{
		get
		{
			if (_NSPasteboardTypeColor == null)
			{
				_NSPasteboardTypeColor = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeColor");
			}
			return _NSPasteboardTypeColor;
		}
	}

	[Field("NSPasteboardTypeFileURL", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardTypeFileUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardTypeFileUrl == null)
			{
				_NSPasteboardTypeFileUrl = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeFileURL");
			}
			return _NSPasteboardTypeFileUrl;
		}
	}

	[Field("NSPasteboardTypeFindPanelSearchOptions", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTextFinderOptions' instead.")]
	public static NSString NSPasteboardTypeFindPanelSearchOptions
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTextFinderOptions' instead.")]
		get
		{
			if (_NSPasteboardTypeFindPanelSearchOptions == null)
			{
				_NSPasteboardTypeFindPanelSearchOptions = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeFindPanelSearchOptions");
			}
			return _NSPasteboardTypeFindPanelSearchOptions;
		}
	}

	[Field("NSPasteboardTypeFont", "AppKit")]
	public static NSString NSPasteboardTypeFont
	{
		get
		{
			if (_NSPasteboardTypeFont == null)
			{
				_NSPasteboardTypeFont = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeFont");
			}
			return _NSPasteboardTypeFont;
		}
	}

	[Field("NSPasteboardTypeHTML", "AppKit")]
	public static NSString NSPasteboardTypeHTML
	{
		get
		{
			if (_NSPasteboardTypeHTML == null)
			{
				_NSPasteboardTypeHTML = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeHTML");
			}
			return _NSPasteboardTypeHTML;
		}
	}

	[Field("NSPasteboardTypeMultipleTextSelection", "AppKit")]
	public static NSString NSPasteboardTypeMultipleTextSelection
	{
		get
		{
			if (_NSPasteboardTypeMultipleTextSelection == null)
			{
				_NSPasteboardTypeMultipleTextSelection = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeMultipleTextSelection");
			}
			return _NSPasteboardTypeMultipleTextSelection;
		}
	}

	[Field("NSPasteboardTypePDF", "AppKit")]
	public static NSString NSPasteboardTypePDF
	{
		get
		{
			if (_NSPasteboardTypePDF == null)
			{
				_NSPasteboardTypePDF = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypePDF");
			}
			return _NSPasteboardTypePDF;
		}
	}

	[Field("NSPasteboardTypePNG", "AppKit")]
	public static NSString NSPasteboardTypePNG
	{
		get
		{
			if (_NSPasteboardTypePNG == null)
			{
				_NSPasteboardTypePNG = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypePNG");
			}
			return _NSPasteboardTypePNG;
		}
	}

	[Field("NSPasteboardTypeRTF", "AppKit")]
	public static NSString NSPasteboardTypeRTF
	{
		get
		{
			if (_NSPasteboardTypeRTF == null)
			{
				_NSPasteboardTypeRTF = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeRTF");
			}
			return _NSPasteboardTypeRTF;
		}
	}

	[Field("NSPasteboardTypeRTFD", "AppKit")]
	public static NSString NSPasteboardTypeRTFD
	{
		get
		{
			if (_NSPasteboardTypeRTFD == null)
			{
				_NSPasteboardTypeRTFD = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeRTFD");
			}
			return _NSPasteboardTypeRTFD;
		}
	}

	[Field("NSPasteboardTypeRuler", "AppKit")]
	public static NSString NSPasteboardTypeRuler
	{
		get
		{
			if (_NSPasteboardTypeRuler == null)
			{
				_NSPasteboardTypeRuler = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeRuler");
			}
			return _NSPasteboardTypeRuler;
		}
	}

	[Field("NSPasteboardTypeSound", "AppKit")]
	public static NSString NSPasteboardTypeSound
	{
		get
		{
			if (_NSPasteboardTypeSound == null)
			{
				_NSPasteboardTypeSound = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeSound");
			}
			return _NSPasteboardTypeSound;
		}
	}

	[Field("NSPasteboardTypeString", "AppKit")]
	public static NSString NSPasteboardTypeString
	{
		get
		{
			if (_NSPasteboardTypeString == null)
			{
				_NSPasteboardTypeString = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeString");
			}
			return _NSPasteboardTypeString;
		}
	}

	[Field("NSPasteboardTypeTIFF", "AppKit")]
	public static NSString NSPasteboardTypeTIFF
	{
		get
		{
			if (_NSPasteboardTypeTIFF == null)
			{
				_NSPasteboardTypeTIFF = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeTIFF");
			}
			return _NSPasteboardTypeTIFF;
		}
	}

	[Field("NSPasteboardTypeTabularText", "AppKit")]
	public static NSString NSPasteboardTypeTabularText
	{
		get
		{
			if (_NSPasteboardTypeTabularText == null)
			{
				_NSPasteboardTypeTabularText = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeTabularText");
			}
			return _NSPasteboardTypeTabularText;
		}
	}

	[Field("NSPasteboardTypeURL", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSString NSPasteboardTypeUrl
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			if (_NSPasteboardTypeUrl == null)
			{
				_NSPasteboardTypeUrl = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeURL");
			}
			return _NSPasteboardTypeUrl;
		}
	}

	[Field("NSPDFPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypePDF' instead.")]
	public static NSString NSPdfType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypePDF' instead.")]
		get
		{
			if (_NSPdfType == null)
			{
				_NSPdfType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPDFPboardType");
			}
			return _NSPdfType;
		}
	}

	[Field("NSPICTPboardType", "AppKit")]
	public static NSString NSPictType
	{
		get
		{
			if (_NSPictType == null)
			{
				_NSPictType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPICTPboardType");
			}
			return _NSPictType;
		}
	}

	[Field("NSPostScriptPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'com.adobe.encapsulated-postscript' instead.")]
	public static NSString NSPostScriptType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'com.adobe.encapsulated-postscript' instead.")]
		get
		{
			if (_NSPostScriptType == null)
			{
				_NSPostScriptType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPostScriptPboardType");
			}
			return _NSPostScriptType;
		}
	}

	[Field("NSRTFPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRTF' instead.")]
	public static NSString NSRtfType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRTF' instead.")]
		get
		{
			if (_NSRtfType == null)
			{
				_NSRtfType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRTFPboardType");
			}
			return _NSRtfType;
		}
	}

	[Field("NSRTFDPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRTFD' instead.")]
	public static NSString NSRtfdType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRTFD' instead.")]
		get
		{
			if (_NSRtfdType == null)
			{
				_NSRtfdType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRTFDPboardType");
			}
			return _NSRtfdType;
		}
	}

	[Field("NSRulerPboard", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameRuler' instead.")]
	public static NSString NSRulerPasteboardName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, "Use 'NSPasteboardNameRuler' instead.")]
		get
		{
			if (_NSRulerPasteboardName == null)
			{
				_NSRulerPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRulerPboard");
			}
			return _NSRulerPasteboardName;
		}
	}

	[Field("NSRulerPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRuler' instead.")]
	public static NSString NSRulerType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeRuler' instead.")]
		get
		{
			if (_NSRulerType == null)
			{
				_NSRulerType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRulerPboardType");
			}
			return _NSRulerType;
		}
	}

	[Field("NSStringPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeString' instead.")]
	public static NSString NSStringType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeString' instead.")]
		get
		{
			if (_NSStringType == null)
			{
				_NSStringType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStringPboardType");
			}
			return _NSStringType;
		}
	}

	[Field("NSTabularTextPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTabularText' instead.")]
	public static NSString NSTabularTextType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTabularText' instead.")]
		get
		{
			if (_NSTabularTextType == null)
			{
				_NSTabularTextType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTabularTextPboardType");
			}
			return _NSTabularTextType;
		}
	}

	[Field("NSTIFFPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTIFF' instead.")]
	public static NSString NSTiffType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeTIFF' instead.")]
		get
		{
			if (_NSTiffType == null)
			{
				_NSTiffType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTIFFPboardType");
			}
			return _NSTiffType;
		}
	}

	[Field("NSURLPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeUrl' instead.")]
	public static NSString NSUrlType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSPasteboardTypeUrl' instead.")]
		get
		{
			if (_NSUrlType == null)
			{
				_NSUrlType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSURLPboardType");
			}
			return _NSUrlType;
		}
	}

	[Field("NSVCardPboardType", "AppKit")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'MobileCoreServices.UTType.VCard' instead.")]
	public static NSString NSVCardType
	{
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'MobileCoreServices.UTType.VCard' instead.")]
		get
		{
			if (_NSVCardType == null)
			{
				_NSVCardType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSVCardPboardType");
			}
			return _NSVCardType;
		}
	}

	[Field("NSPasteboardTypeTextFinderOptions", "AppKit")]
	public static NSString PasteboardTypeTextFinderOptions
	{
		get
		{
			if (_PasteboardTypeTextFinderOptions == null)
			{
				_PasteboardTypeTextFinderOptions = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPasteboardTypeTextFinderOptions");
			}
			return _PasteboardTypeTextFinderOptions;
		}
	}

	public bool WriteObjects(INSPasteboardWriting[] objects)
	{
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = WriteObjects(nSArray.Handle);
		nSArray.Dispose();
		return result;
	}

	public bool WriteObjects(NSPasteboardWriting[] objects)
	{
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = WriteObjects(nSArray.Handle);
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPasteboard(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPasteboard(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addTypes:owner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint AddTypes(string[] newTypes, NSObject? newOwner)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTypes_Owner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero) : Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTypes_Owner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("canReadItemWithDataConformingToTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanReadItemWithDataConformingToTypes(string[] utiTypes)
	{
		NSApplication.EnsureUIThread();
		if (utiTypes == null)
		{
			throw new ArgumentNullException("utiTypes");
		}
		NSArray nSArray = NSArray.FromStrings(utiTypes);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanReadItemWithDataConformingToTypes_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanReadItemWithDataConformingToTypes_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("canReadObjectForClasses:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanReadObjectForClasses(Class[] classArray, NSDictionary? options)
	{
		NSApplication.EnsureUIThread();
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanReadObjectForClasses_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanReadObjectForClasses_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("clearContents")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ClearContents()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selClearContentsHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selClearContentsHandle);
	}

	[Export("pasteboardWithUniqueName")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboard CreateWithUniqueName()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend(class_ptr, selPasteboardWithUniqueNameHandle));
	}

	[Export("declareTypes:owner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DeclareTypes(string[] newTypes, NSObject? newOwner)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeclareTypes_Owner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero) : Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeclareTypes_Owner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("pasteboardWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboard FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPasteboard nSObject = Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPasteboardWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("availableTypeFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetAvailableTypeFromArray(string[] types)
	{
		NSApplication.EnsureUIThread();
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableTypeFromArray_Handle, nSArray.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableTypeFromArray_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("dataForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetDataForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForType_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("propertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPropertyListForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetStringForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("indexOfPasteboardItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSPasteboardItem pasteboardItem)
	{
		NSApplication.EnsureUIThread();
		if (pasteboardItem == null)
		{
			throw new ArgumentNullException("pasteboardItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfPasteboardItem_Handle, pasteboardItem.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfPasteboardItem_Handle, pasteboardItem.Handle);
	}

	[Export("prepareForNewContentsWithOptions:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PrepareForNewContents(NSPasteboardContentsOptions options)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_UInt64(base.Handle, selPrepareForNewContentsWithOptions_Handle, (ulong)options);
		}
		return Messaging.nint_objc_msgSendSuper_UInt64(base.SuperHandle, selPrepareForNewContentsWithOptions_Handle, (ulong)options);
	}

	[Export("readObjectsForClasses:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ReadObjectsForClasses(Class[] classArray, NSDictionary? options)
	{
		NSApplication.EnsureUIThread();
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReadObjectsForClasses_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selReadObjectsForClasses_Options_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero)));
		nSArray.Dispose();
		return result;
	}

	[Export("releaseGlobally")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReleaseGlobally()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseGloballyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseGloballyHandle);
		}
	}

	[Export("setData:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetDataForType(NSData data, string dataType)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetData_ForType_Handle, data.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetData_ForType_Handle, data.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setPropertyList:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetPropertyListForType(NSObject plist, string dataType)
	{
		NSApplication.EnsureUIThread();
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPropertyList_ForType_Handle, plist.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPropertyList_ForType_Handle, plist.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setString:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetStringForType(string str, string dataType)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(str);
		IntPtr arg2 = NSString.CreateNative(dataType);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetString_ForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetString_ForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("writeObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool WriteObjects(IntPtr objects)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteObjects_Handle, objects);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteObjects_Handle, objects);
	}
}
