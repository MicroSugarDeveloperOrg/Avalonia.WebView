using System;
using System.Runtime.InteropServices;

namespace CoreText;

[StructLayout(LayoutKind.Explicit)]
internal struct CTParagraphStyleSettingValue
{
	[FieldOffset(0)]
	public byte int8;

	[FieldOffset(0)]
	public float single;

	[FieldOffset(0)]
	public IntPtr pointer;
}
