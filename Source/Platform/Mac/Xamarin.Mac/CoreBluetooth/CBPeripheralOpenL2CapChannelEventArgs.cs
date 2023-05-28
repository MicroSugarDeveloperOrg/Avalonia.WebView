using System;
using Foundation;

namespace CoreBluetooth;

public class CBPeripheralOpenL2CapChannelEventArgs : EventArgs
{
	public CBL2CapChannel? Channel { get; set; }

	public NSError? Error { get; set; }

	public CBPeripheralOpenL2CapChannelEventArgs(CBL2CapChannel? channel, NSError? error)
	{
		Channel = channel;
		Error = error;
	}
}
