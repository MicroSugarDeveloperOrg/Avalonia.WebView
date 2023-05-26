using System;

namespace CoreImage;

public class CIScreenBlendMode : CIBlendFilter
{
	public CIScreenBlendMode()
		: base("CIScreenBlendMode")
	{
	}

	public CIScreenBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
