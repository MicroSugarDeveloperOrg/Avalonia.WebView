using System;

namespace CoreBluetooth;

public class CBPeripheralManagerSubscriptionEventArgs : EventArgs
{
	public CBCentral Central { get; set; }

	public CBCharacteristic Characteristic { get; set; }

	public CBPeripheralManagerSubscriptionEventArgs(CBCentral central, CBCharacteristic characteristic)
	{
		Central = central;
		Characteristic = characteristic;
	}
}
