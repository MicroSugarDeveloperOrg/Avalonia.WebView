using System;
using Foundation;
using ObjCRuntime;

namespace Network;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class NWConnectionConstants
{
	[Field("_nw_connection_send_idempotent_content", "Network")]
	public static IntPtr _SendIdempotentContent => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_connection_send_idempotent_content");
}
