using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

public static class AVPlayerItemMetadataOutputPushDelegate_Extensions
{
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidOutputTimedMetadataGroups(this IAVPlayerItemMetadataOutputPushDelegate This, AVPlayerItemMetadataOutput output, AVTimedMetadataGroup[] groups, AVPlayerItemTrack? track)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (groups == null)
		{
			throw new ArgumentNullException("groups");
		}
		NSArray nSArray = NSArray.FromNSObjects(groups);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("metadataOutput:didOutputTimedMetadataGroups:fromPlayerItemTrack:"), output.Handle, nSArray.Handle, track?.Handle ?? IntPtr.Zero);
		nSArray.Dispose();
	}
}
