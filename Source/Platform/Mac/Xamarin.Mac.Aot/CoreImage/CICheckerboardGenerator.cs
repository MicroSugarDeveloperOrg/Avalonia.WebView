using System;

namespace CoreImage;

public class CICheckerboardGenerator : CIFilter
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

	public CIColor Color0
	{
		get
		{
			return GetColor("inputColor0");
		}
		set
		{
			SetValue("inputColor0", value);
		}
	}

	public CIColor Color1
	{
		get
		{
			return GetColor("inputColor1");
		}
		set
		{
			SetValue("inputColor1", value);
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

	public float Sharpness
	{
		get
		{
			return GetFloat("inputSharpness");
		}
		set
		{
			SetFloat("inputSharpness", value);
		}
	}

	public CICheckerboardGenerator()
		: base(CIFilter.CreateFilter("CICheckerboardGenerator"))
	{
	}

	public CICheckerboardGenerator(IntPtr handle)
		: base(handle)
	{
	}
}
