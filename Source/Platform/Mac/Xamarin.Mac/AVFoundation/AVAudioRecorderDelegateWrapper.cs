using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVAudioRecorderDelegateWrapper : BaseWrapper, IAVAudioRecorderDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVAudioRecorderDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
