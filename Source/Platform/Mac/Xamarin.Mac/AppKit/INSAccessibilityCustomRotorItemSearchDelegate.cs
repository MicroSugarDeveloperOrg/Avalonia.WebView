using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "NSAccessibilityCustomRotorItemSearchDelegate", WrapperType = typeof(NSAccessibilityCustomRotorItemSearchDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetResult", Selector = "rotor:resultForSearchParameters:", ReturnType = typeof(NSAccessibilityCustomRotorItemResult), ParameterType = new Type[]
{
	typeof(NSAccessibilityCustomRotor),
	typeof(NSAccessibilityCustomRotorSearchParameters)
}, ParameterByRef = new bool[] { false, false })]
public interface INSAccessibilityCustomRotorItemSearchDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("rotor:resultForSearchParameters:")]
	[Preserve(Conditional = true)]
	NSAccessibilityCustomRotorItemResult? GetResult(NSAccessibilityCustomRotor rotor, NSAccessibilityCustomRotorSearchParameters searchParameters);
}
