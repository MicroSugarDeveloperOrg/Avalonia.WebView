using System;

namespace CoreImage;

public class CIHueBlendMode : CIBlendFilter
{
	public CIHueBlendMode()
		: base("CIHueBlendMode")
	{
	}

	public CIHueBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
