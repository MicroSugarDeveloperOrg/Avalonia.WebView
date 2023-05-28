using System;

namespace CoreBluetooth;

public class CBPeripheralsEventArgs : EventArgs
{
	public CBPeripheral[] Peripherals { get; set; }

	public CBPeripheralsEventArgs(CBPeripheral[] peripherals)
	{
		Peripherals = peripherals;
	}
}
