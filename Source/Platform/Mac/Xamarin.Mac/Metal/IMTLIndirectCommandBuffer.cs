using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLIndirectCommandBuffer", WrapperType = typeof(MTLIndirectCommandBufferWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Reset", Selector = "resetWithRange:", ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCommand", Selector = "indirectRenderCommandAtIndex:", ReturnType = typeof(IMTLIndirectRenderCommand), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Size", Selector = "size", PropertyType = typeof(nuint), GetterSelector = "size", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLIndirectCommandBuffer : INativeObject, IDisposable, IMTLResource
{
	[Preserve(Conditional = true)]
	nuint Size
	{
		[Export("size")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("resetWithRange:")]
	[Preserve(Conditional = true)]
	void Reset(NSRange range);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("indirectRenderCommandAtIndex:")]
	[Preserve(Conditional = true)]
	IMTLIndirectRenderCommand GetCommand(nuint commandIndex);
}
