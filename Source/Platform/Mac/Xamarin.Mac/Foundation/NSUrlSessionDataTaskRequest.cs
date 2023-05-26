namespace Foundation;

public class NSUrlSessionDataTaskRequest
{
	public NSData Data { get; set; }

	public NSUrlResponse Response { get; set; }

	public NSUrlSessionDataTaskRequest(NSData data, NSUrlResponse response)
	{
		Data = data;
		Response = response;
	}
}
