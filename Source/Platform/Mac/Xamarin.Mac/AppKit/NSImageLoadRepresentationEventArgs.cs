using System;

namespace AppKit;

public class NSImageLoadRepresentationEventArgs : EventArgs
{
	public NSImageRep Rep { get; set; }

	public NSImageLoadStatus Status { get; set; }

	public NSImageLoadRepresentationEventArgs(NSImageRep rep, NSImageLoadStatus status)
	{
		Rep = rep;
		Status = status;
	}
}
