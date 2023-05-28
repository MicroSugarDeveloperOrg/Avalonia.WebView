using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLMeshBufferZone", WrapperType = typeof(MDLMeshBufferZoneWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Capacity", Selector = "capacity", PropertyType = typeof(nuint), GetterSelector = "capacity", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Allocator", Selector = "allocator", PropertyType = typeof(IMDLMeshBufferAllocator), GetterSelector = "allocator", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMDLMeshBufferZone : INativeObject, IDisposable
{
}
