using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWEndpoint : NativeObject
{
	public NWEndpointType Type => nw_endpoint_get_type(GetCheckedHandle());

	public string Hostname => Marshal.PtrToStringAnsi(nw_endpoint_get_hostname(GetCheckedHandle()));

	public string Port => nw_endpoint_copy_port_string(GetCheckedHandle());

	public ushort PortNumber => nw_endpoint_get_port(GetCheckedHandle());

	public string Address => nw_endpoint_copy_address_string(GetCheckedHandle());

	public string BonjourServiceName => Marshal.PtrToStringAnsi(nw_endpoint_get_bonjour_service_name(GetCheckedHandle()));

	public string BonjourServiceType => Marshal.PtrToStringAnsi(nw_endpoint_get_bonjour_service_type(GetCheckedHandle()));

	public string BonjourServiceDomain => Marshal.PtrToStringAnsi(nw_endpoint_get_bonjour_service_domain(GetCheckedHandle()));

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public string Url => Marshal.PtrToStringAnsi(nw_endpoint_get_url(GetCheckedHandle()));

	public NWEndpoint(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWEndpointType nw_endpoint_get_type(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_create_host(string hostname, string port);

	public static NWEndpoint Create(string hostname, string port)
	{
		if (hostname == null)
		{
			throw new ArgumentNullException("hostname");
		}
		if (port == null)
		{
			throw new ArgumentNullException("port");
		}
		IntPtr intPtr = nw_endpoint_create_host(hostname, port);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWEndpoint(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_get_hostname(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern string nw_endpoint_copy_port_string(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ushort nw_endpoint_get_port(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_create_address(IntPtr sockaddrPtr);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern string nw_endpoint_copy_address_string(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_create_bonjour_service(string name, string type, string domain);

	public static NWEndpoint CreateBonjourService(string name, string serviceType, string domain)
	{
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		IntPtr intPtr = nw_endpoint_create_bonjour_service(name, serviceType, domain);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWEndpoint(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_get_bonjour_service_name(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_get_bonjour_service_type(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_endpoint_get_bonjour_service_domain(IntPtr endpoint);

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr nw_endpoint_create_url(string url);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static NWEndpoint Create(string url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = nw_endpoint_create_url(url);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWEndpoint(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr nw_endpoint_get_url(IntPtr endpoint);
}
