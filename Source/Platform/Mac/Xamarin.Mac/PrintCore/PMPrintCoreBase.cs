using System;
using ObjCRuntime;

namespace PrintCore;

public class PMPrintCoreBase : IDisposable, INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	internal PMPrintCoreBase()
	{
	}

	internal PMPrintCoreBase(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	internal PMPrintCoreBase(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			NativeInvoke.PMRetain(handle);
		}
		this.handle = handle;
	}

	~PMPrintCoreBase()
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
			NativeInvoke.PMRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
