using Foundation;

namespace AddressBook;

public class PersonAddress : DictionaryContainer
{
	public string City
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.City);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.City, value);
		}
	}

	public string Country
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.Country);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.Country, value);
		}
	}

	public string CountryCode
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.CountryCode);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.CountryCode, value);
		}
	}

	public string State
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.State);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.State, value);
		}
	}

	public string Street
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.Street);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.Street, value);
		}
	}

	public string Zip
	{
		get
		{
			return GetStringValue(ABPersonAddressKey.Zip);
		}
		set
		{
			SetStringValue(ABPersonAddressKey.Zip, value);
		}
	}

	public PersonAddress()
	{
	}

	public PersonAddress(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
