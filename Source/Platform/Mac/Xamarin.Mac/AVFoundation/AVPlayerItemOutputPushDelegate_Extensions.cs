using System;
using ObjCRuntime;

namespace AVFoundation;

public static class AVPlayerItemOutputPushDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OutputSequenceWasFlushed(this IAVPlayerItemOutputPushDelegate This, AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outputSequenceWasFlushed:"), output.Handle);
	}
}
