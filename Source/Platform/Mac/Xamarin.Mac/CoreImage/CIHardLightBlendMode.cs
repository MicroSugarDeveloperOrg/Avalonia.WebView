using System;

namespace CoreImage;

public class CIHardLightBlendMode : CIBlendFilter
{
	public CIHardLightBlendMode()
		: base("CIHardLightBlendMode")
	{
	}

	public CIHardLightBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
