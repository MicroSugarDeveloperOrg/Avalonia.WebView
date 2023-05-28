using System;

namespace ObjCRuntime;

public class MarshalManagedExceptionEventArgs
{
	public Exception Exception { get; set; }

	public MarshalManagedExceptionMode ExceptionMode { get; set; }
}
