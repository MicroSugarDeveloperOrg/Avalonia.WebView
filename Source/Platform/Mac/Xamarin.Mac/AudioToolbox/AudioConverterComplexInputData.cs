namespace AudioToolbox;

public delegate AudioConverterError AudioConverterComplexInputData(ref int numberDataPackets, AudioBuffers data, ref AudioStreamPacketDescription[] dataPacketDescription);
