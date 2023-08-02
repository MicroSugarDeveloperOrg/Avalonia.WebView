using System;

namespace CoreLocation;

public class CLAuthorizationChangedEventArgs : EventArgs
{
	public CLAuthorizationStatus Status { get; set; }

	public CLAuthorizationChangedEventArgs(CLAuthorizationStatus status)
	{
		Status = status;
	}
}
