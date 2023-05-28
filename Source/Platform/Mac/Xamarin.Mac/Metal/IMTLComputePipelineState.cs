using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLComputePipelineState", WrapperType = typeof(MTLComputePipelineStateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadsPerThreadgroup", Selector = "maxTotalThreadsPerThreadgroup", PropertyType = typeof(nuint), GetterSelector = "maxTotalThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ThreadExecutionWidth", Selector = "threadExecutionWidth", PropertyType = typeof(nuint), GetterSelector = "threadExecutionWidth", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "StaticThreadgroupMemoryLength", Selector = "staticThreadgroupMemoryLength", PropertyType = typeof(nuint), GetterSelector = "staticThreadgroupMemoryLength", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLComputePipelineState : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint MaxTotalThreadsPerThreadgroup
	{
		[Export("maxTotalThreadsPerThreadgroup")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint ThreadExecutionWidth
	{
		[Export("threadExecutionWidth")]
		get;
	}
}
