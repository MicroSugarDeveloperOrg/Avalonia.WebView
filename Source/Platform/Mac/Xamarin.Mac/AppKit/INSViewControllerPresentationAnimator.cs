using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSViewControllerPresentationAnimator", WrapperType = typeof(NSViewControllerPresentationAnimatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnimatePresentation", Selector = "animatePresentationOfViewController:fromViewController:", ParameterType = new Type[]
{
	typeof(NSViewController),
	typeof(NSViewController)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AnimateDismissal", Selector = "animateDismissalOfViewController:fromViewController:", ParameterType = new Type[]
{
	typeof(NSViewController),
	typeof(NSViewController)
}, ParameterByRef = new bool[] { false, false })]
public interface INSViewControllerPresentationAnimator : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("animatePresentationOfViewController:fromViewController:")]
	[Preserve(Conditional = true)]
	void AnimatePresentation(NSViewController viewController, NSViewController fromViewController);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("animateDismissalOfViewController:fromViewController:")]
	[Preserve(Conditional = true)]
	void AnimateDismissal(NSViewController viewController, NSViewController fromViewController);
}
