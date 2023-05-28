using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVAudioPlayerDelegateWrapper : BaseWrapper, IAVAudioPlayerDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVAudioPlayerDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
