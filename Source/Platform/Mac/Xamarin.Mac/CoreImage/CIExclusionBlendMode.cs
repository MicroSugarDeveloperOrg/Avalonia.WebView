using System;

namespace CoreImage;

public class CIExclusionBlendMode : CIBlendFilter
{
	public CIExclusionBlendMode()
		: base("CIExclusionBlendMode")
	{
	}

	public CIExclusionBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
