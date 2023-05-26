using System;
using AudioToolbox;

namespace AudioUnit;

public delegate AudioUnitStatus AURenderPullInputBlock(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber, AudioBuffers inputData);
