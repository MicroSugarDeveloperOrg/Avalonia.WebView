using ObjCRuntime;

namespace Speech;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum SFSpeechRecognitionTaskHint : long
{
	Unspecified,
	Dictation,
	Search,
	Confirmation
}
