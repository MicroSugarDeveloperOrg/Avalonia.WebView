using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSAppleEventDescriptor", true)]
public class NSAppleEventDescriptor : NSObject
{
	private static readonly IntPtr selNullDescriptorHandle = Selector.GetHandle("nullDescriptor");

	private static readonly IntPtr selListDescriptorHandle = Selector.GetHandle("listDescriptor");

	private static readonly IntPtr selRecordDescriptorHandle = Selector.GetHandle("recordDescriptor");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selBooleanValueHandle = Selector.GetHandle("booleanValue");

	private static readonly IntPtr selInt32ValueHandle = Selector.GetHandle("int32Value");

	private static readonly IntPtr selTypeCodeValueHandle = Selector.GetHandle("typeCodeValue");

	private static readonly IntPtr selStringValueHandle = Selector.GetHandle("stringValue");

	private static readonly IntPtr selEventClassHandle = Selector.GetHandle("eventClass");

	private static readonly IntPtr selEventIDHandle = Selector.GetHandle("eventID");

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	private static readonly IntPtr selDescriptorWithBoolean_Handle = Selector.GetHandle("descriptorWithBoolean:");

	private static readonly IntPtr selDescriptorWithEnumCode_Handle = Selector.GetHandle("descriptorWithEnumCode:");

	private static readonly IntPtr selDescriptorWithInt32_Handle = Selector.GetHandle("descriptorWithInt32:");

	private static readonly IntPtr selDescriptorWithTypeCode_Handle = Selector.GetHandle("descriptorWithTypeCode:");

	private static readonly IntPtr selDescriptorWithString_Handle = Selector.GetHandle("descriptorWithString:");

	private static readonly IntPtr selInitListDescriptorHandle = Selector.GetHandle("initListDescriptor");

	private static readonly IntPtr selInitRecordDescriptorHandle = Selector.GetHandle("initRecordDescriptor");

	private static readonly IntPtr selEnumCodeValueHandle = Selector.GetHandle("enumCodeValue");

	private static readonly IntPtr selSetParamDescriptorForKeyword_Handle = Selector.GetHandle("setParamDescriptor:forKeyword:");

	private static readonly IntPtr selParamDescriptorForKeyword_Handle = Selector.GetHandle("paramDescriptorForKeyword:");

	private static readonly IntPtr selRemoveParamDescriptorWithKeyword_Handle = Selector.GetHandle("removeParamDescriptorWithKeyword:");

	private static readonly IntPtr selSetAttributeDescriptorForKeyword_Handle = Selector.GetHandle("setAttributeDescriptor:forKeyword:");

	private static readonly IntPtr selAttributeDescriptorForKeyword_Handle = Selector.GetHandle("attributeDescriptorForKeyword:");

	private static readonly IntPtr selInsertDescriptorAtIndex_Handle = Selector.GetHandle("insertDescriptor:atIndex:");

	private static readonly IntPtr selDescriptorAtIndex_Handle = Selector.GetHandle("descriptorAtIndex:");

	private static readonly IntPtr selRemoveDescriptorAtIndex_Handle = Selector.GetHandle("removeDescriptorAtIndex:");

	private static readonly IntPtr selSetDescriptorForKeyword_Handle = Selector.GetHandle("setDescriptor:forKeyword:");

	private static readonly IntPtr selDescriptorForKeyword_Handle = Selector.GetHandle("descriptorForKeyword:");

	private static readonly IntPtr selRemoveDescriptorWithKeyword_Handle = Selector.GetHandle("removeDescriptorWithKeyword:");

	private static readonly IntPtr selKeywordForDescriptorAtIndex_Handle = Selector.GetHandle("keywordForDescriptorAtIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAppleEventDescriptor");

	private static object __mt_NullDescriptor_var_static;

	private static object __mt_ListDescriptor_var_static;

	private static object __mt_RecordDescriptor_var_static;

