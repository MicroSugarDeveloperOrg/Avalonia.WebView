using System;
using AudioToolbox;

namespace MediaToolbox;

public delegate void MTAudioProcessingTapPrepareCallback(MTAudioProcessingTap tap, nint maxFrames, ref AudioStreamBasicDescription processingFormat);
