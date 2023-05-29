using System;

namespace CoreImage;

public class CIColorBurnBlendMode : CIBlendFilter
{
	public CIColorBurnBlendMode()
		: base("CIColorBurnBlendMode")
	{
	}

	public CIColorBurnBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
