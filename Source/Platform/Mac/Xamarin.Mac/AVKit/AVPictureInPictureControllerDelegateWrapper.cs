using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

internal sealed class AVPictureInPictureControllerDelegateWrapper : BaseWrapper, IAVPictureInPictureControllerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVPictureInPictureControllerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
