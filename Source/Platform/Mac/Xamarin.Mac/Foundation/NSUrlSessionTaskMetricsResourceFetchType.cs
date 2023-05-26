using ObjCRuntime;

namespace Foundation;

[Watch(3, 0)]
[TV(10, 0)]
[Mac(10, 12)]
[iOS(10, 0)]
[Native]
public enum NSUrlSessionTaskMetricsResourceFetchType : long
{
	Unknown,
	NetworkLoad,
	ServerPush,
	LocalCache
}
