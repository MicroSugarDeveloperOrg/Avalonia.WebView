using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLHeap", WrapperType = typeof(MTLHeapWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMaxAvailableSize", Selector = "maxAvailableSizeWithAlignment:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLResourceOptions)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(MTLTextureDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetPurgeableState", Selector = "setPurgeableState:", ReturnType = typeof(MTLPurgeableState), ParameterType = new Type[] { typeof(MTLPurgeableState) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:offset:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLResourceOptions),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:offset:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[]
{
	typeof(MTLTextureDescriptor),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "StorageMode", Selector = "storageMode", PropertyType = typeof(MTLStorageMode), GetterSelector = "storageMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CpuCacheMode", Selector = "cpuCacheMode", PropertyType = typeof(MTLCpuCacheMode), GetterSelector = "cpuCacheMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof(nuint), GetterSelector = "size", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "UsedSize", Selector = "usedSize", PropertyType = typeof(nuint), GetterSelector = "usedSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentAllocatedSize", Selector = "currentAllocatedSize", PropertyType = typeof(nuint), GetterSelector = "currentAllocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HazardTrackingMode", Selector = "hazardTrackingMode", PropertyType = typeof(MTLHazardTrackingMode), GetterSelector = "hazardTrackingMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ResourceOptions", Selector = "resourceOptions", PropertyType = typeof(MTLResourceOptions), GetterSelector = "resourceOptions", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof(MTLHeapType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLHeap : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string? Label
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
	MTLStorageMode StorageMode
	{
		[Export("storageMode")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint Size
	{
		[Export("size")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint UsedSize
	{
		[Export("usedSize")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("maxAvailableSizeWithAlignment:")]
	[Preserve(Conditional = true)]
	nuint GetMaxAvailableSize(nuint alignment);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferWithLength:options:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLBuffer? CreateBuffer(nuint length, MTLResourceOptions options);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newTextureWithDescriptor:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLTexture? CreateTexture(MTLTextureDescriptor desc);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setPurgeableState:")]
	[Preserve(Conditional = true)]
	MTLPurgeableState SetPurgeableState(MTLPurgeableState state);
}
