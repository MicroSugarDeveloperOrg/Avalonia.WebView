using System;

namespace AppKit;

public class NSImagePartialEventArgs : EventArgs
{
	public NSImageRep Rep { get; set; }

	public nint Rows { get; set; }

	public NSImagePartialEventArgs(NSImageRep rep, nint rows)
	{
		Rep = rep;
		Rows = rows;
	}
}
