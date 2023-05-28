using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

public class DispatchGroup : DispatchObject
{
	private DispatchGroup(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public DispatchGroup()
		: base(dispatch_group_create(), owns: true)
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

	public void DispatchAsync(DispatchQueue queue, Action action)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_group_async_f(GetCheckedHandle(), queue.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, queue)), DispatchQueue.static_dispatch);
	}

	public void Notify(DispatchQueue queue, DispatchBlock block)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_group_notify(GetCheckedHandle(), queue.Handle, block.GetCheckedHandle());
	}

	public void Notify(DispatchQueue queue, Action action)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_group_notify_f(GetCheckedHandle(), queue.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, queue)), DispatchQueue.static_dispatch);
	}

	public void Enter()
	{
		dispatch_group_enter(GetCheckedHandle());
	}

	public void Leave()
	{
		dispatch_group_leave(GetCheckedHandle());
	}

	public bool Wait(DispatchTime timeout)
	{
		return dispatch_group_wait(GetCheckedHandle(), timeout.Nanoseconds) == 0;
	}

	public bool Wait(TimeSpan timeout)
	{
		return Wait(new DispatchTime(DispatchTime.Now, timeout));
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_group_create();

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_group_async_f(IntPtr group, IntPtr queue, IntPtr context, DispatchQueue.dispatch_callback_t block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_group_notify_f(IntPtr group, IntPtr queue, IntPtr context, DispatchQueue.dispatch_callback_t block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_group_notify(IntPtr group, IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_group_enter(IntPtr group);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_group_leave(IntPtr group);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern nint dispatch_group_wait(IntPtr group, ulong timeout);
}
