namespace Foundation;

public class NSTextCheckingTransitComponents : DictionaryContainer
{
	public string? Airline => GetStringValue(NSTextChecking.AirlineKey);

	public string? Flight => GetStringValue(NSTextChecking.FlightKey);

	[Preserve(Conditional = true)]
	public NSTextCheckingTransitComponents()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public NSTextCheckingTransitComponents(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
