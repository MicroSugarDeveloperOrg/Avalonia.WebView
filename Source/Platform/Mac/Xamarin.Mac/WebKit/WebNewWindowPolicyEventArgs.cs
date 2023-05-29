using System;
using Foundation;

namespace WebKit;

public class WebNewWindowPolicyEventArgs : EventArgs
{
	public NSDictionary ActionInformation { get; set; }

	public NSUrlRequest Request { get; set; }

	public string NewFrameName { get; set; }

	public NSObject DecisionToken { get; set; }

	public WebNewWindowPolicyEventArgs(NSDictionary actionInformation, NSUrlRequest request, string newFrameName, NSObject decisionToken)
	{
		ActionInformation = actionInformation;
		Request = request;
		NewFrameName = newFrameName;
		DecisionToken = decisionToken;
	}
}
