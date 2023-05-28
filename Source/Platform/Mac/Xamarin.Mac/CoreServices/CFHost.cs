using System;
using System.Net;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace CoreServices;

internal class CFHost : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	private CFHost(IntPtr handle)
	{
		this.handle = handle;
	}

	~CFHost()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHostCreateWithAddress(IntPtr allocator, IntPtr addr);

	public static CFHost Create(IPEndPoint endpoint)
	{
		using CFSocketAddress cFSocketAddress = new CFSocketAddress(endpoint);
		return new CFHost(CFHostCreateWithAddress(IntPtr.Zero, cFSocketAddress.Handle));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFHostCreateWithName(IntPtr allocator, IntPtr hostname);

	public static CFHost Create(string name)
	{
		using CFString cFString = new CFString(name);
		return new CFHost(CFHostCreateWithName(IntPtr.Zero, cFString.Handle));
	}
}
