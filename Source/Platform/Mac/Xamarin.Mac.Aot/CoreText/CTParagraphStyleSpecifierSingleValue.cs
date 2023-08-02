namespace CoreText;

internal class CTParagraphStyleSpecifierSingleValue : CTParagraphStyleSpecifierValue
{
	private float value;

	internal override int ValueSize => 4;

	public CTParagraphStyleSpecifierSingleValue(CTParagraphStyleSpecifier spec, float value)
		: base(spec)
	{
		this.value = value;
	}

	internal override void WriteValue(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].single = value;
	}
}
