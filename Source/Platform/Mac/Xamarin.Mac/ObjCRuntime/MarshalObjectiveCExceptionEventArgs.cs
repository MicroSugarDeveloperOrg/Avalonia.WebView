using Foundation;

namespace ObjCRuntime;

public class MarshalObjectiveCExceptionEventArgs
{
	public NSException Exception { get; set; }

	public MarshalObjectiveCExceptionMode ExceptionMode { get; set; }
}
