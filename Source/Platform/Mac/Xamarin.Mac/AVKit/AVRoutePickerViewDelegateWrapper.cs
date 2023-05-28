using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

internal sealed class AVRoutePickerViewDelegateWrapper : BaseWrapper, IAVRoutePickerViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVRoutePickerViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
