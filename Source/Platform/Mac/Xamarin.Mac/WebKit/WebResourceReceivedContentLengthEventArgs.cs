using System;
using Foundation;

namespace WebKit;

public class WebResourceReceivedContentLengthEventArgs : EventArgs
{
	public WebDataSource DataSource { get; set; }

	public NSObject Identifier { get; set; }

	public nint Length { get; set; }

	public WebResourceReceivedContentLengthEventArgs(NSObject identifier, nint length, WebDataSource dataSource)
	{
		DataSource = dataSource;
		Identifier = identifier;
		Length = length;
	}
}
