using ObjCRuntime;

namespace MediaLibrary;

[Native]
public enum MLMediaType : ulong
{
	Audio = 1uL,
	Image = 2uL,
	Movie = 4uL
}
