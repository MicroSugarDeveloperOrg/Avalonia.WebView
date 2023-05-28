using System;
using Foundation;

namespace CoreBluetooth;

public class CBDescriptorEventArgs : EventArgs
{
	public CBDescriptor Descriptor { get; set; }

	public NSError Error { get; set; }

	public CBDescriptorEventArgs(CBDescriptor descriptor, NSError error)
	{
		Descriptor = descriptor;
		Error = error;
	}
}
