using System;
using Foundation;

namespace CoreBluetooth;

public class CBWillRestoreEventArgs : EventArgs
{
	public NSDictionary Dict { get; set; }

	public CBWillRestoreEventArgs(NSDictionary dict)
	{
		Dict = dict;
	}
}
