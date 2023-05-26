using AudioToolbox;

namespace Foundation;

public delegate int AVAudioSourceNodeRenderHandler(bool isSilence, AudioTimeStamp timestamp, uint frameCunt, ref AudioBuffers outputData);
