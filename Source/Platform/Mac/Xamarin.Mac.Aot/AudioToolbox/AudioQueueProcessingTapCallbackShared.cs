using System;

namespace AudioToolbox;

internal delegate void AudioQueueProcessingTapCallbackShared(IntPtr clientData, IntPtr tap, uint numberOfFrames, ref AudioTimeStamp timeStamp, ref AudioQueueProcessingTapFlags flags, out uint outNumberFrames, IntPtr data);
