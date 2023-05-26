namespace CoreMidi;

public enum MidiError
{
	Ok = 0,
	InvalidClient = -10830,
	InvalidPort = -10831,
	WrongEndpointType = -10832,
	NoConnection = -10833,
	UnknownEndpoint = -10834,
	UnknownProperty = -10835,
	WrongPropertyType = -10836,
	NoCurrentSetup = -10837,
	MessageSendErr = -10838,
	ServerStartErr = -10839,
	SetupFormatErr = -10840,
	WrongThread = -10841,
	ObjectNotFound = -10842,
	IDNotUnique = -10843,
	NotPermitted = -10844
}
