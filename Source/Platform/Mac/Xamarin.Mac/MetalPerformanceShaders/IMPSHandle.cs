using System;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MPSHandle", WrapperType = typeof(MPSHandleWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMPSHandle : INativeObject, IDisposable, INSCoding
{
	[Preserve(Conditional = true)]
	string? Label
	{
		[Export("label")]
		get;
	}
}
