using System;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SKPaymentQueueDelegate", WrapperType = typeof(SKPaymentQueueDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueTransaction", Selector = "paymentQueue:shouldContinueTransaction:inStorefront:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SKPaymentQueue),
	typeof(SKPaymentTransaction),
	typeof(SKStorefront)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ISKPaymentQueueDelegate : INativeObject, IDisposable
{
}
