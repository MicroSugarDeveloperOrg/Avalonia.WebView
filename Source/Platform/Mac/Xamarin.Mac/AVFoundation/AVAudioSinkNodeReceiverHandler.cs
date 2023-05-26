using AudioToolbox;

namespace AVFoundation;

public delegate int AVAudioSinkNodeReceiverHandler(AudioTimeStamp timestamp, uint frameCount, ref AudioBuffers inputData);