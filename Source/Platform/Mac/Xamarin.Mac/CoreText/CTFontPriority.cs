using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public enum CTFontPriority : uint
{
	System = 10000u,
	Network = 20000u,
	Computer = 30000u,
	User = 40000u,
	Dynamic = 50000u,
	Process = 60000u
}
