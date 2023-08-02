using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboard", true)]
public class NSPasteboard : NSObject
{
	private static readonly IntPtr selGeneralPasteboardHandle = Selector.GetHandle("generalPasteboard");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selChangeCountHandle = Selector.GetHandle("changeCount");

	private static readonly IntPtr selPasteboardItemsHandle = Selector.GetHandle("pasteboardItems");

	private static readonly IntPtr selTypesHandle = Selector.GetHandle("types");

	private static readonly IntPtr selPasteboardWithName_Handle = Selector.GetHandle("pasteboardWithName:");

	private static readonly IntPtr selPasteboardWithUniqueNameHandle = Selector.GetHandle("pasteboardWithUniqueName");

	private static readonly IntPtr selReleaseGloballyHandle = Selector.GetHandle("releaseGlobally");

	private static readonly IntPtr selClearContentsHandle = Selector.GetHandle("clearContents");

	private static readonly IntPtr selWriteObjects_Handle = Selector.GetHandle("writeObjects:");

	private static readonly IntPtr selReadObjectsForClassesOptions_Handle = Selector.GetHandle("readObjectsForClasses:options:");

	private static readonly IntPtr selIndexOfPasteboardItem_Handle = Selector.GetHandle("indexOfPasteboardItem:");

	private static readonly IntPtr selCanReadItemWithDataConformingToTypes_Handle = Selector.GetHandle("canReadItemWithDataConformingToTypes:");

	private static readonly IntPtr selCanReadObjectForClassesOptions_Handle = Selector.GetHandle("canReadObjectForClasses:options:");

	private static readonly IntPtr selDeclareTypesOwner_Handle = Selector.GetHandle("declareTypes:owner:");

	private static readonly IntPtr selAddTypesOwner_Handle = Selector.GetHandle("addTypes:owner:");

	private static readonly IntPtr selAvailableTypeFromArray_Handle = Selector.GetHandle("availableTypeFromArray:");

	private static readonly IntPtr selSetDataForType_Handle = Selector.GetHandle("setData:forType:");

	private static readonly IntPtr selSetPropertyListForType_Handle = Selector.GetHandle("setPropertyList:forType:");

	private static readonly IntPtr selSetStringForType_Handle = Selector.GetHandle("setString:forType:");

	private static readonly IntPtr selDataForType_Handle = Selector.GetHandle("dataForType:");

	private static readonly IntPtr selPropertyListForType_Handle = Selector.GetHandle("propertyListForType:");

	private static readonly IntPtr selStringForType_Handle = Selector.GetHandle("stringForType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPasteboard");

	private static object __mt_GeneralPasteboard_var_static;

	private object __mt_PasteboardItems_var;

	private static NSString _NSStringType;

	private static NSString _NSFilenamesType;

	private static NSString _NSPostScriptType;

	private static NSString _NSTiffType;

	private static NSString _NSRtfType;

	private static NSString _NSTabularTextType;

	private static NSString _NSFontType;

	private static NSString _NSRulerType;

	private static NSString _NSFileContentsType;

	private static NSString _NSColorType;

	private static NSString _NSRtfdType;

	private static NSString _NSHtmlType;

	private static NSString _NSPictType;

	private static NSString _NSUrlType;

	private static NSString _NSPdfType;

	private static NSString _NSVCardType;

	private static NSString _NSFilesPromiseType;

	private static NSString _NSMultipleTextSelectionType;

	private static NSString _NSGeneralPasteboardName;

	private static NSString _NSFontPasteboardName;

	private static NSString _NSRulerPasteboardName;

	private static NSString _NSFindPasteboardName;

	private static NSString _NSDragPasteboardName;

	public override IntPtr ClassHandle => class_ptr;

