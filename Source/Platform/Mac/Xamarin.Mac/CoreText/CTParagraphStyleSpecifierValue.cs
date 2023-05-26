namespace CoreText;

internal abstract class CTParagraphStyleSpecifierValue
{
	internal CTParagraphStyleSpecifier Spec { get; private set; }

	internal abstract int ValueSize { get; }

	protected CTParagraphStyleSpecifierValue(CTParagraphStyleSpecifier spec)
	{
		Spec = spec;
	}

	internal abstract void WriteValue(CTParagraphStyleSettingValue[] values, int index);

	public virtual void Dispose(CTParagraphStyleSettingValue[] values, int index)
	{
	}
}
