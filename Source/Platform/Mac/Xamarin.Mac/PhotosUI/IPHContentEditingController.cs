using System;
using AppKit;
using Foundation;
using ObjCRuntime;
using Photos;

namespace PhotosUI;

[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Protocol(Name = "PHContentEditingController", WrapperType = typeof(PHContentEditingControllerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CanHandleAdjustmentData", Selector = "canHandleAdjustmentData:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(PHAdjustmentData) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartContentEditing", Selector = "startContentEditingWithInput:placeholderImage:", ParameterType = new Type[]
{
	typeof(PHContentEditingInput),
	typeof(NSImage)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishContentEditing", Selector = "finishContentEditingWithCompletionHandler:", ParameterType = new Type[] { typeof(Action<PHContentEditingOutput>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V72) })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelContentEditing", Selector = "cancelContentEditing")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShouldShowCancelConfirmation", Selector = "shouldShowCancelConfirmation", PropertyType = typeof(bool), GetterSelector = "shouldShowCancelConfirmation", ArgumentSemantic = ArgumentSemantic.None)]
public interface IPHContentEditingController : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool ShouldShowCancelConfirmation
	{
		[Export("shouldShowCancelConfirmation")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("canHandleAdjustmentData:")]
	[Preserve(Conditional = true)]
	bool CanHandleAdjustmentData(PHAdjustmentData adjustmentData);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("startContentEditingWithInput:placeholderImage:")]
	[Preserve(Conditional = true)]
	void StartContentEditing(PHContentEditingInput contentEditingInput, NSImage placeholderImage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("finishContentEditingWithCompletionHandler:")]
	[Preserve(Conditional = true)]
	void FinishContentEditing([BlockProxy(typeof(Trampolines.NIDActionArity1V72))] Action<PHContentEditingOutput> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cancelContentEditing")]
	[Preserve(Conditional = true)]
	void CancelContentEditing();
}
