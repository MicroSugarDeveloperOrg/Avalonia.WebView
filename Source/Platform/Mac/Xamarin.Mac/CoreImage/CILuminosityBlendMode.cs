using System;

namespace CoreImage;

public class CILuminosityBlendMode : CIBlendFilter
{
	public CILuminosityBlendMode()
		: base("CILuminosityBlendMode")
	{
	}

	public CILuminosityBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
