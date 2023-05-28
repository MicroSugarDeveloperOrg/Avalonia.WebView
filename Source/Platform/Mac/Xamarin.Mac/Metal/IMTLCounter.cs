using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCounter", WrapperType = typeof(MTLCounterWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCounter : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
	}
}
