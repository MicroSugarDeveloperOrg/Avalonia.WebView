using System;
using Foundation;

namespace WebKit;

public class WebFailureToImplementPolicyEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public WebFrame Frame { get; set; }

	public WebFailureToImplementPolicyEventArgs(NSError error, WebFrame frame)
	{
		Error = error;
		Frame = frame;
	}
}
