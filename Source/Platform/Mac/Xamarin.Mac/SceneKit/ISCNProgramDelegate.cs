using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNProgramDelegate", WrapperType = typeof(SCNProgramDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BindValue", Selector = "program:bindValueForSymbol:atLocation:programID:renderer:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(SCNProgram),
	typeof(string),
	typeof(uint),
	typeof(uint),
	typeof(SCNRenderer)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnbindValue", Selector = "program:unbindValueForSymbol:atLocation:programID:renderer:", ParameterType = new Type[]
{
	typeof(SCNProgram),
	typeof(string),
	typeof(uint),
	typeof(uint),
	typeof(SCNRenderer)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleError", Selector = "program:handleError:", ParameterType = new Type[]
{
	typeof(SCNProgram),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsProgramOpaque", Selector = "programIsOpaque:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(SCNProgram) }, ParameterByRef = new bool[] { false })]
public interface ISCNProgramDelegate : INativeObject, IDisposable
{
}
