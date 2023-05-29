using System;

namespace CoreLocation;

[Obsolete("Use CLAuthorizationChangedEventArgs")]
public class CLAuthroziationChangedEventArgs : CLAuthorizationChangedEventArgs
{
	public CLAuthroziationChangedEventArgs(CLAuthorizationStatus status)
		: base(status)
	{
	}
}
