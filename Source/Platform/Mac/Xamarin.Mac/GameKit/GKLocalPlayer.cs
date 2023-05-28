using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKLocalPlayer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKLocalPlayer : GKPlayer, IGKSavedGameListener, INativeObject, IDisposable
{
	public new static class Notifications
	{
		public static NSObject ObserveAuthenticationDidChangeNotificationName(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AuthenticationDidChangeNotificationName, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveAuthenticationDidChangeNotificationName(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(AuthenticationDidChangeNotificationName, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthenticateHandler = "authenticateHandler";

	private static readonly IntPtr selAuthenticateHandlerHandle = Selector.GetHandle("authenticateHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAuthenticateWithCompletionHandler_ = "authenticateWithCompletionHandler:";

	private static readonly IntPtr selAuthenticateWithCompletionHandler_Handle = Selector.GetHandle("authenticateWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteSavedGamesWithName_CompletionHandler_ = "deleteSavedGamesWithName:completionHandler:";

	private static readonly IntPtr selDeleteSavedGamesWithName_CompletionHandler_Handle = Selector.GetHandle("deleteSavedGamesWithName:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchItemsForIdentityVerificationSignature_ = "fetchItemsForIdentityVerificationSignature:";

	private static readonly IntPtr selFetchItemsForIdentityVerificationSignature_Handle = Selector.GetHandle("fetchItemsForIdentityVerificationSignature:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchSavedGamesWithCompletionHandler_ = "fetchSavedGamesWithCompletionHandler:";

	private static readonly IntPtr selFetchSavedGamesWithCompletionHandler_Handle = Selector.GetHandle("fetchSavedGamesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFriends = "friends";

	private static readonly IntPtr selFriendsHandle = Selector.GetHandle("friends");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateIdentityVerificationSignatureWithCompletionHandler_ = "generateIdentityVerificationSignatureWithCompletionHandler:";

	private static readonly IntPtr selGenerateIdentityVerificationSignatureWithCompletionHandler_Handle = Selector.GetHandle("generateIdentityVerificationSignatureWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAuthenticated = "isAuthenticated";

	private static readonly IntPtr selIsAuthenticatedHandle = Selector.GetHandle("isAuthenticated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMultiplayerGamingRestricted = "isMultiplayerGamingRestricted";

	private static readonly IntPtr selIsMultiplayerGamingRestrictedHandle = Selector.GetHandle("isMultiplayerGamingRestricted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUnderage = "isUnderage";

	private static readonly IntPtr selIsUnderageHandle = Selector.GetHandle("isUnderage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadChallengableFriendsWithCompletionHandler_ = "loadChallengableFriendsWithCompletionHandler:";

	private static readonly IntPtr selLoadChallengableFriendsWithCompletionHandler_Handle = Selector.GetHandle("loadChallengableFriendsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_ = "loadDefaultLeaderboardCategoryIDWithCompletionHandler:";

	private static readonly IntPtr selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_Handle = Selector.GetHandle("loadDefaultLeaderboardCategoryIDWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDefaultLeaderboardIdentifierWithCompletionHandler_ = "loadDefaultLeaderboardIdentifierWithCompletionHandler:";

	private static readonly IntPtr selLoadDefaultLeaderboardIdentifierWithCompletionHandler_Handle = Selector.GetHandle("loadDefaultLeaderboardIdentifierWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFriendPlayersWithCompletionHandler_ = "loadFriendPlayersWithCompletionHandler:";

	private static readonly IntPtr selLoadFriendPlayersWithCompletionHandler_Handle = Selector.GetHandle("loadFriendPlayersWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFriendsWithCompletionHandler_ = "loadFriendsWithCompletionHandler:";

	private static readonly IntPtr selLoadFriendsWithCompletionHandler_Handle = Selector.GetHandle("loadFriendsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadRecentPlayersWithCompletionHandler_ = "loadRecentPlayersWithCompletionHandler:";

	private static readonly IntPtr selLoadRecentPlayersWithCompletionHandler_Handle = Selector.GetHandle("loadRecentPlayersWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocal = "local";

	private static readonly IntPtr selLocalHandle = Selector.GetHandle("local");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalPlayer = "localPlayer";

	private static readonly IntPtr selLocalPlayerHandle = Selector.GetHandle("localPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer_DidModifySavedGame_ = "player:didModifySavedGame:";

	private static readonly IntPtr selPlayer_DidModifySavedGame_Handle = Selector.GetHandle("player:didModifySavedGame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer_HasConflictingSavedGames_ = "player:hasConflictingSavedGames:";

	private static readonly IntPtr selPlayer_HasConflictingSavedGames_Handle = Selector.GetHandle("player:hasConflictingSavedGames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterListener_ = "registerListener:";

	private static readonly IntPtr selRegisterListener_Handle = Selector.GetHandle("registerListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveConflictingSavedGames_WithData_CompletionHandler_ = "resolveConflictingSavedGames:withData:completionHandler:";

	private static readonly IntPtr selResolveConflictingSavedGames_WithData_CompletionHandler_Handle = Selector.GetHandle("resolveConflictingSavedGames:withData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveGameData_WithName_CompletionHandler_ = "saveGameData:withName:completionHandler:";

	private static readonly IntPtr selSaveGameData_WithName_CompletionHandler_Handle = Selector.GetHandle("saveGameData:withName:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAuthenticateHandler_ = "setAuthenticateHandler:";

	private static readonly IntPtr selSetAuthenticateHandler_Handle = Selector.GetHandle("setAuthenticateHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLeaderboardCategoryID_CompletionHandler_ = "setDefaultLeaderboardCategoryID:completionHandler:";

	private static readonly IntPtr selSetDefaultLeaderboardCategoryID_CompletionHandler_Handle = Selector.GetHandle("setDefaultLeaderboardCategoryID:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLeaderboardIdentifier_CompletionHandler_ = "setDefaultLeaderboardIdentifier:completionHandler:";

	private static readonly IntPtr selSetDefaultLeaderboardIdentifier_CompletionHandler_Handle = Selector.GetHandle("setDefaultLeaderboardIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterAllListeners = "unregisterAllListeners";

	private static readonly IntPtr selUnregisterAllListenersHandle = Selector.GetHandle("unregisterAllListeners");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnregisterListener_ = "unregisterListener:";

	private static readonly IntPtr selUnregisterListener_Handle = Selector.GetHandle("unregisterListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKLocalPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _AuthenticationDidChangeNotificationName;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public unsafe virtual Action<NSViewController, NSError>? AuthenticateHandler
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("authenticateHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDActionArity2V57))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAuthenticateHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAuthenticateHandlerHandle));
			return Trampolines.NIDActionArity2V57.Create(block);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setAuthenticateHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDActionArity2V57))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V57.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAuthenticateHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAuthenticateHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Authenticated
	{
		[Export("isAuthenticated")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAuthenticatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAuthenticatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
	public virtual string[] Friends
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadFriendPlayers' instead and collect the friends from the invoked callback.")]
		[Export("friends", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFriendsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFriendsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUnderage
	{
		[Export("isUnderage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUnderageHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUnderageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public static GKLocalPlayer Local
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("local")]
		get
		{
			return Runtime.GetNSObject<GKLocalPlayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLocalHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKLocalPlayer LocalPlayer
	{
		[Export("localPlayer")]
		get
		{
			return Runtime.GetNSObject<GKLocalPlayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLocalPlayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool MultiplayerGamingRestricted
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("isMultiplayerGamingRestricted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMultiplayerGamingRestrictedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMultiplayerGamingRestrictedHandle);
		}
	}

	[Field("GKPlayerAuthenticationDidChangeNotificationName", "GameKit")]
	[Advice("Use GKLocalPlayer.Notifications.ObserveAuthenticationDidChangeNotificationName helper method instead.")]
	public static NSString AuthenticationDidChangeNotificationName
	{
		get
		{
			if (_AuthenticationDidChangeNotificationName == null)
			{
				_AuthenticationDidChangeNotificationName = Dlfcn.GetStringConstant(Libraries.GameKit.Handle, "GKPlayerAuthenticationDidChangeNotificationName");
			}
			return _AuthenticationDidChangeNotificationName;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKLocalPlayer()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKLocalPlayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKLocalPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKLocalPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("authenticateWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Set the 'AuthenticationHandler' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Set the 'AuthenticationHandler' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Authenticate([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? handler)
	{
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAuthenticateWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAuthenticateWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Set the 'AuthenticationHandler' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 8, PlatformArchitecture.None, "Set the 'AuthenticationHandler' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task AuthenticateAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Authenticate(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("deleteSavedGamesWithName:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeleteSavedGames(string name, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? handler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selDeleteSavedGamesWithName_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDeleteSavedGamesWithName_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("player:didModifySavedGame:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidModifySavedGame(GKPlayer player, GKSavedGame savedGame)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (savedGame == null)
		{
			throw new ArgumentNullException("savedGame");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPlayer_DidModifySavedGame_Handle, player.Handle, savedGame.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPlayer_DidModifySavedGame_Handle, player.Handle, savedGame.Handle);
		}
	}

	[Export("fetchItemsForIdentityVerificationSignature:")]
	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchItemsForIdentityVerificationSignature([BlockProxy(typeof(Trampolines.NIDGKFetchItemsForIdentityVerificationSignatureCompletionHandler))] GKFetchItemsForIdentityVerificationSignatureCompletionHandler? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKFetchItemsForIdentityVerificationSignatureCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchItemsForIdentityVerificationSignature_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchItemsForIdentityVerificationSignature_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKFetchItemsForIdentityVerificationSignature> FetchItemsForIdentityVerificationSignatureAsync()
	{
		TaskCompletionSource<GKFetchItemsForIdentityVerificationSignature> tcs = new TaskCompletionSource<GKFetchItemsForIdentityVerificationSignature>();
		FetchItemsForIdentityVerificationSignature(delegate(NSUrl publicKeyUrl_, NSData signature_, NSData salt_, ulong timestamp_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new GKFetchItemsForIdentityVerificationSignature(publicKeyUrl_, signature_, salt_, timestamp_));
			}
		});
		return tcs.Task;
	}

	[Export("fetchSavedGamesWithCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchSavedGames([BlockProxy(typeof(Trampolines.NIDActionArity2V54))] Action<GKSavedGame[], NSError>? handler)
	{
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V54.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFetchSavedGamesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFetchSavedGamesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("generateIdentityVerificationSignatureWithCompletionHandler:")]
	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GenerateIdentityVerificationSignature([BlockProxy(typeof(Trampolines.NIDGKIdentityVerificationSignatureHandler))] GKIdentityVerificationSignatureHandler? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKIdentityVerificationSignatureHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGenerateIdentityVerificationSignatureWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGenerateIdentityVerificationSignatureWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Deprecated(PlatformName.iOS, 13, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 2, PlatformArchitecture.None, "Use 'FetchItemsForIdentityVerificationSignature' instead.")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKIdentityVerificationSignatureResult> GenerateIdentityVerificationSignatureAsync()
	{
		TaskCompletionSource<GKIdentityVerificationSignatureResult> tcs = new TaskCompletionSource<GKIdentityVerificationSignatureResult>();
		GenerateIdentityVerificationSignature(delegate(NSUrl publicKeyUrl_, NSData signature_, NSData salt_, ulong timestamp_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new GKIdentityVerificationSignatureResult(publicKeyUrl_, signature_, salt_, timestamp_));
			}
		});
		return tcs.Task;
	}

	[Export("player:hasConflictingSavedGames:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HasConflictingSavedGames(GKPlayer player, GKSavedGame[] savedGames)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPlayer_HasConflictingSavedGames_Handle, player.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPlayer_HasConflictingSavedGames_Handle, player.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("loadChallengableFriendsWithCompletionHandler:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadChallengeableFriends([BlockProxy(typeof(Trampolines.NIDActionArity2V48))] Action<GKPlayer[], NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V48.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadChallengableFriendsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadChallengableFriendsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer[]> LoadChallengeableFriendsAsync()
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		LoadChallengeableFriends(delegate(GKPlayer[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("loadDefaultLeaderboardCategoryIDWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadDefaultLeaderboardCategoryID([BlockProxy(typeof(Trampolines.NIDActionArity2V55))] Action<string, NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V55.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadDefaultLeaderboardCategoryIDWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadDefaultLeaderboardIdentifier' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string> LoadDefaultLeaderboardCategoryIDAsync()
	{
		TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
		LoadDefaultLeaderboardCategoryID(delegate(string arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("loadDefaultLeaderboardIdentifierWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadDefaultLeaderboardIdentifier([BlockProxy(typeof(Trampolines.NIDActionArity2V55))] Action<string, NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V55.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadDefaultLeaderboardIdentifierWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadDefaultLeaderboardIdentifierWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string> LoadDefaultLeaderboardIdentifierAsync()
	{
		TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
		LoadDefaultLeaderboardIdentifier(delegate(string arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("loadFriendPlayersWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadFriendPlayers([BlockProxy(typeof(Trampolines.NIDActionArity2V48))] Action<GKPlayer[], NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V48.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadFriendPlayersWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadFriendPlayersWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer[]> LoadFriendPlayersAsync()
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		LoadFriendPlayers(delegate(GKPlayer[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("loadFriendsWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'LoadRecentPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadRecentPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadFriends([BlockProxy(typeof(Trampolines.NIDGKFriendsHandler))] GKFriendsHandler? handler)
	{
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKFriendsHandler.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadFriendsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadFriendsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'LoadRecentPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LoadRecentPlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string[]> LoadFriendsAsync()
	{
		TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
		LoadFriends(delegate(string[] friends_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(friends_);
			}
		});
		return tcs.Task;
	}

	[Export("loadRecentPlayersWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadRecentPlayers([BlockProxy(typeof(Trampolines.NIDActionArity2V48))] Action<GKPlayer[], NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V48.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadRecentPlayersWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadRecentPlayersWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer[]> LoadRecentPlayersAsync()
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		LoadRecentPlayers(delegate(GKPlayer[] arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("registerListener:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterListener(IGKLocalPlayerListener listener)
	{
		if (listener != null)
		{
			if (!(listener is NSObject))
			{
				throw new ArgumentException("The object passed of type " + listener.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selRegisterListener_Handle, listener.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRegisterListener_Handle, listener.Handle);
			}
			return;
		}
		throw new ArgumentNullException("listener");
	}

	[Export("resolveConflictingSavedGames:withData:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ResolveConflictingSavedGames(GKSavedGame[] conflictingSavedGames, NSData data, [BlockProxy(typeof(Trampolines.NIDActionArity2V54))] Action<GKSavedGame[], NSError>? handler)
	{
		if (conflictingSavedGames == null)
		{
			throw new ArgumentNullException("conflictingSavedGames");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		NSArray nSArray = NSArray.FromNSObjects(conflictingSavedGames);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V54.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selResolveConflictingSavedGames_WithData_CompletionHandler_Handle, nSArray.Handle, data.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selResolveConflictingSavedGames_WithData_CompletionHandler_Handle, nSArray.Handle, data.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("saveGameData:withName:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveGameData(NSData data, string name, [BlockProxy(typeof(Trampolines.NIDActionArity2V56))] Action<GKSavedGame, NSError>? handler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V56.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSaveGameData_WithName_CompletionHandler_Handle, data.Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveGameData_WithName_CompletionHandler_Handle, data.Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("setDefaultLeaderboardCategoryID:completionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'SetDefaultLeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetDefaultLeaderboardIdentifier' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetDefaultLeaderboardCategoryID(string? categoryID, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		IntPtr arg = NSString.CreateNative(categoryID);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDefaultLeaderboardCategoryID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDefaultLeaderboardCategoryID_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'SetDefaultLeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetDefaultLeaderboardIdentifier' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetDefaultLeaderboardCategoryIDAsync(string? categoryID)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetDefaultLeaderboardCategoryID(categoryID, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("setDefaultLeaderboardIdentifier:completionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetDefaultLeaderboardIdentifier(string leaderboardIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (leaderboardIdentifier == null)
		{
			throw new ArgumentNullException("leaderboardIdentifier");
		}
		IntPtr arg = NSString.CreateNative(leaderboardIdentifier);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDefaultLeaderboardIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDefaultLeaderboardIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetDefaultLeaderboardIdentifierAsync(string leaderboardIdentifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetDefaultLeaderboardIdentifier(leaderboardIdentifier, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("unregisterAllListeners")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterAllListeners()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnregisterAllListenersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnregisterAllListenersHandle);
		}
	}

	[Export("unregisterListener:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnregisterListener(IGKLocalPlayerListener listener)
	{
		if (listener != null)
		{
			if (!(listener is NSObject))
			{
				throw new ArgumentException("The object passed of type " + listener.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnregisterListener_Handle, listener.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnregisterListener_Handle, listener.Handle);
			}
			return;
		}
		throw new ArgumentNullException("listener");
	}
}
