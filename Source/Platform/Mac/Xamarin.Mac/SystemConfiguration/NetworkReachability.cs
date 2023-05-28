using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace SystemConfiguration;

public class NetworkReachability : INativeObject, IDisposable
{
	[StructLayout(LayoutKind.Explicit, Size = 28)]
	private struct sockaddr_in
	{
		[FieldOffset(0)]
		private byte sin_len;

		[FieldOffset(1)]
		private byte sin_family;

		[FieldOffset(2)]
		private short sin_port;

		[FieldOffset(4)]
		private int sin_addr;

		[FieldOffset(4)]
		private uint sin6_flowinfo;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public byte[] sin6_addr8;

		[FieldOffset(24)]
		private uint sin6_scope_id;

		public sockaddr_in(IPAddress address)
		{
			sin_addr = 0;
			sin_len = 28;
			sin6_flowinfo = 0u;
			sin6_scope_id = 0u;
			sin6_addr8 = new byte[16];
			switch (address.AddressFamily)
			{
			case AddressFamily.InterNetwork:
				sin_family = 2;
				sin_addr = (int)address.Address;
				break;
			case AddressFamily.InterNetworkV6:
				sin_family = 30;
				sin6_addr8 = address.GetAddressBytes();
				sin6_scope_id = (uint)address.ScopeId;
				break;
			default:
				throw new NotSupportedException(address.AddressFamily.ToString());
			}
			sin_port = 0;
		}
	}

	private struct SCNetworkReachabilityContext
	{
		public IntPtr version;

		public IntPtr info;

		public IntPtr retain;

		public IntPtr release;

		public IntPtr copyDescription;

		public SCNetworkReachabilityContext(IntPtr val)
		{
			info = val;
			version = (retain = (release = (copyDescription = IntPtr.Zero)));
		}
	}

	private delegate void SCNetworkReachabilityCallBack(IntPtr handle, NetworkReachabilityFlags flags, IntPtr info);

	public delegate void Notification(NetworkReachabilityFlags flags);

	internal IntPtr handle;

	private Notification notification;

	private GCHandle gch;

	private SCNetworkReachabilityCallBack callouth;

	public IntPtr Handle => handle;

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCNetworkReachabilityCreateWithName(IntPtr allocator, string address);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCNetworkReachabilityCreateWithAddress(IntPtr allocator, ref sockaddr_in address);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCNetworkReachabilityCreateWithAddressPair(IntPtr allocator, ref sockaddr_in localAddress, ref sockaddr_in remoteAddress);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCNetworkReachabilityCreateWithAddressPair(IntPtr allocator, IntPtr localAddress, ref sockaddr_in remoteAddress);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern IntPtr SCNetworkReachabilityCreateWithAddressPair(IntPtr allocator, ref sockaddr_in localAddress, IntPtr remoteAddress);

	public NetworkReachability(IPAddress ip)
	{
		if (ip == null)
		{
			throw new ArgumentNullException("ip");
		}
		sockaddr_in address = new sockaddr_in(ip);
		handle = SCNetworkReachabilityCreateWithAddress(IntPtr.Zero, ref address);
		if (handle == IntPtr.Zero)
		{
			throw SystemConfigurationException.FromMostRecentCall();
		}
	}

	public NetworkReachability(string address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		handle = SCNetworkReachabilityCreateWithName(IntPtr.Zero, address);
		if (handle == IntPtr.Zero)
		{
			throw SystemConfigurationException.FromMostRecentCall();
		}
	}

	public NetworkReachability(IPAddress localAddress, IPAddress remoteAddress)
	{
		if (localAddress == null && remoteAddress == null)
		{
			throw new ArgumentException("At least one address is required");
		}
		if (localAddress == null)
		{
			sockaddr_in remoteAddress2 = new sockaddr_in(remoteAddress);
			handle = SCNetworkReachabilityCreateWithAddressPair(IntPtr.Zero, IntPtr.Zero, ref remoteAddress2);
		}
		else if (remoteAddress == null)
		{
			sockaddr_in localAddress2 = new sockaddr_in(localAddress);
			handle = SCNetworkReachabilityCreateWithAddressPair(IntPtr.Zero, ref localAddress2, IntPtr.Zero);
		}
		else
		{
			sockaddr_in localAddress3 = new sockaddr_in(localAddress);
			sockaddr_in remoteAddress3 = new sockaddr_in(remoteAddress);
			handle = SCNetworkReachabilityCreateWithAddressPair(IntPtr.Zero, ref localAddress3, ref remoteAddress3);
		}
		if (handle == IntPtr.Zero)
		{
			throw SystemConfigurationException.FromMostRecentCall();
		}
	}

