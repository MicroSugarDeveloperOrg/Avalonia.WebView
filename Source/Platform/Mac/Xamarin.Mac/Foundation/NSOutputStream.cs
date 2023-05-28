using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSOutputStream", true)]
public class NSOutputStream : NSStream
{
	private const string selWriteMaxLength = "write:maxLength:";

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasSpaceAvailable = "hasSpaceAvailable";

	private static readonly IntPtr selHasSpaceAvailableHandle = Selector.GetHandle("hasSpaceAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitToFileAtPath_Append_ = "initToFileAtPath:append:";

	private static readonly IntPtr selInitToFileAtPath_Append_Handle = Selector.GetHandle("initToFileAtPath:append:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitToMemory = "initToMemory";

	private static readonly IntPtr selInitToMemoryHandle = Selector.GetHandle("initToMemory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputStreamToFileAtPath_Append_ = "outputStreamToFileAtPath:append:";

	private static readonly IntPtr selOutputStreamToFileAtPath_Append_Handle = Selector.GetHandle("outputStreamToFileAtPath:append:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputStreamToMemory = "outputStreamToMemory";

	private static readonly IntPtr selOutputStreamToMemoryHandle = Selector.GetHandle("outputStreamToMemory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOutputStream");

	public override IntPtr ClassHandle => class_ptr;

	public nint Write(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return Write(buffer, (nuint)buffer.Length);
	}

	public nint Write(byte[] buffer, nuint len)
	{
		return objc_msgSend(base.Handle, Selector.GetHandle("write:maxLength:"), buffer, len);
	}

	public unsafe nint Write(byte[] buffer, int offset, nuint len)
	{
		if (offset + (long)len > buffer.Length)
		{
			throw new ArgumentException();
		}
		fixed (byte* ptr = &buffer[offset])
		{
			return objc_msgSend(base.Handle, Selector.GetHandle("write:maxLength:"), (IntPtr)ptr, len);
		}
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern nint objc_msgSend(IntPtr handle, IntPtr sel, [In][Out] byte[] buffer, nuint len);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern nint objc_msgSend(IntPtr handle, IntPtr sel, IntPtr buffer, nuint len);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOutputStream(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOutputStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initToMemory")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOutputStream()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitToMemoryHandle), "initToMemory");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitToMemoryHandle), "initToMemory");
		}
	}

	[Export("initToFileAtPath:append:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSOutputStream(string path, bool shouldAppend)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitToFileAtPath_Append_Handle, arg, shouldAppend), "initToFileAtPath:append:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitToFileAtPath_Append_Handle, arg, shouldAppend), "initToFileAtPath:append:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("outputStreamToFileAtPath:append:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOutputStream CreateFile(string path, bool shouldAppend)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSOutputStream nSObject = Runtime.GetNSObject<NSOutputStream>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(class_ptr, selOutputStreamToFileAtPath_Append_Handle, arg, shouldAppend));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("hasSpaceAvailable")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasSpaceAvailable()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasSpaceAvailableHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasSpaceAvailableHandle);
	}

	[Export("outputStreamToMemory")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject OutputStreamToMemory()
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOutputStreamToMemoryHandle));
	}
}
