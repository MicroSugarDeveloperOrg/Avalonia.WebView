namespace QTKit;

public struct QTTimeRange
{
	public QTTime Time;

	public QTTime Duration;

	public QTTimeRange(QTTime time, QTTime duration)
	{
		Time = time;
		Duration = duration;
	}

	public override string ToString()
	{
		return string.Format("[Time={0} Duration={2}]", Time, Duration);
	}
}
