using System;
using Foundation;

namespace WebKit;

public class WebResourceCompletedEventArgs : EventArgs
{
	public WebDataSource DataSource { get; set; }

	public NSObject Identifier { get; set; }

	public WebResourceCompletedEventArgs(NSObject identifier, WebDataSource dataSource)
	{
		DataSource = dataSource;
		Identifier = identifier;
	}
}
