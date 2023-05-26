using System;
using System.Runtime.InteropServices;
using System.Threading;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class DispatchQueue : DispatchObject
{
	internal delegate void dispatch_callback_t(IntPtr context);

	private static IntPtr main_q;

	private static object lockobj = new object();

	internal static readonly dispatch_callback_t static_dispatch = static_dispatcher_to_managed;

	public string Label
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("DispatchQueue");
			}
			return Marshal.PtrToStringAnsi(dispatch_queue_get_label(handle));
		}
	}

	public IntPtr Context
	{
		get
		{
			Check();
			return dispatch_get_context(handle);
		}
		set
		{
			Check();
			dispatch_set_context(handle, value);
		}
	}

	[Obsolete("Deprecated in iOS 6.0")]
	public static DispatchQueue CurrentQueue => new DispatchQueue(dispatch_get_current_queue(), owns: false);

	public static DispatchQueue DefaultGlobalQueue => new DispatchQueue(dispatch_get_global_queue((IntPtr)0, IntPtr.Zero), owns: false);

	public static DispatchQueue MainQueue
	{
		get
		{
			lock (lockobj)
			{
				if (main_q == IntPtr.Zero)
				{
					main_q = Dlfcn.dlsym((IntPtr)(-2), "_dispatch_main_q");
					if (main_q == IntPtr.Zero)
					{
						IntPtr intPtr = Dlfcn.dlopen("/usr/lib/libSystem.dylib", 0);
						main_q = Dlfcn.GetIndirect(intPtr, "_dispatch_main_q");
						Dlfcn.dlclose(intPtr);
					}
				}
			}
			if (main_q == IntPtr.Zero)
			{
				return PInvokeDispatchGetMainQueue();
			}
			return new DispatchQueue(main_q, owns: false);
		}
	}

	[Preserve(Conditional = true)]
	internal DispatchQueue(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public DispatchQueue(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	public DispatchQueue(string label)
	{
		handle = dispatch_queue_create(label, IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Error creating dispatch queue");
		}
	}

	[DllImport("libc")]
	private static extern void dispatch_suspend(IntPtr o);

	public void Suspend()
	{
		Check();
		dispatch_suspend(handle);
	}

	[DllImport("libc")]
	private static extern void dispatch_resume(IntPtr o);

	public void Resume()
	{
		Check();
		dispatch_resume(handle);
	}

	[DllImport("libc")]
	private static extern IntPtr dispatch_get_context(IntPtr o);

	[DllImport("libc")]
	private static extern void dispatch_set_context(IntPtr o, IntPtr ctx);

	public static DispatchQueue GetGlobalQueue(DispatchQueuePriority priority)
	{
		return new DispatchQueue(dispatch_get_global_queue((IntPtr)(int)priority, IntPtr.Zero), owns: false);
	}

	private static DispatchQueue PInvokeDispatchGetMainQueue()
	{
		return new DispatchQueue(dispatch_get_main_queue(), owns: false);
	}

	[MonoPInvokeCallback(typeof(dispatch_callback_t))]
	private static void static_dispatcher_to_managed(IntPtr context)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(context);
		if (gCHandle.Target is Tuple<NSAction, DispatchQueue> tuple)
		{
			SynchronizationContext current = SynchronizationContext.Current;
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(tuple.Item2));
			}
			try
			{
				tuple.Item1();
			}
			catch
			{
				gCHandle.Free();
				throw;
			}
			finally
			{
				if (current == null)
				{
					SynchronizationContext.SetSynchronizationContext(null);
				}
			}
		}
		gCHandle.Free();
	}

	public void DispatchAsync(NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_async_f(handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchSync(NSAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_sync_f(handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	[DllImport("libc")]
	private static extern IntPtr dispatch_queue_create(string label, IntPtr attr);

	[DllImport("libc")]
	private static extern void dispatch_async_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("libc")]
	private static extern void dispatch_sync_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("libc")]
	private static extern IntPtr dispatch_get_current_queue();

	[DllImport("libc")]
	private static extern IntPtr dispatch_get_global_queue(IntPtr priority, IntPtr flags);

	[DllImport("libc")]
	private static extern IntPtr dispatch_get_main_queue();

	[DllImport("libc")]
	private static extern IntPtr dispatch_queue_get_label(IntPtr queue);

	[DllImport("libc")]
	private static extern IntPtr dispatch_main();

	public static void MainIteration()
	{
		dispatch_main();
	}
}
