using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameKit;

[Register("GKMatchmaker", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKMatchmaker : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPlayersToMatch_MatchRequest_CompletionHandler_ = "addPlayersToMatch:matchRequest:completionHandler:";

	private static readonly IntPtr selAddPlayersToMatch_MatchRequest_CompletionHandler_Handle = Selector.GetHandle("addPlayersToMatch:matchRequest:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelInviteToPlayer_ = "cancelInviteToPlayer:";

	private static readonly IntPtr selCancelInviteToPlayer_Handle = Selector.GetHandle("cancelInviteToPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelPendingInviteToPlayer_ = "cancelPendingInviteToPlayer:";

	private static readonly IntPtr selCancelPendingInviteToPlayer_Handle = Selector.GetHandle("cancelPendingInviteToPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindMatchForRequest_WithCompletionHandler_ = "findMatchForRequest:withCompletionHandler:";

	private static readonly IntPtr selFindMatchForRequest_WithCompletionHandler_Handle = Selector.GetHandle("findMatchForRequest:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindPlayersForHostedMatchRequest_WithCompletionHandler_ = "findPlayersForHostedMatchRequest:withCompletionHandler:";

	private static readonly IntPtr selFindPlayersForHostedMatchRequest_WithCompletionHandler_Handle = Selector.GetHandle("findPlayersForHostedMatchRequest:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindPlayersForHostedRequest_WithCompletionHandler_ = "findPlayersForHostedRequest:withCompletionHandler:";

	private static readonly IntPtr selFindPlayersForHostedRequest_WithCompletionHandler_Handle = Selector.GetHandle("findPlayersForHostedRequest:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishMatchmakingForMatch_ = "finishMatchmakingForMatch:";

	private static readonly IntPtr selFinishMatchmakingForMatch_Handle = Selector.GetHandle("finishMatchmakingForMatch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInviteHandler = "inviteHandler";

	private static readonly IntPtr selInviteHandlerHandle = Selector.GetHandle("inviteHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchForInvite_CompletionHandler_ = "matchForInvite:completionHandler:";

	private static readonly IntPtr selMatchForInvite_CompletionHandler_Handle = Selector.GetHandle("matchForInvite:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryActivityWithCompletionHandler_ = "queryActivityWithCompletionHandler:";

	private static readonly IntPtr selQueryActivityWithCompletionHandler_Handle = Selector.GetHandle("queryActivityWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryPlayerGroupActivity_WithCompletionHandler_ = "queryPlayerGroupActivity:withCompletionHandler:";

	private static readonly IntPtr selQueryPlayerGroupActivity_WithCompletionHandler_Handle = Selector.GetHandle("queryPlayerGroupActivity:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInviteHandler_ = "setInviteHandler:";

	private static readonly IntPtr selSetInviteHandler_Handle = Selector.GetHandle("setInviteHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedMatchmaker = "sharedMatchmaker";

	private static readonly IntPtr selSharedMatchmakerHandle = Selector.GetHandle("sharedMatchmaker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartBrowsingForNearbyPlayersWithHandler_ = "startBrowsingForNearbyPlayersWithHandler:";

	private static readonly IntPtr selStartBrowsingForNearbyPlayersWithHandler_Handle = Selector.GetHandle("startBrowsingForNearbyPlayersWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartBrowsingForNearbyPlayersWithReachableHandler_ = "startBrowsingForNearbyPlayersWithReachableHandler:";

	private static readonly IntPtr selStartBrowsingForNearbyPlayersWithReachableHandler_Handle = Selector.GetHandle("startBrowsingForNearbyPlayersWithReachableHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopBrowsingForNearbyPlayers = "stopBrowsingForNearbyPlayers";

	private static readonly IntPtr selStopBrowsingForNearbyPlayersHandle = Selector.GetHandle("stopBrowsingForNearbyPlayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMatchmaker");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
	public unsafe virtual GKInviteHandler? InviteHandler
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[Export("inviteHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGKInviteHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInviteHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selInviteHandlerHandle));
			return Trampolines.NIDGKInviteHandler.Create(block);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' with an object that implements 'IGKInviteEventListenerProtocol'.")]
		[Export("setInviteHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGKInviteHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKInviteHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInviteHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInviteHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKMatchmaker SharedMatchmaker
	{
		[Export("sharedMatchmaker")]
		get
		{
			return Runtime.GetNSObject<GKMatchmaker>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedMatchmakerHandle));
		}
	}

	[Obsolete("Use 'InviteHandler' property.")]
	public virtual void SetInviteHandler(GKInviteHandler handler)
	{
		InviteHandler = handler;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKMatchmaker()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKMatchmaker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMatchmaker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addPlayersToMatch:matchRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddPlayers(GKMatch toMatch, GKMatchRequest matchRequest, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (toMatch == null)
		{
			throw new ArgumentNullException("toMatch");
		}
		if (matchRequest == null)
		{
			throw new ArgumentNullException("matchRequest");
		}
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddPlayersToMatch_MatchRequest_CompletionHandler_Handle, toMatch.Handle, matchRequest.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddPlayersToMatch_MatchRequest_CompletionHandler_Handle, toMatch.Handle, matchRequest.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task AddPlayersAsync(GKMatch toMatch, GKMatchRequest matchRequest)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		AddPlayers(toMatch, matchRequest, delegate(NSError obj_)
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

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("cancelInviteToPlayer:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'CancelPendingInvite' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'CancelPendingInvite' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelInvite(string playerID)
	{
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		IntPtr arg = NSString.CreateNative(playerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelInviteToPlayer_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelInviteToPlayer_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cancelPendingInviteToPlayer:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelPendingInvite(GKPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelPendingInviteToPlayer_Handle, player.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelPendingInviteToPlayer_Handle, player.Handle);
		}
	}

	[Export("findMatchForRequest:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FindMatch(GKMatchRequest request, [BlockProxy(typeof(Trampolines.NIDGKNotificationMatch))] GKNotificationMatch? matchHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (matchHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKNotificationMatch.Handler, matchHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindMatchForRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindMatchForRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKMatch> FindMatchAsync(GKMatchRequest request)
	{
		TaskCompletionSource<GKMatch> tcs = new TaskCompletionSource<GKMatch>();
		FindMatch(request, delegate(GKMatch match_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(match_);
			}
		});
		return tcs.Task;
	}

	[Export("findPlayersForHostedMatchRequest:withCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'FindPlayersForHostedRequest' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'FindPlayersForHostedRequest' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FindPlayers(GKMatchRequest request, [BlockProxy(typeof(Trampolines.NIDGKFriendsHandler))] GKFriendsHandler? playerHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (playerHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKFriendsHandler.Handler, playerHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindPlayersForHostedMatchRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindPlayersForHostedMatchRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'FindPlayersForHostedRequest' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'FindPlayersForHostedRequest' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string[]> FindPlayersAsync(GKMatchRequest request)
	{
		TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
		FindPlayers(request, delegate(string[] friends_, NSError error_)
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

	[Export("findPlayersForHostedRequest:withCompletionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FindPlayersForHostedRequest(GKMatchRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V48))] Action<GKPlayer[], NSError>? completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFindPlayersForHostedRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFindPlayersForHostedRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer[]> FindPlayersForHostedRequestAsync(GKMatchRequest request)
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		FindPlayersForHostedRequest(request, delegate(GKPlayer[] arg1_, NSError arg2_)
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

	[Export("finishMatchmakingForMatch:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishMatchmaking(GKMatch match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishMatchmakingForMatch_Handle, match.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishMatchmakingForMatch_Handle, match.Handle);
		}
	}

	[Export("matchForInvite:completionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Match(GKInvite invite, [BlockProxy(typeof(Trampolines.NIDActionArity2V58))] Action<GKMatch, NSError>? completionHandler)
	{
		if (invite == null)
		{
			throw new ArgumentNullException("invite");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V58.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMatchForInvite_CompletionHandler_Handle, invite.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMatchForInvite_CompletionHandler_Handle, invite.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKMatch> MatchAsync(GKInvite invite)
	{
		TaskCompletionSource<GKMatch> tcs = new TaskCompletionSource<GKMatch>();
		Match(invite, delegate(GKMatch arg1_, NSError arg2_)
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

	[Export("queryActivityWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void QueryActivity([BlockProxy(typeof(Trampolines.NIDGKQueryHandler))] GKQueryHandler? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKQueryHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selQueryActivityWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryActivityWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<nint> QueryActivityAsync()
	{
		TaskCompletionSource<nint> tcs = new TaskCompletionSource<nint>();
		QueryActivity(delegate(nint activity_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(activity_);
			}
		});
		return tcs.Task;
	}

	[Export("queryPlayerGroupActivity:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void QueryPlayerGroupActivity(nint playerGroup, [BlockProxy(typeof(Trampolines.NIDGKQueryHandler))] GKQueryHandler? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKQueryHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selQueryPlayerGroupActivity_WithCompletionHandler_Handle, playerGroup, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selQueryPlayerGroupActivity_WithCompletionHandler_Handle, playerGroup, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<nint> QueryPlayerGroupActivityAsync(nint playerGroup)
	{
		TaskCompletionSource<nint> tcs = new TaskCompletionSource<nint>();
		QueryPlayerGroupActivity(playerGroup, delegate(nint activity_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(activity_);
			}
		});
		return tcs.Task;
	}

	[Export("startBrowsingForNearbyPlayersWithReachableHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'StartBrowsingForNearbyPlayers(Action<GKPlayer, bool> handler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'StartBrowsingForNearbyPlayers(Action<GKPlayer, bool> handler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartBrowsingForNearbyPlayers([BlockProxy(typeof(Trampolines.NIDActionArity2V61))] Action<string, bool>? reachableHandler)
	{
		BlockLiteral* ptr;
		if (reachableHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V61.Handler, reachableHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartBrowsingForNearbyPlayersWithReachableHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartBrowsingForNearbyPlayersWithReachableHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("startBrowsingForNearbyPlayersWithHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartBrowsingForNearbyPlayers([BlockProxy(typeof(Trampolines.NIDActionArity2V62))] Action<GKPlayer, bool>? handler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V62.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartBrowsingForNearbyPlayersWithHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartBrowsingForNearbyPlayersWithHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("stopBrowsingForNearbyPlayers")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopBrowsingForNearbyPlayers()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopBrowsingForNearbyPlayersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopBrowsingForNearbyPlayersHandle);
		}
	}
}
