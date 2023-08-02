using System;

namespace CoreImage;

public class CIHighlightShadowAdjust : CIFilter
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

	public float ShadowAmount
	{
		get
		{
			return GetFloat("inputShadowAmount");
		}
		set
		{
			SetFloat("inputShadowAmount", value);
		}
	}

	public float HighlightAmount
	{
		get
		{
			return GetFloat("inputHighlightAmount");
		}
		set
		{
			SetFloat("inputHighlightAmount", value);
		}
	}

	public CIHighlightShadowAdjust()
		: base(CIFilter.CreateFilter("CIHighlightShadowAdjust"))
	{
	}

	public CIHighlightShadowAdjust(IntPtr handle)
		: base(handle)
	{
	}
}
