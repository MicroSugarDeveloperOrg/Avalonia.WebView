namespace CoreMidi;

public struct MidiControlTransform
{
	public MidiTransformControlType ControlType;

	public MidiTransformControlType RemappedControlType;

	public ushort ControlNumber;

	public MidiTransformType Transform;

	public short Param;

	public MidiControlTransform(MidiTransformControlType controlType, MidiTransformControlType remappedControlType, ushort controlNumber, MidiTransformType transform, short param)
	{
		ControlType = controlType;
		RemappedControlType = remappedControlType;
		ControlNumber = controlNumber;
		Transform = transform;
		Param = param;
	}
}
