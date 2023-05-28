using ObjCRuntime;

namespace QTKit;

[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
public struct QTTimeRange
{
	private QTTime time;

	private QTTime duration;

	public QTTime Time
	{
		get
		{
			return time;
		}
		set
		{
			time = value;
		}
	}

	public QTTime Duration
	{
		get
		{
			return duration;
		}
		set
		{
			duration = value;
		}
	}

	public QTTimeRange(QTTime time, QTTime duration)
	{
		this.time = time;
		this.duration = duration;
	}

	public override string ToString()
	{
		return string.Format("[Time={0} Duration={2}]", Time, Duration);
	}
}
