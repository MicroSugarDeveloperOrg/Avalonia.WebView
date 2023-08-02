using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSOutputStream", true)]
public class NSOutputStream : NSStream
{
	private const string selWriteMaxLength = "write:maxLength:";

	private static readonly IntPtr selInitToMemoryHandle = Selector.GetHandle("initToMemory");

	private static readonly IntPtr selHasSpaceAvailableHandle = Selector.GetHandle("hasSpaceAvailable");

	private static readonly IntPtr selInitToFileAtPathAppend_Handle = Selector.GetHandle("initToFileAtPath:append:");

	private static readonly IntPtr selOutputStreamToMemoryHandle = Selector.GetHandle("outputStreamToMemory");

	private static readonly IntPtr selOutputStreamToFileAtPathAppend_Handle = Selector.GetHandle("outputStreamToFileAtPath:append:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOutputStream");

	public override IntPtr ClassHandle => class_ptr;

	public int Write(byte[] buffer, uint len)
	{
		return objc_msgSend(base.Handle, Selector.GetHandle("write:maxLength:"), buffer, len);
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern int objc_msgSend(IntPtr handle, IntPtr sel, [In][Out] byte[] buffer, uint len);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOutputStream(NSCoder coder)
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
	public NSOutputStream(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOutputStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initToMemory")]
	public NSOutputStream()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, selInitToMemoryHandle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitToMemoryHandle);
		}
	}

	[Export("hasSpaceAvailable")]
	public virtual bool HasSpaceAvailable()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasSpaceAvailableHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasSpaceAvailableHandle);
	}

	[Export("initToFileAtPath:append:")]
	public NSOutputStream(string path, bool shouldAppend)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitToFileAtPathAppend_Handle, arg, shouldAppend);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitToFileAtPathAppend_Handle, arg, shouldAppend);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("outputStreamToMemory")]
	public static NSObject OutputStreamToMemory()
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOutputStreamToMemoryHandle));
	}

	[Export("outputStreamToFileAtPath:append:")]
	public static NSOutputStream CreateFile(string path, bool shouldAppend)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSOutputStream result = (NSOutputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selOutputStreamToFileAtPathAppend_Handle, arg, shouldAppend));
		NSString.ReleaseNative(arg);
		return result;
	}
}
