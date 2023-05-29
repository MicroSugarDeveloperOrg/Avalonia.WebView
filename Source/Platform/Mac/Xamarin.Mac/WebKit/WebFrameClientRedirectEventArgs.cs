using System;
using Foundation;

namespace WebKit;

public class WebFrameClientRedirectEventArgs : EventArgs
{
	public NSUrl ToUrl { get; set; }

	public double SecondsDelay { get; set; }

	public NSDate FireDate { get; set; }

	public WebFrame ForFrame { get; set; }

	public WebFrameClientRedirectEventArgs(NSUrl toUrl, double secondsDelay, NSDate fireDate, WebFrame forFrame)
	{
		ToUrl = toUrl;
		SecondsDelay = secondsDelay;
		FireDate = fireDate;
		ForFrame = forFrame;
	}
}
