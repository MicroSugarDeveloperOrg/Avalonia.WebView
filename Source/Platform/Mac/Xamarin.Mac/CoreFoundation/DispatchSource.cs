using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class DispatchSource : DispatchObject
{
	public class Data : DispatchSource
	{
		public IntPtr PendingData => dispatch_source_get_data(base.Handle);

		internal Data()
		{
		}

		internal Data(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public void MergeData(IntPtr value)
		{
			dispatch_source_merge_data(base.Handle, value);
		}
	}

	public class DataAdd : Data
	{
		private static IntPtr type_data_add;

		public DataAdd(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public DataAdd(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public DataAdd(DispatchQueue queue = null)
		{
			if (type_data_add == IntPtr.Zero)
			{
				type_data_add = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_data_add");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_data_add, IntPtr.Zero, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class DataOr : Data
	{
		private static IntPtr type_data_or;

		public DataOr(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public DataOr(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public DataOr(DispatchQueue queue = null)
		{
			if (type_data_or == IntPtr.Zero)
			{
				type_data_or = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_data_or");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_data_or, IntPtr.Zero, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class Mach : DispatchSource
	{
		public int MachPort => (int)dispatch_source_get_handle(GetCheckedHandle());

		internal Mach(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		internal Mach(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		internal Mach()
		{
		}
	}

	public class MachSend : Mach
	{
		private static IntPtr type_mach_send;

		public bool SendRightsDestroyed => dispatch_source_get_data(GetCheckedHandle()) != IntPtr.Zero;

		public MachSend(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public MachSend(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public MachSend(int machPort, bool sendDead = false, DispatchQueue queue = null)
		{
			if (type_mach_send == IntPtr.Zero)
			{
				type_mach_send = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_mach_send");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_mach_send, (IntPtr)machPort, (IntPtr)(sendDead ? 1 : 0), (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class MachReceive : DispatchSource
	{
		private static IntPtr type_mach_recv;

		public MachReceive(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public MachReceive(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public MachReceive(int machPort, DispatchQueue queue = null)
		{
			if (type_mach_recv == IntPtr.Zero)
			{
				type_mach_recv = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_mach_recv");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_mach_recv, (IntPtr)machPort, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class MemoryPressure : DispatchSource
	{
		private static IntPtr type_memorypressure;

		public MemoryPressureFlags PressureFlags => (MemoryPressureFlags)(int)dispatch_source_get_data(GetCheckedHandle());

		public MemoryPressure(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public MemoryPressure(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public MemoryPressure(MemoryPressureFlags monitorFlags = MemoryPressureFlags.Normal | MemoryPressureFlags.Warn, DispatchQueue queue = null)
		{
			if (type_memorypressure == IntPtr.Zero)
			{
				type_memorypressure = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_memorypressure");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_memorypressure, IntPtr.Zero, (IntPtr)(int)monitorFlags, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class ProcessMonitor : DispatchSource
	{
		private static IntPtr type_proc;

		public int ProcessId => (int)dispatch_source_get_handle(GetCheckedHandle());

		public ProcessMonitorFlags MonitorFlags => (ProcessMonitorFlags)(int)dispatch_source_get_data(GetCheckedHandle());

		public ProcessMonitor(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public ProcessMonitor(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public ProcessMonitor(int processId, ProcessMonitorFlags monitorKind = ProcessMonitorFlags.Exit, DispatchQueue queue = null)
		{
			if (type_proc == IntPtr.Zero)
			{
				type_proc = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_proc");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_proc, (IntPtr)processId, (IntPtr)(long)monitorKind, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class ReadMonitor : DispatchSource
	{
		private static IntPtr type_read;

		public int FileDescriptor => (int)dispatch_source_get_handle(GetCheckedHandle());

		public int BytesAvailable => (int)dispatch_source_get_data(GetCheckedHandle());

		public ReadMonitor(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public ReadMonitor(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public ReadMonitor(int fileDescriptor, DispatchQueue queue = null)
		{
			if (type_read == IntPtr.Zero)
			{
				type_read = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_read");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_read, (IntPtr)fileDescriptor, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class SignalMonitor : DispatchSource
	{
		private static IntPtr type_signal;

		public int SignalNumber => (int)dispatch_source_get_handle(GetCheckedHandle());

		public int SignalsDelivered => (int)dispatch_source_get_data(GetCheckedHandle());

		public SignalMonitor(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public SignalMonitor(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public SignalMonitor(int signalNumber, DispatchQueue queue = null)
		{
			if (type_signal == IntPtr.Zero)
			{
				type_signal = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_signal");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_signal, (IntPtr)signalNumber, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	public class Timer : DispatchSource
	{
		private static IntPtr type_timer;

		public int TimerFiredCount => (int)dispatch_source_get_data(GetCheckedHandle());

		public Timer(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public Timer(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public Timer(DispatchQueue queue = null)
			: this(strict: false, queue)
		{
		}

		public Timer(bool strict = false, DispatchQueue queue = null)
		{
			if (type_timer == IntPtr.Zero)
			{
				type_timer = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_timer");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_timer, IntPtr.Zero, strict ? ((IntPtr)1) : IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}

		[DllImport("/usr/lib/libc.dylib")]
		private static extern void dispatch_source_set_timer(IntPtr source, ulong start, long interval, long leeway);

		public void SetTimer(DispatchTime time, long nanosecondInterval, long nanosecondLeeway)
		{
			dispatch_source_set_timer(GetCheckedHandle(), time.Nanoseconds, nanosecondInterval, nanosecondLeeway);
		}
	}

	public class VnodeMonitor : DispatchSource
	{
		private static IntPtr type_vnode;

		private int fd;

		private const int O_EVTONLY = 32768;

		public int FileDescriptor => (int)dispatch_source_get_handle(GetCheckedHandle());

		public VnodeMonitorKind ObservedEvents => (VnodeMonitorKind)(int)dispatch_source_get_data(GetCheckedHandle());

		public VnodeMonitor(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public VnodeMonitor(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public VnodeMonitor(int fileDescriptor, VnodeMonitorKind vnodeKind, DispatchQueue queue = null)
		{
			if (type_vnode == IntPtr.Zero)
			{
				type_vnode = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_vnode");
			}
			base.queue = queue;
			fd = -1;
			IntPtr intPtr = dispatch_source_create(type_vnode, (IntPtr)fileDescriptor, (IntPtr)(long)vnodeKind, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}

		[DllImport("/usr/lib/libc.dylib", SetLastError = true)]
		private static extern int open(string path, int flags);

		[DllImport("/usr/lib/libc.dylib")]
		internal static extern int close(int fd);

		public VnodeMonitor(string path, VnodeMonitorKind vnodeKind, DispatchQueue queue = null)
		{
			if (path == null)
			{
				throw new ArgumentNullException("path");
			}
			fd = open(path, 32768);
			if (fd == -1)
			{
				throw new IOException("Failure to open the file", Marshal.GetLastWin32Error());
			}
			if (type_vnode == IntPtr.Zero)
			{
				type_vnode = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_vnode");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_vnode, (IntPtr)fd, (IntPtr)(long)vnodeKind, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (fd != -1)
			{
				close(fd);
				fd = -1;
			}
			base.Dispose(disposing);
		}
	}

	public class WriteMonitor : DispatchSource
	{
		private static IntPtr type_write;

		public int FileDescriptor => (int)dispatch_source_get_handle(GetCheckedHandle());

		public int BufferSpaceAvailable => (int)dispatch_source_get_data(GetCheckedHandle());

		public WriteMonitor(IntPtr handle, bool owns)
			: base(handle, owns)
		{
		}

		public WriteMonitor(IntPtr handle)
			: base(handle, owns: false)
		{
		}

		public WriteMonitor(int fileDescriptor, DispatchQueue queue = null)
		{
			if (type_write == IntPtr.Zero)
			{
				type_write = Dlfcn.dlsym(Libraries.System.Handle, "_dispatch_source_type_write");
			}
			base.queue = queue;
			IntPtr intPtr = dispatch_source_create(type_write, (IntPtr)fileDescriptor, IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle);
			if (intPtr != IntPtr.Zero)
			{
				InitializeHandle(intPtr);
			}
		}
	}

	private DispatchQueue queue;

	public bool IsCanceled => dispatch_source_testcancel(GetCheckedHandle()) != IntPtr.Zero;

	[Preserve(Conditional = true)]
	internal DispatchSource(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	internal DispatchSource(IntPtr handle)
		: base(handle, owns: false)
	{
	}

	internal DispatchSource()
	{
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_create(IntPtr type, IntPtr handle, IntPtr mask, IntPtr queue);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_get_handle(IntPtr source);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_get_mask(IntPtr source);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_get_data(IntPtr source);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_merge_data(IntPtr source, IntPtr data);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_set_event_handler(IntPtr source, IntPtr handler);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_set_registration_handler(IntPtr source, IntPtr handler);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_set_cancel_handler(IntPtr source, IntPtr handler);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_set_event_handler_f(IntPtr source, IntPtr handler);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_cancel(IntPtr source);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_source_testcancel(IntPtr source);

	public void SetEventHandler(Action handler)
	{
		if (handler == null)
		{
			dispatch_source_set_event_handler_f(GetCheckedHandle(), IntPtr.Zero);
			return;
		}
		DispatchBlock.Invoke(delegate
		{
			SynchronizationContext current = SynchronizationContext.Current;
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(queue));
			}
			try
			{
				handler();
			}
			finally
			{
				if (current == null)
				{
					SynchronizationContext.SetSynchronizationContext(null);
				}
			}
		}, delegate(IntPtr block)
		{
			dispatch_source_set_event_handler(GetCheckedHandle(), block);
		});
	}

	public void Suspend()
	{
		DispatchObject.dispatch_suspend(GetCheckedHandle());
	}

	public void Resume()
	{
		DispatchObject.dispatch_resume(GetCheckedHandle());
	}

	public void SetRegistrationHandler(Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		DispatchBlock.Invoke(delegate
		{
			SynchronizationContext current = SynchronizationContext.Current;
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(queue));
			}
			try
			{
				handler();
			}
			finally
			{
				if (current == null)
				{
					SynchronizationContext.SetSynchronizationContext(null);
				}
			}
		}, delegate(IntPtr block)
		{
			dispatch_source_set_registration_handler(GetCheckedHandle(), block);
		});
	}

	public void SetCancelHandler(Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		DispatchBlock.Invoke(delegate
		{
			SynchronizationContext current = SynchronizationContext.Current;
			if (current == null)
			{
				SynchronizationContext.SetSynchronizationContext(new DispatchQueueSynchronizationContext(queue));
			}
			try
			{
				handler();
			}
			finally
			{
				if (current == null)
				{
					SynchronizationContext.SetSynchronizationContext(null);
				}
			}
		}, delegate(IntPtr block)
		{
			dispatch_source_set_cancel_handler(GetCheckedHandle(), block);
		});
	}

	public void Cancel()
	{
		dispatch_source_cancel(GetCheckedHandle());
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}
}
