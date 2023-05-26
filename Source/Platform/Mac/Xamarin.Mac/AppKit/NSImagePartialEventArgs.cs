using System;

namespace AppKit;

public class NSImagePartialEventArgs : EventArgs
{
	public NSImageRep Rep { get; set; }

	public long Rows { get; set; }

	public NSImagePartialEventArgs(NSImageRep rep, long rows)
	{
		Rep = rep;
		Rows = rows;
	}
}
