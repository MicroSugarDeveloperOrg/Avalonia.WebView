using System;
using Foundation;

namespace WebKit;

public class WebResourcePluginErrorEventArgs : EventArgs
{
	public NSError Error { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourcePluginErrorEventArgs(NSError error, WebDataSource dataSource)
	{
		Error = error;
		DataSource = dataSource;
	}
}
