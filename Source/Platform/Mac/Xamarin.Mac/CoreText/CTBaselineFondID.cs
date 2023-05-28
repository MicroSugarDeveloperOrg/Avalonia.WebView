using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

internal static class CTBaselineFondID
{
	public static readonly NSString Reference;

	public static readonly NSString Original;

	static CTBaselineFondID()
	{
		IntPtr handle = Libraries.CoreText.Handle;
		Reference = Dlfcn.GetStringConstant(handle, "kCTBaselineReferenceFont");
		Original = Dlfcn.GetStringConstant(handle, "kCTBaselineOriginalFont");
	}

	public static NSString ToNSString(CTBaselineFont key)
	{
		return key switch
		{
			CTBaselineFont.Reference => Reference, 
			CTBaselineFont.Original => Original, 
			_ => throw new ArgumentOutOfRangeException("key"), 
		};
	}
}
