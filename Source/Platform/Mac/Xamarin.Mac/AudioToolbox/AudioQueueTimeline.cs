using System;
using System.Runtime.InteropServices;

namespace AudioToolbox;

public class AudioQueueTimeline : IDisposable
{
	protected internal IntPtr timelineHandle;

	protected internal IntPtr queueHandle;

	internal AudioQueueTimeline(IntPtr queueHandle, IntPtr timelineHandle)
	{
		this.queueHandle = queueHandle;
		this.timelineHandle = timelineHandle;
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern AudioQueueStatus AudioQueueDisposeTimeline(IntPtr AQ, IntPtr timeline);

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	public virtual void Dispose(bool disposing)
	{
		if (timelineHandle != IntPtr.Zero)
		{
			AudioQueueDisposeTimeline(queueHandle, timelineHandle);
			timelineHandle = IntPtr.Zero;
		}
	}

	~AudioQueueTimeline()
	{
		Dispose(disposing: false);
	}
}
