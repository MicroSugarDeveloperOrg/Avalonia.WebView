using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVPlayerItemOutputPushDelegateWrapper : BaseWrapper, IAVPlayerItemOutputPushDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVPlayerItemOutputPushDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
