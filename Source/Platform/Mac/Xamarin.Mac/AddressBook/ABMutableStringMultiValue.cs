using System;

namespace AddressBook;

public class ABMutableStringMultiValue : ABMutableMultiValue<string>
{
	public ABMutableStringMultiValue()
		: base(ABMultiValue.CreateMutable(ABPropertyType.MultiString), (Converter<IntPtr, string>)ABPerson.ToString, (Converter<string, IntPtr>)ABPerson.ToIntPtr)
	{
	}
}
