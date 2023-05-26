using System;
using AudioToolbox;

namespace AudioUnit;

public delegate AudioUnitStatus AURenderBlock(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, AURenderPullInputBlock? pullInputBlock);
