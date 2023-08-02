using System;

namespace AppKit;

public class NSApplicationRegisterEventArgs : EventArgs
{
	public string[] ReturnTypes { get; set; }

	public NSApplicationRegisterEventArgs(string[] returnTypes)
	{
		ReturnTypes = returnTypes;
	}
}
