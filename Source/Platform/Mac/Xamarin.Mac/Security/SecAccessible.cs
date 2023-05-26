namespace Security;

public enum SecAccessible
{
	WhenUnlocked,
	AfterFirstUnlock,
	Always,
	WhenUnlockedThisDeviceOnly,
	AfterFirstUnlockThisDeviceOnly,
	AlwaysThisDeviceOnly
}
