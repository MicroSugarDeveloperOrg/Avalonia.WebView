using System;

namespace AudioToolbox;

[Obsolete("Use AudioQueueProcessingTapDelegate")]
public delegate uint AudioQueueProcessingTapCallback(AudioQueueProcessingTap audioQueueTap, uint numberOfFrames, ref AudioTimeStamp timeStamp, ref AudioQueueProcessingTapFlags flags, AudioBufferList data);
