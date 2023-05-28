namespace AudioUnit;

public enum AudioComponentValidationResult : uint
{
	Unknown,
	Passed,
	Failed,
	TimedOut,
	UnauthorizedErrorOpen,
	UnauthorizedErrorInit
}
