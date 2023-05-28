using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

public class CFMachPort : INativeObject, IDisposable
{
	private delegate void CFMachPortCallBack(IntPtr cfmachport, IntPtr msg, nint len, IntPtr context);

	internal IntPtr handle;

	public IntPtr Handle => handle;

	public IntPtr MachPort => CFMachPortGetPort(handle);

	public bool IsValid => CFMachPortIsValid(handle);

	public CFMachPort(IntPtr handle)
		: this(handle, ownsHandle: false)
	{
	}

	public CFMachPort(IntPtr handle, bool ownsHandle)
	{
		if (!ownsHandle)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFMachPort()
	{
		Dispose(disposing: false);
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

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMachPortGetPort(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFMachPortInvalidate(IntPtr handle);

	public void Invalidate()
	{
		CFMachPortInvalidate(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern bool CFMachPortIsValid(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFMachPortCreateRunLoopSource(IntPtr allocator, IntPtr port, IntPtr order);

	public CFRunLoopSource CreateRunLoopSource()
	{
		IntPtr intPtr = CFMachPortCreateRunLoopSource(IntPtr.Zero, handle, IntPtr.Zero);
		return new CFRunLoopSource(intPtr, ownsHandle: true);
	}
}
