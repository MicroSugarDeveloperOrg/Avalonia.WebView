using System;
using Foundation;

namespace CoreBluetooth;

public class CBCharacteristicEventArgs : EventArgs
{
	public CBCharacteristic Characteristic { get; set; }

	public NSError Error { get; set; }

	public CBCharacteristicEventArgs(CBCharacteristic characteristic, NSError error)
	{
		Characteristic = characteristic;
		Error = error;
	}
}
