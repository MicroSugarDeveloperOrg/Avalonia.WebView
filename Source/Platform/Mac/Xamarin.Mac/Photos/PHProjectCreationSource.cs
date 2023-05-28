using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Native]
public enum PHProjectCreationSource : long
{
	Undefined = 0L,
	UserSelection = 1L,
	Album = 2L,
	Memory = 3L,
	Moment = 4L,
	Project = 20L,
	ProjectBook = 21L,
	ProjectCalendar = 22L,
	ProjectCard = 23L,
	ProjectPrintOrder = 24L,
	ProjectSlideshow = 25L,
	ProjectExtension = 26L
}
