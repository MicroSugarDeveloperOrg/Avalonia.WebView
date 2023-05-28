using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MetalKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTKViewDelegate", WrapperType = typeof(MTKViewDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DrawableSizeWillChange", Selector = "mtkView:drawableSizeWillChange:", ParameterType = new Type[]
{
	typeof(MTKView),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Draw", Selector = "drawInMTKView:", ParameterType = new Type[] { typeof(MTKView) }, ParameterByRef = new bool[] { false })]
public interface IMTKViewDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("mtkView:drawableSizeWillChange:")]
	[Preserve(Conditional = true)]
	void DrawableSizeWillChange(MTKView view, CGSize size);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("drawInMTKView:")]
	[Preserve(Conditional = true)]
	void Draw(MTKView view);
}
