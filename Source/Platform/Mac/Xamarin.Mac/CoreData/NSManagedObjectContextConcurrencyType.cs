using ObjCRuntime;

namespace CoreData;

[Native]
public enum NSManagedObjectContextConcurrencyType : ulong
{
	Confinement,
	PrivateQueue,
	MainQueue
}
