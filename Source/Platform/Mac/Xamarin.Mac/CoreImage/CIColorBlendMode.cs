using System;

namespace CoreImage;

public class CIColorBlendMode : CIBlendFilter
{
	public CIColorBlendMode()
		: base("CIColorBlendMode")
	{
	}

	public CIColorBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
