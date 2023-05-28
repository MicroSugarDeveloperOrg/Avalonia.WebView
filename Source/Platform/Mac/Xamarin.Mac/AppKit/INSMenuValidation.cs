using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSMenuValidation", WrapperType = typeof(NSMenuValidationWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateMenuItem", Selector = "validateMenuItem:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSMenuItem) }, ParameterByRef = new bool[] { false })]
public interface INSMenuValidation : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("validateMenuItem:")]
	[Preserve(Conditional = true)]
	bool ValidateMenuItem(NSMenuItem menuItem);
}
