using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CILanczosScaleTransform : CIFilter
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

	public float AspectRatio
	{
		get
		{
			return GetFloat("inputAspectRatio");
		}
		set
		{
			SetFloat("inputAspectRatio", value);
		}
	}

	public float Scale
	{
		get
		{
			return GetFloat("inputScale");
		}
		set
		{
			SetFloat("inputScale", value);
		}
	}

	public CILanczosScaleTransform()
		: base("CILanczosScaleTransform")
	{
	}

	public CILanczosScaleTransform(IntPtr handle)
		: base(handle)
	{
	}
}
