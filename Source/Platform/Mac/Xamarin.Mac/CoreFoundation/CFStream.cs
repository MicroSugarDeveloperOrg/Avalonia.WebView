using System;
using System.Runtime.InteropServices;
using CoreServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public abstract class CFStream : CFType, INativeObject, IDisposable
{
	public class StreamEventArgs : EventArgs
	{
		public CFStreamEventType EventType { get; private set; }

		public StreamEventArgs(CFStreamEventType type)
		{
			EventType = type;
		}

		public override string ToString()
		{
			return $"[StreamEventArgs: EventType={EventType}]";
		}
	}

	protected delegate void CFStreamCallback(IntPtr s, CFStreamEventType type, IntPtr info);

	private IntPtr handle;

	private GCHandle gch;

	private CFRunLoop loop;

	private NSString loopMode;

	private bool open;

	private bool closed;

	public IntPtr Handle => handle;

	public event EventHandler<StreamEventArgs> OpenCompletedEvent;

	public event EventHandler<StreamEventArgs> HasBytesAvailableEvent;

	public event EventHandler<StreamEventArgs> CanAcceptBytesEvent;

	public event EventHandler<StreamEventArgs> ErrorEvent;

	public event EventHandler<StreamEventArgs> ClosedEvent;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFStreamCreatePairWithSocket(IntPtr allocator, CFSocketNativeHandle socket, out IntPtr read, out IntPtr write);

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern void CFStreamCreatePairWithSocketToHost(IntPtr allocator, IntPtr host, int port, out IntPtr read, out IntPtr write);

	public static void CreatePairWithSocketToHost(string host, int port, out CFReadStream readStream, out CFWriteStream writeStream)
	{
		using CFString cFString = new CFString(host);
		CFStreamCreatePairWithSocketToHost(IntPtr.Zero, cFString.Handle, port, out var read, out var write);
		readStream = new CFReadStream(read);
		writeStream = new CFWriteStream(write);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFReadStreamCreateForHTTPRequest(IntPtr alloc, IntPtr request);

	public static CFHTTPStream CreateForHTTPRequest(CFHTTPMessage request)
	{
		IntPtr intPtr = CFReadStreamCreateForHTTPRequest(IntPtr.Zero, request.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFHTTPStream(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern IntPtr CFReadStreamCreateForStreamedHTTPRequest(IntPtr alloc, IntPtr request, IntPtr body);

	public static CFHTTPStream CreateForStreamedHTTPRequest(CFHTTPMessage request, CFReadStream body)
	{
		IntPtr intPtr = CFReadStreamCreateForStreamedHTTPRequest(IntPtr.Zero, request.Handle, body.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CFHTTPStream(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	private static extern void CFStreamCreateBoundPair(IntPtr alloc, out IntPtr readStream, out IntPtr writeStream, CFIndex transferBufferSize);

	public static void CreateBoundPair(out CFReadStream readStream, out CFWriteStream writeStream, int bufferSize)
	{
		CFStreamCreateBoundPair(IntPtr.Zero, out var readStream2, out var writeStream2, bufferSize);
		readStream = new CFReadStream(readStream2);
		writeStream = new CFWriteStream(writeStream2);
	}

	public abstract CFException GetError();

	protected void CheckError()
	{
		CFException error = GetError();
		if (error != null)
		{
			throw error;
		}
	}

	public void Open()
	{
		if (open || closed)
		{
			throw new InvalidOperationException();
		}
		CheckHandle();
		if (!DoOpen())
		{
			CheckError();
			throw new InvalidOperationException();
		}
		open = true;
	}

	protected abstract bool DoOpen();

	public void Close()
	{
		if (!open)
		{
			return;
		}
		CheckHandle();
		if (loop != null)
		{
			DoSetClient(null, 0, IntPtr.Zero);
			UnscheduleFromRunLoop(loop, loopMode);
			loop = null;
			loopMode = null;
		}
		try
		{
			DoClose();
		}
		finally
		{
			open = false;
			closed = true;
		}
	}

	protected abstract void DoClose();

	public CFStreamStatus GetStatus()
	{
		CheckHandle();
		return DoGetStatus();
	}

	protected abstract CFStreamStatus DoGetStatus();

	internal IntPtr GetProperty(NSString name)
	{
		CheckHandle();
		return DoGetProperty(name);
	}

	protected abstract IntPtr DoGetProperty(NSString name);

	protected abstract bool DoSetProperty(NSString name, INativeObject value);

	internal void SetProperty(NSString name, INativeObject value)
	{
		CheckHandle();
		if (DoSetProperty(name, value))
		{
			return;
		}
		throw new InvalidOperationException($"Cannot set property '{name}' on {GetType().Name}.");
	}

	protected virtual void OnOpenCompleted(StreamEventArgs args)
	{
		if (this.OpenCompletedEvent != null)
		{
			this.OpenCompletedEvent(this, args);
		}
	}

	protected virtual void OnHasBytesAvailableEvent(StreamEventArgs args)
	{
		if (this.HasBytesAvailableEvent != null)
		{
			this.HasBytesAvailableEvent(this, args);
		}
	}

	protected virtual void OnCanAcceptBytesEvent(StreamEventArgs args)
	{
		if (this.CanAcceptBytesEvent != null)
		{
			this.CanAcceptBytesEvent(this, args);
		}
	}

	protected virtual void OnErrorEvent(StreamEventArgs args)
	{
		if (this.ErrorEvent != null)
		{
			this.ErrorEvent(this, args);
		}
	}

	protected virtual void OnClosedEvent(StreamEventArgs args)
	{
		if (this.ClosedEvent != null)
		{
			this.ClosedEvent(this, args);
		}
	}

	protected abstract void ScheduleWithRunLoop(CFRunLoop loop, NSString mode);

	protected abstract void UnscheduleFromRunLoop(CFRunLoop loop, NSString mode);

	[MonoPInvokeCallback(typeof(CFStreamCallback))]
	private static void OnCallback(IntPtr s, CFStreamEventType type, IntPtr info)
	{
		(GCHandle.FromIntPtr(info).Target as CFStream).OnCallback(type);
	}

	protected virtual void OnCallback(CFStreamEventType type)
	{
		StreamEventArgs args = new StreamEventArgs(type);
		switch (type)
		{
		case CFStreamEventType.OpenCompleted:
			OnOpenCompleted(args);
			break;
		case CFStreamEventType.CanAcceptBytes:
			OnCanAcceptBytesEvent(args);
			break;
		case CFStreamEventType.HasBytesAvailable:
			OnHasBytesAvailableEvent(args);
			break;
		case CFStreamEventType.ErrorOccurred:
			OnErrorEvent(args);
			break;
		case CFStreamEventType.EndEncountered:
			OnClosedEvent(args);
			break;
		}
	}

	public void EnableEvents(CFRunLoop runLoop, NSString runLoopMode)
	{
		if (open || closed || loop != null)
		{
			throw new InvalidOperationException();
		}
		CheckHandle();
		loop = runLoop;
		loopMode = runLoopMode;
		CFStreamClientContext structure = default(CFStreamClientContext);
		structure.Info = GCHandle.ToIntPtr(gch);
		CFStreamEventType cFStreamEventType = CFStreamEventType.OpenCompleted | CFStreamEventType.HasBytesAvailable | CFStreamEventType.CanAcceptBytes | CFStreamEventType.ErrorOccurred | CFStreamEventType.EndEncountered;
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CFStreamClientContext)));
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			if (!DoSetClient(OnCallback, (int)cFStreamEventType, intPtr))
			{
				throw new InvalidOperationException("Stream does not support async events.");
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		ScheduleWithRunLoop(runLoop, runLoopMode);
	}

	protected abstract bool DoSetClient(CFStreamCallback callback, CFIndex eventTypes, IntPtr context);

	protected CFStream(IntPtr handle)
	{
		this.handle = handle;
		gch = GCHandle.Alloc(this);
	}

	protected void CheckHandle()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
	}

	~CFStream()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			Close();
			if (gch.IsAllocated)
			{
				gch.Free();
			}
		}
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}
}
