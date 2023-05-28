using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNAnimatable_Extensions
{
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddAnimation(this ISCNAnimatable This, SCNAnimationPlayer player, NSString? key)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("addAnimationPlayer:forKey:"), player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNAnimationPlayer? GetAnimationPlayer(this ISCNAnimatable This, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("animationPlayerForKey:"), key.Handle));
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveAnimationUsingBlendOutDuration(this ISCNAnimatable This, NSString key, nfloat blendOutDuration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_IntPtr_nfloat(This.Handle, Selector.GetHandle("removeAnimationForKey:blendOutDuration:"), key.Handle, blendOutDuration);
	}

	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSpeed(this ISCNAnimatable This, nfloat speed, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Messaging.void_objc_msgSend_nfloat_IntPtr(This.Handle, Selector.GetHandle("setSpeed:forAnimationKey:"), speed, key.Handle);
	}
}
