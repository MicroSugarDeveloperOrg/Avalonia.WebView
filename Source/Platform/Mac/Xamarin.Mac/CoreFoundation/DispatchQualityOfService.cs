namespace CoreFoundation;

public enum DispatchQualityOfService : uint
{
	UserInteractive = 33u,
	UserInitiated = 25u,
	Default = 21u,
	Utility = 17u,
	Background = 9u,
	Unspecified = 0u
}