	public static NSPasteboard GeneralPasteboard
	{
		[Export("generalPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPasteboard)(__mt_GeneralPasteboard_var_static = (NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selGeneralPasteboardHandle)));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual long ChangeCount
	{
		[Export("changeCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selChangeCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChangeCountHandle);
		}
	}

	public virtual NSPasteboardItem[] PasteboardItems
	{
		[Export("pasteboardItems")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPasteboardItem[])(__mt_PasteboardItems_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPasteboardItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPasteboardItemsHandle)) : NSArray.ArrayFromHandle<NSPasteboardItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selPasteboardItemsHandle))));
		}
	}

	public virtual string[] Types
	{
		[Export("types")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypesHandle));
		}
	}

	[Field("NSStringPboardType", "AppKit")]
	public static NSString NSStringType
	{
		get
		{
			if (_NSStringType == null)
			{
				_NSStringType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStringPboardType");
			}
			return _NSStringType;
		}
	}

	[Field("NSFilenamesPboardType", "AppKit")]
	public static NSString NSFilenamesType
	{
		get
		{
			if (_NSFilenamesType == null)
			{
				_NSFilenamesType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFilenamesPboardType");
			}
			return _NSFilenamesType;
		}
	}

	[Field("NSPostScriptPboardType", "AppKit")]
	public static NSString NSPostScriptType
	{
		get
		{
			if (_NSPostScriptType == null)
			{
				_NSPostScriptType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPostScriptPboardType");
			}
			return _NSPostScriptType;
		}
	}

	[Field("NSTIFFPboardType", "AppKit")]
	public static NSString NSTiffType
	{
		get
		{
			if (_NSTiffType == null)
			{
				_NSTiffType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTIFFPboardType");
			}
			return _NSTiffType;
		}
	}

	[Field("NSRTFPboardType", "AppKit")]
	public static NSString NSRtfType
	{
		get
		{
			if (_NSRtfType == null)
			{
				_NSRtfType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRTFPboardType");
			}
			return _NSRtfType;
		}
	}

	[Field("NSTabularTextPboardType", "AppKit")]
	public static NSString NSTabularTextType
	{
		get
		{
			if (_NSTabularTextType == null)
			{
				_NSTabularTextType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTabularTextPboardType");
			}
			return _NSTabularTextType;
		}
	}

	[Field("NSFontPboardType", "AppKit")]
	public static NSString NSFontType
	{
		get
		{
			if (_NSFontType == null)
			{
				_NSFontType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontPboardType");
			}
			return _NSFontType;
		}
	}

	[Field("NSRulerPboardType", "AppKit")]
	public static NSString NSRulerType
	{
		get
		{
			if (_NSRulerType == null)
			{
				_NSRulerType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRulerPboardType");
			}
			return _NSRulerType;
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

	[Field("NSColorPboardType", "AppKit")]
	public static NSString NSColorType
	{
		get
		{
			if (_NSColorType == null)
			{
				_NSColorType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSColorPboardType");
			}
			return _NSColorType;
		}
	}

	[Field("NSRTFDPboardType", "AppKit")]
	public static NSString NSRtfdType
	{
		get
		{
			if (_NSRtfdType == null)
			{
				_NSRtfdType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRTFDPboardType");
			}
			return _NSRtfdType;
		}
	}

	[Field("NSHTMLPboardType", "AppKit")]
	public static NSString NSHtmlType
	{
		get
		{
			if (_NSHtmlType == null)
			{
				_NSHtmlType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSHTMLPboardType");
			}
			return _NSHtmlType;
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

	[Field("NSURLPboardType", "AppKit")]
	public static NSString NSUrlType
	{
		get
		{
			if (_NSUrlType == null)
			{
				_NSUrlType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSURLPboardType");
			}
			return _NSUrlType;
		}
	}

	[Field("NSPDFPboardType", "AppKit")]
	public static NSString NSPdfType
	{
		get
		{
			if (_NSPdfType == null)
			{
				_NSPdfType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSPDFPboardType");
			}
			return _NSPdfType;
		}
	}

	[Field("NSVCardPboardType", "AppKit")]
	public static NSString NSVCardType
	{
		get
		{
			if (_NSVCardType == null)
			{
				_NSVCardType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSVCardPboardType");
			}
			return _NSVCardType;
		}
	}

	[Field("NSFilesPromisePboardType", "AppKit")]
	public static NSString NSFilesPromiseType
	{
		get
		{
			if (_NSFilesPromiseType == null)
			{
				_NSFilesPromiseType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFilesPromisePboardType");
			}
			return _NSFilesPromiseType;
		}
	}

	[Field("NSMultipleTextSelectionPboardType", "AppKit")]
	public static NSString NSMultipleTextSelectionType
	{
		get
		{
			if (_NSMultipleTextSelectionType == null)
			{
				_NSMultipleTextSelectionType = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMultipleTextSelectionPboardType");
			}
			return _NSMultipleTextSelectionType;
		}
	}

	[Field("NSGeneralPboard", "AppKit")]
	public static NSString NSGeneralPasteboardName
	{
		get
		{
			if (_NSGeneralPasteboardName == null)
			{
				_NSGeneralPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSGeneralPboard");
			}
			return _NSGeneralPasteboardName;
		}
	}

	[Field("NSFontPboard", "AppKit")]
	public static NSString NSFontPasteboardName
	{
		get
		{
			if (_NSFontPasteboardName == null)
			{
				_NSFontPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontPboard");
			}
			return _NSFontPasteboardName;
		}
	}

	[Field("NSRulerPboard", "AppKit")]
	public static NSString NSRulerPasteboardName
	{
		get
		{
			if (_NSRulerPasteboardName == null)
			{
				_NSRulerPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSRulerPboard");
			}
			return _NSRulerPasteboardName;
		}
	}

	[Field("NSFindPboard", "AppKit")]
	public static NSString NSFindPasteboardName
	{
		get
		{
			if (_NSFindPasteboardName == null)
			{
				_NSFindPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFindPboard");
			}
			return _NSFindPasteboardName;
		}
	}

	[Field("NSDragPboard", "AppKit")]
	public static NSString NSDragPasteboardName
	{
		get
		{
			if (_NSDragPasteboardName == null)
			{
				_NSDragPasteboardName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSDragPboard");
			}
			return _NSDragPasteboardName;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPasteboard(NSCoder coder)
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
	public NSPasteboard(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPasteboard(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pasteboardWithName:")]
	public static NSPasteboard FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPasteboard result = (NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPasteboardWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pasteboardWithUniqueName")]
	public static NSPasteboard CreateWithUniqueName()
	{
		NSApplication.EnsureUIThread();
		return (NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPasteboardWithUniqueNameHandle));
	}

	[Export("releaseGlobally")]
	public virtual void ReleaseGlobally()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseGloballyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseGloballyHandle);
		}
	}

	[Export("clearContents")]
	public virtual long ClearContents()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selClearContentsHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selClearContentsHandle);
	}

	[Export("writeObjects:")]
	public virtual bool WriteObjects(NSPasteboardReading[] objects)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("readObjectsForClasses:options:")]
	public virtual NSObject[] ReadObjectsForClasses(NSPasteboardReading[] classArray, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReadObjectsForClassesOptions_Handle, nSArray.Handle, options.Handle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selReadObjectsForClassesOptions_Handle, nSArray.Handle, options.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("indexOfPasteboardItem:")]
	public virtual ulong IndexOf(NSPasteboardItem pasteboardItem)
	{
		NSApplication.EnsureUIThread();
		if (pasteboardItem == null)
		{
			throw new ArgumentNullException("pasteboardItem");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selIndexOfPasteboardItem_Handle, pasteboardItem.Handle);
		}
		return Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfPasteboardItem_Handle, pasteboardItem.Handle);
	}

	[Export("canReadItemWithDataConformingToTypes:")]
	public virtual bool CanReadItemWithDataConformingToTypes(string[] utiTypes)
	{
		NSApplication.EnsureUIThread();
		if (utiTypes == null)
		{
			throw new ArgumentNullException("utiTypes");
		}
		NSArray nSArray = NSArray.FromStrings(utiTypes);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanReadItemWithDataConformingToTypes_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanReadItemWithDataConformingToTypes_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("canReadObjectForClasses:options:")]
	public virtual bool CanReadObjectForClasses(NSObject[] classArray, NSDictionary options)
	{
		NSApplication.EnsureUIThread();
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCanReadObjectForClassesOptions_Handle, nSArray.Handle, options.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selCanReadObjectForClassesOptions_Handle, nSArray.Handle, options.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("declareTypes:owner:")]
	public virtual long DeclareTypes(string[] newTypes, NSObject newOwner)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeclareTypesOwner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeclareTypesOwner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("addTypes:owner:")]
	public virtual long AddTypes(string[] newTypes, NSObject newOwner)
	{
		NSApplication.EnsureUIThread();
		if (newTypes == null)
		{
			throw new ArgumentNullException("newTypes");
		}
		NSArray nSArray = NSArray.FromStrings(newTypes);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddTypesOwner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddTypesOwner_Handle, nSArray.Handle, newOwner?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return result;
	}

	[Export("availableTypeFromArray:")]
	public virtual string GetAvailableTypeFromArray(string[] types)
	{
		NSApplication.EnsureUIThread();
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAvailableTypeFromArray_Handle, nSArray.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAvailableTypeFromArray_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("setData:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataForType_Handle, data.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataForType_Handle, data.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setPropertyList:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPropertyListForType_Handle, plist.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPropertyListForType_Handle, plist.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setString:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetStringForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetStringForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("dataForType:")]
	public virtual NSData GetDataForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForType_Handle, arg))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForType_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("propertyListForType:")]
	public virtual NSObject GetPropertyListForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForType:")]
	public virtual string GetStringForType(string dataType)
	{
		NSApplication.EnsureUIThread();
		if (dataType == null)
		{
			throw new ArgumentNullException("dataType");
		}
		IntPtr arg = NSString.CreateNative(dataType);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_PasteboardItems_var = null;
		}
	}
}
