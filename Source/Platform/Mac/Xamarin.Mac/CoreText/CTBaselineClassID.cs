using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

internal static class CTBaselineClassID
{
	public static readonly NSString Roman;

	public static readonly NSString IdeographicCentered;

	public static readonly NSString IdeographicLow;

	public static readonly NSString IdeographicHigh;

	public static readonly NSString Hanging;

	public static readonly NSString Math;

	static CTBaselineClassID()
	{
		IntPtr handle = Libraries.CoreText.Handle;
		Roman = Dlfcn.GetStringConstant(handle, "kCTBaselineClassRoman");
		IdeographicCentered = Dlfcn.GetStringConstant(handle, "kCTBaselineClassIdeographicCentered");
		IdeographicLow = Dlfcn.GetStringConstant(handle, "kCTBaselineClassIdeographicLow");
		IdeographicHigh = Dlfcn.GetStringConstant(handle, "kCTBaselineClassIdeographicHigh");
		Hanging = Dlfcn.GetStringConstant(handle, "kCTBaselineClassHanging");
		Math = Dlfcn.GetStringConstant(handle, "kCTBaselineClassMath");
	}

	public static NSString ToNSString(CTBaselineClass key)
	{
		return key switch
		{
			CTBaselineClass.Roman => Roman, 
			CTBaselineClass.IdeographicCentered => IdeographicCentered, 
			CTBaselineClass.IdeographicLow => IdeographicLow, 
			CTBaselineClass.IdeographicHigh => IdeographicHigh, 
			CTBaselineClass.Hanging => Hanging, 
			CTBaselineClass.Math => Math, 
			_ => throw new ArgumentOutOfRangeException("key"), 
		};
	}

	public static CTBaselineClass FromHandle(IntPtr handle)
	{
		if (handle == Roman.Handle)
		{
			return CTBaselineClass.Roman;
		}
		if (handle == IdeographicCentered.Handle)
		{
			return CTBaselineClass.IdeographicCentered;
		}
		if (handle == IdeographicLow.Handle)
		{
			return CTBaselineClass.IdeographicLow;
		}
		if (handle == IdeographicHigh.Handle)
		{
			return CTBaselineClass.IdeographicHigh;
		}
		if (handle == Hanging.Handle)
		{
			return CTBaselineClass.Hanging;
		}
		if (handle == Math.Handle)
		{
			return CTBaselineClass.Math;
		}
		throw new ArgumentOutOfRangeException("handle");
	}
}
