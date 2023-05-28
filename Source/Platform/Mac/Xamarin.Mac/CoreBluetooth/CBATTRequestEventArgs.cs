using System;

namespace CoreBluetooth;

public class CBATTRequestEventArgs : EventArgs
{
	public CBATTRequest Request { get; set; }

	public CBATTRequestEventArgs(CBATTRequest request)
	{
		Request = request;
	}
}
