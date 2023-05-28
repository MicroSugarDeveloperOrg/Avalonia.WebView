using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
internal static class SecCertificateOIDs
{
	[Field("kSecOIDX509V1SubjectPublicKey", "Security")]
	public static IntPtr SubjectPublicKey => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecOIDX509V1SubjectPublicKey");
}
