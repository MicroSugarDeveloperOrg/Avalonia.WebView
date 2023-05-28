using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLResource", WrapperType = typeof(MTLResourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPurgeableState", Selector = "setPurgeableState:", ReturnType = typeof(MTLPurgeableState), ParameterType = new Type[] { typeof(MTLPurgeableState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeAliasable", Selector = "makeAliasable")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CpuCacheMode", Selector = "cpuCacheMode", PropertyType = typeof(MTLCpuCacheMode), GetterSelector = "cpuCacheMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "StorageMode", Selector = "storageMode", PropertyType = typeof(MTLStorageMode), GetterSelector = "storageMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Heap", Selector = "heap", PropertyType = typeof(IMTLHeap), GetterSelector = "heap", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsAliasable", Selector = "isAliasable", PropertyType = typeof(bool), GetterSelector = "isAliasable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllocatedSize", Selector = "allocatedSize", PropertyType = typeof(nuint), GetterSelector = "allocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ResourceOptions", Selector = "resourceOptions", PropertyType = typeof(MTLResourceOptions), GetterSelector = "resourceOptions", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HeapOffset", Selector = "heapOffset", PropertyType = typeof(nuint), GetterSelector = "heapOffset", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HazardTrackingMode", Selector = "hazardTrackingMode", PropertyType = typeof(MTLHazardTrackingMode), GetterSelector = "hazardTrackingMode", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLResource : INativeObject, IDisposable
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

	[Preserve(Conditional = true)]
	MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setPurgeableState:")]
	[Preserve(Conditional = true)]
	MTLPurgeableState SetPurgeableState(MTLPurgeableState state);
}
