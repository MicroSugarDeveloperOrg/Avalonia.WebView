using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "DOMNodeFilter", WrapperType = typeof(DomNodeFilterWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "AcceptNode", Selector = "acceptNode:", ReturnType = typeof(short), ParameterType = new Type[] { typeof(DomNode) }, ParameterByRef = new bool[] { false })]
public interface IDomNodeFilter : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("acceptNode:")]
	[Preserve(Conditional = true)]
	short AcceptNode(DomNode n);
}
