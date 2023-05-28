using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNShadable", WrapperType = typeof(SCNShadableWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleBinding", Selector = "handleBindingOfSymbol:usingBlock:", ParameterType = new Type[]
{
	typeof(string),
	typeof(SCNBindingHandler)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDSCNBindingHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleUnbinding", Selector = "handleUnbindingOfSymbol:usingBlock:", ParameterType = new Type[]
{
	typeof(string),
	typeof(SCNBindingHandler)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDSCNBindingHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "WeakShaderModifiers", Selector = "shaderModifiers", PropertyType = typeof(NSDictionary), GetterSelector = "shaderModifiers", SetterSelector = "setShaderModifiers:", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Program", Selector = "program", PropertyType = typeof(SCNProgram), GetterSelector = "program", SetterSelector = "setProgram:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ISCNShadable : INativeObject, IDisposable
{
}
