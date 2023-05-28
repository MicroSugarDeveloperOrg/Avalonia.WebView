using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLNamed", WrapperType = typeof(MDLNamedWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", SetterSelector = "setName:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMDLNamed : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
		[Export("setName:")]
		set;
	}
}
