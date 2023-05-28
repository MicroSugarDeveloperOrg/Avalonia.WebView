using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public abstract class DispatchObject : NativeObject
{
	[Preserve(Conditional = true)]
	internal DispatchObject(IntPtr handle, bool owns)
		: base(handle, owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
	}

	internal DispatchObject()
	{
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_release(IntPtr o);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_retain(IntPtr o);

	protected override void Retain()
	{
		dispatch_retain(base.Handle);
	}

	protected override void Release()
	{
		dispatch_release(base.Handle);
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
		return a.Handle == b.Handle;
	}

	public static bool operator !=(DispatchObject a, DispatchObject b)
	{
		return !(a == b);
	}

	public override bool Equals(object other)
	{
		DispatchQueue dispatchQueue = other as DispatchQueue;
		if (dispatchQueue == null)
		{
			return false;
		}
		return dispatchQueue.Handle == base.Handle;
	}

	public override int GetHashCode()
	{
		return (int)base.Handle;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use 'GetCheckedHandle' instead.")]
	protected void Check()
	{
		GetCheckedHandle();
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_set_target_queue(IntPtr queue, IntPtr target);

	public void SetTargetQueue(DispatchQueue queue)
	{
		IntPtr target = ((queue == null) ? IntPtr.Zero : queue.Handle);
		dispatch_set_target_queue(base.Handle, target);
	}

	[DllImport("/usr/lib/libc.dylib")]
	internal static extern void dispatch_resume(IntPtr o);

	[DllImport("/usr/lib/libc.dylib")]
	internal static extern void dispatch_suspend(IntPtr o);

	[Mac(10, 12)]
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	public void Activate()
	{
		dispatch_activate(GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	[Mac(10, 12)]
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	private static extern void dispatch_activate(IntPtr @object);
}
