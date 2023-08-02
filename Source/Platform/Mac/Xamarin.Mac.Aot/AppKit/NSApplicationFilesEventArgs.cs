using System;

namespace AppKit;

public class NSApplicationFilesEventArgs : EventArgs
{
	public string[] Filenames { get; set; }

	public NSApplicationFilesEventArgs(string[] filenames)
	{
		Filenames = filenames;
	}
}
