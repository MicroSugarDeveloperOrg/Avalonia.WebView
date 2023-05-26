using System;

namespace Foundation;

public class ObjCException : Exception
{
	private NSException native_exc;

	public NSException NSException => native_exc;

	public string Reason => native_exc.Reason;

	public string Name => native_exc.Name;

	public override string Message => $"{Name}: {Reason}";

	public ObjCException()
	{
		native_exc = new NSException("default", string.Empty, null);
	}

	public ObjCException(NSException exc)
	{
		native_exc = exc;
	}

	[Preserve]
	internal static void Throw(IntPtr handle)
	{
		throw new ObjCException(new NSException(handle));
	}
}
