using System;
using Foundation;

namespace WebKit;

public class WebResourceAuthenticationChallengeEventArgs : EventArgs
{
	public NSObject Identifier { get; set; }

	public NSUrlAuthenticationChallenge Challenge { get; set; }

	public WebDataSource DataSource { get; set; }

	public WebResourceAuthenticationChallengeEventArgs(NSObject identifier, NSUrlAuthenticationChallenge challenge, WebDataSource dataSource)
	{
		Identifier = identifier;
		Challenge = challenge;
		DataSource = dataSource;
	}
}
