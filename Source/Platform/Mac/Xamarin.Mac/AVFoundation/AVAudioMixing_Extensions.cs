using System;
using ObjCRuntime;

namespace AVFoundation;

public static class AVAudioMixing_Extensions
{
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudioMixingDestination? DestinationForMixer(this IAVAudioMixing This, AVAudioNode mixer, nuint bus)
	{
		if (mixer == null)
		{
			throw new ArgumentNullException("mixer");
		}
		return Runtime.GetNSObject<AVAudioMixingDestination>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("destinationForMixer:bus:"), mixer.Handle, bus));
	}
}
