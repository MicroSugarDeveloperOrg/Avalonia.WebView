using System;

namespace CoreText;

internal class CTParagraphStyleSpecifierSingleValue : CTParagraphStyleSpecifierValue
{
	private nfloat value;

	internal override int ValueSize => IntPtr.Size;

	public CTParagraphStyleSpecifierSingleValue(CTParagraphStyleSpecifier spec, nfloat value)
		: base(spec)
	{
		this.value = value;
	}

	internal override void WriteValue(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].single = value;
	}
}
