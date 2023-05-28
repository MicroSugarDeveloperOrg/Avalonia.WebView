namespace Foundation;

public class NSUserActivityContinuation
{
	public NSInputStream Arg1 { get; set; }

	public NSOutputStream Arg2 { get; set; }

	public NSUserActivityContinuation(NSInputStream arg1, NSOutputStream arg2)
	{
		Arg1 = arg1;
		Arg2 = arg2;
	}
}
