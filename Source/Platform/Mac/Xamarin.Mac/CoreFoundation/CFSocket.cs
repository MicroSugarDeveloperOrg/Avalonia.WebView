using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreFoundation;

public class CFSocket : CFType, INativeObject, IDisposable
{
	private delegate void CFSocketCallBack(IntPtr s, nuint type, IntPtr address, IntPtr data, IntPtr info);

	public class CFSocketAcceptEventArgs : EventArgs
	{
		internal CFSocketNativeHandle SocketHandle { get; private set; }

		public IPEndPoint RemoteEndPoint { get; private set; }

		public CFSocketAcceptEventArgs(CFSocketNativeHandle handle, IPEndPoint remote)
		{
			SocketHandle = handle;
			RemoteEndPoint = remote;
		}

		public CFSocket CreateSocket()
		{
			return new CFSocket(SocketHandle);
		}

		public override string ToString()
		{
			return $"[CFSocketAcceptEventArgs: RemoteEndPoint={RemoteEndPoint}]";
		}
	}

	public class CFSocketConnectEventArgs : EventArgs
	{
		public CFSocketError Result { get; private set; }

		public CFSocketConnectEventArgs(CFSocketError result)
		{
			Result = result;
		}

		public override string ToString()
		{
			return $"[CFSocketConnectEventArgs: Result={Result}]";
		}
	}

	public class CFSocketDataEventArgs : EventArgs
	{
		public IPEndPoint RemoteEndPoint { get; private set; }

		public byte[] Data { get; private set; }

		public CFSocketDataEventArgs(IPEndPoint remote, byte[] data)
		{
			RemoteEndPoint = remote;
			Data = data;
		}
	}

	public class CFSocketReadEventArgs : EventArgs
	{
	}

	public class CFSocketWriteEventArgs : EventArgs
	{
	}

	private IntPtr handle;

	private GCHandle gch;

	public IntPtr Handle => handle;

	public event EventHandler<CFSocketAcceptEventArgs> AcceptEvent;

	public event EventHandler<CFSocketConnectEventArgs> ConnectEvent;

	public event EventHandler<CFSocketDataEventArgs> DataEvent;

	public event EventHandler<CFSocketReadEventArgs> ReadEvent;

	public event EventHandler<CFSocketWriteEventArgs> WriteEvent;

