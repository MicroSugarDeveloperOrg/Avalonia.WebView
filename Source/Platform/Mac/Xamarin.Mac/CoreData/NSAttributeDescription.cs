using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSAttributeDescription", true)]
public class NSAttributeDescription : NSPropertyDescription
{
	private static readonly IntPtr selAttributeTypeHandle = Selector.GetHandle("attributeType");

	private static readonly IntPtr selSetAttributeType_Handle = Selector.GetHandle("setAttributeType:");

	private static readonly IntPtr selAttributeValueClassNameHandle = Selector.GetHandle("attributeValueClassName");

	private static readonly IntPtr selSetAttributeValueClassName_Handle = Selector.GetHandle("setAttributeValueClassName:");

	private static readonly IntPtr selDefaultValueHandle = Selector.GetHandle("defaultValue");

	private static readonly IntPtr selSetDefaultValue_Handle = Selector.GetHandle("setDefaultValue:");

	private static readonly IntPtr selVersionHashHandle = Selector.GetHandle("versionHash");

	private static readonly IntPtr selValueTransformerNameHandle = Selector.GetHandle("valueTransformerName");

	private static readonly IntPtr selSetValueTransformerName_Handle = Selector.GetHandle("setValueTransformerName:");

	private static readonly IntPtr selAllowsExternalBinaryDataStorageHandle = Selector.GetHandle("allowsExternalBinaryDataStorage");

	private static readonly IntPtr selSetAllowsExternalBinaryDataStorage_Handle = Selector.GetHandle("setAllowsExternalBinaryDataStorage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAttributeDescription");

	private object __mt_DefaultValue_var;

	private object __mt_VersionHash_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSAttributeType AttributeType
	{
		[Export("attributeType")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSAttributeType)Messaging.UInt64_objc_msgSend(base.Handle, selAttributeTypeHandle);
			}
			return (NSAttributeType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAttributeTypeHandle);
		}
		[Export("setAttributeType:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAttributeType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAttributeType_Handle, (ulong)value);
			}
		}
	}

	public virtual string AttributeValueClassName
	{
		[Export("attributeValueClassName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeValueClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeValueClassNameHandle));
		}
		[Export("setAttributeValueClassName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributeValueClassName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeValueClassName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject DefaultValue
	{
		[Export("defaultValue")]
		get
		{
			return (NSObject)(__mt_DefaultValue_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultValueHandle))));
		}
		[Export("setDefaultValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultValue_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultValue_Handle, value.Handle);
			}
			__mt_DefaultValue_var = value;
		}
	}

	public new virtual NSData VersionHash
	{
		[Export("versionHash")]
		get
		{
			return (NSData)(__mt_VersionHash_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVersionHashHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVersionHashHandle)))));
		}
	}

	public virtual string ValueTransformerName
	{
		[Export("valueTransformerName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selValueTransformerNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueTransformerNameHandle));
		}
		[Export("setValueTransformerName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValueTransformerName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValueTransformerName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Since(5, 0)]
	public virtual bool AllowsExternalBinaryDataStorage
	{
		[Export("allowsExternalBinaryDataStorage")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsExternalBinaryDataStorageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsExternalBinaryDataStorageHandle);
		}
		[Export("setAllowsExternalBinaryDataStorage:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsExternalBinaryDataStorage_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsExternalBinaryDataStorage_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAttributeDescription()
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
	public NSAttributeDescription(NSCoder coder)
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
	public NSAttributeDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAttributeDescription(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DefaultValue_var = null;
			__mt_VersionHash_var = null;
		}
	}
}
