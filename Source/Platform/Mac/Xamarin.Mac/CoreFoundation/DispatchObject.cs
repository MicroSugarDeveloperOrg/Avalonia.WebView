using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public abstract class DispatchObject : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	[Preserve(Conditional = true)]
	internal DispatchObject(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		this.handle = handle;
		if (!owns)
		{
			dispatch_retain(handle);
		}
	}

	internal DispatchObject()
	{
	}

	[DllImport("libc")]
	private static extern IntPtr dispatch_release(IntPtr o);

	[DllImport("libc")]
	private static extern IntPtr dispatch_retain(IntPtr o);

	~DispatchObject()
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
			dispatch_release(handle);
			handle = IntPtr.Zero;
		}
	}

	public static bool operator ==(DispatchObject a, DispatchObject b)
	{
		if ((object)a == null)
		{
			if ((object)b == null)
			{
				return true;
			}
			return false;
		}
		if ((object)b == null)
		{
			return false;
		}
		return a.handle == b.handle;
	}

	public static bool operator !=(DispatchObject a, DispatchObject b)
	{
		if ((object)a == null)
		{
			if ((object)b == null)
			{
				return false;
			}
			return true;
		}
		if ((object)b == null)
		{
			return true;
		}
		return a.handle != b.handle;
	}

	public override bool Equals(object other)
	{
		if (other == null)
		{
			return false;
		}
		return (other as DispatchQueue).handle == handle;
	}

	public override int GetHashCode()
	{
		return (int)handle;
	}

	protected void Check()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException(GetType().ToString());
		}
	}

	[DllImport("libc")]
	private static extern void dispatch_set_target_queue(IntPtr queue, IntPtr target);

	public void SetTargetQueue(DispatchQueue queue)
	{
		IntPtr target = ((queue == null) ? IntPtr.Zero : queue.Handle);
		dispatch_set_target_queue(handle, target);
	}
}
