using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVPlayerItemMetadataOutputPushDelegateWrapper : BaseWrapper, IAVPlayerItemMetadataOutputPushDelegate, INativeObject, IDisposable, IAVPlayerItemOutputPushDelegate
{
	[Preserve(Conditional = true)]
	public AVPlayerItemMetadataOutputPushDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
