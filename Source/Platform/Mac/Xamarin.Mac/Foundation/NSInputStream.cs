using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Foundation;

[Register("NSInputStream", true)]
public class NSInputStream : NSStream
{
	private const string selReadMaxLength = "read:maxLength:";

	private CFStreamEventType flags;

	private IntPtr callback;

	private CFStreamClientContext context;

	private static readonly IntPtr selHasBytesAvailableHandle = Selector.GetHandle("hasBytesAvailable");

	private static readonly IntPtr selInitWithFileAtPath_Handle = Selector.GetHandle("initWithFileAtPath:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInputStreamWithData_Handle = Selector.GetHandle("inputStreamWithData:");

	private static readonly IntPtr selInputStreamWithFileAtPath_Handle = Selector.GetHandle("inputStreamWithFileAtPath:");

	private static readonly IntPtr selInputStreamWithURL_Handle = Selector.GetHandle("inputStreamWithURL:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSInputStream");

	public override IntPtr ClassHandle => class_ptr;

	public long Read(byte[] buffer, ulong len)
	{
		return objc_msgSend(base.Handle, Selector.GetHandle("read:maxLength:"), buffer, len);
	}

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern long objc_msgSend(IntPtr handle, IntPtr sel, [In][Out] byte[] buffer, ulong len);

	[DllImport("/usr/lib/libobjc.dylib")]
	private static extern long objc_msgSend(IntPtr handle, IntPtr sel, IntPtr buffer, ulong len);

	[Export("read:maxLength:")]
	public virtual long Read(IntPtr buffer, ulong len)
	{
		if (buffer == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		if (IsDirectBinding)
		{
			return objc_msgSend(base.Handle, Selector.GetHandle("read:maxLength:"), buffer, len);
		}
		return objc_msgSend(base.SuperHandle, Selector.GetHandle("read:maxLength:"), buffer, len);
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
	protected virtual bool GetBuffer(out IntPtr buffer, out uint len)
	{
		buffer = IntPtr.Zero;
		len = 0u;
		return false;
	}

	public void Notify(CFStreamEventType eventType)
	{
		if ((flags & eventType) != 0)
		{
			context.Invoke(callback, base.Handle, eventType);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSInputStream()
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
	public NSInputStream(NSCoder coder)
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
	public NSInputStream(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSInputStream(IntPtr handle)
		: base(handle)
	{
	}

	[Export("hasBytesAvailable")]
	public virtual bool HasBytesAvailable()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasBytesAvailableHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasBytesAvailableHandle);
	}

	[Export("initWithFileAtPath:")]
	public NSInputStream(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFileAtPath_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFileAtPath_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithData:")]
	public NSInputStream(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	[Export("initWithURL:")]
	public NSInputStream(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
		}
	}

	[Export("inputStreamWithData:")]
	public static NSInputStream FromData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithData_Handle, data.Handle));
	}

	[Export("inputStreamWithFileAtPath:")]
	public static NSInputStream FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSInputStream result = (NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithFileAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("inputStreamWithURL:")]
	public static NSInputStream FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return (NSInputStream)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInputStreamWithURL_Handle, url.Handle));
	}
}
