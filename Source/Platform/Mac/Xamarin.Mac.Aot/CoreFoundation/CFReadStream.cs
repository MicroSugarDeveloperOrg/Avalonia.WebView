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
	private static extern IntPtr CFReadStreamCopyError(IntPtr handle);

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
	private static extern bool CFReadStreamOpen(IntPtr handle);

	protected override bool DoOpen()
	{
		return CFReadStreamOpen(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamClose(IntPtr handle);

	protected override void DoClose()
	{
		CFReadStreamClose(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFStreamStatus CFReadStreamGetStatus(IntPtr handle);

	protected override CFStreamStatus DoGetStatus()
	{
		return CFReadStreamGetStatus(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFReadStreamHasBytesAvailable(IntPtr handle);

	public bool HasBytesAvailable()
	{
		return CFReadStreamHasBytesAvailable(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamScheduleWithRunLoop(IntPtr handle, IntPtr loop, IntPtr mode);

	protected override void ScheduleWithRunLoop(CFRunLoop loop, NSString mode)
	{
		CFReadStreamScheduleWithRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFReadStreamUnscheduleFromRunLoop(IntPtr handle, IntPtr loop, IntPtr mode);

	protected override void UnscheduleFromRunLoop(CFRunLoop loop, NSString mode)
	{
		CFReadStreamUnscheduleFromRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFReadStreamSetClient(IntPtr stream, CFIndex eventTypes, CFStreamCallback cb, IntPtr context);

	protected override bool DoSetClient(CFStreamCallback callback, CFIndex eventTypes, IntPtr context)
	{
		return CFReadStreamSetClient(base.Handle, eventTypes, callback, context);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFIndex CFReadStreamRead(IntPtr handle, IntPtr buffer, CFIndex count);

	public int Read(byte[] buffer)
	{
		return Read(buffer, 0, buffer.Length);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
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
		GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
		try
		{
			return CFReadStreamRead(buffer: new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + offset), handle: base.Handle, count: count);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFReadStreamCopyProperty(IntPtr handle, IntPtr name);

	protected override IntPtr DoGetProperty(NSString name)
	{
		return CFReadStreamCopyProperty(base.Handle, name.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFReadStreamSetProperty(IntPtr handle, IntPtr name, IntPtr value);

	protected override bool DoSetProperty(NSString name, INativeObject value)
	{
		return CFReadStreamSetProperty(base.Handle, name.Handle, value.Handle);
	}
}
