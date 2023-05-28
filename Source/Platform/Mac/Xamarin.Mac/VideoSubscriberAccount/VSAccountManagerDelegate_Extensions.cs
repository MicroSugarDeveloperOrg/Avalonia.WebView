using System;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Advice("This API is not available when using UIKit on macOS.")]
public static class VSAccountManagerDelegate_Extensions
{
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldAuthenticateAccountProvider(this IVSAccountManagerDelegate This, VSAccountManager accountManager, string accountProviderIdentifier)
	{
		if (accountManager == null)
		{
			throw new ArgumentNullException("accountManager");
		}
		if (accountProviderIdentifier == null)
		{
			throw new ArgumentNullException("accountProviderIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(accountProviderIdentifier);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("accountManager:shouldAuthenticateAccountProviderWithIdentifier:"), accountManager.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
