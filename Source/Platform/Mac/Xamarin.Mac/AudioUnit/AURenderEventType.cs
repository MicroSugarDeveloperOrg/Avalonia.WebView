namespace AudioUnit;

public enum AURenderEventType : byte
{
	Parameter = 1,
	ParameterRamp = 2,
	Midi = 8,
	MidiSysEx = 9
}
