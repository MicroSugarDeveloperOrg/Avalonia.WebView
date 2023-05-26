namespace AudioToolbox;

internal struct AudioFormatInfo
{
	public AudioStreamBasicDescription AudioStreamBasicDescription;

	public unsafe byte* MagicCookieWeak;

	public int MagicCookieSize;
}
