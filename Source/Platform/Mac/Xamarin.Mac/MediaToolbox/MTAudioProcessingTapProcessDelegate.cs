using AudioToolbox;
using Xamarin.Mac.System.Mac;

namespace MediaToolbox;

public delegate void MTAudioProcessingTapProcessDelegate(MTAudioProcessingTap tap, nint numberFrames, MTAudioProcessingTapFlags flags, AudioBuffers bufferList, out nint numberFramesOut, out MTAudioProcessingTapFlags flagsOut);