	private object __mt_Data_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSAppleEventDescriptor NullDescriptor
	{
		[Export("nullDescriptor")]
		get
		{
			return (NSAppleEventDescriptor)(__mt_NullDescriptor_var_static = (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selNullDescriptorHandle)));
		}
	}

	public static NSAppleEventDescriptor ListDescriptor
	{
		[Export("listDescriptor")]
		get
		{
			return (NSAppleEventDescriptor)(__mt_ListDescriptor_var_static = (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selListDescriptorHandle)));
		}
	}

	public static NSAppleEventDescriptor RecordDescriptor
	{
		[Export("recordDescriptor")]
		get
		{
			return (NSAppleEventDescriptor)(__mt_RecordDescriptor_var_static = (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selRecordDescriptorHandle)));
		}
	}

	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			return (NSData)(__mt_Data_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle)))));
		}
	}

	public virtual bool BooleanValue
	{
		[Export("booleanValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBooleanValueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBooleanValueHandle);
		}
	}

	public virtual int Int32Value
	{
		[Export("int32Value")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selInt32ValueHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selInt32ValueHandle);
		}
	}

	public virtual uint TypeCodeValue
	{
		[Export("typeCodeValue")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selTypeCodeValueHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selTypeCodeValueHandle);
		}
	}

	public virtual string StringValue
	{
		[Export("stringValue")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValueHandle));
		}
	}

	public virtual AEEventClass EventClass
	{
		[Export("eventClass")]
		get
		{
			if (IsDirectBinding)
			{
				return (AEEventClass)Messaging.UInt32_objc_msgSend(base.Handle, selEventClassHandle);
			}
			return (AEEventClass)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEventClassHandle);
		}
	}

	public virtual AEEventID EventID
	{
		[Export("eventID")]
		get
		{
			if (IsDirectBinding)
			{
				return (AEEventID)Messaging.UInt32_objc_msgSend(base.Handle, selEventIDHandle);
			}
			return (AEEventID)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEventIDHandle);
		}
	}

	public virtual int NumberOfItems
	{
		[Export("numberOfItems")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAppleEventDescriptor()
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
	public NSAppleEventDescriptor(NSCoder coder)
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
	public NSAppleEventDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAppleEventDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("descriptorWithBoolean:")]
	public static NSAppleEventDescriptor DescriptorWithBoolean(bool boolean)
	{
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(class_ptr, selDescriptorWithBoolean_Handle, boolean));
	}

	[Export("descriptorWithEnumCode:")]
	public static NSAppleEventDescriptor DescriptorWithEnumCode(uint enumerator)
	{
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selDescriptorWithEnumCode_Handle, enumerator));
	}

	[Export("descriptorWithInt32:")]
	public static NSAppleEventDescriptor DescriptorWithInt32(int signedInt)
	{
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(class_ptr, selDescriptorWithInt32_Handle, signedInt));
	}

	[Export("descriptorWithTypeCode:")]
	public static NSAppleEventDescriptor DescriptorWithTypeCode(uint typeCode)
	{
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(class_ptr, selDescriptorWithTypeCode_Handle, typeCode));
	}

	[Export("descriptorWithString:")]
	public static NSAppleEventDescriptor DescriptorWithString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSAppleEventDescriptor result = (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDescriptorWithString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initListDescriptor")]
	public virtual NSObject InitListDescriptor()
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitListDescriptorHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitListDescriptorHandle));
	}

	[Export("initRecordDescriptor")]
	public virtual NSObject InitRecordDescriptor()
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInitRecordDescriptorHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitRecordDescriptorHandle));
	}

	[Export("enumCodeValue")]
	public virtual uint EnumCodeValue()
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend(base.Handle, selEnumCodeValueHandle);
		}
		return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selEnumCodeValueHandle);
	}

	[Export("setParamDescriptor:forKeyword:")]
	public virtual void SetParamDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetParamDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetParamDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[Export("paramDescriptorForKeyword:")]
	public virtual NSAppleEventDescriptor ParamDescriptorForKeyword(uint keyword)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selParamDescriptorForKeyword_Handle, keyword));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selParamDescriptorForKeyword_Handle, keyword));
	}

	[Export("removeParamDescriptorWithKeyword:")]
	public virtual void RemoveParamDescriptorWithKeyword(uint keyword)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveParamDescriptorWithKeyword_Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveParamDescriptorWithKeyword_Handle, keyword);
		}
	}

	[Export("setAttributeDescriptor:forKeyword:")]
	public virtual void SetAttributeDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetAttributeDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetAttributeDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[Export("attributeDescriptorForKeyword:")]
	public virtual NSAppleEventDescriptor AttributeDescriptorForKeyword(uint keyword)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selAttributeDescriptorForKeyword_Handle, keyword));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selAttributeDescriptorForKeyword_Handle, keyword));
	}

	[Export("insertDescriptor:atIndex:")]
	public virtual void InsertDescriptoratIndex(NSAppleEventDescriptor descriptor, int index)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertDescriptorAtIndex_Handle, descriptor.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertDescriptorAtIndex_Handle, descriptor.Handle, index);
		}
	}

	[Export("descriptorAtIndex:")]
	public virtual NSAppleEventDescriptor DescriptorAtIndex(int index)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selDescriptorAtIndex_Handle, index));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selDescriptorAtIndex_Handle, index));
	}

	[Export("removeDescriptorAtIndex:")]
	public virtual void RemoveDescriptorAtIndex(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selRemoveDescriptorAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selRemoveDescriptorAtIndex_Handle, index);
		}
	}

	[Export("setDescriptor:forKeyword:")]
	public virtual void SetDescriptorforKeyword(NSAppleEventDescriptor descriptor, uint keyword)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt32(base.Handle, selSetDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selSetDescriptorForKeyword_Handle, descriptor.Handle, keyword);
		}
	}

	[Export("descriptorForKeyword:")]
	public virtual NSAppleEventDescriptor DescriptorForKeyword(uint keyword)
	{
		if (IsDirectBinding)
		{
			return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selDescriptorForKeyword_Handle, keyword));
		}
		return (NSAppleEventDescriptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selDescriptorForKeyword_Handle, keyword));
	}

	[Export("removeDescriptorWithKeyword:")]
	public virtual void RemoveDescriptorWithKeyword(uint keyword)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32(base.Handle, selRemoveDescriptorWithKeyword_Handle, keyword);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selRemoveDescriptorWithKeyword_Handle, keyword);
		}
	}

	[Export("keywordForDescriptorAtIndex:")]
	public virtual uint KeywordForDescriptorAtIndex(int index)
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt32_objc_msgSend_int(base.Handle, selKeywordForDescriptorAtIndex_Handle, index);
		}
		return Messaging.UInt32_objc_msgSendSuper_int(base.SuperHandle, selKeywordForDescriptorAtIndex_Handle, index);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Data_var = null;
		}
	}
}
