namespace AudioUnit;

public delegate void AUScheduleParameterBlock(AUEventSampleTime eventSampleTime, uint rampDurationSampleFrames, ulong parameterAddress, float value);
