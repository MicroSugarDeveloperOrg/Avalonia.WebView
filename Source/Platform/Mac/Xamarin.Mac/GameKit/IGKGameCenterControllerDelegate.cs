using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKGameCenterControllerDelegate", WrapperType = typeof(GKGameCenterControllerDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "gameCenterViewControllerDidFinish:", ParameterType = new Type[] { typeof(GKGameCenterViewController) }, ParameterByRef = new bool[] { false })]
public interface IGKGameCenterControllerDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("gameCenterViewControllerDidFinish:")]
	[Preserve(Conditional = true)]
	void Finished(GKGameCenterViewController controller);
}
