using System;
using Foundation;

namespace WebKit;

public class WebResourceErrorEventArgs : EventArgs
{
	public NSObject Identifier { get; set; }

	public NSError WithError { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourceErrorEventArgs(NSObject identifier, NSError withError, WebDataSource dataSource)
	{
		Identifier = identifier;
		WithError = withError;
		DataSource = dataSource;
	}
}
