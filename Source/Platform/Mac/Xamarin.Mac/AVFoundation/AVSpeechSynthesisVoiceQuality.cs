using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum AVSpeechSynthesisVoiceQuality : long
{
	Default = 1L,
	Enhanced
}
