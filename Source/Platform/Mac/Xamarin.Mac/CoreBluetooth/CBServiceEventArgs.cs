using System;
using Foundation;

namespace CoreBluetooth;

public class CBServiceEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public CBService Service { get; set; }

	public CBServiceEventArgs(CBService service, NSError error)
	{
		Error = error;
		Service = service;
	}
}
