using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWError : NativeObject
{
	public NWErrorDomain ErrorDomain => nw_error_get_error_domain(GetCheckedHandle());

	public int ErrorCode => nw_error_get_error_code(GetCheckedHandle());

	public CFException CFError => CFException.FromCFError(nw_error_copy_cf_error(GetCheckedHandle()), release: true);

	public NWError(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWErrorDomain nw_error_get_error_domain(IntPtr error);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern int nw_error_get_error_code(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_error_copy_cf_error(IntPtr error);
}
