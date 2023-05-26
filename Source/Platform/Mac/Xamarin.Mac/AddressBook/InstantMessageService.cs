using Foundation;

namespace AddressBook;

public class InstantMessageService : DictionaryContainer
{
	public string ServiceName
	{
		get
		{
			return GetStringValue(ABPersonInstantMessageKey.Service);
		}
		set
		{
			SetStringValue(ABPersonInstantMessageKey.Service, value);
		}
	}

	public NSString Service
	{
		set
		{
			SetStringValue(ABPersonInstantMessageKey.Service, value);
		}
	}

	public string Username
	{
		get
		{
			return GetStringValue(ABPersonInstantMessageKey.Username);
		}
		set
		{
			SetStringValue(ABPersonInstantMessageKey.Username, value);
		}
	}

	public InstantMessageService()
	{
	}

	public InstantMessageService(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
