using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerItemMetadataOutputPushDelegate", WrapperType = typeof(AVPlayerItemMetadataOutputPushDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputTimedMetadataGroups", Selector = "metadataOutput:didOutputTimedMetadataGroups:fromPlayerItemTrack:", ParameterType = new Type[]
{
	typeof(AVPlayerItemMetadataOutput),
	typeof(AVTimedMetadataGroup[]),
	typeof(AVPlayerItemTrack)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IAVPlayerItemMetadataOutputPushDelegate : INativeObject, IDisposable, IAVPlayerItemOutputPushDelegate
{
}
