namespace AudioUnit;

public enum AUGraphError
{
	OK = 0,
	NodeNotFound = -10860,
	InvalidConnection = -10861,
	OutputNodeError = -10862,
	CannotDoInCurrentContext = -10863,
	InvalidAudioUnit = -10864,
	FormatNotSupported = -10868,
	InvalidElement = -10877
}
