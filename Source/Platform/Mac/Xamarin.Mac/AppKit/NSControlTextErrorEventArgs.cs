using System;

namespace AppKit;

public class NSControlTextErrorEventArgs : EventArgs
{
	public string Error { get; set; }

	public string Str { get; set; }

	public NSControlTextErrorEventArgs(string str, string error)
	{
		Error = error;
		Str = str;
	}
}
