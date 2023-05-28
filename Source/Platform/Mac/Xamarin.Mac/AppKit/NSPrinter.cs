using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSPrinter", true)]
public class NSPrinter : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBooleanForKey_InTable_ = "booleanForKey:inTable:";

	private static readonly IntPtr selBooleanForKey_InTable_Handle = Selector.GetHandle("booleanForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceDescription = "deviceDescription";

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatForKey_InTable_ = "floatForKey:inTable:";

	private static readonly IntPtr selFloatForKey_InTable_Handle = Selector.GetHandle("floatForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntForKey_InTable_ = "intForKey:inTable:";

	private static readonly IntPtr selIntForKey_InTable_Handle = Selector.GetHandle("intForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsKey_InTable_ = "isKey:inTable:";

	private static readonly IntPtr selIsKey_InTable_Handle = Selector.GetHandle("isKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageLevel = "languageLevel";

	private static readonly IntPtr selLanguageLevelHandle = Selector.GetHandle("languageLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageSizeForPaper_ = "pageSizeForPaper:";

	private static readonly IntPtr selPageSizeForPaper_Handle = Selector.GetHandle("pageSizeForPaper:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinterNames = "printerNames";

	private static readonly IntPtr selPrinterNamesHandle = Selector.GetHandle("printerNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinterTypes = "printerTypes";

	private static readonly IntPtr selPrinterTypesHandle = Selector.GetHandle("printerTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinterWithName_ = "printerWithName:";

	private static readonly IntPtr selPrinterWithName_Handle = Selector.GetHandle("printerWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrinterWithType_ = "printerWithType:";

	private static readonly IntPtr selPrinterWithType_Handle = Selector.GetHandle("printerWithType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectForKey_InTable_ = "rectForKey:inTable:";

	private static readonly IntPtr selRectForKey_InTable_Handle = Selector.GetHandle("rectForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSizeForKey_InTable_ = "sizeForKey:inTable:";

	private static readonly IntPtr selSizeForKey_InTable_Handle = Selector.GetHandle("sizeForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatusForTable_ = "statusForTable:";

	private static readonly IntPtr selStatusForTable_Handle = Selector.GetHandle("statusForTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringForKey_InTable_ = "stringForKey:inTable:";

	private static readonly IntPtr selStringForKey_InTable_Handle = Selector.GetHandle("stringForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringListForKey_InTable_ = "stringListForKey:inTable:";

	private static readonly IntPtr selStringListForKey_InTable_Handle = Selector.GetHandle("stringListForKey:inTable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPrinter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LanguageLevel
	{
		[Export("languageLevel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLanguageLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLanguageLevelHandle);
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
	public static string[] PrinterNames
	{
		[Export("printerNames", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPrinterNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] PrinterTypes
	{
		[Export("printerTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selPrinterTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Type
	{
		[Export("type")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPrinter()
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
	public NSPrinter(NSCoder coder)
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
	protected NSPrinter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPrinter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("booleanForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBooleanForKey_InTable_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selBooleanForKey_InTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
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

	[Export("floatForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		float result = ((!base.IsDirectBinding) ? Messaging.float_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFloatForKey_InTable_Handle, arg, arg2) : Messaging.float_objc_msgSend_IntPtr_IntPtr(base.Handle, selFloatForKey_InTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("intForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIntForKey_InTable_Handle, arg, arg2) : Messaging.int_objc_msgSend_IntPtr_IntPtr(base.Handle, selIntForKey_InTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("isKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsKey_InTable_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsKey_InTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("pageSizeForPaper:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize PageSizeForPaper(string paperName)
	{
		NSApplication.EnsureUIThread();
		if (paperName == null)
		{
			throw new ArgumentNullException("paperName");
		}
		IntPtr arg = NSString.CreateNative(paperName);
		CGSize result = ((!base.IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr(base.SuperHandle, selPageSizeForPaper_Handle, arg) : Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selPageSizeForPaper_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("printerWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrinter PrinterWithName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSPrinter nSObject = Runtime.GetNSObject<NSPrinter>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrinterWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("printerWithType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPrinter PrinterWithType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPrinter nSObject = Runtime.GetNSObject<NSPrinter>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPrinterWithType_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("rectForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_IntPtr(out retval, base.Handle, selRectForKey_InTable_Handle, arg, arg2);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr(out retval, base.SuperHandle, selRectForKey_InTable_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return retval;
	}

	[Export("sizeForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		CGSize result = ((!base.IsDirectBinding) ? Messaging.CGSize_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSizeForKey_InTable_Handle, arg, arg2) : Messaging.CGSize_objc_msgSend_IntPtr_IntPtr(base.Handle, selSizeForKey_InTable_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("statusForTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrinterTableStatus StatusForTable(string tableName)
	{
		NSApplication.EnsureUIThread();
		if (tableName == null)
		{
			throw new ArgumentNullException("tableName");
		}
		IntPtr arg = NSString.CreateNative(tableName);
		NSPrinterTableStatus result = (NSPrinterTableStatus)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr(base.SuperHandle, selStatusForTable_Handle, arg) : Messaging.UInt64_objc_msgSend_IntPtr(base.Handle, selStatusForTable_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("stringForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringForKey_InTable_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringForKey_InTable_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("stringListForKey:inTable:")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStringListForKey_InTable_Handle, arg, arg2)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selStringListForKey_InTable_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}
}
