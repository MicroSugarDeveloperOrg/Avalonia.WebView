using System;
using Foundation;
using ObjCRuntime;

namespace Network;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class NWParametersConstants
{
	[Field("_nw_parameters_configure_protocol_default_configuration", "Network")]
	public static IntPtr _DefaultConfiguration => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_parameters_configure_protocol_default_configuration");

	[Field("_nw_parameters_configure_protocol_disable", "Network")]
	public static IntPtr _ProtocolDisable => Dlfcn.GetIntPtr(Libraries.Network.Handle, "_nw_parameters_configure_protocol_disable");
}
