using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSLayerDelegateContentsScaleUpdatingWrapper : BaseWrapper, INSLayerDelegateContentsScaleUpdating, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSLayerDelegateContentsScaleUpdatingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
