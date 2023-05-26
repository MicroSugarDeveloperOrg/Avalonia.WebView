using System;

namespace Foundation;

public class NSNetServiceErrorEventArgs : EventArgs
{
	public NSDictionary Errors { get; set; }

	public NSNetServiceErrorEventArgs(NSDictionary errors)
	{
		Errors = errors;
	}
}
