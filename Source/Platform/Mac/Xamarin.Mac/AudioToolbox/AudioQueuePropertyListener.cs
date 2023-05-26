using System;

namespace AudioToolbox;

internal delegate void AudioQueuePropertyListener(IntPtr userData, IntPtr AQ, AudioQueueProperty id);
