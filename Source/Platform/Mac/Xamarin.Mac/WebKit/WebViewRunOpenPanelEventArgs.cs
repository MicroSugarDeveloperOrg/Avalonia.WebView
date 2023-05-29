using System;

namespace WebKit;

public class WebViewRunOpenPanelEventArgs : EventArgs
{
	public WebOpenPanelResultListener ResultListener { get; set; }

	public WebViewRunOpenPanelEventArgs(WebOpenPanelResultListener resultListener)
	{
		ResultListener = resultListener;
	}
}
