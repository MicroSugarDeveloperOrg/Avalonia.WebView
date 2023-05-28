using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using CoreServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

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

	protected delegate void CFStreamCallback(IntPtr s, nint type, IntPtr info);

	private IntPtr handle;

	private GCHandle gch;

	private CFRunLoop loop;

	private NSString loopMode;

	private bool open;

	private bool closed;

	public IntPtr Handle => handle;

	[iOS(7, 0)]
	[Mac(10, 9)]
	public DispatchQueue ReadDispatchQueue
	{
		get
		{
			return new DispatchQueue(CFReadStreamCopyDispatchQueue(handle));
		}
		set
		{
			CFReadStreamSetDispatchQueue(handle, (value == null) ? IntPtr.Zero : value.Handle);
		}
	}

	[iOS(7, 0)]
	[Mac(10, 9)]
	public DispatchQueue WriteDispatchQueue
	{
		get
		{
			return new DispatchQueue(CFWriteStreamCopyDispatchQueue(handle));
		}
		set
		{
			CFWriteStreamSetDispatchQueue(handle, (value == null) ? IntPtr.Zero : value.Handle);
		}
	}

	public event EventHandler<StreamEventArgs> OpenCompletedEvent;

	public event EventHandler<StreamEventArgs> HasBytesAvailableEvent;

	public event EventHandler<StreamEventArgs> CanAcceptBytesEvent;

	public event EventHandler<StreamEventArgs> ErrorEvent;

	public event EventHandler<StreamEventArgs> ClosedEvent;

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	internal static extern void CFStreamCreatePairWithSocket(IntPtr allocator, CFSocketNativeHandle sock, out IntPtr readStream, out IntPtr writeStream);

	public static void CreatePairWithSocket(CFSocket socket, out CFReadStream readStream, out CFWriteStream writeStream)
	{
		if (socket == null)
		{
			throw new ArgumentNullException("socket");
		}
		CFStreamCreatePairWithSocket(IntPtr.Zero, socket.GetNative(), out var readStream2, out var writeStream2);
		readStream = new CFReadStream(readStream2);
		writeStream = new CFWriteStream(writeStream2);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	internal static extern void CFStreamCreatePairWithPeerSocketSignature(IntPtr allocator, ref CFSocketSignature sig, out IntPtr readStream, out IntPtr writeStream);

	public static void CreatePairWithPeerSocketSignature(AddressFamily family, SocketType type, ProtocolType proto, IPEndPoint endpoint, out CFReadStream readStream, out CFWriteStream writeStream)
	{
		using CFSocketAddress address = new CFSocketAddress(endpoint);
		CFSocketSignature sig = new CFSocketSignature(family, type, proto, address);
		CFStreamCreatePairWithPeerSocketSignature(IntPtr.Zero, ref sig, out var readStream2, out var writeStream2);
		readStream = new CFReadStream(readStream2);
		writeStream = new CFWriteStream(writeStream2);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	internal static extern void CFStreamCreatePairWithSocketToCFHost(IntPtr allocator, IntPtr host, int port, out IntPtr readStream, out IntPtr writeStream);

	public static void CreatePairWithSocketToHost(IPEndPoint endpoint, out CFReadStream readStream, out CFWriteStream writeStream)
	{
		using CFHost cFHost = CFHost.Create(endpoint);
		CFStreamCreatePairWithSocketToCFHost(IntPtr.Zero, cFHost.Handle, endpoint.Port, out var readStream2, out var writeStream2);
		readStream = ((readStream2 == IntPtr.Zero) ? null : new CFReadStream(readStream2));
		writeStream = ((writeStream2 == IntPtr.Zero) ? null : new CFWriteStream(writeStream2));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	internal static extern void CFStreamCreatePairWithSocketToHost(IntPtr allocator, IntPtr host, int port, out IntPtr readStream, out IntPtr writeStream);

	public static void CreatePairWithSocketToHost(string host, int port, out CFReadStream readStream, out CFWriteStream writeStream)
	{
		using CFString cFString = new CFString(host);
		CFStreamCreatePairWithSocketToHost(IntPtr.Zero, cFString.Handle, port, out var readStream2, out var writeStream2);
		readStream = ((readStream2 == IntPtr.Zero) ? null : new CFReadStream(readStream2));
		writeStream = ((writeStream2 == IntPtr.Zero) ? null : new CFWriteStream(writeStream2));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static extern IntPtr CFReadStreamCreateForHTTPRequest(IntPtr alloc, IntPtr request);

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession'.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession'.")]
	public static CFHTTPStream CreateForHTTPRequest(CFHTTPMessage request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr intPtr = CFReadStreamCreateForHTTPRequest(IntPtr.Zero, request.Handle);
		return new CFHTTPStream(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	internal static extern IntPtr CFReadStreamCreateForStreamedHTTPRequest(IntPtr alloc, IntPtr requestHeaders, IntPtr requestBody);

	public static CFHTTPStream CreateForStreamedHTTPRequest(CFHTTPMessage request, CFReadStream body)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		IntPtr intPtr = CFReadStreamCreateForStreamedHTTPRequest(IntPtr.Zero, request.Handle, body.Handle);
		return new CFHTTPStream(intPtr);
	}

	public static CFHTTPStream CreateForStreamedHTTPRequest(CFHTTPMessage request, NSInputStream body)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		IntPtr intPtr = CFReadStreamCreateForStreamedHTTPRequest(IntPtr.Zero, request.Handle, body.Handle);
		return new CFHTTPStream(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/Frameworks/CFNetwork.framework/CFNetwork")]
	internal static extern void CFStreamCreateBoundPair(IntPtr alloc, out IntPtr readStream, out IntPtr writeStream, nint transferBufferSize);

	public static void CreateBoundPair(out CFReadStream readStream, out CFWriteStream writeStream, nint bufferSize)
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
		this.OpenCompletedEvent?.Invoke(this, args);
	}

	protected virtual void OnHasBytesAvailableEvent(StreamEventArgs args)
	{
		this.HasBytesAvailableEvent?.Invoke(this, args);
	}

	protected virtual void OnCanAcceptBytesEvent(StreamEventArgs args)
	{
		this.CanAcceptBytesEvent?.Invoke(this, args);
	}

	protected virtual void OnErrorEvent(StreamEventArgs args)
	{
		this.ErrorEvent?.Invoke(this, args);
	}

	protected virtual void OnClosedEvent(StreamEventArgs args)
	{
		this.ClosedEvent?.Invoke(this, args);
	}

	protected abstract void ScheduleWithRunLoop(CFRunLoop loop, NSString mode);

	protected abstract void UnscheduleFromRunLoop(CFRunLoop loop, NSString mode);

	[MonoPInvokeCallback(typeof(CFStreamCallback))]
	private static void OnCallback(IntPtr s, nint type, IntPtr info)
	{
		CFStream cFStream = GCHandle.FromIntPtr(info).Target as CFStream;
		cFStream.OnCallback((CFStreamEventType)(long)type);
	}

	protected virtual void OnCallback(CFStreamEventType type)
	{
		StreamEventArgs args = new StreamEventArgs(type);
		CFStreamEventType num = type - 1;
		if (num <= (CFStreamEventType.OpenCompleted | CFStreamEventType.HasBytesAvailable))
		{
			switch (num)
			{
			case CFStreamEventType.None:
				OnOpenCompleted(args);
				return;
			case CFStreamEventType.OpenCompleted | CFStreamEventType.HasBytesAvailable:
				OnCanAcceptBytesEvent(args);
				return;
			case CFStreamEventType.OpenCompleted:
				OnHasBytesAvailableEvent(args);
				return;
			case CFStreamEventType.HasBytesAvailable:
				return;
			}
		}
		switch (type)
		{
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
			if (!DoSetClient(OnCallback, (nint)(long)cFStreamEventType, intPtr))
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

	protected abstract bool DoSetClient(CFStreamCallback callback, nint eventTypes, IntPtr context);

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

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern void CFReadStreamSetDispatchQueue(IntPtr stream, IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern void CFWriteStreamSetDispatchQueue(IntPtr stream, IntPtr queue);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern IntPtr CFReadStreamCopyDispatchQueue(IntPtr stream);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern IntPtr CFWriteStreamCopyDispatchQueue(IntPtr stream);
}
