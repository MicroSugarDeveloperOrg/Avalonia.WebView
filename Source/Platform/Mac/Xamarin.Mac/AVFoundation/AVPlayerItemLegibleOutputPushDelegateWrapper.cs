using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVPlayerItemLegibleOutputPushDelegateWrapper : BaseWrapper, IAVPlayerItemLegibleOutputPushDelegate, INativeObject, IDisposable, IAVPlayerItemOutputPushDelegate
{
	[Preserve(Conditional = true)]
	public AVPlayerItemLegibleOutputPushDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
