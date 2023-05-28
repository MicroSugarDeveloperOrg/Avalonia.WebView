using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAudioPlayerDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FinishedPlaying(this IAVAudioPlayerDelegate This, AVAudioPlayer player, bool flag)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("audioPlayerDidFinishPlaying:successfully:"), player.Handle, flag);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DecoderError(this IAVAudioPlayerDelegate This, AVAudioPlayer player, NSError? error)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("audioPlayerDecodeErrorDidOccur:error:"), player.Handle, error?.Handle ?? IntPtr.Zero);
	}
}
