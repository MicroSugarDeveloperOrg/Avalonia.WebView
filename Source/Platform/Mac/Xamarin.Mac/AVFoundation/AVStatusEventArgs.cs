using System;

namespace AVFoundation;

public class AVStatusEventArgs : EventArgs
{
	public bool Status { get; private set; }

	public AVStatusEventArgs(bool status)
	{
		Status = status;
	}
}
