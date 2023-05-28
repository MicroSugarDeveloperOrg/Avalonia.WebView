using Foundation;
using ObjCRuntime;

namespace CoreText;

public static class CTTextTabOptionKey
{
	public static readonly NSString ColumnTerminators;

	static CTTextTabOptionKey()
	{
		ColumnTerminators = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTTabColumnTerminatorsAttributeName");
	}
}
