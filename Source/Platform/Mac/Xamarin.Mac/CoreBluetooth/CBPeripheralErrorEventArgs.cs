using System;
using Foundation;

namespace CoreBluetooth;

public class CBPeripheralErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public CBPeripheral Peripheral { get; set; }

	public CBPeripheralErrorEventArgs(CBPeripheral peripheral, NSError error)
	{
		Error = error;
		Peripheral = peripheral;
	}
}
