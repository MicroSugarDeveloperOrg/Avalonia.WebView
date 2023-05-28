using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Protocol(Name = "VSAccountManagerDelegate", WrapperType = typeof(VSAccountManagerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PresentViewController", Selector = "accountManager:presentViewController:", ParameterType = new Type[]
{
	typeof(VSAccountManager),
	typeof(NSViewController)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DismissViewController", Selector = "accountManager:dismissViewController:", ParameterType = new Type[]
{
	typeof(VSAccountManager),
	typeof(NSViewController)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAuthenticateAccountProvider", Selector = "accountManager:shouldAuthenticateAccountProviderWithIdentifier:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(VSAccountManager),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface IVSAccountManagerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accountManager:presentViewController:")]
	[Preserve(Conditional = true)]
	void PresentViewController(VSAccountManager accountManager, NSViewController viewController);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("accountManager:dismissViewController:")]
	[Preserve(Conditional = true)]
	void DismissViewController(VSAccountManager accountManager, NSViewController viewController);
}
