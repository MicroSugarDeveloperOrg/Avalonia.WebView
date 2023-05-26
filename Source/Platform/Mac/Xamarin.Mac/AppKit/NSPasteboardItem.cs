using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboardItem", true)]
public class NSPasteboardItem : NSObject
{
	private static readonly IntPtr selTypesHandle = Selector.GetHandle("types");

	private static readonly IntPtr selAvailableTypeFromArray_Handle = Selector.GetHandle("availableTypeFromArray:");

	private static readonly IntPtr selSetDataProviderForTypes_Handle = Selector.GetHandle("setDataProvider:forTypes:");

	private static readonly IntPtr selSetDataForType_Handle = Selector.GetHandle("setData:forType:");

	private static readonly IntPtr selSetStringForType_Handle = Selector.GetHandle("setString:forType:");

	private static readonly IntPtr selSetPropertyListForType_Handle = Selector.GetHandle("setPropertyList:forType:");

	private static readonly IntPtr selDataForType_Handle = Selector.GetHandle("dataForType:");

	private static readonly IntPtr selStringForType_Handle = Selector.GetHandle("stringForType:");

	private static readonly IntPtr selPropertyListForType_Handle = Selector.GetHandle("propertyListForType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPasteboardItem");

	public override IntPtr ClassHandle => class_ptr;

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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardItem()
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
	public NSPasteboardItem(NSCoder coder)
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
	public NSPasteboardItem(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPasteboardItem(IntPtr handle)
		: base(handle)
	{
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

	[Export("setDataProvider:forTypes:")]
	public virtual bool SetDataProviderForTypes(NSPasteboardItemDataProvider dataProvider, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (dataProvider == null)
		{
			throw new ArgumentNullException("dataProvider");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataProviderForTypes_Handle, dataProvider.Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataProviderForTypes_Handle, dataProvider.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("setData:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDataForType_Handle, data.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDataForType_Handle, data.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setString:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetStringForType_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetStringForType_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setPropertyList:forType:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetPropertyListForType_Handle, propertyList.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetPropertyListForType_Handle, propertyList.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataForType:")]
	public virtual NSData GetDataForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataForType_Handle, arg))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataForType_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForType:")]
	public virtual string GetStringForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("propertyListForType:")]
	public virtual NSObject GetPropertyListForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
