using System;

namespace CoreImage;

public class CILightenBlendMode : CIBlendFilter
{
	public CILightenBlendMode()
		: base("CILightenBlendMode")
	{
	}

	public CILightenBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
