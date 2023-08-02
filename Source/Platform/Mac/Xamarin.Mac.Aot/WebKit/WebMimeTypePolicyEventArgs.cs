using System;
using Foundation;

namespace WebKit;

public class WebMimeTypePolicyEventArgs : EventArgs
{
	public string MimeType { get; set; }

	public NSUrlRequest Request { get; set; }

	public WebFrame Frame { get; set; }

	public NSObject DecisionToken { get; set; }

	public WebMimeTypePolicyEventArgs(string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		MimeType = mimeType;
		Request = request;
		Frame = frame;
		DecisionToken = decisionToken;
	}
}
