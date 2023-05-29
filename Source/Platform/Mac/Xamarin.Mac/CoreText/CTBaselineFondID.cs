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
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Reference = Dlfcn.GetStringConstant(intPtr, "kCTBaselineReferenceFont");
			Original = Dlfcn.GetStringConstant(intPtr, "kCTBaselineOriginalFont");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
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
