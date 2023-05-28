using System;
using ObjCRuntime;

namespace GameKit;

public static class GKTurnBasedEventHandlerDelegate_Extensions
{
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'HandleTurnEvent' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'HandleTurnEvent' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HandleTurnEventForMatch(this IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("handleTurnEventForMatch:"), match.Handle);
	}

	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HandleMatchEnded(this IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("handleMatchEnded:"), match.Handle);
	}

	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HandleTurnEvent(this IGKTurnBasedEventHandlerDelegate This, GKTurnBasedMatch match, bool activated)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("handleTurnEventForMatch:didBecomeActive:"), match.Handle, activated);
	}
}
