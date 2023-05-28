using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWBrowseResult : NativeObject
{
	private delegate void nw_browse_result_enumerate_interfaces_t(IntPtr block, IntPtr nwInterface);

	private static nw_browse_result_enumerate_interfaces_t static_EnumerateInterfacesHandler = TrampolineEnumerateInterfacesHandler;

	public NWEndpoint EndPoint => new NWEndpoint(nw_browse_result_copy_endpoint(GetCheckedHandle()), owns: true);

	public nuint InterfacesCount => nw_browse_result_get_interfaces_count(GetCheckedHandle());

	public NWTxtRecord TxtRecord => new NWTxtRecord(nw_browse_result_copy_txt_record_object(GetCheckedHandle()), owns: true);

	internal NWBrowseResult(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browse_result_copy_endpoint(IntPtr result);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern nuint nw_browse_result_get_interfaces_count(IntPtr result);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_browse_result_copy_txt_record_object(IntPtr result);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern NWBrowseResultChange nw_browse_result_get_changes(IntPtr old_result, IntPtr new_result);

	public static NWBrowseResultChange GetChanges(NWBrowseResult oldResult, NWBrowseResult newResult)
	{
		return nw_browse_result_get_changes(oldResult.GetHandle(), newResult.GetHandle());
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_browse_result_enumerate_interfaces(IntPtr result, ref BlockLiteral enumerator);

	[MonoPInvokeCallback(typeof(nw_browse_result_enumerate_interfaces_t))]
	private static void TrampolineEnumerateInterfacesHandler(IntPtr block, IntPtr inter)
	{
		Action<NWInterface> target = BlockLiteral.GetTarget<Action<NWInterface>>(block);
		if (target != null)
		{
			NWInterface obj = new NWInterface(inter, owns: false);
			target(obj);
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateInterfaces(Action<NWInterface> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerator = default(BlockLiteral);
		enumerator.SetupBlockUnsafe(static_EnumerateInterfacesHandler, handler);
		try
		{
			nw_browse_result_enumerate_interfaces(GetCheckedHandle(), ref enumerator);
		}
		finally
		{
			enumerator.CleanupBlock();
		}
	}
}
