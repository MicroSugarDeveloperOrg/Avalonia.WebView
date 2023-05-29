using System;

namespace CoreImage;

public class CIColorDodgeBlendMode : CIBlendFilter
{
	public CIColorDodgeBlendMode()
		: base("CIColorDodgeBlendMode")
	{
	}

	public CIColorDodgeBlendMode(IntPtr handle)
		: base(handle)
	{
	}
}
