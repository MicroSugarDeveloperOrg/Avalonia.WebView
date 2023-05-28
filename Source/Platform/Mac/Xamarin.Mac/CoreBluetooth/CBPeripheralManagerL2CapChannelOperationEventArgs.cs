using System;
using Foundation;

namespace CoreBluetooth;

public class CBPeripheralManagerL2CapChannelOperationEventArgs : EventArgs
{
	public NSError? Error { get; set; }

	public ushort Psm { get; set; }

	public CBPeripheralManagerL2CapChannelOperationEventArgs(ushort psm, NSError? error)
	{
		Error = error;
		Psm = psm;
	}
}
