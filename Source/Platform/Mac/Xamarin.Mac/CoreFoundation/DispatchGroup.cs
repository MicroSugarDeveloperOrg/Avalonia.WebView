using System;
using System.Runtime.InteropServices;
using Foundation;

namespace CoreFoundation;

public class DispatchGroup : DispatchObject
{
	private DispatchGroup(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public static DispatchGroup Create()
	{
		IntPtr intPtr = dispatch_group_create();
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new DispatchGroup(intPtr, owns: true);
	}

	public void DispatchAsync(DispatchQueue queue, NSAction action)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Check();
		dispatch_group_async_f(handle, queue.handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, queue)), DispatchQueue.static_dispatch);
	}

	public void Enter()
	{
		Check();
		dispatch_group_enter(handle);
	}

	public void Leave()
	{
		Check();
		dispatch_group_leave(handle);
	}

	public bool Wait(DispatchTime timeout)
	{
		Check();
		return dispatch_group_wait(handle, timeout.Nanoseconds) == IntPtr.Zero;
	}

	[DllImport("libc")]
	private static extern IntPtr dispatch_group_create();

	[DllImport("libc")]
	private static extern void dispatch_group_async_f(IntPtr group, IntPtr queue, IntPtr context, DispatchQueue.dispatch_callback_t block);

	[DllImport("libc")]
	private static extern void dispatch_group_enter(IntPtr group);

	[DllImport("libc")]
	private static extern void dispatch_group_leave(IntPtr group);

	[DllImport("libc")]
	private static extern IntPtr dispatch_group_wait(IntPtr group, ulong timeout);
}
