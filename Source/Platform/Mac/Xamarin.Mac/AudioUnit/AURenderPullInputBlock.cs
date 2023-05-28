using AudioToolbox;
using Xamarin.Mac.System.Mac;

namespace AudioUnit;

public delegate AudioUnitStatus AURenderPullInputBlock(ref AudioUnitRenderActionFlags actionFlags, ref AudioTimeStamp timestamp, uint frameCount, nint inputBusNumber, AudioBuffers inputData);
