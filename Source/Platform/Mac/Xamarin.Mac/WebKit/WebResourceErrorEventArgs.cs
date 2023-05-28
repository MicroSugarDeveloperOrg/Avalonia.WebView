using System;
using Foundation;

namespace WebKit;

public class WebResourceErrorEventArgs : EventArgs
{
	public WebDataSource DataSource { get; set; }

	public NSObject Identifier { get; set; }

	public NSError WithError { get; set; }

	public WebResourceErrorEventArgs(NSObject identifier, NSError withError, WebDataSource dataSource)
	{
		DataSource = dataSource;
		Identifier = identifier;
		WithError = withError;
	}
}
