using ObjCRuntime;

namespace CoreData;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Please see the release notes and Core Data documentation.")]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Please see the release notes and Core Data documentation.")]
[Native]
public enum NSPersistentStoreUbiquitousTransitionType : ulong
{
	AccountAdded = 1uL,
	AccountRemoved,
	ContentRemoved,
	InitialImportCompleted
}
