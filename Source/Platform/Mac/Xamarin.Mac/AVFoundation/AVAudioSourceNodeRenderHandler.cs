using AudioToolbox;

namespace AVFoundation;

public delegate int AVAudioSourceNodeRenderHandler(bool isSilence, AudioTimeStamp timestamp, uint frameCunt, ref AudioBuffers outputData);
