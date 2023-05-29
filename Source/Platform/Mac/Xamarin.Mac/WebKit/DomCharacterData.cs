using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCharacterData", true)]
public class DomCharacterData : DomNode
{
	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selSubstringDataLength_Handle = Selector.GetHandle("substringData:length:");

	private static readonly IntPtr selAppendData_Handle = Selector.GetHandle("appendData:");

	private static readonly IntPtr selInsertDataData_Handle = Selector.GetHandle("insertData:data:");

	private static readonly IntPtr selDeleteDataLength_Handle = Selector.GetHandle("deleteData:length:");

	private static readonly IntPtr selReplaceDataLengthData_Handle = Selector.GetHandle("replaceData:length:data:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCharacterData");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Data
	{
		[Export("data")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
		[Export("setData:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetData_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetData_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCharacterData(NSCoder coder)
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
	public DomCharacterData(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCharacterData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("substringData:length:")]
	public virtual string SubstringData(uint offset, uint length)
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt32_UInt32(base.Handle, selSubstringDataLength_Handle, offset, length));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selSubstringDataLength_Handle, offset, length));
	}

	[Export("appendData:")]
	public virtual void AppendData(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendData_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendData_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertData:data:")]
	public virtual void InsertData(uint offset, string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_IntPtr(base.Handle, selInsertDataData_Handle, offset, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selInsertDataData_Handle, offset, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("deleteData:length:")]
	public virtual void DeleteData(uint offset, uint length)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32(base.Handle, selDeleteDataLength_Handle, offset, length);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selDeleteDataLength_Handle, offset, length);
		}
	}

	[Export("replaceData:length:data:")]
	public virtual void ReplaceData(uint offset, uint length, string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr(base.Handle, selReplaceDataLengthData_Handle, offset, length, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32_IntPtr(base.SuperHandle, selReplaceDataLengthData_Handle, offset, length, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
