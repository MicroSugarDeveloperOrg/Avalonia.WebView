using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSPortDelegate", WrapperType = typeof(NSPortDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageReceived", Selector = "handlePortMessage:", ParameterType = new Type[] { typeof(NSPortMessage) }, ParameterByRef = new bool[] { false })]
public interface INSPortDelegate : INativeObject, IDisposable
{
}
