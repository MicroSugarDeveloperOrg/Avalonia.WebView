using System;

namespace AppKit;

public class NSSharingServicePickerDidChooseSharingServiceEventArgs : EventArgs
{
	public NSSharingService Service { get; set; }

	public NSSharingServicePickerDidChooseSharingServiceEventArgs(NSSharingService service)
	{
		Service = service;
	}
}
