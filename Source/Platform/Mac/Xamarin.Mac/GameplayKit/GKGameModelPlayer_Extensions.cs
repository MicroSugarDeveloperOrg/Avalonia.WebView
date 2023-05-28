using System;
using ObjCRuntime;

namespace GameplayKit;

public static class GKGameModelPlayer_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetPlayerId(this IGKGameModelPlayer This)
	{
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("playerId"));
	}
}
