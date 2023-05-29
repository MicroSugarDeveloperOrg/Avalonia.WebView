namespace Foundation;

public enum NSNotificationSuspensionBehavior : ulong
{
	Drop = 1uL,
	Coalesce,
	Hold,
	DeliverImmediately
}
