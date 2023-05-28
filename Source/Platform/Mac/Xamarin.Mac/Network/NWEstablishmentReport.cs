using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Network;

[TV(13, 0)]
[Mac(10, 15)]
[iOS(13, 0)]
[Watch(6, 0)]
public class NWEstablishmentReport : NativeObject
{
	private delegate void nw_report_resolution_enumerator_t(IntPtr block, NWReportResolutionSource source, nuint milliseconds, int endpoint_count, IntPtr successful_endpoint, IntPtr preferred_endpoint);

	private delegate void nw_establishment_report_enumerate_protocols_t(IntPtr block, IntPtr protocol, nuint handshake_milliseconds, nuint handshake_rtt_milliseconds);

	private static nw_report_resolution_enumerator_t static_ResolutionEnumeratorHandler = TrampolineResolutionEnumeratorHandler;

	private static nw_establishment_report_enumerate_protocols_t static_EnumerateProtocolsHandler = TrampolineEnumerateProtocolsHandler;

	public bool UsedProxy => nw_establishment_report_get_used_proxy(GetCheckedHandle());

	public bool ProxyConfigured => nw_establishment_report_get_proxy_configured(GetCheckedHandle());

	public uint PreviousAttemptCount => nw_establishment_report_get_previous_attempt_count(GetCheckedHandle());

	public TimeSpan Duration => TimeSpan.FromMilliseconds(nw_establishment_report_get_duration_milliseconds(GetCheckedHandle()));

	public TimeSpan ConnectionSetupTime => TimeSpan.FromMilliseconds(nw_establishment_report_get_attempt_started_after_milliseconds(GetCheckedHandle()));

	public NWEndpoint ProxyEndpoint
	{
		get
		{
			IntPtr intPtr = nw_establishment_report_copy_proxy_endpoint(GetCheckedHandle());
			return (intPtr == IntPtr.Zero) ? null : new NWEndpoint(intPtr, owns: true);
		}
	}

	internal NWEstablishmentReport(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_establishment_report_get_used_proxy(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern bool nw_establishment_report_get_proxy_configured(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern uint nw_establishment_report_get_previous_attempt_count(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_establishment_report_get_duration_milliseconds(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern ulong nw_establishment_report_get_attempt_started_after_milliseconds(IntPtr report);

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_establishment_report_enumerate_resolutions(IntPtr report, ref BlockLiteral enumerate_block);

	[MonoPInvokeCallback(typeof(nw_report_resolution_enumerator_t))]
	private static void TrampolineResolutionEnumeratorHandler(IntPtr block, NWReportResolutionSource source, nuint milliseconds, int endpoint_count, IntPtr successful_endpoint, IntPtr preferred_endpoint)
	{
		Action<NWReportResolutionSource, TimeSpan, int, NWEndpoint, NWEndpoint> target = BlockLiteral.GetTarget<Action<NWReportResolutionSource, TimeSpan, int, NWEndpoint, NWEndpoint>>(block);
		if (target == null)
		{
			return;
		}
		using NWEndpoint arg = new NWEndpoint(successful_endpoint, owns: false);
		using NWEndpoint arg2 = new NWEndpoint(preferred_endpoint, owns: false);
		target(source, TimeSpan.FromMilliseconds(milliseconds), endpoint_count, arg, arg2);
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateResolutions(Action<NWReportResolutionSource, TimeSpan, int, NWEndpoint, NWEndpoint> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerate_block = default(BlockLiteral);
		enumerate_block.SetupBlockUnsafe(static_ResolutionEnumeratorHandler, handler);
		try
		{
			nw_establishment_report_enumerate_resolutions(GetCheckedHandle(), ref enumerate_block);
		}
		finally
		{
			enumerate_block.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern void nw_establishment_report_enumerate_protocols(IntPtr report, ref BlockLiteral enumerate_block);

	[MonoPInvokeCallback(typeof(nw_establishment_report_enumerate_protocols_t))]
	private static void TrampolineEnumerateProtocolsHandler(IntPtr block, IntPtr protocol, nuint handshake_milliseconds, nuint handshake_rtt_milliseconds)
	{
		Action<NWProtocolDefinition, TimeSpan, TimeSpan> target = BlockLiteral.GetTarget<Action<NWProtocolDefinition, TimeSpan, TimeSpan>>(block);
		if (target != null)
		{
			using (NWProtocolDefinition arg = new NWProtocolDefinition(protocol, owns: false))
			{
				target(arg, TimeSpan.FromMilliseconds(handshake_milliseconds), TimeSpan.FromMilliseconds(handshake_rtt_milliseconds));
			}
		}
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	public void EnumerateProtocols(Action<NWProtocolDefinition, TimeSpan, TimeSpan> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral enumerate_block = default(BlockLiteral);
		enumerate_block.SetupBlockUnsafe(static_EnumerateProtocolsHandler, handler);
		try
		{
			nw_establishment_report_enumerate_protocols(GetCheckedHandle(), ref enumerate_block);
		}
		finally
		{
			enumerate_block.CleanupBlock();
		}
	}

	[DllImport("/System/Library/Frameworks/Network.framework/Network")]
	private static extern IntPtr nw_establishment_report_copy_proxy_endpoint(IntPtr report);
}
