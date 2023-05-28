using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSXPCListenerDelegate", WrapperType = typeof(NSXpcListenerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldAcceptConnection", Selector = "listener:shouldAcceptNewConnection:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSXpcListener),
	typeof(NSXpcConnection)
}, ParameterByRef = new bool[] { false, false })]
public interface INSXpcListenerDelegate : INativeObject, IDisposable
{
}
