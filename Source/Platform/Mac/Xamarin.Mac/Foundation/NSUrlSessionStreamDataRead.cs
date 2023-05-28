namespace Foundation;

public class NSUrlSessionStreamDataRead
{
	public NSData Data { get; set; }

	public bool AtEof { get; set; }

	public NSUrlSessionStreamDataRead(NSData data, bool atEof)
	{
		Data = data;
		AtEof = atEof;
	}
}
