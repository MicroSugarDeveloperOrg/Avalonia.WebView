using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTFrameAttributeKey
{
	public static readonly NSString Progression;

	[Since(4, 2)]
	public static readonly NSString PathFillRule;

	[Since(4, 2)]
	public static readonly NSString PathWidth;

	[Since(4, 3)]
	public static readonly NSString ClippingPaths;

	[Since(4, 3)]
	public static readonly NSString PathClippingPath;

	static CTFrameAttributeKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			Progression = Dlfcn.GetStringConstant(intPtr, "kCTFrameProgressionAttributeName");
			PathFillRule = Dlfcn.GetStringConstant(intPtr, "kCTFramePathFillRuleAttributeName");
			PathWidth = Dlfcn.GetStringConstant(intPtr, "kCTFramePathWidthAttributeName");
			ClippingPaths = Dlfcn.GetStringConstant(intPtr, "kCTFrameClippingPathsAttributeName");
			PathClippingPath = Dlfcn.GetStringConstant(intPtr, "kCTFramePathClippingPathAttributeName");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
