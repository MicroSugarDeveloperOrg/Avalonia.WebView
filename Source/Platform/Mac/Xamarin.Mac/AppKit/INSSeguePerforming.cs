using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NSSeguePerforming", WrapperType = typeof(NSSeguePerformingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForSegue", Selector = "prepareForSegue:sender:", ParameterType = new Type[]
{
	typeof(NSStoryboardSegue),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformSegue", Selector = "performSegueWithIdentifier:sender:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldPerformSegue", Selector = "shouldPerformSegueWithIdentifier:sender:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(string),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
public interface INSSeguePerforming : INativeObject, IDisposable
{
}
