using System;
using AudioToolbox;

namespace AudioUnit;

internal delegate AudioUnitStatus CallbackShared(IntPtr clientData, ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, IntPtr data);
