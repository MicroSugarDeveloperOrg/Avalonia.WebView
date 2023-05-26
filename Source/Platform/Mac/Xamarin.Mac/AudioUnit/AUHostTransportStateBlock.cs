namespace AudioUnit;

public delegate bool AUHostTransportStateBlock(ref AUHostTransportStateFlags transportStateFlags, ref double currentSamplePosition, ref double cycleStartBeatPosition, ref double cycleEndBeatPosition);
