namespace CoreData;

public enum NSManagedObjectContextConcurrencyType : ulong
{
	Confinement,
	PrivateQueue,
	MainQueue
}
