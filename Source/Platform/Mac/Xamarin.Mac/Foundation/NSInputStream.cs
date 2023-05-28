using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSInputStream", true)]
public class NSInputStream : NSStream
{
	private const string selReadMaxLength = "read:maxLength:";

	private CFStreamEventType flags;

	private IntPtr callback;

	private CFStreamClientContext context;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasBytesAvailable = "hasBytesAvailable";

	private static readonly IntPtr selHasBytesAvailableHandle = Selector.GetHandle("hasBytesAvailable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFileAtPath_ = "initWithFileAtPath:";

	private static readonly IntPtr selInitWithFileAtPath_Handle = Selector.GetHandle("initWithFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputStreamWithData_ = "inputStreamWithData:";

	private static readonly IntPtr selInputStreamWithData_Handle = Selector.GetHandle("inputStreamWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputStreamWithFileAtPath_ = "inputStreamWithFileAtPath:";

	private static readonly IntPtr selInputStreamWithFileAtPath_Handle = Selector.GetHandle("inputStreamWithFileAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputStreamWithURL_ = "inputStreamWithURL:";

	private static readonly IntPtr selInputStreamWithURL_Handle = Selector.GetHandle("inputStreamWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSInputStream");

	public override IntPtr ClassHandle => class_ptr;

	public nint Read(byte[] buffer, nuint len)
	{
		return objc_msgSend(base.Handle, Selector.GetHandle("read:maxLength:"), buffer, len);
	}

	public unsafe nint Read(byte[] buffer, int offset, nuint len)
	{
		if (offset + (long)len > buffer.Length)
		{
			throw new ArgumentException();
		}
		fixed (byte* ptr = &buffer[offset])
		{
			return Read((IntPtr)ptr, len);
		}
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern nint objc_msgSend(IntPtr handle, IntPtr sel, [In][Out] byte[] buffer, nuint len);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern nint objc_msgSend(IntPtr handle, IntPtr sel, IntPtr buffer, nuint len);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern nint objc_msgSendSuper(IntPtr handle, IntPtr sel, IntPtr buffer, nuint len);

	[Export("read:maxLength:")]
	public virtual nint Read(IntPtr buffer, nuint len)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		if (base.IsDirectBinding)
		{
			return objc_msgSend(base.Handle, Selector.GetHandle("read:maxLength:"), buffer, len);
		}
		return objc_msgSendSuper(base.SuperHandle, Selector.GetHandle("read:maxLength:"), buffer, len);
	}

	protected override void Dispose(bool disposing)
	{
		context.Release();
		context.Info = IntPtr.Zero;
		base.Dispose(disposing);
	}

	[Export("_setCFClientFlags:callback:context:")]
	protected virtual bool SetCFClientFlags(CFStreamEventType inFlags, IntPtr inCallback, IntPtr inContextPtr)
	{
		if (inContextPtr == IntPtr.Zero)
		{
			return false;
		}
		CFStreamClientContext cFStreamClientContext = (CFStreamClientContext)Marshal.PtrToStructure(inContextPtr, typeof(CFStreamClientContext));
		if (cFStreamClientContext.Version != 0)
		{
			return false;
		}
		context.Release();
		context = cFStreamClientContext;
		context.Retain();
		flags = inFlags;
		callback = inCallback;
		return true;
	}

	[Export("getBuffer:length:")]
	protected virtual bool GetBuffer(out IntPtr buffer, out nuint len)
	{
		buffer = IntPtr.Zero;
		len = (byte)0;
		return false;
	}

	public void Notify(CFStreamEventType eventType)
	{
		if ((flags & eventType) != 0)
		{
			context.Invoke(callback, base.Handle, eventType);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSInputStream()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSInputStream(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSInputStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSInputStream(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFileAtPath_Handle, arg), "initWithFileAtPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFileAtPath_Handle, arg), "initWithFileAtPath:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithData:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSInputStream(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("initWithURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSInputStream(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("inputStreamWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSInputStream FromData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithData_Handle, data.Handle));
	}

	[Export("inputStreamWithFileAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSInputStream FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSInputStream nSObject = Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("inputStreamWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSInputStream FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSInputStream>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithURL_Handle, url.Handle));
	}

	[Export("hasBytesAvailable")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasBytesAvailable()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasBytesAvailableHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasBytesAvailableHandle);
	}
}
