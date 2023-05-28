using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFWriteStream : CFStream
{
	internal CFWriteStream(IntPtr handle)
		: base(handle)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFWriteStreamCopyError(IntPtr stream);

	public override CFException GetError()
	{
		IntPtr intPtr = CFWriteStreamCopyError(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return CFException.FromCFError(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFWriteStreamOpen(IntPtr stream);

	protected override bool DoOpen()
	{
		return CFWriteStreamOpen(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamClose(IntPtr stream);

	protected override void DoClose()
	{
		CFWriteStreamClose(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFWriteStreamGetStatus(IntPtr stream);

	protected override CFStreamStatus DoGetStatus()
	{
		return (CFStreamStatus)(long)CFWriteStreamGetStatus(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFWriteStreamCanAcceptBytes(IntPtr handle);

	public bool CanAcceptBytes()
	{
		return CFWriteStreamCanAcceptBytes(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFWriteStreamWrite(IntPtr handle, IntPtr buffer, nint count);

	public int Write(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return Write(buffer, 0, buffer.Length);
	}

	public unsafe int Write(byte[] buffer, nint offset, nint count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		CheckHandle();
		if (offset < 0)
		{
			throw new ArgumentException();
		}
		if (count < 1)
		{
			throw new ArgumentException();
		}
		if (offset + count > buffer.Length)
		{
			throw new ArgumentException();
		}
		fixed (byte* ptr = buffer)
		{
			return (int)CFWriteStreamWrite(base.Handle, (IntPtr)ptr + (int)offset, count);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFWriteStreamSetClient(IntPtr stream, nint streamEvents, CFStreamCallback clientCB, IntPtr clientContext);

	protected override bool DoSetClient(CFStreamCallback callback, nint eventTypes, IntPtr context)
	{
		return CFWriteStreamSetClient(base.Handle, eventTypes, callback, context);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamScheduleWithRunLoop(IntPtr stream, IntPtr runLoop, IntPtr runLoopMode);

	protected override void ScheduleWithRunLoop(CFRunLoop loop, NSString mode)
	{
		if (loop == null)
		{
			throw new ArgumentNullException("loop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFWriteStreamScheduleWithRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamUnscheduleFromRunLoop(IntPtr stream, IntPtr runLoop, IntPtr runLoopMode);

	protected override void UnscheduleFromRunLoop(CFRunLoop loop, NSString mode)
	{
		if (loop == null)
		{
			throw new ArgumentNullException("loop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		CFWriteStreamUnscheduleFromRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFWriteStreamSetProperty(IntPtr stream, IntPtr propertyName);

	protected override IntPtr DoGetProperty(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return CFWriteStreamSetProperty(base.Handle, name.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFWriteStreamSetProperty(IntPtr stream, IntPtr propertyName, IntPtr value);

	protected override bool DoSetProperty(NSString name, INativeObject value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return CFWriteStreamSetProperty(base.Handle, name.Handle, value?.Handle ?? IntPtr.Zero);
	}
}
