using AudioToolbox;

namespace AVFoundation;

public delegate AVAudioEngineManualRenderingStatus AVAudioEngineManualRenderingBlock(uint numberOfFrames, AudioBuffers outBuffer, ref int outError);
