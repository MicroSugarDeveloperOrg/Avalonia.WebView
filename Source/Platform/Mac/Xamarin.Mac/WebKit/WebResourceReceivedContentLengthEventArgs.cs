using System;
using Foundation;

namespace WebKit;

public class WebResourceReceivedContentLengthEventArgs : EventArgs
{
	public NSObject Identifier { get; set; }

	public int Length { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourceReceivedContentLengthEventArgs(NSObject identifier, int length, WebDataSource dataSource)
	{
		Identifier = identifier;
		Length = length;
		DataSource = dataSource;
	}
}
