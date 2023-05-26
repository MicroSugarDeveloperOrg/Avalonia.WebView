using System;
using AudioToolbox;

namespace AudioUnit;

public delegate void AUInputHandler(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber);
