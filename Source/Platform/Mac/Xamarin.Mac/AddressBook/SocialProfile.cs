using Foundation;

namespace AddressBook;

public class SocialProfile : DictionaryContainer
{
	public string ServiceName
	{
		get
		{
			return GetStringValue(ABPersonSocialProfile.ServiceKey);
		}
		set
		{
			SetStringValue(ABPersonSocialProfile.ServiceKey, value);
		}
	}

	public NSString Service
	{
		set
		{
			SetStringValue(ABPersonSocialProfile.ServiceKey, value);
		}
	}

	public string Username
	{
		get
		{
			return GetStringValue(ABPersonSocialProfile.UsernameKey);
		}
		set
		{
			SetStringValue(ABPersonSocialProfile.UsernameKey, value);
		}
	}

	public string UserIdentifier
	{
		get
		{
			return GetStringValue(ABPersonSocialProfile.UserIdentifierKey);
		}
		set
		{
			SetStringValue(ABPersonSocialProfile.UserIdentifierKey, value);
		}
	}

	public string Url
	{
		get
		{
			return GetStringValue(ABPersonSocialProfile.URLKey);
		}
		set
		{
			SetStringValue(ABPersonSocialProfile.URLKey, value);
		}
	}

	public SocialProfile()
	{
	}

	public SocialProfile(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
