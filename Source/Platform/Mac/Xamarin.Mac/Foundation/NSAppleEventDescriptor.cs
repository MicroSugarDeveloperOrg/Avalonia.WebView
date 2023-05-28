using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSAppleEventDescriptor", true)]
public class NSAppleEventDescriptor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeDescriptorForKeyword_ = "attributeDescriptorForKeyword:";

	private static readonly IntPtr selAttributeDescriptorForKeyword_Handle = Selector.GetHandle("attributeDescriptorForKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBooleanValue = "booleanValue";

	private static readonly IntPtr selBooleanValueHandle = Selector.GetHandle("booleanValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentProcessDescriptor = "currentProcessDescriptor";

	private static readonly IntPtr selCurrentProcessDescriptorHandle = Selector.GetHandle("currentProcessDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateValue = "dateValue";

	private static readonly IntPtr selDateValueHandle = Selector.GetHandle("dateValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorAtIndex_ = "descriptorAtIndex:";

	private static readonly IntPtr selDescriptorAtIndex_Handle = Selector.GetHandle("descriptorAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorForKeyword_ = "descriptorForKeyword:";

	private static readonly IntPtr selDescriptorForKeyword_Handle = Selector.GetHandle("descriptorForKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithApplicationURL_ = "descriptorWithApplicationURL:";

	private static readonly IntPtr selDescriptorWithApplicationURL_Handle = Selector.GetHandle("descriptorWithApplicationURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithBoolean_ = "descriptorWithBoolean:";

	private static readonly IntPtr selDescriptorWithBoolean_Handle = Selector.GetHandle("descriptorWithBoolean:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithBundleIdentifier_ = "descriptorWithBundleIdentifier:";

	private static readonly IntPtr selDescriptorWithBundleIdentifier_Handle = Selector.GetHandle("descriptorWithBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithDate_ = "descriptorWithDate:";

	private static readonly IntPtr selDescriptorWithDate_Handle = Selector.GetHandle("descriptorWithDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithDouble_ = "descriptorWithDouble:";

	private static readonly IntPtr selDescriptorWithDouble_Handle = Selector.GetHandle("descriptorWithDouble:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithEnumCode_ = "descriptorWithEnumCode:";

	private static readonly IntPtr selDescriptorWithEnumCode_Handle = Selector.GetHandle("descriptorWithEnumCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithFileURL_ = "descriptorWithFileURL:";

	private static readonly IntPtr selDescriptorWithFileURL_Handle = Selector.GetHandle("descriptorWithFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithInt32_ = "descriptorWithInt32:";

	private static readonly IntPtr selDescriptorWithInt32_Handle = Selector.GetHandle("descriptorWithInt32:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithProcessIdentifier_ = "descriptorWithProcessIdentifier:";

	private static readonly IntPtr selDescriptorWithProcessIdentifier_Handle = Selector.GetHandle("descriptorWithProcessIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithString_ = "descriptorWithString:";

	private static readonly IntPtr selDescriptorWithString_Handle = Selector.GetHandle("descriptorWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithTypeCode_ = "descriptorWithTypeCode:";

	private static readonly IntPtr selDescriptorWithTypeCode_Handle = Selector.GetHandle("descriptorWithTypeCode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleValue = "doubleValue";

	private static readonly IntPtr selDoubleValueHandle = Selector.GetHandle("doubleValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumCodeValue = "enumCodeValue";

	private static readonly IntPtr selEnumCodeValueHandle = Selector.GetHandle("enumCodeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventClass = "eventClass";

	private static readonly IntPtr selEventClassHandle = Selector.GetHandle("eventClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEventID = "eventID";

	private static readonly IntPtr selEventIDHandle = Selector.GetHandle("eventID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURLValue = "fileURLValue";

	private static readonly IntPtr selFileURLValueHandle = Selector.GetHandle("fileURLValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitListDescriptor = "initListDescriptor";

	private static readonly IntPtr selInitListDescriptorHandle = Selector.GetHandle("initListDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitRecordDescriptor = "initRecordDescriptor";

	private static readonly IntPtr selInitRecordDescriptorHandle = Selector.GetHandle("initRecordDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertDescriptor_AtIndex_ = "insertDescriptor:atIndex:";

	private static readonly IntPtr selInsertDescriptor_AtIndex_Handle = Selector.GetHandle("insertDescriptor:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInt32Value = "int32Value";

	private static readonly IntPtr selInt32ValueHandle = Selector.GetHandle("int32Value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRecordDescriptor = "isRecordDescriptor";

	private static readonly IntPtr selIsRecordDescriptorHandle = Selector.GetHandle("isRecordDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeywordForDescriptorAtIndex_ = "keywordForDescriptorAtIndex:";

	private static readonly IntPtr selKeywordForDescriptorAtIndex_Handle = Selector.GetHandle("keywordForDescriptorAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selListDescriptor = "listDescriptor";

	private static readonly IntPtr selListDescriptorHandle = Selector.GetHandle("listDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNullDescriptor = "nullDescriptor";

	private static readonly IntPtr selNullDescriptorHandle = Selector.GetHandle("nullDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParamDescriptorForKeyword_ = "paramDescriptorForKeyword:";

	private static readonly IntPtr selParamDescriptorForKeyword_Handle = Selector.GetHandle("paramDescriptorForKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordDescriptor = "recordDescriptor";

	private static readonly IntPtr selRecordDescriptorHandle = Selector.GetHandle("recordDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDescriptorAtIndex_ = "removeDescriptorAtIndex:";

	private static readonly IntPtr selRemoveDescriptorAtIndex_Handle = Selector.GetHandle("removeDescriptorAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDescriptorWithKeyword_ = "removeDescriptorWithKeyword:";

	private static readonly IntPtr selRemoveDescriptorWithKeyword_Handle = Selector.GetHandle("removeDescriptorWithKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveParamDescriptorWithKeyword_ = "removeParamDescriptorWithKeyword:";

	private static readonly IntPtr selRemoveParamDescriptorWithKeyword_Handle = Selector.GetHandle("removeParamDescriptorWithKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendEventWithOptions_Timeout_Error_ = "sendEventWithOptions:timeout:error:";

	private static readonly IntPtr selSendEventWithOptions_Timeout_Error_Handle = Selector.GetHandle("sendEventWithOptions:timeout:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeDescriptor_ForKeyword_ = "setAttributeDescriptor:forKeyword:";

	private static readonly IntPtr selSetAttributeDescriptor_ForKeyword_Handle = Selector.GetHandle("setAttributeDescriptor:forKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDescriptor_ForKeyword_ = "setDescriptor:forKeyword:";

	private static readonly IntPtr selSetDescriptor_ForKeyword_Handle = Selector.GetHandle("setDescriptor:forKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParamDescriptor_ForKeyword_ = "setParamDescriptor:forKeyword:";

	private static readonly IntPtr selSetParamDescriptor_ForKeyword_Handle = Selector.GetHandle("setParamDescriptor:forKeyword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValue = "stringValue";

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypeCodeValue = "typeCodeValue";

	private static readonly IntPtr selTypeCodeValueHandle = Selector.GetHandle("typeCodeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAppleEventDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BooleanValue
	{
		[Export("booleanValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBooleanValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBooleanValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSAppleEventDescriptor CurrentProcessDescriptor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("currentProcessDescriptor")]
		get
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentProcessDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDate? DateValue
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("dateValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateValueHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual double DoubleValue
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("doubleValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selDoubleValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDoubleValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AEEventClass EventClass
	{
		[Export("eventClass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AEEventClass)Messaging.UInt32_objc_msgSend(base.Handle, selEventClassHandle);
			}
			return (AEEventClass)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEventClassHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AEEventID EventID
	{
		[Export("eventID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AEEventID)Messaging.UInt32_objc_msgSend(base.Handle, selEventIDHandle);
			}
			return (AEEventID)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEventIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSUrl? FileURLValue
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("fileURLValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileURLValueHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileURLValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Int32Value
	{
		[Export("int32Value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selInt32ValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selInt32ValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual bool IsRecordDescriptor
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("isRecordDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRecordDescriptorHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRecordDescriptorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor ListDescriptor
	{
		[Export("listDescriptor")]
		get
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selListDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor NullDescriptor
	{
		[Export("nullDescriptor")]
		get
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selNullDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfItems
	{
		[Export("numberOfItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor RecordDescriptor
	{
		[Export("recordDescriptor")]
		get
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selRecordDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint TypeCodeValue
	{
		[Export("typeCodeValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selTypeCodeValueHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selTypeCodeValueHandle);
		}
	}

	public NSAppleEventDescriptor(NSAppleEventDescriptorType type)
	{
		switch (type)
		{
		case NSAppleEventDescriptorType.List:
			InitializeHandle(_InitListDescriptor(), "listDescriptor");
			break;
		case NSAppleEventDescriptorType.Record:
			InitializeHandle(_InitRecordDescriptor(), "recordDescriptor");
			break;
		default:
			throw new ArgumentOutOfRangeException("type");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppleEventDescriptor()
		: base(NSObjectFlag.Empty)
	{
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
	public NSAppleEventDescriptor(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected NSAppleEventDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAppleEventDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributeDescriptorForKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor AttributeDescriptorForKeyword(uint keyword)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selAttributeDescriptorForKeyword_Handle, keyword));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selAttributeDescriptorForKeyword_Handle, keyword));
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("descriptorAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor DescriptorAtIndex(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selDescriptorAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selDescriptorAtIndex_Handle, index));
	}

	[Export("descriptorForKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor DescriptorForKeyword(uint keyword)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selDescriptorForKeyword_Handle, keyword));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selDescriptorForKeyword_Handle, keyword));
	}

	[Export("descriptorWithBoolean:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor DescriptorWithBoolean(bool boolean)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selDescriptorWithBoolean_Handle, boolean));
	}

	[Export("descriptorWithEnumCode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor DescriptorWithEnumCode(uint enumerator)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selDescriptorWithEnumCode_Handle, enumerator));
	}

	[Export("descriptorWithInt32:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor DescriptorWithInt32(int signedInt)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selDescriptorWithInt32_Handle, signedInt));
	}

	[Export("descriptorWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor DescriptorWithString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSAppleEventDescriptor nSObject = Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("descriptorWithTypeCode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor DescriptorWithTypeCode(uint typeCode)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selDescriptorWithTypeCode_Handle, typeCode));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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

	[Export("enumCodeValue")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint EnumCodeValue()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(base.Handle, selEnumCodeValueHandle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEnumCodeValueHandle);
	}

	[Export("descriptorWithApplicationURL:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromApplicationURL(NSUrl applicationURL)
	{
		if (applicationURL == null)
		{
			throw new ArgumentNullException("applicationURL");
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithApplicationURL_Handle, applicationURL.Handle));
	}

	[Export("descriptorWithBundleIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromBundleIdentifier(string bundleIdentifier)
	{
		if (bundleIdentifier == null)
		{
			throw new ArgumentNullException("bundleIdentifier");
		}
		IntPtr arg = NSString.CreateNative(bundleIdentifier);
		NSAppleEventDescriptor nSObject = Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithBundleIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("descriptorWithDate:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromDate(NSDate date)
	{
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithDate_Handle, date.Handle));
	}

	[Export("descriptorWithDouble:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromDouble(double doubleValue)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selDescriptorWithDouble_Handle, doubleValue));
	}

	[Export("descriptorWithFileURL:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromFileURL(NSUrl fileURL)
	{
		if (fileURL == null)
		{
			throw new ArgumentNullException("fileURL");
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithFileURL_Handle, fileURL.Handle));
	}

	[Export("descriptorWithProcessIdentifier:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAppleEventDescriptor FromProcessIdentifier(int processIdentifier)
	{
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_int(class_ptr, selDescriptorWithProcessIdentifier_Handle, processIdentifier));
	}

	[Export("initListDescriptor")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitListDescriptor()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitListDescriptorHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitListDescriptorHandle));
	}

	[Export("initRecordDescriptor")]
	[Obsolete("Use the constructor instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitRecordDescriptor()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitRecordDescriptorHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitRecordDescriptorHandle));
	}

	[Export("insertDescriptor:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertDescriptoratIndex(NSAppleEventDescriptor descriptor, nint index)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertDescriptor_AtIndex_Handle, descriptor.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertDescriptor_AtIndex_Handle, descriptor.Handle, index);
		}
	}

	[Export("keywordForDescriptorAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint KeywordForDescriptorAtIndex(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_nint(base.Handle, selKeywordForDescriptorAtIndex_Handle, index);
		}
		return Messaging.UInt32_objc_msgSendSuper_nint(base.SuperHandle, selKeywordForDescriptorAtIndex_Handle, index);
	}

	[Export("paramDescriptorForKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor ParamDescriptorForKeyword(uint keyword)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selParamDescriptorForKeyword_Handle, keyword));
		}
		return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selParamDescriptorForKeyword_Handle, keyword));
	}

	[Export("removeDescriptorAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDescriptorAtIndex(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveDescriptorAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveDescriptorAtIndex_Handle, index);
		}
	}

	[Export("removeDescriptorWithKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDescriptorWithKeyword(uint keyword)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveDescriptorWithKeyword_Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveDescriptorWithKeyword_Handle, keyword);
		}
	}

	[Export("removeParamDescriptorWithKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveParamDescriptorWithKeyword(uint keyword)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveParamDescriptorWithKeyword_Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveParamDescriptorWithKeyword_Handle, keyword);
		}
	}

	[Export("sendEventWithOptions:timeout:error:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor? SendEvent(NSAppleEventSendOptions sendOptions, double timeoutInSeconds, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSAppleEventDescriptor result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper_UInt64_Double_ref_IntPtr(base.SuperHandle, selSendEventWithOptions_Timeout_Error_Handle, (ulong)sendOptions, timeoutInSeconds, ref arg)) : Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend_UInt64_Double_ref_IntPtr(base.Handle, selSendEventWithOptions_Timeout_Error_Handle, (ulong)sendOptions, timeoutInSeconds, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("setAttributeDescriptor:forKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttributeDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetAttributeDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetAttributeDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[Export("setDescriptor:forKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[Export("setParamDescriptor:forKeyword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetParamDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetParamDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetParamDescriptor_ForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _InitListDescriptor()
	{
		return Messaging.IntPtr_objc_msgSend(base.Handle, selInitListDescriptorHandle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr _InitRecordDescriptor()
	{
		return Messaging.IntPtr_objc_msgSend(base.Handle, selInitRecordDescriptorHandle);
	}
}
