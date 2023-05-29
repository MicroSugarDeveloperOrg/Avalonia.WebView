using System;

namespace Foundation;

public class NSErrorException : Exception
{
	private NSError error;

	public NSError Error => error;

	public string Domain => error.Domain;

	public long Code => error.Code;

	public NSDictionary UserInfo => error.UserInfo;

	public NSErrorException(NSError error)
	{
		this.error = error;
	}
}
