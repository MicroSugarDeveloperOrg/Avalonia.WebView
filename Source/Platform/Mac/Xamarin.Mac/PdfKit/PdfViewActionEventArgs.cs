using System;

namespace PdfKit;

public class PdfViewActionEventArgs : EventArgs
{
	public PdfActionRemoteGoTo Action { get; set; }

	public PdfViewActionEventArgs(PdfActionRemoteGoTo action)
	{
		Action = action;
	}
}
