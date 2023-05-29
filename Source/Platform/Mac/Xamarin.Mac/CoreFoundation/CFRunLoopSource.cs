using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

public class CFRunLoopSource : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int Order => CFRunLoopSourceGetOrder(handle);

	public bool IsValid => CFRunLoopSourceIsValid(handle) != 0;

	internal CFRunLoopSource(IntPtr handle)
		: this(handle, ownsHandle: false)
	{
	}

	internal CFRunLoopSource(IntPtr handle, bool ownsHandle)
	{
		if (!ownsHandle)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFRunLoopSource()
	{
		Dispose(disposing: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFIndex CFRunLoopSourceGetOrder(IntPtr source);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopSourceInvalidate(IntPtr source);

	public void Invalidate()
	{
		CFRunLoopSourceInvalidate(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern int CFRunLoopSourceIsValid(IntPtr source);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFRunLoopSourceSignal(IntPtr source);

	public void Signal()
	{
		CFRunLoopSourceSignal(handle);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
