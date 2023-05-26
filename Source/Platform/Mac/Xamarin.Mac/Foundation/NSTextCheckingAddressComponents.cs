namespace Foundation;

public class NSTextCheckingAddressComponents : DictionaryContainer
{
	public string? Name => GetStringValue(NSTextChecking.NameKey);

	public string? JobTitle => GetStringValue(NSTextChecking.JobTitleKey);

	public string? Organization => GetStringValue(NSTextChecking.OrganizationKey);

	public string? Street => GetStringValue(NSTextChecking.StreetKey);

	public string? City => GetStringValue(NSTextChecking.CityKey);

	public string? State => GetStringValue(NSTextChecking.StateKey);

	public string? ZIP => GetStringValue(NSTextChecking.ZipKey);

	public string? Country => GetStringValue(NSTextChecking.CountryKey);

	public string? Phone => GetStringValue(NSTextChecking.PhoneKey);

	[Preserve(Conditional = true)]
	public NSTextCheckingAddressComponents()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public NSTextCheckingAddressComponents(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
