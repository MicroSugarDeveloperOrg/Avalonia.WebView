using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSToolbarItemValidation", WrapperType = typeof(NSToolbarItemValidationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValidateToolbarItem", Selector = "validateToolbarItem:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSToolbarItem) }, ParameterByRef = new bool[] { false })]
public interface INSToolbarItemValidation : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("validateToolbarItem:")]
	[Preserve(Conditional = true)]
	bool ValidateToolbarItem(NSToolbarItem item);
}
