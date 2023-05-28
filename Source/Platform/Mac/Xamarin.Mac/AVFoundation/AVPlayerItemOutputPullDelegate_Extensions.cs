using System;
using ObjCRuntime;

namespace AVFoundation;

public static class AVPlayerItemOutputPullDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OutputMediaDataWillChange(this IAVPlayerItemOutputPullDelegate This, AVPlayerItemOutput sender)
	{
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outputMediaDataWillChange:"), sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void OutputSequenceWasFlushed(this IAVPlayerItemOutputPullDelegate This, AVPlayerItemOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("outputSequenceWasFlushed:"), output.Handle);
	}
}
