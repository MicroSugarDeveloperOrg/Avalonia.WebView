using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNTechniqueSupport", WrapperType = typeof(SCNTechniqueSupportWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Technique", Selector = "technique", PropertyType = typeof(SCNTechnique), GetterSelector = "technique", SetterSelector = "setTechnique:", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface ISCNTechniqueSupport : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	SCNTechnique? Technique
	{
		[Export("technique", ArgumentSemantic.Copy)]
		get;
		[Export("setTechnique:", ArgumentSemantic.Copy)]
		set;
	}
}
