using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSPropertyListSerialization", true)]
public class NSPropertyListSerialization : NSObject
{
	private static readonly IntPtr selDataWithPropertyListFormatOptionsError_Handle = Selector.GetHandle("dataWithPropertyList:format:options:error:");

	private static readonly IntPtr selWritePropertyListToStreamFormatOptionsError_Handle = Selector.GetHandle("writePropertyList:toStream:format:options:error:");

	private static readonly IntPtr selPropertyListWithDataOptionsFormatError_Handle = Selector.GetHandle("propertyListWithData:options:format:error:");

	private static readonly IntPtr selPropertyListWithStreamOptionsFormatError_Handle = Selector.GetHandle("propertyListWithStream:options:format:error:");

	private static readonly IntPtr selPropertyListIsValidForFormat_Handle = Selector.GetHandle("propertyList:isValidForFormat:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPropertyListSerialization");

	public override IntPtr ClassHandle => class_ptr;

	public static NSData DataWithPropertyList(NSObject plist, NSPropertyListFormat format, out NSError error)
	{
		return DataWithPropertyList(plist, format, NSPropertyListWriteOptions.Immutable, out error);
	}

	public static int WritePropertyList(NSObject plist, NSOutputStream stream, NSPropertyListFormat format, out NSError error)
	{
		return WritePropertyList(plist, stream, format, NSPropertyListWriteOptions.Immutable, out error);
	}

	public static NSObject PropertyListWithData(NSData data, ref NSPropertyListFormat format, out NSError error)
	{
		return PropertyListWithData(data, NSPropertyListReadOptions.Immutable, ref format, out error);
	}

	public static NSObject PropertyListWithStream(NSInputStream stream, ref NSPropertyListFormat format, out NSError error)
	{
		return PropertyListWithStream(stream, NSPropertyListReadOptions.Immutable, ref format, out error);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSPropertyListSerialization(NSCoder coder)
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
	public NSPropertyListSerialization(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPropertyListSerialization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dataWithPropertyList:format:options:error:")]
	public static NSData DataWithPropertyList(NSObject plist, NSPropertyListFormat format, NSPropertyListWriteOptions options, out NSError error)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSData result = (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr(class_ptr, selDataWithPropertyListFormatOptionsError_Handle, plist.Handle, (ulong)format, (ulong)options, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writePropertyList:toStream:format:options:error:")]
	public static int WritePropertyList(NSObject plist, NSOutputStream stream, NSPropertyListFormat format, NSPropertyListWriteOptions options, out NSError error)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		int result = Messaging.int_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_IntPtr(class_ptr, selWritePropertyListToStreamFormatOptionsError_Handle, plist.Handle, stream.Handle, (ulong)format, (ulong)options, intPtr);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("propertyListWithData:options:format:error:")]
	public static NSObject PropertyListWithData(NSData data, NSPropertyListReadOptions options, ref NSPropertyListFormat format, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_out_NSPropertyListFormat_IntPtr(class_ptr, selPropertyListWithDataOptionsFormatError_Handle, data.Handle, (ulong)options, out format, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	[Export("propertyListWithStream:options:format:error:")]
	public static NSObject PropertyListWithStream(NSInputStream stream, NSPropertyListReadOptions options, ref NSPropertyListFormat format, out NSError error)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_out_NSPropertyListFormat_IntPtr(class_ptr, selPropertyListWithStreamOptionsFormatError_Handle, stream.Handle, (ulong)options, out format, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	[Export("propertyList:isValidForFormat:")]
	public static bool IsValidForFormat(NSObject plist, NSPropertyListFormat format)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		return Messaging.bool_objc_msgSend_IntPtr_UInt64(class_ptr, selPropertyListIsValidForFormat_Handle, plist.Handle, (ulong)format);
	}
}
