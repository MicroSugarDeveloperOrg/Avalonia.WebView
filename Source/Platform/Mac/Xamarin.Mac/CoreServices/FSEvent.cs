using System;
using System.Runtime.InteropServices;

namespace CoreServices;

public struct FSEvent
{
	public const ulong SinceNowId = ulong.MaxValue;

	public ulong Id { get; internal set; }

	public string Path { get; internal set; }

	public FSEventStreamEventFlags Flags { get; internal set; }

	public static ulong CurrentEventId => FSEventsGetCurrentEventId();

	public override string ToString()
	{
		return $"[FSEvent: Id={Id}, Path={Path}, Flags={Flags}]";
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern IntPtr FSEventsCopyUUIDForDevice(ulong device);

	public static Guid GetUuidForDevice(ulong device)
	{
		if (device == 0)
		{
			return Guid.Empty;
		}
		IntPtr intPtr = FSEventsCopyUUIDForDevice(device);
		if (intPtr == IntPtr.Zero)
		{
			return Guid.Empty;
		}
		return (Guid)Marshal.PtrToStructure(intPtr, typeof(Guid));
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern ulong FSEventsGetCurrentEventId();

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern ulong FSEventsGetLastEventIdForDeviceBeforeTime(ulong device, double timeInSecondsSinceEpoch);

	public static ulong GetLastEventIdForDeviceBeforeTime(ulong device, double timeInSecondsSinceEpoch)
	{
		return FSEventsGetLastEventIdForDeviceBeforeTime(device, timeInSecondsSinceEpoch);
	}

	[DllImport("/System/Library/Frameworks/CoreServices.framework/CoreServices")]
	private static extern bool FSEventsPurgeEventsForDeviceUpToEventId(ulong device, ulong eventId);

	public static bool PurgeEventsForDeviceUpToEventId(ulong device, ulong eventId)
	{
		return FSEventsPurgeEventsForDeviceUpToEventId(device, eventId);
	}
}
