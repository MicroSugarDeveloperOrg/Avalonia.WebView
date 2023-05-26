using System;

namespace AudioToolbox;

public class PropertyFoundEventArgs : EventArgs
{
	public AudioFileStreamProperty Property { get; private set; }

	public AudioFileStreamPropertyFlag Flags { get; set; }

	public PropertyFoundEventArgs(AudioFileStreamProperty propertyID, AudioFileStreamPropertyFlag ioFlags)
	{
		Property = propertyID;
		Flags = ioFlags;
	}

	public override string ToString()
	{
		return $"AudioFileStreamProperty ({Property})";
	}
}
