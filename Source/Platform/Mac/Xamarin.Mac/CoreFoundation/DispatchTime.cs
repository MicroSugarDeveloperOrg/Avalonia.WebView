namespace CoreFoundation;

public struct DispatchTime
{
	public static readonly DispatchTime Now = default(DispatchTime);

	public static readonly DispatchTime Forever = new DispatchTime(ulong.MaxValue);

	public ulong Nanoseconds { get; private set; }

	public DispatchTime(ulong nanoseconds)
	{
		this = default(DispatchTime);
		Nanoseconds = nanoseconds;
	}
}
