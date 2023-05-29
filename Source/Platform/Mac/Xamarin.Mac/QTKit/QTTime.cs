namespace QTKit;

public struct QTTime
{
	public static readonly QTTime Zero = new QTTime(0L, 1, (TimeFlags)0);

	public static readonly QTTime IndefiniteTime = new QTTime(0L, 1, TimeFlags.TimeIsIndefinite);

	public long TimeValue;

	public int TimeScale;

	public TimeFlags Flags;

	public QTTime(long timeValue, int timeScale, TimeFlags flags)
	{
		TimeValue = timeValue;
		TimeScale = timeScale;
		Flags = flags;
	}

	public QTTime(long timeValue, int timeScale)
	{
		TimeValue = timeValue;
		TimeScale = timeScale;
		Flags = (TimeFlags)0;
	}

	public override string ToString()
	{
		if (Flags == (TimeFlags)0)
		{
			return $"[TimeValue={TimeValue} scale={TimeScale}]";
		}
		return $"[TimeValue={TimeValue} scale={TimeScale} Flags={Flags}]";
	}
}
