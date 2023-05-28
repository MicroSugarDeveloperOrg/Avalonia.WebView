using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSJSONSerialization", true)]
public class NSJsonSerialization : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSONObjectWithData_Options_Error_ = "JSONObjectWithData:options:error:";

	private static readonly IntPtr selJSONObjectWithData_Options_Error_Handle = Selector.GetHandle("JSONObjectWithData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selJSONObjectWithStream_Options_Error_ = "JSONObjectWithStream:options:error:";

	private static readonly IntPtr selJSONObjectWithStream_Options_Error_Handle = Selector.GetHandle("JSONObjectWithStream:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithJSONObject_Options_Error_ = "dataWithJSONObject:options:error:";

	private static readonly IntPtr selDataWithJSONObject_Options_Error_Handle = Selector.GetHandle("dataWithJSONObject:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidJSONObject_ = "isValidJSONObject:";

	private static readonly IntPtr selIsValidJSONObject_Handle = Selector.GetHandle("isValidJSONObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteJSONObject_ToStream_Options_Error_ = "writeJSONObject:toStream:options:error:";

	private static readonly IntPtr selWriteJSONObject_ToStream_Options_Error_Handle = Selector.GetHandle("writeJSONObject:toStream:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSJSONSerialization");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSJsonSerialization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSJsonSerialization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("JSONObjectWithData:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject Deserialize(NSData data, NSJsonReadingOptions opt, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selJSONObjectWithData_Options_Error_Handle, data.Handle, (ulong)opt, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("JSONObjectWithStream:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject Deserialize(NSInputStream stream, NSJsonReadingOptions opt, out NSError error)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selJSONObjectWithStream_Options_Error_Handle, stream.Handle, (ulong)opt, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("isValidJSONObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsValidJSONObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsValidJSONObject_Handle, obj.Handle);
	}

	[Export("dataWithJSONObject:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData Serialize(NSObject obj, NSJsonWritingOptions opt, out NSError error)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		IntPtr arg = IntPtr.Zero;
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selDataWithJSONObject_Options_Error_Handle, obj.Handle, (ulong)opt, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("writeJSONObject:toStream:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint Serialize(NSObject obj, NSOutputStream stream, NSJsonWritingOptions opt, out NSError error)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr arg = IntPtr.Zero;
		nint result = Messaging.nint_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(class_ptr, selWriteJSONObject_ToStream_Options_Error_Handle, obj.Handle, stream.Handle, (ulong)opt, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
