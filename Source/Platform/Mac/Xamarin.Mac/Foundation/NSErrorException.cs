using Xamarin.Mac.System.Mac;

namespace Foundation;

public class NSErrorException : Exception
{
	private NSError error;

	public NSError Error => error;

	public string Domain => error.Domain;

	public nint Code => error.Code;

	public NSDictionary UserInfo => error.UserInfo;

	public override string Message => error.Description;

	public NSErrorException(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		this.error = error;
	}
}
