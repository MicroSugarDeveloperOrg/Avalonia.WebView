using System;

namespace CoreBluetooth;

public class CBPeripheralEventArgs : EventArgs
{
	public CBPeripheral Peripheral { get; set; }

	public CBPeripheralEventArgs(CBPeripheral peripheral)
	{
		Peripheral = peripheral;
	}
}
