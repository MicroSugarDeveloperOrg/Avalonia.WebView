using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCommandQueue", WrapperType = typeof(MTLCommandQueueWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommandBuffer", Selector = "commandBuffer", ReturnType = typeof(IMTLCommandBuffer))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommandBufferWithUnretainedReferences", Selector = "commandBufferWithUnretainedReferences", ReturnType = typeof(IMTLCommandBuffer))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertDebugCaptureBoundary", Selector = "insertDebugCaptureBoundary")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCommandQueue : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}

	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commandBuffer")]
	[Preserve(Conditional = true)]
	IMTLCommandBuffer? CommandBuffer();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commandBufferWithUnretainedReferences")]
	[Preserve(Conditional = true)]
	IMTLCommandBuffer? CommandBufferWithUnretainedReferences();

	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'MTLCaptureScope' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'MTLCaptureScope' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'MTLCaptureScope' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'MTLCaptureScope' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("insertDebugCaptureBoundary")]
	[Preserve(Conditional = true)]
	void InsertDebugCaptureBoundary();
}
