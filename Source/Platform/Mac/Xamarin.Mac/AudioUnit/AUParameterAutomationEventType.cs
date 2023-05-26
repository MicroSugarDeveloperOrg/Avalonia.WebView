namespace AudioUnit;

[iOS(10, 0)]
[Mac(10, 12)]
public enum AUParameterAutomationEventType : uint
{
	Value,
	Touch,
	Release
}
