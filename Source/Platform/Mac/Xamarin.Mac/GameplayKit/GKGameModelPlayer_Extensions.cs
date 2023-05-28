using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

public static class GKGameModelPlayer_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetPlayerId(this IGKGameModelPlayer This)
	{
		return Messaging.nint_objc_msgSend(This.Handle, Selector.GetHandle("playerId"));
	}
}
