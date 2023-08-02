using Foundation;

namespace AddressBook;

public class ABMutableDictionaryMultiValue : ABMutableMultiValue<NSDictionary>
{
	public ABMutableDictionaryMultiValue()
		: base(ABMultiValue.CreateMutable(ABPropertyType.MultiDictionary))
	{
	}
}
