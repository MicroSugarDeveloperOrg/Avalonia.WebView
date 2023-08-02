using System;

namespace CoreMidi;

public class IOErrorEventArgs : EventArgs
{
	public MidiDevice Device { get; set; }

	public int ErrorCode { get; set; }

	public IOErrorEventArgs(MidiDevice device, int errorCode)
	{
		Device = device;
		ErrorCode = errorCode;
	}
}
