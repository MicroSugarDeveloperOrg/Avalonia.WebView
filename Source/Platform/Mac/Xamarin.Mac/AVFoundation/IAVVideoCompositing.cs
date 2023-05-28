using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVVideoCompositing", WrapperType = typeof(AVVideoCompositingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SourcePixelBufferAttributes", Selector = "sourcePixelBufferAttributes", ReturnType = typeof(NSDictionary))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequiredPixelBufferAttributesForRenderContext", Selector = "requiredPixelBufferAttributesForRenderContext", ReturnType = typeof(NSDictionary))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RenderContextChanged", Selector = "renderContextChanged:", ParameterType = new Type[] { typeof(AVVideoCompositionRenderContext) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartVideoCompositionRequest", Selector = "startVideoCompositionRequest:", ParameterType = new Type[] { typeof(AVAsynchronousVideoCompositionRequest) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelAllPendingVideoCompositionRequests", Selector = "cancelAllPendingVideoCompositionRequests")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AnticipateRendering", Selector = "anticipateRenderingUsingHint:", ParameterType = new Type[] { typeof(AVVideoCompositionRenderHint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrerollForRendering", Selector = "prerollForRenderingUsingHint:", ParameterType = new Type[] { typeof(AVVideoCompositionRenderHint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsWideColorSourceFrames", Selector = "supportsWideColorSourceFrames", PropertyType = typeof(bool), GetterSelector = "supportsWideColorSourceFrames", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVVideoCompositing : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("sourcePixelBufferAttributes")]
	[Preserve(Conditional = true)]
	NSDictionary? SourcePixelBufferAttributes();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("requiredPixelBufferAttributesForRenderContext")]
	[Preserve(Conditional = true)]
	NSDictionary RequiredPixelBufferAttributesForRenderContext();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("renderContextChanged:")]
	[Preserve(Conditional = true)]
	void RenderContextChanged(AVVideoCompositionRenderContext newRenderContext);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("startVideoCompositionRequest:")]
	[Preserve(Conditional = true)]
	void StartVideoCompositionRequest(AVAsynchronousVideoCompositionRequest asyncVideoCompositionRequest);
}
