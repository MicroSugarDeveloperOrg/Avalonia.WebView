using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreServices;

public class FSEventStream : INativeObject, IDisposable
{
	private delegate void FSEventStreamCallback(IntPtr handle, IntPtr userData, nint numEvents, IntPtr eventPaths, IntPtr eventFlags, IntPtr eventIds);

	private IntPtr handle;

	private FSEventStreamCallback eventsCallback;

	public IntPtr Handle => handle;

	public string Description
	{
		get
		{
			if (handle == IntPtr.Zero)
			{
				return null;
			}
			IntPtr intPtr = FSEventStreamCopyDescription(handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			using CFString cFString = new CFString(intPtr, owns: true);
			return cFString.ToString();
		}
	}

	public string[] PathsBeingWatched
	{
		get
		{
			CheckDisposed();
			CFArray cFArray = new CFArray(FSEventStreamCopyPathsBeingWatched(handle), owns: true);
			string[] array = new string[(long)cFArray.Count];
			for (int i = 0; i < array.Length; i++)
			{
				using CFString cFString = new CFString(cFArray.GetValue(i), owns: true);
				array[i] = cFString.ToString();
			}
			return array;
		}
	}

	public ulong LatestEventId
	{
		get
		{
			CheckDisposed();
			return FSEventStreamGetLatestEventId(handle);
		}
	}

	public event FSEventStreamEventsHandler Events;

	~FSEventStream()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamRelease(IntPtr handle);

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			FSEventStreamRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	private void CheckDisposed()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("this");
		}
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr FSEventStreamCreate(IntPtr allocator, FSEventStreamCallback callback, IntPtr context, IntPtr pathsToWatch, ulong sinceWhen, double latency, FSEventStreamCreateFlags flags);

	public FSEventStream(CFAllocator allocator, NSArray pathsToWatch, ulong sinceWhenId, TimeSpan latency, FSEventStreamCreateFlags flags)
	{
		if (pathsToWatch == null)
		{
			throw new ArgumentNullException("pathsToWatch");
		}
		eventsCallback = EventsCallback;
		handle = FSEventStreamCreate(allocator?.Handle ?? IntPtr.Zero, eventsCallback, IntPtr.Zero, pathsToWatch.Handle, sinceWhenId, latency.TotalSeconds, flags | (FSEventStreamCreateFlags)1u);
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Unable to create FSEventStream");
		}
	}

	public FSEventStream(string[] pathsToWatch, TimeSpan latency, FSEventStreamCreateFlags flags)
		: this(null, NSArray.FromStrings(pathsToWatch), ulong.MaxValue, latency, flags)
	{
	}

	private void EventsCallback(IntPtr handle, IntPtr userData, nint numEvents, IntPtr eventPaths, IntPtr eventFlags, IntPtr eventIds)
	{
		if (numEvents == 0)
		{
			return;
		}
		FSEvent[] array = new FSEvent[(long)numEvents];
		CFArray cFArray = new CFArray(eventPaths);
		for (int i = 0; i < array.Length; i++)
		{
			array[i].Flags = (FSEventStreamEventFlags)Marshal.ReadInt32(eventFlags, i * 4);
			array[i].Id = (uint)Marshal.ReadInt64(eventIds, i * 8);
			using CFString cFString = new CFString(cFArray.GetValue(i));
			array[i].Path = cFString.ToString();
		}
		OnEvents(array);
	}

	protected virtual void OnEvents(FSEvent[] events)
	{
		this.Events?.Invoke(this, new FSEventStreamEventsArgs(events));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr FSEventStreamCopyDescription(IntPtr handle);

	public override string ToString()
	{
		return Description;
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamShow(IntPtr handle);

	public void Show()
	{
		CheckDisposed();
		FSEventStreamShow(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern bool FSEventStreamStart(IntPtr handle);

	public bool Start()
	{
		CheckDisposed();
		return FSEventStreamStart(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamStop(IntPtr handle);

	public void Stop()
	{
		CheckDisposed();
		FSEventStreamStop(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamScheduleWithRunLoop(IntPtr handle, IntPtr runLoop, IntPtr runLoopMode);

	public void ScheduleWithRunLoop(CFRunLoop runLoop, NSString runLoopMode)
	{
		CheckDisposed();
		FSEventStreamScheduleWithRunLoop(handle, runLoop.Handle, runLoopMode.Handle);
	}

	public void ScheduleWithRunLoop(CFRunLoop runLoop)
	{
		ScheduleWithRunLoop(runLoop, CFRunLoop.ModeDefault);
	}

	public void ScheduleWithRunLoop(NSRunLoop runLoop, NSString runLoopMode)
	{
		ScheduleWithRunLoop(runLoop.GetCFRunLoop(), runLoopMode);
	}

	public void ScheduleWithRunLoop(NSRunLoop runLoop)
	{
		ScheduleWithRunLoop(runLoop.GetCFRunLoop(), CFRunLoop.ModeDefault);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr FSEventStreamCopyPathsBeingWatched(IntPtr handle);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern uint FSEventStreamFlushAsync(IntPtr handle);

	public uint FlushAsync()
	{
		CheckDisposed();
		return FSEventStreamFlushAsync(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamFlushSync(IntPtr handle);

	public void FlushSync()
	{
		CheckDisposed();
		FSEventStreamFlushSync(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern void FSEventStreamInvalidate(IntPtr handle);

	public void Invalidate()
	{
		CheckDisposed();
		FSEventStreamInvalidate(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern ulong FSEventStreamGetLatestEventId(IntPtr handle);
}
