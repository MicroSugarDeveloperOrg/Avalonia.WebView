using Foundation;

namespace StoreKit;

public class SKReceiptProperties : DictionaryContainer
{
	public bool IsExpired
	{
		get
		{
			return GetInt32Value(_SKReceiptProperty.IsExpired) != 0;
		}
		set
		{
			SetNumberValue(_SKReceiptProperty.IsExpired, value ? 1 : 0);
		}
	}

	public bool IsRevoked
	{
		get
		{
			return GetInt32Value(_SKReceiptProperty.IsRevoked) != 0;
		}
		set
		{
			SetNumberValue(_SKReceiptProperty.IsRevoked, value ? 1 : 0);
		}
	}

	public bool IsVolumePurchase
	{
		get
		{
			return GetInt32Value(_SKReceiptProperty.IsVolumePurchase) != 0;
		}
		set
		{
			SetNumberValue(_SKReceiptProperty.IsVolumePurchase, value ? 1 : 0);
		}
	}

	public SKReceiptProperties()
		: base(new NSMutableDictionary())
	{
	}

	public SKReceiptProperties(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}
