using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLRenderPipelineState", WrapperType = typeof(MTLRenderPipelineStateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportIndirectCommandBuffers", Selector = "supportIndirectCommandBuffers", PropertyType = typeof(bool), GetterSelector = "supportIndirectCommandBuffers", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLRenderPipelineState : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}
}
