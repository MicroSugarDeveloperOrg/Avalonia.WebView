using System;
using System.Runtime.InteropServices;

namespace CoreFoundation;

public struct DispatchTime
{
	public static readonly DispatchTime Now = default(DispatchTime);

	public static readonly DispatchTime Forever = new DispatchTime(ulong.MaxValue);

	public ulong Nanoseconds { get; private set; }

	public DispatchTime WallTime => new DispatchTime(dispatch_walltime(IntPtr.Zero, 0L));

	public DispatchTime(ulong nanoseconds)
	{
		this = default(DispatchTime);
		Nanoseconds = nanoseconds;
	}

	public DispatchTime(DispatchTime when, long deltaNanoseconds)
	{
		this = default(DispatchTime);
		Nanoseconds = dispatch_time(when.Nanoseconds, deltaNanoseconds);
	}

	public DispatchTime(DispatchTime when, TimeSpan delta)
	{
		this = default(DispatchTime);
		Nanoseconds = dispatch_time(when.Nanoseconds, delta.Ticks * 100);
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern ulong dispatch_time(ulong when, long delta);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern ulong dispatch_walltime(IntPtr when, long delta);
}
