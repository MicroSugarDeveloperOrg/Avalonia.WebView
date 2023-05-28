using System;
using ObjCRuntime;

namespace CoreFoundation;

public abstract class NativeObject : INativeObject, IDisposable
{
	private IntPtr handle;

	public IntPtr Handle
	{
		get
		{
			return handle;
		}
		protected set
		{
			InitializeHandle(value);
		}
	}

	protected NativeObject()
	{
	}

	protected NativeObject(IntPtr handle, bool owns)
	{
		Handle = handle;
		if (!owns)
		{
			Retain();
		}
	}

	~NativeObject()
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
		if (Handle != IntPtr.Zero)
		{
			Release();
			handle = IntPtr.Zero;
		}
	}

	protected virtual void Retain()
	{
		CFObject.CFRetain(Handle);
	}

	protected virtual void Release()
	{
		CFObject.CFRelease(Handle);
	}

	protected virtual void InitializeHandle(IntPtr handle)
	{
		if (handle == IntPtr.Zero && Class.ThrowOnInitFailure)
		{
			throw new Exception("Could not initialize an instance of the type '" + GetType().FullName + "': handle is null.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
		}
		this.handle = handle;
	}

	private void Throw()
	{
		throw new ObjectDisposedException(GetType().ToString());
	}

	internal IntPtr GetCheckedHandle()
	{
		if (handle == IntPtr.Zero)
		{
			Throw();
		}
		return handle;
	}
}
