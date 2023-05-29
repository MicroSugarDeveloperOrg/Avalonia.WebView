using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIBlendWithMask : CIBlendFilter
{
	public CIImage Mask
	{
		get
		{
			return GetImage("inputMaskImage");
		}
		set
		{
			SetImage("inputMaskImage", value);
		}
	}

	public CIBlendWithMask()
		: base("CIBlendWithMask")
	{
	}

	public CIBlendWithMask(IntPtr handle)
		: base(handle)
	{
	}
}
