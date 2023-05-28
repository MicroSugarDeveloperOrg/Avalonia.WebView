using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "DOMEventTarget", WrapperType = typeof(DomEventTargetWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddEventListener", Selector = "addEventListener:listener:useCapture:", ParameterType = new Type[]
{
	typeof(string),
	typeof(IDomEventListener),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveEventListener", Selector = "removeEventListener:listener:useCapture:", ParameterType = new Type[]
{
	typeof(string),
	typeof(IDomEventListener),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DispatchEvent", Selector = "dispatchEvent:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(DomEvent) }, ParameterByRef = new bool[] { false })]
public interface IDomEventTarget : INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("addEventListener:listener:useCapture:")]
	[Preserve(Conditional = true)]
	void AddEventListener(string type, IDomEventListener listener, bool useCapture);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeEventListener:listener:useCapture:")]
	[Preserve(Conditional = true)]
	void RemoveEventListener(string type, IDomEventListener listener, bool useCapture);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("dispatchEvent:")]
	[Preserve(Conditional = true)]
	bool DispatchEvent(DomEvent evt);
}
