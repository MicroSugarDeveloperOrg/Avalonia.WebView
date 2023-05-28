using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWBrowserDescriptor : NativeObject
{
	public bool IncludeTxtRecord
	{
		get
		{
			return nw_browse_descriptor_get_include_txt_record(GetCheckedHandle());
		}
		set
		{
			nw_browse_descriptor_set_include_txt_record(GetCheckedHandle(), value);
		}
	}

	public string BonjourType => Marshal.PtrToStringAnsi(nw_browse_descriptor_get_bonjour_service_type(GetCheckedHandle()));

	public string BonjourDomain => Marshal.PtrToStringAnsi(nw_browse_descriptor_get_bonjour_service_domain(GetCheckedHandle()));

	internal NWBrowserDescriptor(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browse_descriptor_create_bonjour_service(string type, string domain);

	public static NWBrowserDescriptor CreateBonjourService(string type, string domain)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		return new NWBrowserDescriptor(nw_browse_descriptor_create_bonjour_service(type, domain), owns: true);
	}

	public static NWBrowserDescriptor CreateBonjourService(string type)
	{
		return CreateBonjourService(type, null);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_browse_descriptor_get_include_txt_record(IntPtr descriptor);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_browse_descriptor_set_include_txt_record(IntPtr descriptor, bool include_txt_record);

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr nw_browse_descriptor_get_bonjour_service_type(IntPtr descriptor);

	[DllImport("/System/Library/Frameworks/Network.framework/Network", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern IntPtr nw_browse_descriptor_get_bonjour_service_domain(IntPtr descriptor);
}
