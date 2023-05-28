using System;
using Foundation;

namespace WebKit;

public class WebMimeTypePolicyEventArgs : EventArgs
{
	public NSObject DecisionToken { get; set; }

	public WebFrame Frame { get; set; }

	public string MimeType { get; set; }

	public NSUrlRequest Request { get; set; }

	public WebMimeTypePolicyEventArgs(string mimeType, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		DecisionToken = decisionToken;
		Frame = frame;
		MimeType = mimeType;
		Request = request;
	}
}
