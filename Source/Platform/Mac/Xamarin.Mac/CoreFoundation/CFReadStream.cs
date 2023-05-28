using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFReadStream : CFStream
{
	public CFReadStream(IntPtr handle)
		: base(handle)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFReadStreamCopyError(IntPtr stream);

	public override CFException GetError()
	{
		IntPtr intPtr = CFReadStreamCopyError(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return CFException.FromCFError(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFReadStreamOpen(IntPtr stream);

	protected override bool DoOpen()
	{
		return CFReadStreamOpen(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamClose(IntPtr stream);

	protected override void DoClose()
	{
		CFReadStreamClose(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFReadStreamGetStatus(IntPtr stream);

	protected override CFStreamStatus DoGetStatus()
	{
		return (CFStreamStatus)(long)CFReadStreamGetStatus(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFReadStreamHasBytesAvailable(IntPtr stream);

	public bool HasBytesAvailable()
	{
		return CFReadStreamHasBytesAvailable(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamScheduleWithRunLoop(IntPtr stream, IntPtr runLoop, IntPtr runLoopMode);

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
		CFReadStreamScheduleWithRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamUnscheduleFromRunLoop(IntPtr stream, IntPtr runLoop, IntPtr runLoopMode);

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
		CFReadStreamUnscheduleFromRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFReadStreamSetClient(IntPtr stream, nint streamEvents, CFStreamCallback clientCB, IntPtr clientContext);

	protected override bool DoSetClient(CFStreamCallback callback, nint eventTypes, IntPtr context)
	{
		return CFReadStreamSetClient(base.Handle, eventTypes, callback, context);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFReadStreamRead(IntPtr handle, IntPtr buffer, nint count);

	public nint Read(byte[] buffer)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		return Read(buffer, 0, buffer.Length);
	}

	public unsafe nint Read(byte[] buffer, int offset, int count)
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
			return CFReadStreamRead(base.Handle, (IntPtr)ptr + offset, count);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFReadStreamCopyProperty(IntPtr stream, IntPtr propertyName);

	protected override IntPtr DoGetProperty(NSString name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return CFReadStreamCopyProperty(base.Handle, name.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CFReadStreamSetProperty(IntPtr stream, IntPtr propertyName, IntPtr propertyValue);

	protected override bool DoSetProperty(NSString name, INativeObject value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		return CFReadStreamSetProperty(base.Handle, name.Handle, value?.Handle ?? IntPtr.Zero);
	}
}
