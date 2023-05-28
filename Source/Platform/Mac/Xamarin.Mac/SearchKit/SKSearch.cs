using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace SearchKit;

public class SKSearch : IDisposable, INativeObject
{
	private IntPtr handle;

	public IntPtr Handle => handle;

	internal SKSearch(IntPtr h)
	{
		handle = h;
	}

	~SKSearch()
	{
		Dispose(disposing: false);
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern bool SKSearchFindMatches(IntPtr handle, nint maxCount, IntPtr ids, IntPtr scores, double time, out nint foundCount);

	public unsafe bool FindMatches(nint maxCount, ref nint[] ids, double waitTime, out nint foundCount)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (ids.Length == 0)
		{
			throw new ArgumentException("ids should have at least one element");
		}
		if (ids.Length != maxCount)
		{
			throw new ArgumentException("ids should have as many elements as maxCount");
		}
		fixed (nint* ptr = &ids[0])
		{
			return SKSearchFindMatches(handle, maxCount, (IntPtr)ptr, IntPtr.Zero, waitTime, out foundCount);
		}
	}

	public unsafe bool FindMatches(nint maxCount, ref nint[] ids, ref float[] scores, double waitTime, out nint foundCount)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (ids.Length == 0)
		{
			throw new ArgumentException("ids should have at least one element");
		}
		if (ids.Length != maxCount)
		{
			throw new ArgumentException("ids should have as many elements as maxCount");
		}
		if (scores != null)
		{
			if (scores.Length == 0)
			{
				throw new ArgumentException("scores should have at least one element");
			}
			if (scores.Length != maxCount)
			{
				throw new ArgumentException("scores should have as many elements as maxCount");
			}
		}
		fixed (nint* ptr = &ids[0])
		{
			if (scores == null)
			{
				return SKSearchFindMatches(handle, maxCount, (IntPtr)ptr, IntPtr.Zero, waitTime, out foundCount);
			}
			fixed (float* ptr2 = &scores[0])
			{
				return SKSearchFindMatches(handle, maxCount, (IntPtr)ptr, (IntPtr)ptr2, waitTime, out foundCount);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/SearchKit.framework/SearchKit")]
	private static extern void SKSearchCancel(IntPtr h);

	public void Cancel()
	{
		SKSearchCancel(handle);
	}
}
