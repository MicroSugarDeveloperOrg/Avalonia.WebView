using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLArgumentEncoder", WrapperType = typeof(MTLArgumentEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentBuffer", Selector = "setArgumentBuffer:offset:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetArgumentBuffer", Selector = "setArgumentBuffer:startOffset:arrayElement:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffer", Selector = "setBuffer:offset:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBuffers", Selector = "setBuffers:offsets:withRange:", ParameterType = new Type[]
{
	typeof(IMTLBuffer[]),
	typeof(IntPtr),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTexture", Selector = "setTexture:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLTexture),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetTextures", Selector = "setTextures:withRange:", ParameterType = new Type[]
{
	typeof(IMTLTexture[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerState", Selector = "setSamplerState:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetSamplerStates", Selector = "setSamplerStates:withRange:", ParameterType = new Type[]
{
	typeof(IMTLSamplerState[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetConstantData", Selector = "constantDataAtIndex:", ReturnType = typeof(IntPtr), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineState", Selector = "setRenderPipelineState:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLRenderPipelineState),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetRenderPipelineStates", Selector = "setRenderPipelineStates:withRange:", ParameterType = new Type[]
{
	typeof(IMTLRenderPipelineState[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetIndirectCommandBuffer", Selector = "setIndirectCommandBuffer:atIndex:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetIndirectCommandBuffers", Selector = "setIndirectCommandBuffers:withRange:", ParameterType = new Type[]
{
	typeof(IMTLIndirectCommandBuffer[]),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderForBufferAtIndex:", ReturnType = typeof(IMTLArgumentEncoder), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "EncodedLength", Selector = "encodedLength", PropertyType = typeof(nuint), GetterSelector = "encodedLength", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Alignment", Selector = "alignment", PropertyType = typeof(nuint), GetterSelector = "alignment", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLArgumentEncoder : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string? Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}

	[Preserve(Conditional = true)]
	nuint EncodedLength
	{
		[Export("encodedLength")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint Alignment
	{
		[Export("alignment")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setArgumentBuffer:offset:")]
	[Preserve(Conditional = true)]
	void SetArgumentBuffer(IMTLBuffer? argumentBuffer, nuint offset);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setArgumentBuffer:startOffset:arrayElement:")]
	[Preserve(Conditional = true)]
	void SetArgumentBuffer(IMTLBuffer? argumentBuffer, nuint startOffset, nuint arrayElement);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBuffer:offset:atIndex:")]
	[Preserve(Conditional = true)]
	void SetBuffer(IMTLBuffer? buffer, nuint offset, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setBuffers:offsets:withRange:")]
	[Preserve(Conditional = true)]
	void SetBuffers(IMTLBuffer[] buffers, IntPtr offsets, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setTexture:atIndex:")]
	[Preserve(Conditional = true)]
	void SetTexture(IMTLTexture? texture, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setTextures:withRange:")]
	[Preserve(Conditional = true)]
	void SetTextures(IMTLTexture[] textures, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerState:atIndex:")]
	[Preserve(Conditional = true)]
	void SetSamplerState(IMTLSamplerState? sampler, nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setSamplerStates:withRange:")]
	[Preserve(Conditional = true)]
	void SetSamplerStates(IMTLSamplerState[] samplers, NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("constantDataAtIndex:")]
	[Preserve(Conditional = true)]
	IntPtr GetConstantData(nuint index);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newArgumentEncoderForBufferAtIndex:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLArgumentEncoder? CreateArgumentEncoder(nuint index);
}
