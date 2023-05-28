using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCounterSet", WrapperType = typeof(MTLCounterSetWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Counters", Selector = "counters", PropertyType = typeof(IMTLCounter[]), GetterSelector = "counters", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface IMTLCounterSet : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLCounter[] Counters
	{
		[Export("counters", ArgumentSemantic.Copy)]
		get;
	}
}
