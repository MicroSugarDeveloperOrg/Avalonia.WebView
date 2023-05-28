using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWInterface : NativeObject
{
	public NWInterfaceType InterfaceType => nw_interface_get_type(GetCheckedHandle());

	public string Name => Marshal.PtrToStringAnsi(nw_interface_get_name(GetCheckedHandle()));

	public uint Index => nw_interface_get_index(GetCheckedHandle());

	public NWInterface(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWInterfaceType nw_interface_get_type(IntPtr iface);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_interface_get_name(IntPtr iface);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern uint nw_interface_get_index(IntPtr iface);
}
