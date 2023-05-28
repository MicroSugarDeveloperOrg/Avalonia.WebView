using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public static class NSUserActivity_IntentsAdditions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteraction = "interaction";

	private static readonly IntPtr selInteractionHandle = Selector.GetHandle("interaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSUserActivity");

	[Export("interaction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INInteraction? GetInteraction(this NSUserActivity This)
	{
		return Runtime.GetNSObject<INInteraction>(Messaging.IntPtr_objc_msgSend(This.Handle, selInteractionHandle));
	}
}
