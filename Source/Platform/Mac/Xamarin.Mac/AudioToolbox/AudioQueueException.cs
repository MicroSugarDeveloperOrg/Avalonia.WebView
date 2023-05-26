using System;

namespace AudioToolbox;

public class AudioQueueException : Exception
{
	public AudioQueueStatus ErrorCode { get; private set; }

	private static string Lookup(int k)
	{
		AudioQueueStatus audioQueueStatus = (AudioQueueStatus)k;
		return audioQueueStatus switch
		{
			AudioQueueStatus.InvalidBuffer => "The specified audio queue buffer does not belong to this audio queue", 
			AudioQueueStatus.BufferEmpty => "The audio buffer is empty (AudioDataByteSize is zero)", 
			AudioQueueStatus.DisposalPending => "This audio queue is being asynchronously disposed", 
			AudioQueueStatus.InvalidProperty => "Invalid property specified", 
			AudioQueueStatus.InvalidPropertySize => "Invalid property size", 
			AudioQueueStatus.InvalidParameter => "The specified parameter is invalid", 
			AudioQueueStatus.CannotStart => "The queue has encountered a problem and can not start", 
			AudioQueueStatus.InvalidDevice => "The specified hardware device can not be located", 
			AudioQueueStatus.BufferInQueue => "The specified buffer can not be disposed while it is on an active queue", 
			AudioQueueStatus.InvalidRunState => "The operation can not be performed in the current queue state (running or stopped)", 
			AudioQueueStatus.InvalidQueueType => "Invalid queue type (input operation attempted on output or output operation on input", 
			AudioQueueStatus.Permissions => "No permissions to access that function", 
			AudioQueueStatus.InvalidPropertyValue => "The property value is invalid", 
			AudioQueueStatus.PrimeTimedOut => "Timeout during Prime operation", 
			AudioQueueStatus.CodecNotFound => "The requested codec was not found", 
			AudioQueueStatus.InvalidCodecAccess => "The codec could not be accessed", 
			AudioQueueStatus.QueueInvalidated => "The audio server has terminated, the queue has been invalidated", 
			AudioQueueStatus.RecordUnderrun => "Recording lost data because enqueued buffer was not available", 
			AudioQueueStatus.EnqueueDuringReset => "You tried to enqueue a buffer during a Reset, Stop or Dispose methods", 
			AudioQueueStatus.InvalidOfflineMode => "Offline mode is either required or not required for the operation", 
			AudioQueueStatus.GeneralParamError => "Error in user parameter list", 
			_ => $"Error code: {audioQueueStatus.ToString()}", 
		};
	}

	internal AudioQueueException(AudioQueueStatus k)
		: base(Lookup((int)k))
	{
		ErrorCode = k;
	}

	internal AudioQueueException(int k)
		: base(Lookup(k))
	{
		ErrorCode = (AudioQueueStatus)k;
	}
}
