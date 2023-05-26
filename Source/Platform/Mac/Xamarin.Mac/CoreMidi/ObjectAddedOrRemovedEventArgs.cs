using System;

namespace CoreMidi;

public class ObjectAddedOrRemovedEventArgs : EventArgs
{
	public MidiObject Parent { get; private set; }

	public MidiObject Child { get; private set; }

	public ObjectAddedOrRemovedEventArgs(MidiObject parent, MidiObject child)
	{
		Parent = parent;
		Child = child;
	}
}
