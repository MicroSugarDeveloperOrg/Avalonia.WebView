using System;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class ASAuthorizationProviderAuthorizationOperationExtensions
{
	private static IntPtr[] values = new IntPtr[0];

	public static NSString? GetConstant(this ASAuthorizationProviderAuthorizationOperation self)
	{
		IntPtr zero = IntPtr.Zero;
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static ASAuthorizationProviderAuthorizationOperation GetValue(NSString? constant)
	{
		if (constant == null)
		{
			return ASAuthorizationProviderAuthorizationOperation.None;
		}
		return ASAuthorizationProviderAuthorizationOperation.None;
	}
}
