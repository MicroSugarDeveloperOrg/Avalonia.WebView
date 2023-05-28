namespace AudioToolbox;

public struct ExtendedNoteOnEvent
{
	public uint InstrumentID;

	public uint DeviceGroupID;

	public float Duration;

	private int argCount;

	public float Pitch;

	public float Velocity;
}
