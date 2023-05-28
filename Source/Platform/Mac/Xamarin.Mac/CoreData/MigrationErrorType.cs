using ObjCRuntime;

namespace CoreData;

[Native]
public enum MigrationErrorType
{
	Migration = 134110,
	MigrationCancelled = 134120,
	MigrationMissingSourceModel = 134130,
	MigrationMissingMappingModel = 134140,
	MigrationManagerSourceStore = 134150,
	MigrationManagerDestinationStore = 134160,
	EntityMigrationPolicy = 134170,
	InferredMappingModel = 134190,
	ExternalRecordImport = 134200,
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	HistoryTokenExpired = 134301
}
