namespace AudioUnit;

[iOS(10, 0)]
[Mac(10, 12)]
public struct AUParameterAutomationEvent
{
	public ulong HostTime;

	public ulong Address;

	public float Value;

	public AUParameterAutomationEventType EventType;

	private ulong Reserved;
}
