using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Darwin;

public class KernelQueue : IDisposable, INativeObject
{
	private int handle;

	public IntPtr Handle => (IntPtr)handle;

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int kqueue();

	[DllImport("/usr/lib/libSystem.dylib")]
	private static extern int close(int fd);

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
			close(handle);
			handle = -1;
		}
	}

	[DllImport("/usr/lib/libSystem.dylib")]
	private unsafe static extern int kevent(int kq, KernelEvent* changeList, int nChanges, KernelEvent* eventList, int nEvents, IntPtr timeout);

	[DllImport("/usr/lib/libSystem.dylib")]
	private unsafe static extern int kevent(int kq, KernelEvent* changeList, int nChanges, KernelEvent* eventList, int nEvents, ref TimeSpec timeout);

	public unsafe int KEvent(KernelEvent[] changeList, int nChanges, KernelEvent[] eventList, int nEvents, ref TimeSpec timeOut)
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
				return kevent(handle, changeList2, nChanges, eventList2, nEvents, ref timeOut);
			}
		}
	}

	public unsafe int KEvent(KernelEvent[] changeList, int nChanges, KernelEvent[] eventList, int nEvents)
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
				return kevent(handle, changeList2, nChanges, eventList2, nEvents, IntPtr.Zero);
			}
		}
	}

	public unsafe int KEvent(KernelEvent[] changeList, KernelEvent[] eventList, ref TimeSpec timeOut)
	{
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, (changeList != null) ? changeList.Length : 0, eventList2, (eventList != null) ? eventList.Length : 0, ref timeOut);
			}
		}
	}

	public unsafe int KEvent(KernelEvent[] changeList, KernelEvent[] eventList)
	{
		fixed (KernelEvent* changeList2 = &changeList[0])
		{
			fixed (KernelEvent* eventList2 = &eventList[0])
			{
				return kevent(handle, changeList2, (changeList != null) ? changeList.Length : 0, eventList2, (eventList != null) ? eventList.Length : 0, IntPtr.Zero);
			}
		}
	}
}
