using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

public static class GKGameModel_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint GetScore(this IGKGameModel This, IGKGameModelPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return Messaging.nint_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("scoreForPlayer:"), player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsWin(this IGKGameModel This, IGKGameModelPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("isWinForPlayer:"), player.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsLoss(this IGKGameModel This, IGKGameModelPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("isLossForPlayer:"), player.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnapplyGameModelUpdate(this IGKGameModel This, IGKGameModelUpdate gameModelUpdate)
	{
		if (gameModelUpdate == null)
		{
			throw new ArgumentNullException("gameModelUpdate");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("unapplyGameModelUpdate:"), gameModelUpdate.Handle);
	}
}
