using System;
using Foundation;
using ObjCRuntime;

namespace Network;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class NWContentContextConstants
{
	[Field("_nw_content_context_default_message", "Network")]
	public static IntPtr _DefaultMessage => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_content_context_default_message");

	[Field("_nw_content_context_default_stream", "Network")]
	public static IntPtr _DefaultStream => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_content_context_default_stream");

	[Field("_nw_content_context_final_send", "Network")]
	public static IntPtr _FinalSend => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_content_context_final_send");
}
