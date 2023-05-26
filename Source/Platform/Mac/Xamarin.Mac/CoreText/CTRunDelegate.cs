using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTRunDelegate : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CTRunDelegateOperations Operations => CTRunDelegateOperations.GetOperations(CTRunDelegateGetRefCon(handle));

	internal CTRunDelegate(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTRunDelegate()
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

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTRunDelegateCreate(CTRunDelegateCallbacks callbacks, IntPtr refCon);

	public CTRunDelegate(CTRunDelegateOperations operations)
	{
		if (operations == null)
		{
			throw ConstructorError.ArgumentNull(this, "operations");
		}
		handle = CTRunDelegateCreate(operations.GetCallbacks(), GCHandle.ToIntPtr(operations.handle));
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTRunDelegateGetRefCon(IntPtr runDelegate);
}
