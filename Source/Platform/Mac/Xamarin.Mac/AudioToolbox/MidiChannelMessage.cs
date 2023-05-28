namespace AudioToolbox;

public struct MidiChannelMessage
{
	public byte Status;

	public byte Data1;

	public byte Data2;

	public byte Reserved;

	public MidiChannelMessage(byte status, byte data1, byte data2)
	{
		Status = status;
		Data1 = data1;
		Data2 = data2;
		Reserved = 0;
	}
}
