using Foundation;

namespace AddressBook;

public class ABMutableDateMultiValue : ABMutableMultiValue<NSDate>
{
	public ABMutableDateMultiValue()
		: base(ABMultiValue.CreateMutable(ABPropertyType.MultiDateTime))
	{
	}
}