	~NetworkReachability()
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
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern int SCNetworkReachabilityGetFlags(IntPtr target, out NetworkReachabilityFlags flags);

	public bool TryGetFlags(out NetworkReachabilityFlags flags)
	{
		return GetFlags(out flags) == StatusCode.OK;
	}

	public StatusCode GetFlags(out NetworkReachabilityFlags flags)
	{
		return (SCNetworkReachabilityGetFlags(handle, out flags) == 0) ? StatusCodeError.SCError() : StatusCode.OK;
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool SCNetworkReachabilitySetCallback(IntPtr handle, SCNetworkReachabilityCallBack callout, ref SCNetworkReachabilityContext context);

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool SCNetworkReachabilitySetCallback(IntPtr handle, SCNetworkReachabilityCallBack callout, IntPtr context);

	[MonoPInvokeCallback(typeof(SCNetworkReachabilityCallBack))]
	private static void Callback(IntPtr handle, NetworkReachabilityFlags flags, IntPtr info)
	{
		if (GCHandle.FromIntPtr(info).Target is NetworkReachability networkReachability)
		{
			networkReachability.notification(flags);
		}
	}

	public StatusCode SetNotification(Notification callback)
	{
		if (notification == null)
		{
			if (callback == null)
			{
				return StatusCode.OK;
			}
			gch = GCHandle.Alloc(this);
			SCNetworkReachabilityContext context = new SCNetworkReachabilityContext(GCHandle.ToIntPtr(gch));
			lock (typeof(NetworkReachability))
			{
				if (callouth == null)
				{
					callouth = Callback;
				}
			}
			if (!SCNetworkReachabilitySetCallback(handle, callouth, ref context))
			{
				return StatusCodeError.SCError();
			}
		}
		else if (callback == null)
		{
			notification = null;
			callouth = null;
			if (!SCNetworkReachabilitySetCallback(handle, null, IntPtr.Zero))
			{
				return StatusCodeError.SCError();
			}
			return StatusCode.OK;
		}
		notification = callback;
		return StatusCode.OK;
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool SCNetworkReachabilityScheduleWithRunLoop(IntPtr target, IntPtr runloop, IntPtr runLoopMode);

	public bool Schedule(CFRunLoop runLoop, string mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		using CFString cFString = new CFString(mode);
		return SCNetworkReachabilityScheduleWithRunLoop(handle, runLoop.Handle, cFString.Handle);
	}

	public bool Schedule()
	{
		return Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern int SCNetworkReachabilityUnscheduleFromRunLoop(IntPtr target, IntPtr runloop, IntPtr runLoopMode);

	public bool Unschedule(CFRunLoop runLoop, string mode)
	{
		if (runLoop == null)
		{
			throw new ArgumentNullException("runLoop");
		}
		if (mode == null)
		{
			throw new ArgumentNullException("mode");
		}
		using CFString cFString = new CFString(mode);
		return SCNetworkReachabilityUnscheduleFromRunLoop(handle, runLoop.Handle, cFString.Handle) != 0;
	}

	public bool Unschedule()
	{
		return Unschedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
	}

	[DllImport("/System/Library/Frameworks/SystemConfiguration.framework/SystemConfiguration")]
	private static extern bool SCNetworkReachabilitySetDispatchQueue(IntPtr target, IntPtr queue);

	public bool SetDispatchQueue(DispatchQueue queue)
	{
		return SCNetworkReachabilitySetDispatchQueue(handle, (queue == null) ? IntPtr.Zero : queue.Handle);
	}
}
