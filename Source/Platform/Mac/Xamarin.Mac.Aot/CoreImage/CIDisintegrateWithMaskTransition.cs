using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIDisintegrateWithMaskTransition : CITransitionFilter
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

	public float ShadowRadius
	{
		get
		{
			return GetFloat("inputShadowRadius");
		}
		set
		{
			SetFloat("inputShadowRadius", value);
		}
	}

	public float ShadowDensity
	{
		get
		{
			return GetFloat("inputShadowDensity");
		}
		set
		{
			SetFloat("inputShadowDensity", value);
		}
	}

	public CIVector ShadowOffset
	{
		get
		{
			return GetVector("inputShadowOffset");
		}
		set
		{
			SetValue("inputShadowOffset", value);
		}
	}

	public CIDisintegrateWithMaskTransition()
		: base("CIDisintegrateWithMaskTransition")
	{
	}

	public CIDisintegrateWithMaskTransition(IntPtr handle)
		: base(handle)
	{
	}
}
