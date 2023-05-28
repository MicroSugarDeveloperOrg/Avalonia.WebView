using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

public static class GKSavedGameListener_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidModifySavedGame(this IGKSavedGameListener This, GKPlayer player, GKSavedGame savedGame)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (savedGame == null)
		{
			throw new ArgumentNullException("savedGame");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:didModifySavedGame:"), player.Handle, savedGame.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void HasConflictingSavedGames(this IGKSavedGameListener This, GKPlayer player, GKSavedGame[] savedGames)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (savedGames == null)
		{
			throw new ArgumentNullException("savedGames");
		}
		NSArray nSArray = NSArray.FromNSObjects(savedGames);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("player:hasConflictingSavedGames:"), player.Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}
