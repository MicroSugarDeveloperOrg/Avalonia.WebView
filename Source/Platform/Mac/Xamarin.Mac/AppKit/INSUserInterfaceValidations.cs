using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSUserInterfaceValidations", WrapperType = typeof(NSUserInterfaceValidationsWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateUserInterfaceItem", Selector = "validateUserInterfaceItem:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(INSValidatedUserInterfaceItem) }, ParameterByRef = new bool[] { false })]
public interface INSUserInterfaceValidations : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("validateUserInterfaceItem:")]
	[Preserve(Conditional = true)]
	bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem item);
}
