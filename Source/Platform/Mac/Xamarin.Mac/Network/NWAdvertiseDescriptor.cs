using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(12, 0)]
[Mac(10, 14)]
[iOS(12, 0)]
[Watch(6, 0)]
public class NWAdvertiseDescriptor : NativeObject
{
	public bool NoAutoRename
	{
		get
		{
			return nw_advertise_descriptor_get_no_auto_rename(GetCheckedHandle());
		}
		set
		{
			nw_advertise_descriptor_set_no_auto_rename(GetCheckedHandle(), value);
		}
	}

	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	public NWTxtRecord TxtRecord
	{
		get
		{
			return new NWTxtRecord(nw_advertise_descriptor_copy_txt_record_object(GetCheckedHandle()), owns: true);
		}
		set
		{
			nw_advertise_descriptor_set_txt_record_object(GetCheckedHandle(), value.GetHandle());
		}
	}

	public NWAdvertiseDescriptor(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_advertise_descriptor_create_bonjour_service(string name, string type, string domain);

	public static NWAdvertiseDescriptor CreateBonjourService(string name, string type, string domain = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = nw_advertise_descriptor_create_bonjour_service(name, type, domain);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new NWAdvertiseDescriptor(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_advertise_descriptor_set_txt_record(IntPtr handle, string txtRecord, nuint txtLen);

	public void SetTxtRecord(string txt)
	{
		if (txt == null)
		{
			throw new ArgumentNullException("txt");
		}
		int byteCount = Encoding.UTF8.GetByteCount(txt);
		nw_advertise_descriptor_set_txt_record(GetCheckedHandle(), txt, (nuint)byteCount);
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_advertise_descriptor_set_no_auto_rename(IntPtr handle, [MarshalAs(UnmanagedType.I1)] bool no_auto_rename);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool nw_advertise_descriptor_get_no_auto_rename(IntPtr handle);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern IntPtr nw_advertise_descriptor_copy_txt_record_object(IntPtr advertise_descriptor);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[Watch(6, 0)]
	private static extern void nw_advertise_descriptor_set_txt_record_object(IntPtr advertise_descriptor, IntPtr txt_record);
}
