namespace ObjCRuntime;

public enum MarshalManagedExceptionMode
{
	Default,
	UnwindNativeCode,
	ThrowObjectiveCException,
	Abort,
	Disable
}
