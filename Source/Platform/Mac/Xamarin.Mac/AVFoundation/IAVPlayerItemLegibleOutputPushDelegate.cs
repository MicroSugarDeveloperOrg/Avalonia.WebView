using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerItemLegibleOutputPushDelegate", WrapperType = typeof(AVPlayerItemLegibleOutputPushDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputAttributedStrings", Selector = "legibleOutput:didOutputAttributedStrings:nativeSampleBuffers:forItemTime:", ParameterType = new Type[]
{
	typeof(AVPlayerItemLegibleOutput),
	typeof(NSAttributedString[]),
	typeof(CMSampleBuffer[]),
	typeof(CMTime)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface IAVPlayerItemLegibleOutputPushDelegate : INativeObject, IDisposable, IAVPlayerItemOutputPushDelegate
{
}
