using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTDataReference", true)]
public class QTDataReference : NSObject
{
	private static readonly IntPtr selDataRefDataHandle = Selector.GetHandle("dataRefData");

	private static readonly IntPtr selReferenceFileHandle = Selector.GetHandle("referenceFile");

	private static readonly IntPtr selReferenceURLHandle = Selector.GetHandle("referenceURL");

	private static readonly IntPtr selReferenceDataHandle = Selector.GetHandle("referenceData");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selMIMETypeHandle = Selector.GetHandle("MIMEType");

	private static readonly IntPtr selDataRefTypeHandle = Selector.GetHandle("dataRefType");

	private static readonly IntPtr selSetDataRefType_Handle = Selector.GetHandle("setDataRefType:");

	private static readonly IntPtr selDataReferenceWithDataRefDataType_Handle = Selector.GetHandle("dataReferenceWithDataRefData:type:");

	private static readonly IntPtr selDataReferenceWithReferenceToFile_Handle = Selector.GetHandle("dataReferenceWithReferenceToFile:");

	private static readonly IntPtr selDataReferenceWithReferenceToURL_Handle = Selector.GetHandle("dataReferenceWithReferenceToURL:");

	private static readonly IntPtr selDataReferenceWithReferenceToData_Handle = Selector.GetHandle("dataReferenceWithReferenceToData:");

	private static readonly IntPtr selDataReferenceWithReferenceToDataNameMIMEType_Handle = Selector.GetHandle("dataReferenceWithReferenceToData:name:MIMEType:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTDataReference");

	private object __mt_DataRefData_var;

	private object __mt_ReferenceUrl_var;

	private object __mt_ReferenceData_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSData DataRefData
	{
		[Export("dataRefData")]
		get
		{
			return (NSData)(__mt_DataRefData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRefDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRefDataHandle)))));
		}
	}

	public virtual string ReferenceFile
	{
		[Export("referenceFile")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceFileHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceFileHandle));
		}
	}

	public virtual NSUrl ReferenceUrl
	{
		[Export("referenceURL")]
		get
		{
			return (NSUrl)(__mt_ReferenceUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceURLHandle)))));
		}
	}

	public virtual NSData ReferenceData
	{
		[Export("referenceData")]
		get
		{
			return (NSData)(__mt_ReferenceData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferenceDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReferenceDataHandle)))));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual string MimeType
	{
		[Export("MIMEType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMIMETypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMIMETypeHandle));
		}
	}

	public virtual string DataRefType
	{
		[Export("dataRefType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRefTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRefTypeHandle));
		}
		[Export("setDataRefType:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataRefType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataRefType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTDataReference()
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
	public QTDataReference(NSCoder coder)
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
	public QTDataReference(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTDataReference(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dataReferenceWithDataRefData:type:")]
	public static NSObject FromDataRefData(NSData dataRefData, string type)
	{
		if (dataRefData == null)
		{
			throw new ArgumentNullException("dataRefData");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDataReferenceWithDataRefDataType_Handle, dataRefData.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("dataReferenceWithReferenceToFile:")]
	public static NSObject FromReference(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataReferenceWithReferenceToFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("dataReferenceWithReferenceToURL:")]
	public static NSObject FromReference(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataReferenceWithReferenceToURL_Handle, url.Handle));
	}

	[Export("dataReferenceWithReferenceToData:")]
	public static NSObject FromDataReference(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDataReferenceWithReferenceToData_Handle, data.Handle));
	}

	[Export("dataReferenceWithReferenceToData:name:MIMEType:")]
	public static NSObject FromReference(NSData data, string name, string mimeType)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(mimeType);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selDataReferenceWithReferenceToDataNameMIMEType_Handle, data.Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataRefData_var = null;
			__mt_ReferenceUrl_var = null;
			__mt_ReferenceData_var = null;
		}
	}
}
