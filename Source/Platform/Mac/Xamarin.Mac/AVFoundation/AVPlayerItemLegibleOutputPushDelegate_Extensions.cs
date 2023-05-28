using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVPlayerItemLegibleOutputPushDelegate_Extensions
{
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputAttributedStrings(this IAVPlayerItemLegibleOutputPushDelegate This, AVPlayerItemLegibleOutput output, NSAttributedString[] strings, CMSampleBuffer[] nativeSamples, CMTime itemTime)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (strings == null)
		{
			throw new ArgumentNullException("strings");
		}
		if (nativeSamples == null)
		{
			throw new ArgumentNullException("nativeSamples");
		}
		NSArray nSArray = NSArray.FromNSObjects(strings);
		NSArray nSArray2 = NSArray.FromNSObjects(nativeSamples);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_CMTime(This.Handle, Selector.GetHandle("legibleOutput:didOutputAttributedStrings:nativeSampleBuffers:forItemTime:"), output.Handle, nSArray.Handle, nSArray2.Handle, itemTime);
		nSArray.Dispose();
		nSArray2.Dispose();
	}
}
