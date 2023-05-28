using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Native]
public enum AVSpeechBoundary : long
{
	Immediate,
	Word
}
