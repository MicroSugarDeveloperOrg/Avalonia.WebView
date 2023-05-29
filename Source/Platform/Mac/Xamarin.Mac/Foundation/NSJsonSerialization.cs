using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSJSONSerialization", true)]
public class NSJsonSerialization : NSObject
{
	private static readonly IntPtr selIsValidJSONObject_Handle = Selector.GetHandle("isValidJSONObject:");

	private static readonly IntPtr selDataWithJSONObjectOptionsError_Handle = Selector.GetHandle("dataWithJSONObject:options:error:");

	private static readonly IntPtr selJSONObjectWithDataOptionsError_Handle = Selector.GetHandle("JSONObjectWithData:options:error:");

	private static readonly IntPtr selWriteJSONObjectToStreamOptionsError_Handle = Selector.GetHandle("writeJSONObject:toStream:options:error:");

	private static readonly IntPtr selJSONObjectWithStreamOptionsError_Handle = Selector.GetHandle("JSONObjectWithStream:options:error:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSJSONSerialization");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSJsonSerialization(NSCoder coder)
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
	public NSJsonSerialization(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSJsonSerialization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isValidJSONObject:")]
	public static bool IsValidJSONObject(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsValidJSONObject_Handle, obj.Handle);
	}

	[Export("dataWithJSONObject:options:error:")]
	public static NSData Serialize(NSObject obj, NSJsonWritingOptions opt, out NSError error)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selDataWithJSONObjectOptionsError_Handle, obj.Handle, (ulong)opt, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("JSONObjectWithData:options:error:")]
	public static NSObject Deserialize(NSData data, NSJsonReadingOptions opt, NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selJSONObjectWithDataOptionsError_Handle, data.Handle, (ulong)opt, error.Handle));
	}

	[Export("writeJSONObject:toStream:options:error:")]
	public static long Serialize(NSObject obj, NSOutputStream stream, NSJsonWritingOptions opt, out NSError error)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		long result = Messaging.Int64_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(class_ptr, selWriteJSONObjectToStreamOptionsError_Handle, obj.Handle, stream.Handle, (ulong)opt, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("JSONObjectWithStream:options:error:")]
	public static NSObject Deserialize(NSInputStream stream, NSJsonReadingOptions opt, out NSError error)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr(class_ptr, selJSONObjectWithStreamOptionsError_Handle, stream.Handle, (ulong)opt, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}
}
