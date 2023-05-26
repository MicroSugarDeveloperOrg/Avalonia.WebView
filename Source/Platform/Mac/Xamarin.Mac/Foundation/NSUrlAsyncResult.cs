namespace Foundation;

public class NSUrlAsyncResult
{
	public NSUrlResponse Response { get; set; }

	public NSData Data { get; set; }

	public NSUrlAsyncResult(NSUrlResponse response, NSData data)
	{
		Response = response;
		Data = data;
	}
}
