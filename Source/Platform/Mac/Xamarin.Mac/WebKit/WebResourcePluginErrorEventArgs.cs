using System;
using Foundation;

namespace WebKit;

public class WebResourcePluginErrorEventArgs : EventArgs
{
	public WebDataSource DataSource { get; set; }

	public NSError Error { get; set; }

	public WebResourcePluginErrorEventArgs(NSError error, WebDataSource dataSource)
	{
		DataSource = dataSource;
		Error = error;
	}
}
