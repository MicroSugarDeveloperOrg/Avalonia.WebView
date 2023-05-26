using System;
using CoreFoundation;

namespace AudioToolbox;

public struct AudioQueueChannelAssignment
{
	private IntPtr deviceUID;

	private uint channelNumber;

	public AudioQueueChannelAssignment(CFString deviceUID, uint channelNumber)
	{
		this.deviceUID = deviceUID.Handle;
		this.channelNumber = channelNumber;
	}
}
