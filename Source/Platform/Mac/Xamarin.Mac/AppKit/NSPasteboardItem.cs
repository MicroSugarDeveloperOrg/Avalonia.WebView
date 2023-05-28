using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboardItem", true)]
public class NSPasteboardItem : NSObject, INSPasteboardReading, INativeObject, IDisposable, INSPasteboardWriting
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTypeFromArray_ = "availableTypeFromArray:";

	private static readonly IntPtr selAvailableTypeFromArray_Handle = Selector.GetHandle("availableTypeFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataForType_ = "dataForType:";

	private static readonly IntPtr selDataForType_Handle = Selector.GetHandle("dataForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyListForType_ = "propertyListForType:";

	private static readonly IntPtr selPropertyListForType_Handle = Selector.GetHandle("propertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ForType_ = "setData:forType:";

	private static readonly IntPtr selSetData_ForType_Handle = Selector.GetHandle("setData:forType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataProvider_ForTypes_ = "setDataProvider:forTypes:";

	private static readonly IntPtr selSetDataProvider_ForTypes_Handle = Selector.GetHandle("setDataProvider:forTypes:");

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
	private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

	private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

	private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPasteboardItem");

	public override IntPtr ClassHandle => class_ptr;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardItem()
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
	protected NSPasteboardItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPasteboardItem(IntPtr handle)
		: base(handle)
	{
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
	public virtual NSData GetDataForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForType_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("propertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPropertyListForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetStringForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		NSApplication.EnsureUIThread();
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setData:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetDataForType(NSData data, string type)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetData_ForType_Handle, data.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetData_ForType_Handle, data.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setDataProvider:forTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetDataProviderForTypes(INSPasteboardItemDataProvider dataProvider, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (dataProvider != null)
		{
			if (!(dataProvider is NSObject))
			{
				throw new ArgumentException("The object passed of type " + dataProvider.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			NSArray nSArray = NSArray.FromStrings(types);
			bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataProvider_ForTypes_Handle, dataProvider.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataProvider_ForTypes_Handle, dataProvider.Handle, nSArray.Handle));
			nSArray.Dispose();
			return result;
		}
		throw new ArgumentNullException("dataProvider");
	}

	[Export("setPropertyList:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetPropertyListForType(NSObject propertyList, string type)
	{
		NSApplication.EnsureUIThread();
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPropertyList_ForType_Handle, propertyList.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPropertyList_ForType_Handle, propertyList.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setString:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetStringForType(string str, string type)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(str);
		IntPtr arg2 = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetString_ForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetString_ForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}
}
