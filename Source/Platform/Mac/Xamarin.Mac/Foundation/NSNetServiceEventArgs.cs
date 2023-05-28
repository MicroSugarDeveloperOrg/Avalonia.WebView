using System;

namespace Foundation;

public class NSNetServiceEventArgs : EventArgs
{
	public bool MoreComing { get; set; }

	public NSNetService Service { get; set; }

	public NSNetServiceEventArgs(NSNetService service, bool moreComing)
	{
		MoreComing = moreComing;
		Service = service;
	}
}
