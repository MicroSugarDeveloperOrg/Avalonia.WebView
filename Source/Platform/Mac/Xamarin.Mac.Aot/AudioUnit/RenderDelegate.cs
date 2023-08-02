using AudioToolbox;

namespace AudioUnit;

public delegate AudioUnitStatus RenderDelegate(AudioUnitRenderActionFlags actionFlags, AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, AudioBuffers data);
