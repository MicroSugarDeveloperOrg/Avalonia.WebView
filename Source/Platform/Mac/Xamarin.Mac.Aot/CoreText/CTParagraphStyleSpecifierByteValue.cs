namespace CoreText;

internal class CTParagraphStyleSpecifierByteValue : CTParagraphStyleSpecifierValue
{
	private byte value;

	internal override int ValueSize => 1;

	public CTParagraphStyleSpecifierByteValue(CTParagraphStyleSpecifier spec, byte value)
		: base(spec)
	{
		this.value = value;
	}

	internal override void WriteValue(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].int8 = value;
	}
}
