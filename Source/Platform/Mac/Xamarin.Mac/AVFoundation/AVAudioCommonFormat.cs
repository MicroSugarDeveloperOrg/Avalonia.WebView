using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVAudioCommonFormat : ulong
{
    Other,
    PCMFloat32,
    PCMFloat64,
    PCMInt16,
    PCMInt32
}
