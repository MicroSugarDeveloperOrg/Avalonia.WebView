using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "DOMEventListener", WrapperType = typeof(DomEventListenerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "handleEvent:", ParameterType = new Type[] { typeof(DomEvent) }, ParameterByRef = new bool[] { false })]
public interface IDomEventListener : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleEvent:")]
	[Preserve(Conditional = true)]
	void HandleEvent(DomEvent evt);
}
