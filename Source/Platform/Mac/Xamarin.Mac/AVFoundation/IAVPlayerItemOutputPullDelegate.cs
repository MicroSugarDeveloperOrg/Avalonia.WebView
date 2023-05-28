using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "AVPlayerItemOutputPullDelegate", WrapperType = typeof(AVPlayerItemOutputPullDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OutputMediaDataWillChange", Selector = "outputMediaDataWillChange:", ParameterType = new Type[] { typeof(AVPlayerItemOutput) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "OutputSequenceWasFlushed", Selector = "outputSequenceWasFlushed:", ParameterType = new Type[] { typeof(AVPlayerItemOutput) }, ParameterByRef = new bool[] { false })]
public interface IAVPlayerItemOutputPullDelegate : INativeObject, IDisposable
{
}
