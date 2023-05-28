using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVAudioStereoMixingWrapper : BaseWrapper, IAVAudioStereoMixing, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Pan
	{
		[Export("pan")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("pan"));
		}
		[Export("setPan:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setPan:"), value);
		}
	}

	[Preserve(Conditional = true)]
	public AVAudioStereoMixingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
