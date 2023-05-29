namespace OpenGL;

public enum ArbRobustness
{
	NoError = 0,
	ContextFlagRobustAccessBitArb = 4,
	LoseContextOnResetArb = 33362,
	GuiltyContextResetArb = 33363,
	InnocentContextResetArb = 33364,
	UnknownContextResetArb = 33365,
	ResetNotificationStrategyArb = 33366,
	NoResetNotificationArb = 33377
}
