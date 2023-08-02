namespace AudioToolbox;

public delegate uint AudioQueueProcessingTapDelegate(AudioQueueProcessingTap audioQueueTap, uint numberOfFrames, ref AudioTimeStamp timeStamp, ref AudioQueueProcessingTapFlags flags, AudioBuffers data);
