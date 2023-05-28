namespace ObjCRuntime;

public enum MarshalObjectiveCExceptionMode
{
	Default,
	UnwindManagedCode,
	ThrowManagedException,
	Abort,
	Disable
}