	~CFSocket()
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
		if (disposing && gch.IsAllocated)
		{
			gch.Free();
		}
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[MonoPInvokeCallback(typeof(CFSocketCallBack))]
	private static void OnCallback(IntPtr s, nuint type, IntPtr address, IntPtr data, IntPtr info)
	{
		CFSocket cFSocket = GCHandle.FromIntPtr(info).Target as CFSocket;
		switch ((CFSocketCallBackType)(ulong)type)
		{
		case CFSocketCallBackType.AcceptCallBack:
		{
			IPEndPoint remote2 = CFSocketAddress.EndPointFromAddressPtr(address);
			CFSocketNativeHandle cFSocketNativeHandle = new CFSocketNativeHandle(Marshal.ReadInt32(data));
			cFSocket.OnAccepted(new CFSocketAcceptEventArgs(cFSocketNativeHandle, remote2));
			break;
		}
		case CFSocketCallBackType.ConnectCallBack:
		{
			CFSocketError result = (CFSocketError)((!(data == IntPtr.Zero)) ? Marshal.ReadInt32(data) : 0);
			cFSocket.OnConnect(new CFSocketConnectEventArgs(result));
			break;
		}
		case CFSocketCallBackType.DataCallBack:
		{
			IPEndPoint remote = CFSocketAddress.EndPointFromAddressPtr(address);
			using CFData cFData = new CFData(data, owns: false);
			cFSocket.OnData(new CFSocketDataEventArgs(remote, cFData.GetBuffer()));
			break;
		}
		case CFSocketCallBackType.ReadCallBack:
			cFSocket.OnRead(new CFSocketReadEventArgs());
			break;
		case CFSocketCallBackType.WriteCallBack:
			cFSocket.OnWrite(new CFSocketWriteEventArgs());
			break;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFSocketCreate(IntPtr allocator, int family, int type, int proto, nuint callBackTypes, CFSocketCallBack callout, IntPtr ctx);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFSocketCreateWithNative(IntPtr allocator, CFSocketNativeHandle sock, nuint callBackTypes, CFSocketCallBack callout, IntPtr ctx);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFSocketCreateRunLoopSource(IntPtr allocator, IntPtr socket, nint order);

	public CFSocket()
		: this(AddressFamily.Unspecified, (SocketType)0, ProtocolType.IP)
	{
	}

	public CFSocket(AddressFamily family, SocketType type, ProtocolType proto)
		: this(family, type, proto, CFRunLoop.Current)
	{
	}

	public CFSocket(AddressFamily family, SocketType type, ProtocolType proto, CFRunLoop loop)
		: this(CFSocketSignature.AddressFamilyToInt(family), CFSocketSignature.SocketTypeToInt(type), CFSocketSignature.ProtocolToInt(proto), loop)
	{
	}

	private CFSocket(int family, int type, int proto, CFRunLoop loop)
	{
		CFSocketCallBackType cFSocketCallBackType = CFSocketCallBackType.DataCallBack | CFSocketCallBackType.ConnectCallBack;
		gch = GCHandle.Alloc(this);
		CFStreamClientContext structure = new CFStreamClientContext
		{
			Info = GCHandle.ToIntPtr(gch)
		};
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CFStreamClientContext)));
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			handle = CFSocketCreate(IntPtr.Zero, family, type, proto, (nuint)(ulong)cFSocketCallBackType, OnCallback, intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		if (handle == IntPtr.Zero)
		{
			throw new CFSocketException(CFSocketError.Error);
		}
		gch = GCHandle.Alloc(this);
		CFRunLoopSource source = new CFRunLoopSource(CFSocketCreateRunLoopSource(IntPtr.Zero, handle, 0));
		loop.AddSource(source, CFRunLoop.ModeDefault);
	}

