using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLBlitCommandEncoder", WrapperType = typeof(MTLBlitCommandEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Synchronize", Selector = "synchronizeResource:", ParameterType = new Type[] { typeof(IMTLResource) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Synchronize", Selector = "synchronizeTexture:slice:level:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin),
	typeof(MTLSize),
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLSize),
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:options:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLSize),
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin),
	typeof(MTLBlitOption)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin),
	typeof(MTLSize),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CopyFromTexture", Selector = "copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:options:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLOrigin),
	typeof(MTLSize),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLBlitOption)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GenerateMipmapsForTexture", Selector = "generateMipmapsForTexture:", ParameterType = new Type[] { typeof(IMTLTexture) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FillBuffer", Selector = "fillBuffer:range:value:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(NSRange),
	typeof(byte)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyFromBuffer", Selector = "copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:", ParameterType = new Type[] { typeof(IMTLFence) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:", ParameterType = new Type[] { typeof(IMTLFence) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:", ParameterType = new Type[] { typeof(IMTLTexture) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForGpuAccess", Selector = "optimizeContentsForGPUAccess:slice:level:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:", ParameterType = new Type[] { typeof(IMTLTexture) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OptimizeContentsForCpuAccess", Selector = "optimizeContentsForCPUAccess:slice:level:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetCommands", Selector = "resetCommandsInBuffer:withRange:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyIndirectCommandBuffer:sourceRange:destination:destinationIndex:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(NSRange),
	typeof(IMTLIndirectCommandBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Optimize", Selector = "optimizeIndirectCommandBuffer:withRange:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyFromTexture:sourceSlice:sourceLevel:toTexture:destinationSlice:destinationLevel:sliceCount:levelCount:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(IMTLTexture),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyFromTexture:toTexture:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(IMTLTexture)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SampleCounters", Selector = "sampleCountersInBuffer:atSampleIndex:withBarrier:", ParameterType = new Type[]
{
	typeof(MTLCounterSampleBuffer),
	typeof(nuint),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCounters", Selector = "resolveCounters:inRange:destinationBuffer:destinationOffset:", ParameterType = new Type[]
{
	typeof(MTLCounterSampleBuffer),
	typeof(NSRange),
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IMTLBlitCommandEncoder : INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("synchronizeResource:")]
	[Preserve(Conditional = true)]
	void Synchronize(IMTLResource resource);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("synchronizeTexture:slice:level:")]
	[Preserve(Conditional = true)]
	void Synchronize(IMTLTexture texture, nuint slice, nuint level);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
	[Preserve(Conditional = true)]
	void CopyFromTexture(IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyFromBuffer:sourceOffset:sourceBytesPerRow:sourceBytesPerImage:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
	[Preserve(Conditional = true)]
	void CopyFromBuffer(IMTLBuffer sourceBuffer, nuint sourceOffset, nuint sourceBytesPerRow, nuint sourceBytesPerImage, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toBuffer:destinationOffset:destinationBytesPerRow:destinationBytesPerImage:")]
	[Preserve(Conditional = true)]
	void CopyFromTexture(IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint destinatinBytesPerRow, nuint destinationBytesPerImage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("generateMipmapsForTexture:")]
	[Preserve(Conditional = true)]
	void GenerateMipmapsForTexture(IMTLTexture texture);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("fillBuffer:range:value:")]
	[Preserve(Conditional = true)]
	void FillBuffer(IMTLBuffer buffer, NSRange range, byte value);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyFromBuffer:sourceOffset:toBuffer:destinationOffset:size:")]
	[Preserve(Conditional = true)]
	void CopyFromBuffer(IMTLBuffer sourceBuffer, nuint sourceOffset, IMTLBuffer destinationBuffer, nuint destinationOffset, nuint size);
}
