using System;

namespace CoreImage;

public class CISaturationBlendMode : CIBlendFilter
{
	public CISaturationBlendMode()
		: base("CISaturationBlendMode")
	{
	}

	public CISaturationBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
