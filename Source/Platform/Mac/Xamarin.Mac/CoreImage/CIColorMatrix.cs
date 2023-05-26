using System;

namespace CoreImage;

public class CIColorMatrix : CIFilter
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

	public CIVector RVector
	{
		get
		{
			return GetVector("inputRVector");
		}
		set
		{
			SetValue("inputRVector", value);
		}
	}

	public CIVector GVector
	{
		get
		{
			return GetVector("inputGVector");
		}
		set
		{
			SetValue("inputGVector", value);
		}
	}

	public CIVector BVector
	{
		get
		{
			return GetVector("inputBVector");
		}
		set
		{
			SetValue("inputBVector", value);
		}
	}

	public CIVector AVector
	{
		get
		{
			return GetVector("inputAVector");
		}
		set
		{
			SetValue("inputAVector", value);
		}
	}

	public CIVector BiasVector
	{
		get
		{
			return GetVector("inputBiasVector");
		}
		set
		{
			SetValue("inputBiasVector", value);
		}
	}

	public CIColorMatrix()
		: base(CIFilter.CreateFilter("CIColorMatrix"))
	{
	}

	public CIColorMatrix(IntPtr handle)
		: base(handle)
	{
	}
}
