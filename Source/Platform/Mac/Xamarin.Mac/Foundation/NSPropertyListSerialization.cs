using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSPropertyListSerialization", true)]
public class NSPropertyListSerialization : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithPropertyList_Format_Options_Error_ = "dataWithPropertyList:format:options:error:";

	private static readonly IntPtr selDataWithPropertyList_Format_Options_Error_Handle = Selector.GetHandle("dataWithPropertyList:format:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyList_IsValidForFormat_ = "propertyList:isValidForFormat:";

	private static readonly IntPtr selPropertyList_IsValidForFormat_Handle = Selector.GetHandle("propertyList:isValidForFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyListWithData_Options_Format_Error_ = "propertyListWithData:options:format:error:";

	private static readonly IntPtr selPropertyListWithData_Options_Format_Error_Handle = Selector.GetHandle("propertyListWithData:options:format:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyListWithStream_Options_Format_Error_ = "propertyListWithStream:options:format:error:";

	private static readonly IntPtr selPropertyListWithStream_Options_Format_Error_Handle = Selector.GetHandle("propertyListWithStream:options:format:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritePropertyList_ToStream_Format_Options_Error_ = "writePropertyList:toStream:format:options:error:";

	private static readonly IntPtr selWritePropertyList_ToStream_Format_Options_Error_Handle = Selector.GetHandle("writePropertyList:toStream:format:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPropertyListSerialization");

	public override IntPtr ClassHandle => class_ptr;

	public static NSData DataWithPropertyList(NSObject plist, NSPropertyListFormat format, out NSError error)
	{
		return DataWithPropertyList(plist, format, NSPropertyListWriteOptions.Immutable, out error);
	}

	public static nint WritePropertyList(NSObject plist, NSOutputStream stream, NSPropertyListFormat format, out NSError error)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPropertyListSerialization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPropertyListSerialization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dataWithPropertyList:format:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData DataWithPropertyList(NSObject plist, NSPropertyListFormat format, NSPropertyListWriteOptions options, out NSError error)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		IntPtr arg = IntPtr.Zero;
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_ref_IntPtr(class_ptr, selDataWithPropertyList_Format_Options_Error_Handle, plist.Handle, (ulong)format, (ulong)options, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("propertyList:isValidForFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsValidForFormat(NSObject plist, NSPropertyListFormat format)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		return Messaging.bool_objc_msgSend_IntPtr_UInt64(class_ptr, selPropertyList_IsValidForFormat_Handle, plist.Handle, (ulong)format);
	}

	[Export("propertyListWithData:options:format:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject PropertyListWithData(NSData data, NSPropertyListReadOptions options, ref NSPropertyListFormat format, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_NSPropertyListFormat_ref_IntPtr(class_ptr, selPropertyListWithData_Options_Format_Error_Handle, data.Handle, (ulong)options, ref format, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("propertyListWithStream:options:format:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject PropertyListWithStream(NSInputStream stream, NSPropertyListReadOptions options, ref NSPropertyListFormat format, out NSError error)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_NSPropertyListFormat_ref_IntPtr(class_ptr, selPropertyListWithStream_Options_Format_Error_Handle, stream.Handle, (ulong)options, ref format, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("writePropertyList:toStream:format:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint WritePropertyList(NSObject plist, NSOutputStream stream, NSPropertyListFormat format, NSPropertyListWriteOptions options, out NSError error)
	{
		if (plist == null)
		{
			throw new ArgumentNullException("plist");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr arg = IntPtr.Zero;
		nint result = Messaging.nint_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_ref_IntPtr(class_ptr, selWritePropertyList_ToStream_Format_Options_Error_Handle, plist.Handle, stream.Handle, (ulong)format, (ulong)options, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}
