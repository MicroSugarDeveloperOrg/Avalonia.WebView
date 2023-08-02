using System;
using CoreFoundation;

namespace CoreText;

internal class CTParagraphStyleSpecifierIntPtrsValue : CTParagraphStyleSpecifierValue
{
	private CFArray value;

	internal override int ValueSize => IntPtr.Size;

	public CTParagraphStyleSpecifierIntPtrsValue(CTParagraphStyleSpecifier spec, IntPtr[] value)
		: base(spec)
	{
		this.value = CFArray.FromIntPtrs(value);
	}

	internal override void WriteValue(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].pointer = value.Handle;
	}

	public override void Dispose(CTParagraphStyleSettingValue[] values, int index)
	{
		values[index].pointer = IntPtr.Zero;
		value.Dispose();
		value = null;
	}
}
