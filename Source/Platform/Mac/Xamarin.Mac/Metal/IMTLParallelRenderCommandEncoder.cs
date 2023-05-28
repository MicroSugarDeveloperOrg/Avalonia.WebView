using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLParallelRenderCommandEncoder", WrapperType = typeof(MTLParallelRenderCommandEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderCommandEncoder", Selector = "renderCommandEncoder", ReturnType = typeof(IMTLRenderCommandEncoder))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetColorStoreAction", Selector = "setColorStoreAction:atIndex:", ParameterType = new Type[]
{
	typeof(MTLStoreAction),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDepthStoreAction", Selector = "setDepthStoreAction:", ParameterType = new Type[] { typeof(MTLStoreAction) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStencilStoreAction", Selector = "setStencilStoreAction:", ParameterType = new Type[] { typeof(MTLStoreAction) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetColorStoreActionOptions", Selector = "setColorStoreActionOptions:atIndex:", ParameterType = new Type[]
{
	typeof(MTLStoreActionOptions),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetDepthStoreActionOptions", Selector = "setDepthStoreActionOptions:", ParameterType = new Type[] { typeof(MTLStoreActionOptions) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStencilStoreActionOptions", Selector = "setStencilStoreActionOptions:", ParameterType = new Type[] { typeof(MTLStoreActionOptions) }, ParameterByRef = new bool[] { false })]
public interface IMTLParallelRenderCommandEncoder : INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("renderCommandEncoder")]
	[Preserve(Conditional = true)]
	IMTLRenderCommandEncoder? CreateRenderCommandEncoder();
}
