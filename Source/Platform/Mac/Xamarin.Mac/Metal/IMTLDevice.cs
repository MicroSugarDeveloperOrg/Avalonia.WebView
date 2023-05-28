using System.ComponentModel;
using Foundation;
using IOSurface;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLDevice", WrapperType = typeof(MTLDeviceWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHeapTextureSizeAndAlign", Selector = "heapTextureSizeAndAlignWithDescriptor:", ReturnType = typeof(MTLSizeAndAlign), ParameterType = new Type[] { typeof(MTLTextureDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetHeapBufferSizeAndAlignWithLength", Selector = "heapBufferSizeAndAlignWithLength:options:", ReturnType = typeof(MTLSizeAndAlign), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLResourceOptions)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateHeap", Selector = "newHeapWithDescriptor:", ReturnType = typeof(IMTLHeap), ParameterType = new Type[] { typeof(MTLHeapDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandQueue", Selector = "newCommandQueue", ReturnType = typeof(IMTLCommandQueue))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateCommandQueue", Selector = "newCommandQueueWithMaxCommandBufferCount:", ReturnType = typeof(IMTLCommandQueue), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithLength:options:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLResourceOptions)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBuffer", Selector = "newBufferWithBytes:length:options:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(MTLResourceOptions)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBufferNoCopy", Selector = "newBufferWithBytesNoCopy:length:options:deallocator:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(MTLResourceOptions),
	typeof(MTLDeallocator)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDMTLDeallocator)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDepthStencilState", Selector = "newDepthStencilStateWithDescriptor:", ReturnType = typeof(IMTLDepthStencilState), ParameterType = new Type[] { typeof(MTLDepthStencilDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(MTLTextureDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:iosurface:plane:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[]
{
	typeof(MTLTextureDescriptor),
	typeof(global::IOSurface.IOSurface),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateSharedTexture", Selector = "newSharedTextureWithDescriptor:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(MTLTextureDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateSharedTexture", Selector = "newSharedTextureWithHandle:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(MTLSharedTextureHandle) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSamplerState", Selector = "newSamplerStateWithDescriptor:", ReturnType = typeof(IMTLSamplerState), ParameterType = new Type[] { typeof(MTLSamplerDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDefaultLibrary", Selector = "newDefaultLibrary", ReturnType = typeof(IMTLLibrary))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithFile:error:", ReturnType = typeof(IMTLLibrary), ParameterType = new Type[]
{
	typeof(string),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithData:error:", ReturnType = typeof(IMTLLibrary), ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithSource:options:error:", ReturnType = typeof(IMTLLibrary), ParameterType = new Type[]
{
	typeof(string),
	typeof(MTLCompileOptions),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithSource:options:completionHandler:", ParameterType = new Type[]
{
	typeof(string),
	typeof(MTLCompileOptions),
	typeof(Action<IMTLLibrary, NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity2V67)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newDefaultLibraryWithBundle:error:", ReturnType = typeof(IMTLLibrary), ParameterType = new Type[]
{
	typeof(NSBundle),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:error:", ReturnType = typeof(IMTLRenderPipelineState), ParameterType = new Type[]
{
	typeof(MTLRenderPipelineDescriptor),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:completionHandler:", ParameterType = new Type[]
{
	typeof(MTLRenderPipelineDescriptor),
	typeof(Action<IMTLRenderPipelineState, NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity2V68)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:options:reflection:error:", ReturnType = typeof(IMTLRenderPipelineState), ParameterType = new Type[]
{
	typeof(MTLRenderPipelineDescriptor),
	typeof(MTLPipelineOption),
	typeof(MTLRenderPipelineReflection),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:options:completionHandler:", ParameterType = new Type[]
{
	typeof(MTLRenderPipelineDescriptor),
	typeof(MTLPipelineOption),
	typeof(Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity3V2)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:options:reflection:error:", ReturnType = typeof(IMTLComputePipelineState), ParameterType = new Type[]
{
	typeof(IMTLFunction),
	typeof(MTLPipelineOption),
	typeof(MTLComputePipelineReflection),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:completionHandler:", ParameterType = new Type[]
{
	typeof(IMTLFunction),
	typeof(Action<IMTLComputePipelineState, NSError>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity2V69)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:error:", ReturnType = typeof(IMTLComputePipelineState), ParameterType = new Type[]
{
	typeof(IMTLFunction),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithFunction:options:completionHandler:", ParameterType = new Type[]
{
	typeof(IMTLFunction),
	typeof(MTLPipelineOption),
	typeof(Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity3V3)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:options:reflection:error:", ReturnType = typeof(IMTLComputePipelineState), ParameterType = new Type[]
{
	typeof(MTLComputePipelineDescriptor),
	typeof(MTLPipelineOption),
	typeof(MTLComputePipelineReflection),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:options:completionHandler:", ParameterType = new Type[]
{
	typeof(MTLComputePipelineDescriptor),
	typeof(MTLPipelineOption),
	typeof(MTLNewComputePipelineStateWithReflectionCompletionHandler)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateFence", Selector = "newFence", ReturnType = typeof(IMTLFence))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SupportsFeatureSet", Selector = "supportsFeatureSet:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MTLFeatureSet) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsTextureSampleCount", Selector = "supportsTextureSampleCount:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithURL:error:", ReturnType = typeof(IMTLLibrary), ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMinimumLinearTextureAlignment", Selector = "minimumLinearTextureAlignmentForPixelFormat:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(MTLPixelFormat) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMinimumTextureBufferAlignment", Selector = "minimumTextureBufferAlignmentForPixelFormat:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(MTLPixelFormat) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDefaultSamplePositions", Selector = "getDefaultSamplePositions:count:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithArguments:", ReturnType = typeof(IMTLArgumentEncoder), ParameterType = new Type[] { typeof(MTLArgumentDescriptor[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateIndirectCommandBuffer", Selector = "newIndirectCommandBufferWithDescriptor:maxCommandCount:options:", ReturnType = typeof(IMTLIndirectCommandBuffer), ParameterType = new Type[]
{
	typeof(MTLIndirectCommandBufferDescriptor),
	typeof(nuint),
	typeof(MTLResourceOptions)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateEvent", Selector = "newEvent", ReturnType = typeof(IMTLEvent))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateSharedEvent", Selector = "newSharedEvent", ReturnType = typeof(IMTLSharedEvent))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateSharedEvent", Selector = "newSharedEventWithHandle:", ReturnType = typeof(IMTLSharedEvent), ParameterType = new Type[] { typeof(MTLSharedEventHandle) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsVertexAmplification", Selector = "supportsVertexAmplificationCount:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsRasterizationRateMap", Selector = "supportsRasterizationRateMapWithLayerCount:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateRasterizationRateMap", Selector = "newRasterizationRateMapWithDescriptor:", ReturnType = typeof(IMTLRasterizationRateMap), ParameterType = new Type[] { typeof(MTLRasterizationRateMapDescriptor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsFamily", Selector = "supportsFamily:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(MTLGpuFamily) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateCounterSampleBuffer", Selector = "newCounterSampleBufferWithDescriptor:error:", ReturnType = typeof(MTLCounterSampleBuffer), ParameterType = new Type[]
{
	typeof(MTLCounterSampleBufferDescriptor),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSampleTimestamps", Selector = "sampleTimestamps:gpuTimestamp:", ParameterType = new Type[]
{
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxThreadsPerThreadgroup", Selector = "maxThreadsPerThreadgroup", PropertyType = typeof(MTLSize), GetterSelector = "maxThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "LowPower", Selector = "lowPower", PropertyType = typeof(bool), GetterSelector = "isLowPower", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Headless", Selector = "headless", PropertyType = typeof(bool), GetterSelector = "isHeadless", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RecommendedMaxWorkingSetSize", Selector = "recommendedMaxWorkingSetSize", PropertyType = typeof(ulong), GetterSelector = "recommendedMaxWorkingSetSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Depth24Stencil8PixelFormatSupported", Selector = "depth24Stencil8PixelFormatSupported", PropertyType = typeof(bool), GetterSelector = "isDepth24Stencil8PixelFormatSupported", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Removable", Selector = "removable", PropertyType = typeof(bool), GetterSelector = "isRemovable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ReadWriteTextureSupport", Selector = "readWriteTextureSupport", PropertyType = typeof(MTLReadWriteTextureTier), GetterSelector = "readWriteTextureSupport", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ArgumentBuffersSupport", Selector = "argumentBuffersSupport", PropertyType = typeof(MTLArgumentBuffersTier), GetterSelector = "argumentBuffersSupport", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RasterOrderGroupsSupported", Selector = "rasterOrderGroupsSupported", PropertyType = typeof(bool), GetterSelector = "areRasterOrderGroupsSupported", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxThreadgroupMemoryLength", Selector = "maxThreadgroupMemoryLength", PropertyType = typeof(nuint), GetterSelector = "maxThreadgroupMemoryLength", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxArgumentBufferSamplerCount", Selector = "maxArgumentBufferSamplerCount", PropertyType = typeof(nuint), GetterSelector = "maxArgumentBufferSamplerCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ProgrammableSamplePositionsSupported", Selector = "programmableSamplePositionsSupported", PropertyType = typeof(bool), GetterSelector = "areProgrammableSamplePositionsSupported", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxBufferLength", Selector = "maxBufferLength", PropertyType = typeof(nuint), GetterSelector = "maxBufferLength", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RegistryId", Selector = "registryID", PropertyType = typeof(ulong), GetterSelector = "registryID", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CurrentAllocatedSize", Selector = "currentAllocatedSize", PropertyType = typeof(nuint), GetterSelector = "currentAllocatedSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasUnifiedMemory", Selector = "hasUnifiedMemory", PropertyType = typeof(bool), GetterSelector = "hasUnifiedMemory", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "BarycentricCoordsSupported", Selector = "barycentricCoordsSupported", PropertyType = typeof(bool), GetterSelector = "areBarycentricCoordsSupported", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SupportsShaderBarycentricCoordinates", Selector = "supportsShaderBarycentricCoordinates", PropertyType = typeof(bool), GetterSelector = "supportsShaderBarycentricCoordinates", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PeerIndex", Selector = "peerIndex", PropertyType = typeof(uint), GetterSelector = "peerIndex", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PeerCount", Selector = "peerCount", PropertyType = typeof(uint), GetterSelector = "peerCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "CounterSets", Selector = "counterSets", PropertyType = typeof(MTLCounterSet[]), GetterSelector = "counterSets", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PeerGroupId", Selector = "peerGroupID", PropertyType = typeof(ulong), GetterSelector = "peerGroupID", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MaxTransferRate", Selector = "maxTransferRate", PropertyType = typeof(ulong), GetterSelector = "maxTransferRate", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "location", PropertyType = typeof(MTLDeviceLocation), GetterSelector = "location", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "LocationNumber", Selector = "locationNumber", PropertyType = typeof(nuint), GetterSelector = "locationNumber", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLDevice : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newCommandQueue")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLCommandQueue? CreateCommandQueue();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newCommandQueueWithMaxCommandBufferCount:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLCommandQueue? CreateCommandQueue(nuint maxCommandBufferCount);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferWithLength:options:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLBuffer? CreateBuffer(nuint length, MTLResourceOptions options);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferWithBytes:length:options:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLBuffer? CreateBuffer(IntPtr pointer, nuint length, MTLResourceOptions options);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newBufferWithBytesNoCopy:length:options:deallocator:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLBuffer? CreateBufferNoCopy(IntPtr pointer, nuint length, MTLResourceOptions options, [BlockProxy(typeof(Trampolines.NIDMTLDeallocator))] MTLDeallocator deallocator);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newDepthStencilStateWithDescriptor:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLDepthStencilState? CreateDepthStencilState(MTLDepthStencilDescriptor descriptor);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newTextureWithDescriptor:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLTexture? CreateTexture(MTLTextureDescriptor descriptor);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newSamplerStateWithDescriptor:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLSamplerState? CreateSamplerState(MTLSamplerDescriptor descriptor);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newDefaultLibrary")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLLibrary CreateDefaultLibrary();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newLibraryWithFile:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLLibrary CreateLibrary(string filepath, out NSError error);

	[Obsolete("Use the overload that take a 'DispatchData' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newLibraryWithData:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLLibrary CreateLibrary(NSObject data, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newLibraryWithSource:options:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLLibrary CreateLibrary(string source, MTLCompileOptions options, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newLibraryWithSource:options:completionHandler:")]
	[Preserve(Conditional = true)]
	void CreateLibrary(string source, MTLCompileOptions options, [BlockProxy(typeof(Trampolines.NIDActionArity2V67))] Action<IMTLLibrary, NSError> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newRenderPipelineStateWithDescriptor:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLRenderPipelineState CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newRenderPipelineStateWithDescriptor:completionHandler:")]
	[Preserve(Conditional = true)]
	void CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, [BlockProxy(typeof(Trampolines.NIDActionArity2V68))] Action<IMTLRenderPipelineState, NSError> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newRenderPipelineStateWithDescriptor:options:reflection:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLRenderPipelineState CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection reflection, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newRenderPipelineStateWithDescriptor:options:completionHandler:")]
	[Preserve(Conditional = true)]
	void CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy(typeof(Trampolines.NIDActionArity3V2))] Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newComputePipelineStateWithFunction:options:reflection:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLComputePipelineState CreateComputePipelineState(IMTLFunction computeFunction, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newComputePipelineStateWithFunction:completionHandler:")]
	[Preserve(Conditional = true)]
	void CreateComputePipelineState(IMTLFunction computeFunction, [BlockProxy(typeof(Trampolines.NIDActionArity2V69))] Action<IMTLComputePipelineState, NSError> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newComputePipelineStateWithFunction:error:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLComputePipelineState CreateComputePipelineState(IMTLFunction computeFunction, out NSError error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newComputePipelineStateWithFunction:options:completionHandler:")]
	[Preserve(Conditional = true)]
	void CreateComputePipelineState(IMTLFunction computeFunction, MTLPipelineOption options, [BlockProxy(typeof(Trampolines.NIDActionArity3V3))] Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> completionHandler);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("supportsFeatureSet:")]
	[Preserve(Conditional = true)]
	bool SupportsFeatureSet(MTLFeatureSet featureSet);
}
