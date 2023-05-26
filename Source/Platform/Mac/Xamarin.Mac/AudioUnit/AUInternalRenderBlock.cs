using System;
using AudioToolbox;

namespace AudioUnit;

public delegate AudioUnitStatus AUInternalRenderBlock(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint outputBusNumber, AudioBuffers outputData, AURenderEventEnumerator realtimeEventListHead, AURenderPullInputBlock? pullInputBlock);
