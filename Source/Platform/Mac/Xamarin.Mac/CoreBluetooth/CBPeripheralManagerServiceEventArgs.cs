using System;
using Foundation;

namespace CoreBluetooth;

public class CBPeripheralManagerServiceEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public CBService Service { get; set; }

	public CBPeripheralManagerServiceEventArgs(CBService service, NSError error)
	{
		Error = error;
		Service = service;
	}
}
