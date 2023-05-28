using System;

namespace WebKit;

public class WebViewRunOpenPanelEventArgs : EventArgs
{
	public IWebOpenPanelResultListener ResultListener { get; set; }

	public WebViewRunOpenPanelEventArgs(IWebOpenPanelResultListener resultListener)
	{
		ResultListener = resultListener;
	}
}
