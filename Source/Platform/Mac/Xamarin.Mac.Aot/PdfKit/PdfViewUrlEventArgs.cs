using System;
using Foundation;

namespace PdfKit;

public class PdfViewUrlEventArgs : EventArgs
{
	public NSUrl Url { get; set; }

	public PdfViewUrlEventArgs(NSUrl url)
	{
		Url = url;
	}
}
