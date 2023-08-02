using System;

namespace AudioToolbox;

internal unsafe delegate void AudioQueueInputCallback(IntPtr userData, IntPtr AQ, IntPtr audioQueueBuffer, AudioTimeStamp* startTime, int descriptors, IntPtr AudioStreamPacketDescription_inPacketDesc);
