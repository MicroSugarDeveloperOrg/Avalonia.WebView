using System;
using Foundation;

namespace Accounts;

public class AccountStoreOptions : DictionaryContainer
{
	public string FacebookAppId
	{
		get
		{
			return GetStringValue(ACFacebookKey.AppId);
		}
		set
		{
			SetStringValue(ACFacebookKey.AppId, value);
		}
	}

	public string TencentWeiboAppId
	{
		get
		{
			return GetStringValue(ACTencentWeiboKey.AppId);
		}
		set
		{
			SetStringValue(ACTencentWeiboKey.AppId, value);
		}
	}

	public AccountStoreOptions()
		: base(new NSMutableDictionary())
	{
	}

	public AccountStoreOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}

	public void SetPermissions(ACFacebookAudience audience, params string[] permissions)
	{
		if (permissions == null)
		{
			throw new ArgumentNullException("permissions");
		}
		if (permissions.Length == 0)
		{
			throw new ArgumentException("permissions");
		}
		SetArrayValue(ACFacebookKey.Permissions, permissions);
		SetNativeValue(value: audience switch
		{
			ACFacebookAudience.Everyone => ACFacebookAudienceValue.Everyone, 
			ACFacebookAudience.Friends => ACFacebookAudienceValue.Friends, 
			ACFacebookAudience.OnlyMe => ACFacebookAudienceValue.Friends, 
			_ => throw new ArgumentOutOfRangeException("audience"), 
		}, key: ACFacebookKey.Audience);
	}
}
