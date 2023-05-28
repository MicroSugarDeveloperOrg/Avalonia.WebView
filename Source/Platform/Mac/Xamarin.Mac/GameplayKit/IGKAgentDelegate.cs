using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "GKAgentDelegate", WrapperType = typeof(GKAgentDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentWillUpdate", Selector = "agentWillUpdate:", ParameterType = new Type[] { typeof(GKAgent) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentDidUpdate", Selector = "agentDidUpdate:", ParameterType = new Type[] { typeof(GKAgent) }, ParameterByRef = new bool[] { false })]
public interface IGKAgentDelegate : INativeObject, IDisposable
{
}
