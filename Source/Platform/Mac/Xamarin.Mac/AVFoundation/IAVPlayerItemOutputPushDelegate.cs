using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerItemOutputPushDelegate", WrapperType = typeof(AVPlayerItemOutputPushDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OutputSequenceWasFlushed", Selector = "outputSequenceWasFlushed:", ParameterType = new Type[] { typeof(AVPlayerItemOutput) }, ParameterByRef = new bool[] { false })]
public interface IAVPlayerItemOutputPushDelegate : INativeObject, IDisposable
{
}
