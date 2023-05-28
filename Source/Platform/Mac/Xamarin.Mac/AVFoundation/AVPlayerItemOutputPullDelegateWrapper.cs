using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVPlayerItemOutputPullDelegateWrapper : BaseWrapper, IAVPlayerItemOutputPullDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVPlayerItemOutputPullDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
