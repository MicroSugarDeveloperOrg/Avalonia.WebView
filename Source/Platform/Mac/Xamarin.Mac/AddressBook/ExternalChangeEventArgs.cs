using System;
using Foundation;

namespace AddressBook;

public class ExternalChangeEventArgs : EventArgs
{
	public ABAddressBook AddressBook { get; private set; }

	public NSDictionary Info { get; private set; }

	public ExternalChangeEventArgs(ABAddressBook addressBook, NSDictionary info)
	{
		AddressBook = addressBook;
		Info = info;
	}
}
