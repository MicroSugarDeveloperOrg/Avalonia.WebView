using System;

namespace CoreMidi;

public class MidiException : Exception
{
	public MidiError ErrorCode { get; private set; }

	internal MidiException(MidiError code)
		: base((code == MidiError.NotPermitted) ? "NotPermitted, does your app Info.plist include the 'audio' key in the UIBackgroundModes section?" : code.ToString())
	{
		ErrorCode = code;
	}
}
