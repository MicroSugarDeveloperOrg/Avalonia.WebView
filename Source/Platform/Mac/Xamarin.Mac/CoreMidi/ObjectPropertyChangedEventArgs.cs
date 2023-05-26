using System;

namespace CoreMidi;

public class ObjectPropertyChangedEventArgs : EventArgs
{
	public MidiObject MidiObject { get; private set; }

	public string PropertyName { get; private set; }

	public ObjectPropertyChangedEventArgs(MidiObject midiObject, string propertyName)
	{
		MidiObject = midiObject;
		PropertyName = propertyName;
	}
}
