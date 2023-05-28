using System;
using System.Runtime.InteropServices;
using System.Threading;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public sealed class DispatchQueue : DispatchObject
{
	internal delegate void dispatch_callback_t(IntPtr context);

	internal delegate void dispatch_callback_iterations_t(IntPtr context, IntPtr count);

	public class Attributes
	{
		public bool Concurrent { get; set; }

		[Mac(10, 12)]
		[iOS(10, 0)]
		[TV(10, 0)]
		[Watch(3, 0)]
		public bool IsInitiallyInactive { get; set; }

		[Mac(10, 12)]
		[iOS(10, 0)]
		[TV(10, 0)]
		[Watch(3, 0)]
		public AutoreleaseFrequency? AutoreleaseFrequency { get; set; }

		[Mac(10, 10)]
		[iOS(8, 0)]
		public int RelativePriority { get; set; }

		[Mac(10, 10)]
		[iOS(8, 0)]
		public DispatchQualityOfService? QualityOfService { get; set; }

		internal IntPtr Create()
		{
			IntPtr intPtr = IntPtr.Zero;
			if (Concurrent)
			{
				intPtr = ConcurrentQueue;
			}
			if (IsInitiallyInactive)
			{
				intPtr = dispatch_queue_attr_make_initially_inactive(intPtr);
			}
			if (AutoreleaseFrequency.HasValue)
			{
				intPtr = dispatch_queue_attr_make_with_autorelease_frequency(intPtr, (nuint)(ulong)AutoreleaseFrequency.Value);
			}
			if (QualityOfService.HasValue)
			{
				intPtr = dispatch_queue_attr_make_with_qos_class(intPtr, QualityOfService.Value, RelativePriority);
			}
			return intPtr;
		}

		[DllImport("/usr/lib/libc.dylib")]
		[Mac(10, 12)]
		[iOS(10, 0)]
		[TV(10, 0)]
		[Watch(3, 0)]
		private static extern IntPtr dispatch_queue_attr_make_initially_inactive(IntPtr attr);

		[DllImport("/usr/lib/libc.dylib")]
		[Mac(10, 12)]
		[iOS(10, 0)]
		[TV(10, 0)]
		[Watch(3, 0)]
		private static extern IntPtr dispatch_queue_attr_make_with_autorelease_frequency(IntPtr attr, nuint frequency);

		[DllImport("/usr/lib/libc.dylib")]
		[Mac(10, 10)]
		[iOS(8, 0)]
		private static extern IntPtr dispatch_queue_attr_make_with_qos_class(IntPtr attr, DispatchQualityOfService qos_class, int relative_priority);
	}

	[Mac(10, 12)]
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	[Native]
	public enum AutoreleaseFrequency : ulong
	{
		Inherit,
		WorkItem,
		Never
	}

	private static IntPtr concurrent_queue;

	private static IntPtr main_q;

	internal static readonly dispatch_callback_t static_dispatch = static_dispatcher_to_managed;

	internal static readonly dispatch_callback_iterations_t static_dispatch_iterations = static_dispatcher_iterations_to_managed;

	internal static readonly dispatch_callback_t free_gchandle = static_free_gchandle;

	private static IntPtr ConcurrentQueue
	{
		get
		{
			if (concurrent_queue == IntPtr.Zero)
			{
				concurrent_queue = Dlfcn.dlsym(Dlfcn.RTLD.Self, "_dispatch_queue_attr_concurrent");
			}
			return concurrent_queue;
		}
	}

	public string Label => Marshal.PtrToStringAnsi(dispatch_queue_get_label(GetCheckedHandle()));

	[iOS(7, 0)]
	public static string CurrentQueueLabel => Marshal.PtrToStringAnsi(dispatch_queue_get_label(IntPtr.Zero));

	public IntPtr Context
	{
		get
		{
			return dispatch_get_context(GetCheckedHandle());
		}
		set
		{
			dispatch_set_context(GetCheckedHandle(), value);
		}
	}

	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public static DispatchQueue CurrentQueue => new DispatchQueue(dispatch_get_current_queue(), owns: false);

	public static DispatchQueue DefaultGlobalQueue => new DispatchQueue(dispatch_get_global_queue(0, (byte)0), owns: false);

	public static DispatchQueue MainQueue
	{
		get
		{
			if (main_q == IntPtr.Zero)
			{
				main_q = Dlfcn.GetIndirect(Libraries.libdispatch.Handle, "_dispatch_main_q");
			}
			return new DispatchQueue(main_q, owns: false);
		}
	}

	[Mac(10, 10)]
	[iOS(8, 0)]
	public unsafe DispatchQualityOfService QualityOfService => dispatch_queue_get_qos_class(base.Handle, null);

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
		: base(dispatch_queue_create(label, IntPtr.Zero), owns: true)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new Exception("Error creating dispatch queue");
		}
	}

	public DispatchQueue(string label, bool concurrent)
		: base(dispatch_queue_create(label, concurrent ? ConcurrentQueue : IntPtr.Zero), owns: true)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new Exception("Error creating dispatch queue");
		}
	}

	[Mac(10, 12)]
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	public DispatchQueue(string label, Attributes attributes, DispatchQueue target = null)
		: base(dispatch_queue_create_with_target(label, attributes?.Create() ?? IntPtr.Zero, target.GetHandle()), owns: true)
	{
	}

	public void Suspend()
	{
		DispatchObject.dispatch_suspend(GetCheckedHandle());
	}

	public void Resume()
	{
		DispatchObject.dispatch_resume(GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_get_context(IntPtr o);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_set_context(IntPtr o, IntPtr ctx);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_apply_f(IntPtr iterations, IntPtr queue, IntPtr ctx, dispatch_callback_iterations_t dispatch);

	public static DispatchQueue GetGlobalQueue(DispatchQueuePriority priority)
	{
		return new DispatchQueue(dispatch_get_global_queue((int)priority, (byte)0), owns: false);
	}

	public static DispatchQueue GetGlobalQueue(DispatchQualityOfService service)
	{
		return new DispatchQueue(dispatch_get_global_queue((int)service, (byte)0), owns: false);
	}

	[MonoPInvokeCallback(typeof(dispatch_callback_t))]
	private static void static_dispatcher_to_managed(IntPtr context)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(context);
		Tuple<Action, DispatchQueue> tuple = gCHandle.Target as Tuple<Action, DispatchQueue>;
		gCHandle.Free();
		if (tuple == null)
		{
			return;
		}
		SynchronizationContext current = SynchronizationContext.Current;
		if (current == null)
		{
			SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(tuple.Item2));
		}
		try
		{
			tuple.Item1();
		}
		finally
		{
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(null);
			}
		}
	}

	[MonoPInvokeCallback(typeof(dispatch_callback_iterations_t))]
	private static void static_dispatcher_iterations_to_managed(IntPtr context, IntPtr count)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(context);
		Tuple<Action<long>, DispatchQueue> tuple = gCHandle.Target as Tuple<Action<long>, DispatchQueue>;
		gCHandle.Free();
		if (tuple == null)
		{
			return;
		}
		SynchronizationContext current = SynchronizationContext.Current;
		if (current == null)
		{
			SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(tuple.Item2));
		}
		try
		{
			tuple.Item1((long)count);
		}
		finally
		{
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(null);
			}
		}
	}

	[MonoPInvokeCallback(typeof(dispatch_callback_t))]
	private static void static_free_gchandle(IntPtr context)
	{
		GCHandle.FromIntPtr(context).Free();
	}

	public void DispatchAsync(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_async_f(base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchAsync(DispatchBlock block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_async(GetCheckedHandle(), block.GetCheckedHandle());
	}

	public void DispatchSync(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_sync_f(base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchSync(DispatchBlock block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_sync(GetCheckedHandle(), block.GetCheckedHandle());
	}

	public void DispatchBarrierAsync(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_barrier_async_f(base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchBarrierAsync(DispatchBlock block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_barrier_async(GetCheckedHandle(), block.GetCheckedHandle());
	}

	public void DispatchBarrierSync(Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_barrier_sync_f(base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchBarrierSync(DispatchBlock block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_barrier_sync(GetCheckedHandle(), block.GetCheckedHandle());
	}

	public void DispatchAfter(DispatchTime when, Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_after_f(when.Nanoseconds, base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch);
	}

	public void DispatchAfter(DispatchTime when, DispatchBlock block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		dispatch_after(when.Nanoseconds, GetCheckedHandle(), block.GetCheckedHandle());
	}

	public void Submit(Action<int> action, long times)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		dispatch_apply_f((IntPtr)times, base.Handle, (IntPtr)GCHandle.Alloc(Tuple.Create(action, this)), static_dispatch_iterations);
	}

	public void SetSpecific(IntPtr key, object context)
	{
		dispatch_queue_set_specific(GetCheckedHandle(), key, (IntPtr)GCHandle.Alloc(context), free_gchandle);
	}

	public object GetSpecific(IntPtr key)
	{
		return ((GCHandle)dispatch_queue_get_specific(GetCheckedHandle(), key)).Target;
	}

	[Mac(10, 10)]
	[iOS(8, 0)]
	public unsafe DispatchQualityOfService GetQualityOfService(out int relative_priority)
	{
		fixed (int* relative_priority2 = &relative_priority)
		{
			return dispatch_queue_get_qos_class(base.Handle, relative_priority2);
		}
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_queue_create(string label, IntPtr attr);

	[DllImport("/usr/lib/libc.dylib")]
	[Mac(10, 12)]
	[iOS(10, 0)]
	[TV(10, 0)]
	[Watch(3, 0)]
	private static extern IntPtr dispatch_queue_create_with_target(string label, IntPtr attr, IntPtr target);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_async_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_async(IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_sync_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_sync(IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_barrier_async_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_barrier_async(IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_barrier_sync_f(IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_barrier_sync(IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_after_f(ulong time, IntPtr queue, IntPtr context, dispatch_callback_t dispatch);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_after(ulong time, IntPtr queue, IntPtr block);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_get_current_queue();

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_get_global_queue(nint identifier, nuint flags);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_queue_get_label(IntPtr queue);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_queue_set_specific(IntPtr queue, IntPtr key, IntPtr context, dispatch_callback_t destructor);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_queue_get_specific(IntPtr queue, IntPtr key);

	[DllImport("/usr/lib/libc.dylib")]
	[Mac(10, 10)]
	[iOS(8, 0)]
	private unsafe static extern DispatchQualityOfService dispatch_queue_get_qos_class(IntPtr queue, int* relative_priority);

	public override bool Equals(object other)
	{
		DispatchQueue dispatchQueue = other as DispatchQueue;
		if (dispatchQueue == null)
		{
			return false;
		}
		return dispatchQueue.Handle == base.Handle;
	}

	public static bool operator ==(DispatchQueue left, DispatchQueue right)
	{
		return left?.Equals(right) ?? ((object)right == null);
	}

	public static bool operator !=(DispatchQueue left, DispatchQueue right)
	{
		if ((object)left == null)
		{
			return (object)right != null;
		}
		return !left.Equals(right);
	}

	public override int GetHashCode()
	{
		return (int)base.Handle;
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_main();

	public static void MainIteration()
	{
		dispatch_main();
	}
}
