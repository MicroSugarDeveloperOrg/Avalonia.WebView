using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSAttributeType : ulong
{
	Undefined = 0uL,
	Integer16 = 100uL,
	Integer32 = 200uL,
	Integer64 = 300uL,
	Decimal = 400uL,
	Double = 500uL,
	Float = 600uL,
	String = 700uL,
	Boolean = 800uL,
	Date = 900uL,
	Binary = 1000uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	Uuid = 1100uL,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	Uri = 1200uL,
	Transformable = 1800uL,
	ObjectID = 2000uL
}
