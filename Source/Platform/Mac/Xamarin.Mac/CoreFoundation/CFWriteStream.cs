using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFWriteStream : CFStream
{
	internal CFWriteStream(IntPtr handle)
		: base(handle)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFWriteStreamCopyError(IntPtr handle);

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
	private static extern bool CFWriteStreamOpen(IntPtr handle);

	protected override bool DoOpen()
	{
		return CFWriteStreamOpen(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamClose(IntPtr handle);

	protected override void DoClose()
	{
		CFWriteStreamClose(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFStreamStatus CFWriteStreamGetStatus(IntPtr handle);

	protected override CFStreamStatus DoGetStatus()
	{
		return CFWriteStreamGetStatus(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFWriteStreamCanAcceptBytes(IntPtr handle);

	public bool CanAcceptBytes()
	{
		return CFWriteStreamCanAcceptBytes(base.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFIndex CFWriteStreamWrite(IntPtr handle, IntPtr buffer, CFIndex count);

	public int Write(byte[] buffer)
	{
		return Write(buffer, 0, buffer.Length);
	}

	public int Write(byte[] buffer, int offset, int count)
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
			return CFWriteStreamWrite(buffer: new IntPtr(gCHandle.AddrOfPinnedObject().ToInt64() + offset), handle: base.Handle, count: count);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFWriteStreamSetClient(IntPtr stream, CFIndex eventTypes, CFStreamCallback cb, IntPtr context);

	protected override bool DoSetClient(CFStreamCallback callback, CFIndex eventTypes, IntPtr context)
	{
		return CFWriteStreamSetClient(base.Handle, eventTypes, callback, context);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamScheduleWithRunLoop(IntPtr handle, IntPtr loop, IntPtr mode);

	protected override void ScheduleWithRunLoop(CFRunLoop loop, NSString mode)
	{
		CFWriteStreamScheduleWithRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFWriteStreamUnscheduleFromRunLoop(IntPtr handle, IntPtr loop, IntPtr mode);

	protected override void UnscheduleFromRunLoop(CFRunLoop loop, NSString mode)
	{
		CFWriteStreamUnscheduleFromRunLoop(base.Handle, loop.Handle, mode.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFReadStreamCopyProperty(IntPtr handle, IntPtr name);

	protected override IntPtr DoGetProperty(NSString name)
	{
		return CFReadStreamCopyProperty(base.Handle, name.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFWriteStreamSetProperty(IntPtr handle, IntPtr name, IntPtr value);

	protected override bool DoSetProperty(NSString name, INativeObject value)
	{
		return CFWriteStreamSetProperty(base.Handle, name.Handle, value.Handle);
	}
}
