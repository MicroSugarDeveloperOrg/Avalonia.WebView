using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSMachPortDelegate", WrapperType = typeof(NSMachPortDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MachMessageReceived", Selector = "handleMachMessage:", ParameterType = new Type[] { typeof(IntPtr) }, ParameterByRef = new bool[] { false })]
public interface INSMachPortDelegate : INativeObject, IDisposable, INSPortDelegate
{
}