	internal CFSocket(CFSocketNativeHandle sock)
	{
		CFSocketCallBackType cFSocketCallBackType = CFSocketCallBackType.DataCallBack | CFSocketCallBackType.WriteCallBack;
		gch = GCHandle.Alloc(this);
		CFStreamClientContext structure = new CFStreamClientContext
		{
			Info = GCHandle.ToIntPtr(gch)
		};
		IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CFStreamClientContext)));
		try
		{
			Marshal.StructureToPtr(structure, intPtr, fDeleteOld: false);
			handle = CFSocketCreateWithNative(IntPtr.Zero, sock, (nuint)(ulong)cFSocketCallBackType, OnCallback, intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		if (handle == IntPtr.Zero)
		{
			throw new CFSocketException(CFSocketError.Error);
		}
		CFRunLoopSource source = new CFRunLoopSource(CFSocketCreateRunLoopSource(IntPtr.Zero, handle, 0));
		CFRunLoop current = CFRunLoop.Current;
		current.AddSource(source, CFRunLoop.ModeDefault);
	}

	private CFSocket(IntPtr handle)
	{
		this.handle = handle;
		gch = GCHandle.Alloc(this);
		CFRunLoopSource source = new CFRunLoopSource(CFSocketCreateRunLoopSource(IntPtr.Zero, handle, 0));
		CFRunLoop current = CFRunLoop.Current;
		current.AddSource(source, CFRunLoop.ModeDefault);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFSocketCreateConnectedToSocketSignature(IntPtr allocator, ref CFSocketSignature signature, nuint callBackTypes, CFSocketCallBack callout, IntPtr context, double timeout);

	public static CFSocket CreateConnectedToSocketSignature(AddressFamily family, SocketType type, ProtocolType proto, IPEndPoint endpoint, double timeout)
	{
		CFSocketCallBackType cFSocketCallBackType = CFSocketCallBackType.DataCallBack | CFSocketCallBackType.ConnectCallBack;
		using CFSocketAddress address = new CFSocketAddress(endpoint);
		CFSocketSignature signature = new CFSocketSignature(family, type, proto, address);
		IntPtr intPtr = CFSocketCreateConnectedToSocketSignature(IntPtr.Zero, ref signature, (nuint)(ulong)cFSocketCallBackType, OnCallback, IntPtr.Zero, timeout);
		if (intPtr == IntPtr.Zero)
		{
			throw new CFSocketException(CFSocketError.Error);
		}
		return new CFSocket(intPtr);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFSocketNativeHandle CFSocketGetNative(IntPtr handle);

	internal CFSocketNativeHandle GetNative()
	{
		return CFSocketGetNative(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFSocketSetAddress(IntPtr handle, IntPtr address);

	public void SetAddress(IPAddress address, int port)
	{
		SetAddress(new IPEndPoint(address, port));
	}

	public void SetAddress(IPEndPoint endpoint)
	{
		EnableCallBacks(CFSocketCallBackType.AcceptCallBack);
		CFSocketFlags socketFlags = GetSocketFlags();
		socketFlags |= CFSocketFlags.AutomaticallyReenableAcceptCallBack;
		SetSocketFlags(socketFlags);
		using CFSocketAddress cFSocketAddress = new CFSocketAddress(endpoint);
		CFSocketError cFSocketError = (CFSocketError)(long)CFSocketSetAddress(handle, cFSocketAddress.Handle);
		if (cFSocketError != CFSocketError.Success)
		{
			throw new CFSocketException(cFSocketError);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern CFSocketFlags CFSocketGetSocketFlags(IntPtr handle);

	public CFSocketFlags GetSocketFlags()
	{
		return CFSocketGetSocketFlags(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFSocketSetSocketFlags(IntPtr handle, nuint flags);

	public void SetSocketFlags(CFSocketFlags flags)
	{
		CFSocketSetSocketFlags(handle, (nuint)(ulong)flags);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFSocketDisableCallBacks(IntPtr handle, nuint types);

	public void DisableCallBacks(CFSocketCallBackType types)
	{
		CFSocketDisableCallBacks(handle, (nuint)(ulong)types);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFSocketEnableCallBacks(IntPtr handle, nuint types);

	public void EnableCallBacks(CFSocketCallBackType types)
	{
		CFSocketEnableCallBacks(handle, (nuint)(ulong)types);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFSocketSendData(IntPtr handle, IntPtr address, IntPtr data, double timeout);

	public void SendData(byte[] data, double timeout)
	{
		using CFDataBuffer cFDataBuffer = new CFDataBuffer(data);
		CFSocketError cFSocketError = (CFSocketError)(long)CFSocketSendData(handle, IntPtr.Zero, cFDataBuffer.Handle, timeout);
		if (cFSocketError != CFSocketError.Success)
		{
			throw new CFSocketException(cFSocketError);
		}
	}

	private void OnAccepted(CFSocketAcceptEventArgs args)
	{
		if (this.AcceptEvent != null)
		{
			this.AcceptEvent(this, args);
		}
	}

	private void OnConnect(CFSocketConnectEventArgs args)
	{
		if (this.ConnectEvent != null)
		{
			this.ConnectEvent(this, args);
		}
	}

	private void OnData(CFSocketDataEventArgs args)
	{
		if (this.DataEvent != null)
		{
			this.DataEvent(this, args);
		}
	}

	private void OnRead(CFSocketReadEventArgs args)
	{
		if (this.ReadEvent != null)
		{
			this.ReadEvent(this, args);
		}
	}

	private void OnWrite(CFSocketWriteEventArgs args)
	{
		if (this.WriteEvent != null)
		{
			this.WriteEvent(this, args);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern nint CFSocketConnectToAddress(IntPtr handle, IntPtr address, double timeout);

	public void Connect(IPAddress address, int port, double timeout)
	{
		Connect(new IPEndPoint(address, port), timeout);
	}

	public void Connect(IPEndPoint endpoint, double timeout)
	{
		using CFSocketAddress cFSocketAddress = new CFSocketAddress(endpoint);
		CFSocketError cFSocketError = (CFSocketError)(long)CFSocketConnectToAddress(handle, cFSocketAddress.Handle, timeout);
		if (cFSocketError != CFSocketError.Success)
		{
			throw new CFSocketException(cFSocketError);
		}
	}
}
