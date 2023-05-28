using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSStreamDelegate", WrapperType = typeof(NSStreamDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "stream:handleEvent:", ParameterType = new Type[]
{
	typeof(NSStream),
	typeof(NSStreamEvent)
}, ParameterByRef = new bool[] { false, false })]
public interface INSStreamDelegate : INativeObject, IDisposable
{
}
