namespace CoreMidi;

public enum MidiTransformType : ushort
{
	None = 0,
	FilterOut = 1,
	MapControl = 2,
	Add = 8,
	Scale = 9,
	MinValue = 10,
	MaxValue = 11,
	MapValue = 12
}
