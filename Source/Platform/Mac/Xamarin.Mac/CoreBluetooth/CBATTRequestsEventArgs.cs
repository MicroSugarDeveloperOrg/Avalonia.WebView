using System;

namespace CoreBluetooth;

public class CBATTRequestsEventArgs : EventArgs
{
	public CBATTRequest[] Requests { get; set; }

	public CBATTRequestsEventArgs(CBATTRequest[] requests)
	{
		Requests = requests;
	}
}
