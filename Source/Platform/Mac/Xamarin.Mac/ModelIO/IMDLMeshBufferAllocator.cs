using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLMeshBufferAllocator", WrapperType = typeof(MDLMeshBufferAllocatorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateZone", Selector = "newZone:", ReturnType = typeof(IMDLMeshBufferZone), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateZone", Selector = "newZoneForBuffersWithSize:andType:", ReturnType = typeof(IMDLMeshBufferZone), ParameterType = new Type[]
{
	typeof(NSNumber[]),
	typeof(NSNumber[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBuffer:type:", ReturnType = typeof(IMDLMeshBuffer), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MDLMeshBufferType)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithData:type:", ReturnType = typeof(IMDLMeshBuffer), ParameterType = new Type[]
{
	typeof(NSData),
	typeof(MDLMeshBufferType)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferFromZone:length:type:", ReturnType = typeof(IMDLMeshBuffer), ParameterType = new Type[]
{
	typeof(IMDLMeshBufferZone),
	typeof(nuint),
	typeof(MDLMeshBufferType)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferFromZone:data:type:", ReturnType = typeof(IMDLMeshBuffer), ParameterType = new Type[]
{
	typeof(IMDLMeshBufferZone),
	typeof(NSData),
	typeof(MDLMeshBufferType)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IMDLMeshBufferAllocator : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newZone:")]
	[Preserve(Conditional = true)]
	IMDLMeshBufferZone CreateZone(nuint capacity);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newZoneForBuffersWithSize:andType:")]
	[Preserve(Conditional = true)]
	IMDLMeshBufferZone CreateZone(NSNumber[] sizes, NSNumber[] types);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBuffer:type:")]
	[Preserve(Conditional = true)]
	IMDLMeshBuffer CreateBuffer(nuint length, MDLMeshBufferType type);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferWithData:type:")]
	[Preserve(Conditional = true)]
	IMDLMeshBuffer CreateBuffer(NSData data, MDLMeshBufferType type);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferFromZone:length:type:")]
	[Preserve(Conditional = true)]
	IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferFromZone:data:type:")]
	[Preserve(Conditional = true)]
	IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type);
}
