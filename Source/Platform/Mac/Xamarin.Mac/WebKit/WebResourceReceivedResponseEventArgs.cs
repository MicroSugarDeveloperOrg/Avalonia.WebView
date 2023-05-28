using System;
using Foundation;

namespace WebKit;

public class WebResourceReceivedResponseEventArgs : EventArgs
{
	public WebDataSource DataSource { get; set; }

	public NSObject Identifier { get; set; }

	public NSUrlResponse ResponseReceived { get; set; }

	public WebResourceReceivedResponseEventArgs(NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
	{
		DataSource = dataSource;
		Identifier = identifier;
		ResponseReceived = responseReceived;
	}
}
