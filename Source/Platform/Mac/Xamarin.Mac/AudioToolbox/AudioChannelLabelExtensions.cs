namespace AudioToolbox;

public static class AudioChannelLabelExtensions
{
	public static bool IsReserved(this AudioChannelLabel value)
	{
		return (uint)value >= 4026531840u && (uint)value <= 4294967294u;
	}
}
