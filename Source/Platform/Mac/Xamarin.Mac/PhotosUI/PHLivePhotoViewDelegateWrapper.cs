using System;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

internal sealed class PHLivePhotoViewDelegateWrapper : BaseWrapper, IPHLivePhotoViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHLivePhotoViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
