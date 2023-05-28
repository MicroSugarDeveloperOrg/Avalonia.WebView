using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using ObjCRuntime;

namespace AudioToolbox;

public class InputAudioQueue : AudioQueue
{
	private unsafe static readonly AudioQueueInputCallback dInputCallback = input_callback;

	public event EventHandler<InputCompletedEventArgs> InputCompleted;

	[MonoPInvokeCallback(typeof(AudioQueueInputCallback))]
	private unsafe static void input_callback(IntPtr userData, IntPtr AQ, IntPtr audioQueueBuffer, AudioTimeStamp* startTime, int descriptors, IntPtr inPacketDesc)
	{
		InputAudioQueue inputAudioQueue = GCHandle.FromIntPtr(userData).Target as InputAudioQueue;
		inputAudioQueue.OnInputCompleted(audioQueueBuffer, *startTime, AudioFile.PacketDescriptionFrom(descriptors, inPacketDesc));
	}

	protected virtual void OnInputCompleted(IntPtr audioQueueBuffer, AudioTimeStamp timeStamp, AudioStreamPacketDescription[] packetDescriptions)
	{
		this.InputCompleted?.Invoke(this, new InputCompletedEventArgs(audioQueueBuffer, timeStamp, packetDescriptions));
	}

	[DllImport("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox")]
	private static extern int AudioQueueNewInput(ref AudioStreamBasicDescription format, AudioQueueInputCallback callback, IntPtr inUserData, IntPtr cfrunLoop_inCallbackRunLoop, IntPtr cfstringref_inCallbackRunLoopMode, uint inFlags, out IntPtr audioQueue);

	public InputAudioQueue(AudioStreamBasicDescription desc)
		: this(desc, null, null)
	{
	}

	public InputAudioQueue(AudioStreamBasicDescription desc, CFRunLoop runLoop, string runMode)
	{
		GCHandle value = GCHandle.Alloc(this);
		CFString cFString = ((runMode == null) ? null : new CFString(runMode));
		IntPtr audioQueue;
		int num = AudioQueueNewInput(ref desc, dInputCallback, GCHandle.ToIntPtr(value), (runLoop == null) ? IntPtr.Zero : runLoop.Handle, cFString?.Handle ?? IntPtr.Zero, 0u, out audioQueue);
		cFString?.Dispose();
		if (num == 0)
		{
			handle = audioQueue;
			gch = value;
			return;
		}
		value.Free();
		throw new AudioQueueException(num);
	}

	public unsafe AudioQueueStatus EnqueueBuffer(AudioQueueBuffer* buffer)
	{
		return AudioQueue.AudioQueueEnqueueBuffer(handle, buffer, 0, null);
	}
}
