using System;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMAudioFormatDescription : CMFormatDescription
{
	internal CMAudioFormatDescription(IntPtr handle)
		: base(handle)
	{
	}

	internal CMAudioFormatDescription(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
