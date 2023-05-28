using System;
using Foundation;

namespace CoreBluetooth;

public class CBRssiEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public NSNumber Rssi { get; set; }

	public CBRssiEventArgs(NSNumber rssi, NSError error)
	{
		Error = error;
		Rssi = rssi;
	}
}
