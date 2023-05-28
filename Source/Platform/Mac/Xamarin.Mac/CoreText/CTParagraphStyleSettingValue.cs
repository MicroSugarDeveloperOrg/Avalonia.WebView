using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace CoreText;

[StructLayout(LayoutKind.Explicit)]
internal struct CTParagraphStyleSettingValue
{
	[FieldOffset(0)]
	public byte int8;

	[FieldOffset(0)]
	public nfloat single;

	[FieldOffset(0)]
	public nuint native_uint;

	[FieldOffset(0)]
	public IntPtr pointer;
}
