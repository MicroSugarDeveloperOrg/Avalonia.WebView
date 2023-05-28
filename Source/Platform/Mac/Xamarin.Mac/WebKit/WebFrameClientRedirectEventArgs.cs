using System;
using Foundation;

namespace WebKit;

public class WebFrameClientRedirectEventArgs : EventArgs
{
	public NSDate FireDate { get; set; }

	public WebFrame ForFrame { get; set; }

	public double SecondsDelay { get; set; }

	public NSUrl ToUrl { get; set; }

	public WebFrameClientRedirectEventArgs(NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
	{
		FireDate = fireDate;
		ForFrame = forFrame;
		SecondsDelay = secondsDelay;
		ToUrl = toUrl;
	}
}
