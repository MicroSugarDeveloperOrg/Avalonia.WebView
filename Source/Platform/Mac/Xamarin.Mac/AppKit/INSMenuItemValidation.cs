using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSMenuItemValidation", WrapperType = typeof(NSMenuItemValidationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateMenuItem", Selector = "validateMenuItem:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSMenuItem) }, ParameterByRef = new bool[] { false })]
public interface INSMenuItemValidation : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("validateMenuItem:")]
	[Preserve(Conditional = true)]
	bool ValidateMenuItem(NSMenuItem menuItem);
}
