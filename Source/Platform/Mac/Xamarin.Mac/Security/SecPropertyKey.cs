using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class SecPropertyKey
{
	[Field("kSecPropertyKeyLabel", "Security")]
	public static IntPtr Label => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecPropertyKeyLabel");

	[Field("kSecPropertyKeyLocalizedLabel", "Security")]
	public static IntPtr LocalizedLabel => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecPropertyKeyLocalizedLabel");

	[Field("kSecPropertyKeyType", "Security")]
	public static IntPtr Type => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecPropertyKeyType");

	[Field("kSecPropertyKeyValue", "Security")]
	public static IntPtr Value => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecPropertyKeyValue");
}
