using Xamarin.Mac.System.Mac;

namespace CoreText;

internal class CTParagraphStyleSpecifierNativeIntValue : CTParagraphStyleSpecifierValue
{
	private nuint value;

	internal override int ValueSize => IntPtr.Size;

	public CTParagraphStyleSpecifierNativeIntValue(CTParagraphStyleSpecifier spec, nuint value)
		: base(spec)
	{
		this.value = value;
	}

	internal override void WriteValue(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].native_uint = value;
	}
}
