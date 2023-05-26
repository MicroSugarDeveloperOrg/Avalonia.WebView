using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIMaximumComponent : CIFilter
{
	public CIImage Image
	{
		get
		{
			return GetInputImage();
		}
		set
		{
			SetInputImage(value);
		}
	}

	public CIMaximumComponent()
		: base("CIMaximumComponent")
	{
	}

	public CIMaximumComponent(IntPtr handle)
		: base(handle)
	{
	}
}
