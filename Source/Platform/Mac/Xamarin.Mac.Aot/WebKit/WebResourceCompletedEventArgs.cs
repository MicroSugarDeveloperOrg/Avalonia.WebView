using System;
using Foundation;

namespace WebKit;

public class WebResourceCompletedEventArgs : EventArgs
{
	public NSObject Identifier { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourceCompletedEventArgs(NSObject identifier, WebDataSource dataSource)
	{
		Identifier = identifier;
		DataSource = dataSource;
	}
}
