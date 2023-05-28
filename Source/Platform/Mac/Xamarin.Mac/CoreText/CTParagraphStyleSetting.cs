using Xamarin.Mac.System.Mac;

namespace CoreText;

internal struct CTParagraphStyleSetting
{
	public CTParagraphStyleSpecifier spec;

	public nuint valueSize;

	public IntPtr value;
}
