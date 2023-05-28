using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLEvent", WrapperType = typeof(MTLEventWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLEvent : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice? Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string? Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}
}
