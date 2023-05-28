using System;

namespace AudioToolbox;

internal delegate void MusicSequenceUserCallbackProxy(IntPtr inClientData, IntPtr inSequence, IntPtr inTrack, double inEventTime, IntPtr inEventData, double inStartSliceBeat, double inEndSliceBeat);
