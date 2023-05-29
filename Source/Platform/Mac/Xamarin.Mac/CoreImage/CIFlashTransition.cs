using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIFlashTransition : CITransitionFilter
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

	public CIColor Color
	{
		get
		{
			return GetColor("inputColor");
		}
		set
		{
			SetValue("inputColor", value);
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

	public float FadeThreshold
	{
		get
		{
			return GetFloat("inputFadeThreshold");
		}
		set
		{
			SetFloat("inputFadeThreshold", value);
		}
	}

	public float MaxStriationRadius
	{
		get
		{
			return GetFloat("inputMaxStriationRadius");
		}
		set
		{
			SetFloat("inputMaxStriationRadius", value);
		}
	}

	public float MaxStriationStrength
	{
		get
		{
			return GetFloat("inputStriationStrength");
		}
		set
		{
			SetFloat("inputStriationStrength", value);
		}
	}

	public float MaxStriationContrast
	{
		get
		{
			return GetFloat("inputStriationContrast");
		}
		set
		{
			SetFloat("inputStriationContrast", value);
		}
	}

	public CIFlashTransition()
		: base("CIFlashTransition")
	{
	}

	public CIFlashTransition(IntPtr handle)
		: base(handle)
	{
	}
}
