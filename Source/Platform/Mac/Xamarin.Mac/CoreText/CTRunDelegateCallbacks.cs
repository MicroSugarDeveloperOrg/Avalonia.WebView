using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace CoreText;

[StructLayout(LayoutKind.Sequential)]
internal class CTRunDelegateCallbacks
{
	public nint version;

	public CTRunDelegateDeallocateCallback dealloc;

	public CTRunDelegateGetCallback getAscent;

	public CTRunDelegateGetCallback getDescent;

	public CTRunDelegateGetCallback getWidth;
}
