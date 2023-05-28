using System;

namespace CoreBluetooth;

public class CBPeripheralServicesEventArgs : EventArgs
{
	public CBService[] Services { get; set; }

	public CBPeripheralServicesEventArgs(CBService[] services)
	{
		Services = services;
	}
}
