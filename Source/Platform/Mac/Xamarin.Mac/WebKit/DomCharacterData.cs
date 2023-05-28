using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCharacterData", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCharacterData : DomNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendData_ = "appendData:";

	private static readonly IntPtr selAppendData_Handle = Selector.GetHandle("appendData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteData_Length_ = "deleteData:length:";

	private static readonly IntPtr selDeleteData_Length_Handle = Selector.GetHandle("deleteData:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertData_Data_ = "insertData:data:";

	private static readonly IntPtr selInsertData_Data_Handle = Selector.GetHandle("insertData:data:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceData_Length_Data_ = "replaceData:length:data:";

	private static readonly IntPtr selReplaceData_Length_Data_Handle = Selector.GetHandle("replaceData:length:data:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetData_ = "setData:";

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstringData_Length_ = "substringData:length:";

	private static readonly IntPtr selSubstringData_Length_Handle = Selector.GetHandle("substringData:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCharacterData");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Data
	{
		[Export("data", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
		[Export("setData:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCharacterData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCharacterData(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AppendData(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendData_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendData_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("deleteData:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteData(uint offset, uint length)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32(base.Handle, selDeleteData_Length_Handle, offset, length);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selDeleteData_Length_Handle, offset, length);
		}
	}

	[Export("insertData:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertData(uint offset, string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_IntPtr(base.Handle, selInsertData_Data_Handle, offset, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selInsertData_Data_Handle, offset, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceData:length:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceData(uint offset, uint length, string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr(base.Handle, selReplaceData_Length_Data_Handle, offset, length, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt32_UInt32_IntPtr(base.SuperHandle, selReplaceData_Length_Data_Handle, offset, length, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("substringData:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SubstringData(uint offset, uint length)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_UInt32_UInt32(base.Handle, selSubstringData_Length_Handle, offset, length));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32(base.SuperHandle, selSubstringData_Length_Handle, offset, length));
	}
}
