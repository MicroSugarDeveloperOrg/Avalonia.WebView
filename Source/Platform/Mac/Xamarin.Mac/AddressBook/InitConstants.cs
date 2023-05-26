using System;
using CoreFoundation;

namespace AddressBook;

internal class InitConstants
{
	public static void Init()
	{
	}

	static InitConstants()
	{
		IntPtr intPtr = ABAddressBook.ABAddressBookCreate();
		ABGroupProperty.Init();
		ABLabel.Init();
		ABPersonAddressKey.Init();
		ABPersonDateLabel.Init();
		ABPersonInstantMessageKey.Init();
		ABPersonInstantMessageService.Init();
		ABPersonKindId.Init();
		ABPersonPhoneLabel.Init();
		ABPersonPropertyId.Init();
		ABPersonRelatedNamesLabel.Init();
		ABPersonUrlLabel.Init();
		ABSourcePropertyId.Init();
		if (intPtr != IntPtr.Zero)
		{
			CFObject.CFRelease(intPtr);
		}
	}
}
