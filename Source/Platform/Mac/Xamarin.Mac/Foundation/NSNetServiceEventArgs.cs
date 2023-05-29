using System;

namespace Foundation;

public class NSNetServiceEventArgs : EventArgs
{
	public NSNetService Service { get; set; }

	public bool MoreComing { get; set; }

	public NSNetServiceEventArgs(NSNetService service, bool moreComing)
	{
		Service = service;
		MoreComing = moreComing;
	}
}
