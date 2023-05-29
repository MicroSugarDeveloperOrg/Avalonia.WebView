using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPrinter", true)]
public class NSPrinter : NSObject
{
	private static readonly IntPtr selPrinterNamesHandle = Selector.GetHandle("printerNames");

	private static readonly IntPtr selPrinterTypesHandle = Selector.GetHandle("printerTypes");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selLanguageLevelHandle = Selector.GetHandle("languageLevel");

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	private static readonly IntPtr selPrinterWithName_Handle = Selector.GetHandle("printerWithName:");

	private static readonly IntPtr selPrinterWithType_Handle = Selector.GetHandle("printerWithType:");

	private static readonly IntPtr selPageSizeForPaper_Handle = Selector.GetHandle("pageSizeForPaper:");

	private static readonly IntPtr selStatusForTable_Handle = Selector.GetHandle("statusForTable:");

	private static readonly IntPtr selIsKeyInTable_Handle = Selector.GetHandle("isKey:inTable:");

	private static readonly IntPtr selBooleanForKeyInTable_Handle = Selector.GetHandle("booleanForKey:inTable:");

	private static readonly IntPtr selFloatForKeyInTable_Handle = Selector.GetHandle("floatForKey:inTable:");

	private static readonly IntPtr selIntForKeyInTable_Handle = Selector.GetHandle("intForKey:inTable:");

	private static readonly IntPtr selRectForKeyInTable_Handle = Selector.GetHandle("rectForKey:inTable:");

	private static readonly IntPtr selSizeForKeyInTable_Handle = Selector.GetHandle("sizeForKey:inTable:");

	private static readonly IntPtr selStringForKeyInTable_Handle = Selector.GetHandle("stringForKey:inTable:");

	private static readonly IntPtr selStringListForKeyInTable_Handle = Selector.GetHandle("stringListForKey:inTable:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPrinter");

	private object __mt_DeviceDescription_var;

	public override IntPtr ClassHandle => class_ptr;

	public static string[] PrinterNames
	{
		[Export("printerNames")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPrinterNamesHandle));
		}
	}

	public static string[] PrinterTypes
	{
		[Export("printerTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPrinterTypesHandle));
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

	public virtual string Type
	{
		[Export("type")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	public virtual long LanguageLevel
	{
		[Export("languageLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLanguageLevelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLanguageLevelHandle);
		}
	}

	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_DeviceDescription_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrinter()
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
	public NSPrinter(NSCoder coder)
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
	public NSPrinter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPrinter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("printerWithName:")]
	public static NSPrinter PrinterWithName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPrinter result = (NSPrinter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrinterWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("printerWithType:")]
	public static NSPrinter PrinterWithType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPrinter result = (NSPrinter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrinterWithType_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("pageSizeForPaper:")]
	public virtual CGSize PageSizeForPaper(string paperName)
	{
		NSApplication.EnsureUIThread();
		if (paperName == null)
		{
			throw new ArgumentNullException("paperName");
		}
		IntPtr arg = NSString.CreateNative(paperName);
		CGSize result = ((!IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selPageSizeForPaper_Handle, arg) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selPageSizeForPaper_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("statusForTable:")]
	public virtual NSPrinterTableStatus StatusForTable(string tableName)
	{
		NSApplication.EnsureUIThread();
		if (tableName == null)
		{
			throw new ArgumentNullException("tableName");
		}
		IntPtr arg = NSString.CreateNative(tableName);
		NSPrinterTableStatus result = (NSPrinterTableStatus)((!IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selStatusForTable_Handle, arg) : Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selStatusForTable_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isKey:inTable:")]
	public virtual bool IsKeyInTable(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsKeyInTable_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsKeyInTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("booleanForKey:inTable:")]
	public virtual bool BooleanForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBooleanForKeyInTable_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selBooleanForKeyInTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("floatForKey:inTable:")]
	public virtual float FloatForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		float result = ((!IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFloatForKeyInTable_Handle, arg, arg2) : Messaging.float_objc_msgSend_IntPtr_IntPtr(base.Handle, selFloatForKeyInTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("intForKey:inTable:")]
	public virtual int IntForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		int result = ((!IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIntForKeyInTable_Handle, arg, arg2) : Messaging.int_objc_msgSend_IntPtr_IntPtr(base.Handle, selIntForKeyInTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("rectForKey:inTable:")]
	public virtual CGRect RectForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out retval, base.Handle, selRectForKeyInTable_Handle, arg, arg2);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr(out retval, base.SuperHandle, selRectForKeyInTable_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return retval;
	}

	[Export("sizeForKey:inTable:")]
	public virtual CGSize SizeForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		CGSize result = ((!IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSizeForKeyInTable_Handle, arg, arg2) : Messaging.CGSize_objc_msgSend_IntPtr_IntPtr(base.Handle, selSizeForKeyInTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("stringForKey:inTable:")]
	public virtual string StringForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringForKeyInTable_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringForKeyInTable_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("stringListForKey:inTable:")]
	public virtual string[] StringListForKey(string key, string table)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (table == null)
		{
			throw new ArgumentNullException("table");
		}
		IntPtr arg = NSString.CreateNative(key);
		IntPtr arg2 = NSString.CreateNative(table);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringListForKeyInTable_Handle, arg, arg2)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringListForKeyInTable_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DeviceDescription_var = null;
		}
	}
}
