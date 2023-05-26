namespace AppKit;

public enum NSEventSubtype : ulong
{
	WindowExposed = 0uL,
	ApplicationActivated = 1uL,
	ApplicationDeactivated = 2uL,
	WindowMoved = 4uL,
	ScreenChanged = 8uL,
	AWT = 0x10uL
}
