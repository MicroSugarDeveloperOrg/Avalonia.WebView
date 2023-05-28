namespace AVFoundation;

public delegate AVAudioBuffer AVAudioConverterInputHandler(uint inNumberOfPackets, out AVAudioConverterInputStatus outStatus);
