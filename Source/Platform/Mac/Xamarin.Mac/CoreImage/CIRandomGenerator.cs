using System;
using ObjCRuntime;

namespace CoreImage;

[Since(6, 0)]
public class CIRandomGenerator : CIFilter
{
	public CIRandomGenerator()
		: base("CIRandomGenerator")
	{
	}

	public CIRandomGenerator(IntPtr handle)
		: base(handle)
	{
	}
}
