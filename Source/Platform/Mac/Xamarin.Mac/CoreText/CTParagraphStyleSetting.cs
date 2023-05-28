using System;

namespace CoreText;

internal struct CTParagraphStyleSetting
{
	public CTParagraphStyleSpecifier spec;

	public nuint valueSize;

	public IntPtr value;
}
