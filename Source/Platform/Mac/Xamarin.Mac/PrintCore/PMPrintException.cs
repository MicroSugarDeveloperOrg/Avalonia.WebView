using System;

namespace PrintCore;

public class PMPrintException : Exception
{
	public PMPrintException(PMStatusCode code)
		: base(code.ToString())
	{
	}
}
