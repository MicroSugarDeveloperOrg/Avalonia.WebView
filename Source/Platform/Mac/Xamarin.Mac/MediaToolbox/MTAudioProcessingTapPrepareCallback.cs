using AudioToolbox;
using Xamarin.Mac.System.Mac;

namespace MediaToolbox;

public delegate void MTAudioProcessingTapPrepareCallback(MTAudioProcessingTap tap, nint maxFrames, ref AudioStreamBasicDescription processingFormat);
