using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Native]
public enum SKPaymentTransactionState : long
{
	Purchasing,
	Purchased,
	Failed,
	Restored,
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	Deferred
}
