using System;

namespace AppKit;

public class NSImageLoadEventArgs : EventArgs
{
	public NSImageRep Rep { get; set; }

	public NSImageLoadEventArgs(NSImageRep rep)
	{
		Rep = rep;
	}
}
