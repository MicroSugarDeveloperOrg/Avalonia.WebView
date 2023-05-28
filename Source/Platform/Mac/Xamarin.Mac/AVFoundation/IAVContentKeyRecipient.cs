using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "AVContentKeyRecipient", WrapperType = typeof(AVContentKeyRecipientWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MayRequireContentKeysForMediaDataProcessing", Selector = "mayRequireContentKeysForMediaDataProcessing", PropertyType = typeof(bool), GetterSelector = "mayRequireContentKeysForMediaDataProcessing", ArgumentSemantic = ArgumentSemantic.None)]
public interface IAVContentKeyRecipient : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool MayRequireContentKeysForMediaDataProcessing
	{
		[Export("mayRequireContentKeysForMediaDataProcessing")]
		get;
	}
}
