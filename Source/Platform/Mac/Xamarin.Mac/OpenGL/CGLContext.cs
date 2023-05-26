using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace OpenGL;

public class CGLContext : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public static CGLContext CurrentContext
	{
		get
		{
			IntPtr intPtr = CGLGetCurrentContext();
			if (intPtr != IntPtr.Zero)
			{
				return new CGLContext(intPtr);
			}
			return null;
		}
		set
		{
			if (CGLSetCurrentContext(value.Handle) != 0)
			{
				throw new Exception("Error setting the Current Context");
			}
		}
	}

	public CGLContext(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid parameters to context creation");
		}
		CGLRetainContext(handle);
		this.handle = handle;
	}

	internal CGLContext()
	{
	}

	[Preserve(Conditional = true)]
	internal CGLContext(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGLRetainContext(handle);
		}
		this.handle = handle;
	}

	~CGLContext()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern void CGLRetainContext(IntPtr handle);

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern void CGLReleaseContext(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CGLReleaseContext(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern CGLErrorCode CGLLockContext(IntPtr ctx);

	public CGLErrorCode Lock()
	{
		return CGLLockContext(handle);
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern CGLErrorCode CGLUnlockContext(IntPtr ctx);

	public CGLErrorCode Unlock()
	{
		return CGLUnlockContext(handle);
	}

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern CGLErrorCode CGLSetCurrentContext(IntPtr ctx);

	[DllImport("/System/Library/Frameworks/OpenGL.framework/OpenGL")]
	private static extern IntPtr CGLGetCurrentContext();
}
