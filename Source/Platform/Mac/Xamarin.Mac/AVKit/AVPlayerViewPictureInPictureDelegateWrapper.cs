using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

internal sealed class AVPlayerViewPictureInPictureDelegateWrapper : BaseWrapper, IAVPlayerViewPictureInPictureDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVPlayerViewPictureInPictureDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
