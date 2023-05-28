namespace AudioToolbox;

public struct MidiNoteMessage
{
	public byte Channel;

	public byte Note;

	public byte Velocity;

	public byte ReleaseVelocity;

	public float Duration;

	public MidiNoteMessage(byte channel, byte note, byte velocity, byte releaseVelocity, float duration)
	{
		Channel = channel;
		Note = note;
		Velocity = velocity;
		ReleaseVelocity = releaseVelocity;
		Duration = duration;
	}
}
