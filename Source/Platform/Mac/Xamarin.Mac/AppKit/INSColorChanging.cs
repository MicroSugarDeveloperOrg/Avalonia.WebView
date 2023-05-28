using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSColorChanging", WrapperType = typeof(NSColorChangingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ChangeColor", Selector = "changeColor:", ParameterType = new Type[] { typeof(NSColorPanel) }, ParameterByRef = new bool[] { false })]
public interface INSColorChanging : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("changeColor:")]
	[Preserve(Conditional = true)]
	void ChangeColor(NSColorPanel? sender);
}
