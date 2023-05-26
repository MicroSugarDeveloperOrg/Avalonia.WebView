using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIMinimumComponent : CIFilter
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

	public CIMinimumComponent()
		: base("CIMinimumComponent")
	{
	}

	public CIMinimumComponent(IntPtr handle)
		: base(handle)
	{
	}
}
