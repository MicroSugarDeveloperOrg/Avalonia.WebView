using ObjCRuntime;

namespace CoreData;

[Native]
public enum PersistentStoreErrorType : ulong
{
	InvalidType = 134000uL,
	TypeMismatch = 134010uL,
	IncompatibleSchema = 134020uL,
	Save = 134030uL,
	IncompleteSave = 134040uL,
	SaveConflicts = 134050uL,
	Operation = 134070uL,
	Open = 134080uL,
	Timeout = 134090uL,
	IncompatibleVersionHash = 134100uL
}
