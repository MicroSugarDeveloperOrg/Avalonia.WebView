using System;

namespace Foundation;

public class NSNetDomainEventArgs : EventArgs
{
	public string Domain { get; set; }

	public bool MoreComing { get; set; }

	public NSNetDomainEventArgs(string domain, bool moreComing)
	{
		Domain = domain;
		MoreComing = moreComing;
	}
}
