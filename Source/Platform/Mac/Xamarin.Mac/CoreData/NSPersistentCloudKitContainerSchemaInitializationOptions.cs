using System;
using ObjCRuntime;

namespace CoreData;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Flags]
[Native]
public enum NSPersistentCloudKitContainerSchemaInitializationOptions : ulong
{
	None = 0uL,
	DryRun = 2uL,
	PrintSchema = 4uL
}
