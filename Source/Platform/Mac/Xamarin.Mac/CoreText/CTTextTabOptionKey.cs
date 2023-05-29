using System;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public static class CTTextTabOptionKey
{
	public static readonly NSString ColumnTerminators;

	static CTTextTabOptionKey()
	{
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			ColumnTerminators = Dlfcn.GetStringConstant(intPtr, "kCTTabColumnTerminatorsAttributeName");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}
}
