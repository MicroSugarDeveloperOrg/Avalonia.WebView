namespace CoreMidi;

public struct MidiTransform
{
	public MidiTransformType Transform;

	public short Param;

	public MidiTransform(MidiTransformType transform, short param)
	{
		Transform = transform;
		Param = param;
	}
}
