using System;
using Foundation;

namespace WebKit;

public class WebNavigationPolicyEventArgs : EventArgs
{
	public NSDictionary ActionInformation { get; set; }

	public NSUrlRequest Request { get; set; }

	public WebFrame Frame { get; set; }

	public NSObject DecisionToken { get; set; }

	public WebNavigationPolicyEventArgs(NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		ActionInformation = actionInformation;
		Request = request;
		Frame = frame;
		DecisionToken = decisionToken;
	}
}
