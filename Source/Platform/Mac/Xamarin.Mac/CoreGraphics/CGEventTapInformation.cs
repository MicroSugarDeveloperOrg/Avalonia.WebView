namespace CoreGraphics;

public struct CGEventTapInformation
{
	public uint EventTapID;

	public CGEventTapLocation TapPoint;

	public CGEventTapOptions Options;

	public CGEventMask EventsOfInterest;

	public int TappingProcess;

	public int ProcessBeingTapped;

	public bool Enabled;

	public float MinUsecLatency;

	public float AvgUsecLatency;

	public float MaxUsecLatency;
}
