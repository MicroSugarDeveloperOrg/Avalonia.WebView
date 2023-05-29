using System;
using Foundation;

namespace CoreImage;

public class CIColorCube : CIFilter
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

	public float CubeDimension
	{
		get
		{
			return GetFloat("inputCubeDimension");
		}
		set
		{
			SetFloat("inputCubeDimension", value);
		}
	}

	public NSData CubeData
	{
		get
		{
			return ValueForKey("inputCubeData") as NSData;
		}
		set
		{
			SetValue("inputCubeData", value);
		}
	}

	public CIColorCube()
		: base(CIFilter.CreateFilter("CIColorCube"))
	{
	}

	public CIColorCube(IntPtr handle)
		: base(handle)
	{
	}
}
