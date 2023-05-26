using System;

namespace CoreImage;

public class CIDarkenBlendMode : CIBlendFilter
{
	public CIDarkenBlendMode()
		: base("CIDarkenBlendMode")
	{
	}

	public CIDarkenBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
