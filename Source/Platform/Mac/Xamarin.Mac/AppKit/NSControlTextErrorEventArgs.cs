using System;

namespace AppKit;

public class NSControlTextErrorEventArgs : EventArgs
{
	public string Str { get; set; }

	public string Error { get; set; }

	public NSControlTextErrorEventArgs(string str, string error)
	{
		Str = str;
		Error = error;
	}
}
