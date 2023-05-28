using System;
using Foundation;

namespace CoreBluetooth;

public class CBPeripheralManagerOpenL2CapChannelEventArgs : EventArgs
{
	public CBL2CapChannel? Channel { get; set; }

	public NSError? Error { get; set; }

	public CBPeripheralManagerOpenL2CapChannelEventArgs(CBL2CapChannel? channel, NSError? error)
	{
		Channel = channel;
		Error = error;
	}
}
