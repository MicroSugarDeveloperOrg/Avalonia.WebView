using System;

namespace Security;

public class SecurityException : Exception
{
	private static string ToMessage(SecStatusCode code)
	{
		switch (code)
		{
		case SecStatusCode.Decode:
		case SecStatusCode.InteractionNotAllowed:
		case SecStatusCode.ItemNotFound:
		case SecStatusCode.DuplicateItem:
		case SecStatusCode.NotAvailable:
		case SecStatusCode.Allocate:
		case SecStatusCode.Param:
		case SecStatusCode.Unimplemented:
		case SecStatusCode.Success:
			return code.ToString();
		default:
			return $"Unknown error: 0x{code:x}";
		}
	}

	public SecurityException(SecStatusCode code)
		: base(ToMessage(code))
	{
	}
}
