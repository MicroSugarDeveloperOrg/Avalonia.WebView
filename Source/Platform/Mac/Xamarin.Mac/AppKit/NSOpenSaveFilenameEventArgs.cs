using System;

namespace AppKit;

public class NSOpenSaveFilenameEventArgs : EventArgs
{
	public string Path { get; set; }

	public NSOpenSaveFilenameEventArgs(string path)
	{
		Path = path;
	}
}
