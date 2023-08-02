using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIColorMap : CIFilter
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

	public CIImage GradientImage
	{
		get
		{
			return GetImage("inputGradientImage");
		}
		set
		{
			SetImage("inputGradientImage", value);
		}
	}

	public CIColorMap()
		: base("CIColorMap")
	{
	}

	public CIColorMap(IntPtr handle)
		: base(handle)
	{
	}
}
