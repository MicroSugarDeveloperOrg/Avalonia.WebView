using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIRippleTransition : CITransitionFilter
{
	public CIVector Center
	{
		get
		{
			return GetVector("inputCenter");
		}
		set
		{
			SetValue("inputCenter", value);
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

	public float Width
	{
		get
		{
			return GetFloat("inputWidth");
		}
		set
		{
			SetFloat("inputWidth", value);
		}
	}

	public CIRippleTransition()
		: base("CIRippleTransition")
	{
	}

	public CIRippleTransition(IntPtr handle)
		: base(handle)
	{
	}
}
