using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Darwin;

public class KernelQueue : IDisposable, INativeObject
{
	private int handle;

	public IntPtr Handle => (IntPtr)handle;

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int kqueue();

	public KernelQueue()
	{
		handle = kqueue();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	~KernelQueue()
	{
		Dispose(disposing: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != -1)
		{
			DispatchSource.VnodeMonitor.close(handle);
			handle = -1;
		}
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private unsafe static extern int kevent(int kq, KernelEvent* changeList, int nChanges, KernelEvent* eventList, int nEvents, IntPtr timeout);

	[DllImport("/usr/lib/libSystem.dylib")]
	private unsafe static extern int kevent(int kq, KernelEvent* changeList, int nChanges, KernelEvent* eventList, int nEvents, ref TimeSpec timeout);

	public int KEvent(KernelEvent[] changeList, KernelEvent[] eventList, TimeSpan? timeout = null)
	{
		if (changeList == null)
		{
			throw new ArgumentNullException("changeList");
		}
		if (eventList == null)
		{
			throw new ArgumentNullException("eventList");
		}
		if (changeList.Length < 1)
		{
			throw new ArgumentOutOfRangeException("eventList must contain at least one element", "eventList");
		}
		if (eventList.Length < 1)
		{
			throw new ArgumentOutOfRangeException("changeList must contain at least one element", "changeList");
		}
		return KEvent(changeList, changeList.Length, eventList, eventList.Length, ToTimespec(timeout));
	}

	public unsafe int KEvent(KernelEvent[] changeList, int nChanges, KernelEvent[] eventList, int nEvents, TimeSpec? timeout = null)
	{
		if (changeList == null)
		{
			throw new ArgumentNullException("changeList");
		}
		if (eventList == null)
		{
			throw new ArgumentNullException("eventList");
		}
		if (changeList.Length < 1)
		{
			throw new ArgumentOutOfRangeException("eventList must contain at least one element", "eventList");
		}
		if (eventList.Length < 1)
		{
			throw new ArgumentOutOfRangeException("changeList must contain at least one element", "changeList");
		}
		if (changeList.Length < nChanges)
		{
			throw new ArgumentOutOfRangeException("nChanges is larger than the number of elements in changeList", "nChanges");
		}
		if (eventList.Length < nEvents)
		{
			throw new ArgumentOutOfRangeException("nEvents is larger than the number of elements in eventList", "nEvents");
		}
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				if (!timeout.HasValue)
				{
					return kevent(handle, changeList2, nChanges, eventList2, nEvents, IntPtr.Zero);
				}
				TimeSpec timeout2 = timeout.Value;
				return kevent(handle, changeList2, nChanges, eventList2, nEvents, ref timeout2);
			}
		}
	}

	private static TimeSpec? ToTimespec(TimeSpan? ts)
	{
		if (!ts.HasValue)
		{
			return null;
		}
		TimeSpec value = default(TimeSpec);
		value.Seconds = (nint)ts.Value.TotalSeconds;
		value.NanoSeconds = (nint)((long)ts.Value.Milliseconds * 1000000L);
		return value;
	}

	[Obsolete("Use any of the overloads that return an int to get how many events were returned from kevent.")]
	public unsafe bool KEvent(KernelEvent[] changeList, int nChanges, KernelEvent[] eventList, int nEvents, ref TimeSpec timeOut)
	{
		if (changeList != null && changeList.Length < nChanges)
		{
			throw new ArgumentException("nChanges is larger than the number of elements in changeList");
		}
		if (eventList != null && eventList.Length < nEvents)
		{
			throw new ArgumentException("nChanges is larger than the number of elements in changeList");
		}
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, nChanges, eventList2, nEvents, ref timeOut) != -1;
			}
		}
	}

	[Obsolete("Use any of the overloads that return an int to get how many events were returned from kevent.")]
	public unsafe bool KEvent(KernelEvent[] changeList, int nChanges, KernelEvent[] eventList, int nEvents)
	{
		if (changeList != null && changeList.Length < nChanges)
		{
			throw new ArgumentException("nChanges is larger than the number of elements in changeList");
		}
		if (eventList != null && eventList.Length < nEvents)
		{
			throw new ArgumentException("nChanges is larger than the number of elements in changeList");
		}
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, nChanges, eventList2, nEvents, IntPtr.Zero) != -1;
			}
		}
	}

	[Obsolete("Use any of the overloads that return an int to get how many events were returned from kevent.")]
	public unsafe bool KEvent(KernelEvent[] changeList, KernelEvent[] eventList, ref TimeSpec timeOut)
	{
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, (changeList != null) ? changeList.Length : 0, eventList2, (eventList != null) ? eventList.Length : 0, ref timeOut) != -1;
			}
		}
	}

	[Obsolete("Use any of the overloads that return an int to get how many events were returned from kevent.")]
	public unsafe bool KEvent(KernelEvent[] changeList, KernelEvent[] eventList)
	{
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, (changeList != null) ? changeList.Length : 0, eventList2, (eventList != null) ? eventList.Length : 0, IntPtr.Zero) != -1;
			}
		}
	}
}
