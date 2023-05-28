using System;
using Foundation;

namespace WebKit;

public class WebNavigationPolicyEventArgs : EventArgs
{
	public WebNavigationType NavigationType => (WebNavigationType)((NSNumber)ActionInformation[WebPolicyDelegate.WebActionNavigationTypeKey]).Int32Value;

	public NSDictionary ElementInfo => ActionInformation[WebPolicyDelegate.WebActionElementKey] as NSDictionary;

	public WebActionMouseButton MouseButton
	{
		get
		{
			if (!(ActionInformation[WebPolicyDelegate.WebActionButtonKey] is NSNumber nSNumber))
			{
				return WebActionMouseButton.None;
			}
			return (WebActionMouseButton)nSNumber.Int32Value;
		}
	}

	public uint Flags => ((NSNumber)ActionInformation[WebPolicyDelegate.WebActionModifierFlagsKey]).UInt32Value;

	public NSUrl OriginalUrl => ActionInformation[WebPolicyDelegate.WebActionOriginalUrlKey] as NSUrl;

	public NSDictionary ActionInformation { get; set; }

	public NSObject DecisionToken { get; set; }

	public WebFrame Frame { get; set; }

	public NSUrlRequest Request { get; set; }

	public WebNavigationPolicyEventArgs(NSDictionary actionInformation, NSUrlRequest request, WebFrame frame, NSObject decisionToken)
	{
		ActionInformation = actionInformation;
		DecisionToken = decisionToken;
		Frame = frame;
		Request = request;
	}
}
