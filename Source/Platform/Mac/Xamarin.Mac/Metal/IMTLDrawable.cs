using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLDrawable", WrapperType = typeof(MTLDrawableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Present", Selector = "present")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Present", Selector = "presentAtTime:", ParameterType = new Type[] { typeof(double) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PresentAfter", Selector = "presentAfterMinimumDuration:", ParameterType = new Type[] { typeof(double) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPresentedHandler", Selector = "addPresentedHandler:", ParameterType = new Type[] { typeof(Action<IMTLDrawable>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V65) })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PresentedTime", Selector = "presentedTime", PropertyType = typeof(double), GetterSelector = "presentedTime", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "DrawableID", Selector = "drawableID", PropertyType = typeof(nuint), GetterSelector = "drawableID", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLDrawable : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("present")]
	[Preserve(Conditional = true)]
	void Present();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("presentAtTime:")]
	[Preserve(Conditional = true)]
	void Present(double presentationTime);
}
