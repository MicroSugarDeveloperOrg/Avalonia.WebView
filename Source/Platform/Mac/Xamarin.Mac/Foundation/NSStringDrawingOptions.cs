namespace Foundation;

public enum NSStringDrawingOptions : ulong
{
	UsesLineFragmentOrigin = 1uL,
	UsesFontLeading = 2uL,
	DisableScreenFontSubstitution = 4uL,
	UsesDeviceMetrics = 8uL,
	OneShot = 0x10uL,
	TruncatesLastVisibleLine = 0x20uL
}
