using ObjCRuntime;

namespace Foundation;

[Native]
public enum NSUbiquitousKeyValueStoreChangeReason : long
{
	ServerChange,
	InitialSyncChange,
	QuotaViolationChange,
	AccountChange
}
