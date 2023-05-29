namespace AudioToolbox;

public struct SmpteTime
{
	public short Subframes;

	public short SubframeDivisor;

	public uint Counter;

	public uint Type;

	public uint Flags;

	public short Hours;

	public short Minutes;

	public short Seconds;

	public short Frames;

	public override string ToString()
	{
		return $"[Subframes={Subframes},Divisor={SubframeDivisor},Counter={Counter},Type={Type},Flags={Flags},Hours={Hours},Minutes={Minutes},Seconds={Seconds},Frames={Frames}]";
	}
}
