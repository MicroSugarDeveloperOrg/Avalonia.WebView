using System;

namespace CoreImage;

public class CIPageCurlTransition : CITransitionFilter
{
	public float Angle
	{
		get
		{
			return GetFloat("inputAngle");
		}
		set
		{
			SetFloat("inputAngle", value);
		}
	}

	public CIImage BacksideImage
	{
		get
		{
			return GetImage("inputBacksideImage");
		}
		set
		{
			SetImage("inputBacksideImage", value);
		}
	}

	public CIVector Extent
	{
		get
		{
			return GetVector("inputExtent");
		}
		set
		{
			SetValue("inputExtent", value);
		}
	}

	public CIImage ShadingImage
	{
		get
		{
			return GetImage("inputShadingImage");
		}
		set
		{
			SetImage("inputShadingImage", value);
		}
	}

	public float Radius
	{
		get
		{
			return GetFloat("inputRadius");
		}
		set
		{
			SetFloat("inputRadius", value);
		}
	}

	public CIPageCurlTransition()
		: base("CIPageCurlTransition")
	{
	}

	public CIPageCurlTransition(IntPtr handle)
		: base(handle)
	{
	}
}
