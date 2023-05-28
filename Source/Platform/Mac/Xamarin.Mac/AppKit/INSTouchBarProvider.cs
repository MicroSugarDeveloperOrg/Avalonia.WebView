using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "NSTouchBarProvider", WrapperType = typeof(NSTouchBarProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TouchBar", Selector = "touchBar", PropertyType = typeof(NSTouchBar), GetterSelector = "touchBar", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface INSTouchBarProvider : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSTouchBar? TouchBar
	{
		[Export("touchBar", ArgumentSemantic.Retain)]
		get;
	}
}
