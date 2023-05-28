using ObjCRuntime;

namespace CoreText;

public enum CTFontManagerScope : uint
{
	None = 0u,
	Process = 1u,
	[iOS(13, 0)]
	[TV(13, 0)]
	[Watch(6, 0)]
	Persistent = 2u,
	[NoiOS]
	[NoTV]
	[NoWatch]
	Session = 3u,
	[NoiOS]
	[NoTV]
	[NoWatch]
	User = 2u
}
