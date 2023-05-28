using AudioToolbox;

namespace AudioUnit;

public delegate AudioUnitStatus InputDelegate(AudioUnitRenderActionFlags actionFlags, AudioTimeStamp timeStamp, uint busNumber, uint numberFrames, AudioUnit audioUnit);
