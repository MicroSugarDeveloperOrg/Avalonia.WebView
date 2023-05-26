namespace CoreMidi;

internal enum MidiNotificationMessageId
{
	SetupChanged = 1,
	ObjectAdded,
	ObjectRemoved,
	PropertyChanged,
	ThruConnectionsChanged,
	SerialPortOwnerChanged,
	IOError
}
