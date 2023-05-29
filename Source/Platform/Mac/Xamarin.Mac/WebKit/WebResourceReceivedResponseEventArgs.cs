using System;
using Foundation;

namespace WebKit;

public class WebResourceReceivedResponseEventArgs : EventArgs
{
	public NSObject Identifier { get; set; }

	public NSUrlResponse ResponseReceived { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourceReceivedResponseEventArgs(NSObject identifier, NSUrlResponse responseReceived, WebDataSource dataSource)
	{
		Identifier = identifier;
		ResponseReceived = responseReceived;
		DataSource = dataSource;
	}
}
