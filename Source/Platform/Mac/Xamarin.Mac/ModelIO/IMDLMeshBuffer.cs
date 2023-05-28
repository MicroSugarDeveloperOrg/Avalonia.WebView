using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLMeshBuffer", WrapperType = typeof(MDLMeshBufferWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FillData", Selector = "fillData:offset:", ParameterType = new Type[]
{
	typeof(NSData),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Map", Selector = "map", PropertyType = typeof(MDLMeshBufferMap), GetterSelector = "map", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Length", Selector = "length", PropertyType = typeof(nuint), GetterSelector = "length", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Allocator", Selector = "allocator", PropertyType = typeof(IMDLMeshBufferAllocator), GetterSelector = "allocator", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Zone", Selector = "zone", PropertyType = typeof(IMDLMeshBufferZone), GetterSelector = "zone", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof(MDLMeshBufferType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMDLMeshBuffer : INativeObject, IDisposable, INSCopying
{
	[Preserve(Conditional = true)]
	MDLMeshBufferMap Map
	{
		[Export("map")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("fillData:offset:")]
	[Preserve(Conditional = true)]
	void FillData(NSData data, nuint offset);
}
