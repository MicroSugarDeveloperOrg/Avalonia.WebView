using System;

namespace CoreMidi;

public class MidiException : Exception
{
	public MidiError ErrorCode { get; private set; }

	internal MidiException(MidiError code)
		: base(code.ToString())
	{
		ErrorCode = code;
	}
}
