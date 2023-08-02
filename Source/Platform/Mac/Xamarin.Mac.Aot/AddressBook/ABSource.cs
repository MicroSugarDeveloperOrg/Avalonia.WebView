using System;
using Foundation;

namespace AddressBook;

public class ABSource : ABRecord
{
	[Advice("Use ABSourceType.SearchableMask")]
	public const int SearchableMask = 16777216;

	public string Name
	{
		get
		{
			return PropertyToString(ABSourcePropertyId.Name);
		}
		set
		{
			SetValue(ABSourcePropertyId.Name, value);
		}
	}

	public ABSourceType SourceType
	{
		get
		{
			return (ABSourceType)(int)PropertyTo<NSNumber>(ABSourcePropertyId.Type);
		}
		set
		{
			SetValue(ABSourcePropertyId.Type, new NSNumber((int)value));
		}
	}

	internal ABSource(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	internal ABSource(IntPtr handle, ABAddressBook addressbook)
		: base(handle, owns: false)
	{
		base.AddressBook = addressbook;
	}
}
