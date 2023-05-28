using System;
using Foundation;

namespace WebKit;

public class WebResourceAuthenticationChallengeEventArgs : EventArgs
{
	public NSUrlAuthenticationChallenge Challenge { get; set; }

	public WebDataSource DataSource { get; set; }

	public NSObject Identifier { get; set; }

	public WebResourceAuthenticationChallengeEventArgs(NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		Challenge = challenge;
		DataSource = dataSource;
		Identifier = identifier;
	}
}
