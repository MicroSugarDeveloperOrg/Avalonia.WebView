using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTFrameAttributeKey
{
	public static readonly NSString Progression;

	public static readonly NSString PathFillRule;

	public static readonly NSString PathWidth;

	public static readonly NSString ClippingPaths;

	public static readonly NSString PathClippingPath;

	static CTFrameAttributeKey()
	{
		IntPtr handle = Libraries.CoreText.Handle;
		Progression = Dlfcn.GetStringConstant(handle, "kCTFrameProgressionAttributeName");
		PathFillRule = Dlfcn.GetStringConstant(handle, "kCTFramePathFillRuleAttributeName");
		PathWidth = Dlfcn.GetStringConstant(handle, "kCTFramePathWidthAttributeName");
		ClippingPaths = Dlfcn.GetStringConstant(handle, "kCTFrameClippingPathsAttributeName");
		PathClippingPath = Dlfcn.GetStringConstant(handle, "kCTFramePathClippingPathAttributeName");
	}
}
