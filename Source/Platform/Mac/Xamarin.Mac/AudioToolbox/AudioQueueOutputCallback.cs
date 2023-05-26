using System;

namespace AudioToolbox;

internal delegate void AudioQueueOutputCallback(IntPtr userData, IntPtr AQ, IntPtr audioQueueBuffer);
