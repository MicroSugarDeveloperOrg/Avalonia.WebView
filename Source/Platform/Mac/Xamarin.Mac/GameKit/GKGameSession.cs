using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKGameSession", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GKMatchmakerViewController' (real-time) or 'GKTurnBasedMatchmakerViewController' (turn-based) instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GKMatchmakerViewController' (real-time) or 'GKTurnBasedMatchmakerViewController' (turn-based) instead.")]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GKMatchmakerViewController' (real-time) or 'GKTurnBasedMatchmakerViewController' (turn-based) instead.")]
public class GKGameSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddEventListener_ = "addEventListener:";

	private static readonly IntPtr selAddEventListener_Handle = Selector.GetHandle("addEventListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBadgedPlayers = "badgedPlayers";

	private static readonly IntPtr selBadgedPlayersHandle = Selector.GetHandle("badgedPlayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearBadgeForPlayers_CompletionHandler_ = "clearBadgeForPlayers:completionHandler:";

	private static readonly IntPtr selClearBadgeForPlayers_CompletionHandler_Handle = Selector.GetHandle("clearBadgeForPlayers:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateSessionInContainer_WithTitle_MaxConnectedPlayers_CompletionHandler_ = "createSessionInContainer:withTitle:maxConnectedPlayers:completionHandler:";

	private static readonly IntPtr selCreateSessionInContainer_WithTitle_MaxConnectedPlayers_CompletionHandler_Handle = Selector.GetHandle("createSessionInContainer:withTitle:maxConnectedPlayers:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetShareURLWithCompletionHandler_ = "getShareURLWithCompletionHandler:";

	private static readonly IntPtr selGetShareURLWithCompletionHandler_Handle = Selector.GetHandle("getShareURLWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastModifiedDate = "lastModifiedDate";

	private static readonly IntPtr selLastModifiedDateHandle = Selector.GetHandle("lastModifiedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastModifiedPlayer = "lastModifiedPlayer";

	private static readonly IntPtr selLastModifiedPlayerHandle = Selector.GetHandle("lastModifiedPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadDataWithCompletionHandler_ = "loadDataWithCompletionHandler:";

	private static readonly IntPtr selLoadDataWithCompletionHandler_Handle = Selector.GetHandle("loadDataWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadSessionWithIdentifier_CompletionHandler_ = "loadSessionWithIdentifier:completionHandler:";

	private static readonly IntPtr selLoadSessionWithIdentifier_CompletionHandler_Handle = Selector.GetHandle("loadSessionWithIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadSessionsInContainer_CompletionHandler_ = "loadSessionsInContainer:completionHandler:";

	private static readonly IntPtr selLoadSessionsInContainer_CompletionHandler_Handle = Selector.GetHandle("loadSessionsInContainer:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxNumberOfConnectedPlayers = "maxNumberOfConnectedPlayers";

	private static readonly IntPtr selMaxNumberOfConnectedPlayersHandle = Selector.GetHandle("maxNumberOfConnectedPlayers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwner = "owner";

	private static readonly IntPtr selOwnerHandle = Selector.GetHandle("owner");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayers = "players";

	private static readonly IntPtr selPlayersHandle = Selector.GetHandle("players");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayersWithConnectionState_ = "playersWithConnectionState:";

	private static readonly IntPtr selPlayersWithConnectionState_Handle = Selector.GetHandle("playersWithConnectionState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEventListener_ = "removeEventListener:";

	private static readonly IntPtr selRemoveEventListener_Handle = Selector.GetHandle("removeEventListener:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSessionWithIdentifier_CompletionHandler_ = "removeSessionWithIdentifier:completionHandler:";

	private static readonly IntPtr selRemoveSessionWithIdentifier_CompletionHandler_Handle = Selector.GetHandle("removeSessionWithIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveData_CompletionHandler_ = "saveData:completionHandler:";

	private static readonly IntPtr selSaveData_CompletionHandler_Handle = Selector.GetHandle("saveData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendData_WithTransportType_CompletionHandler_ = "sendData:withTransportType:completionHandler:";

	private static readonly IntPtr selSendData_WithTransportType_CompletionHandler_Handle = Selector.GetHandle("sendData:withTransportType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMessageWithLocalizedFormatKey_Arguments_Data_ToPlayers_BadgePlayers_CompletionHandler_ = "sendMessageWithLocalizedFormatKey:arguments:data:toPlayers:badgePlayers:completionHandler:";

	private static readonly IntPtr selSendMessageWithLocalizedFormatKey_Arguments_Data_ToPlayers_BadgePlayers_CompletionHandler_Handle = Selector.GetHandle("sendMessageWithLocalizedFormatKey:arguments:data:toPlayers:badgePlayers:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConnectionState_CompletionHandler_ = "setConnectionState:completionHandler:";

	private static readonly IntPtr selSetConnectionState_CompletionHandler_Handle = Selector.GetHandle("setConnectionState:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGameSession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKCloudPlayer[] BadgedPlayers
	{
		[Export("badgedPlayers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selBadgedPlayersHandle));
			}
			return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBadgedPlayersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LastModifiedDate
	{
		[Export("lastModifiedDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastModifiedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastModifiedDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKCloudPlayer LastModifiedPlayer
	{
		[Export("lastModifiedPlayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKCloudPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastModifiedPlayerHandle));
			}
			return Runtime.GetNSObject<GKCloudPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastModifiedPlayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaxNumberOfConnectedPlayers
	{
		[Export("maxNumberOfConnectedPlayers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxNumberOfConnectedPlayersHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxNumberOfConnectedPlayersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKCloudPlayer Owner
	{
		[Export("owner")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKCloudPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerHandle));
			}
			return Runtime.GetNSObject<GKCloudPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKCloudPlayer[] Players
	{
		[Export("players")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayersHandle));
			}
			return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidAddPlayer(GKGameSession session, GKCloudPlayer player)
	{
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidChangeConnectionState(GKGameSession session, GKCloudPlayer player, GKConnectionState newState)
	{
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidReceiveData(GKGameSession session, NSData data, GKCloudPlayer player)
	{
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidReceiveMessage(GKGameSession session, string message, NSData data, GKCloudPlayer player)
	{
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidRemovePlayer(GKGameSession session, GKCloudPlayer player)
	{
	}

	[Obsolete("Empty stub (GKGameSessionEventListenerPrivate category members are not public API).")]
	public static void DidSaveData(GKGameSession session, GKCloudPlayer player, NSData data)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGameSession()
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
	protected GKGameSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGameSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addEventListener:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.RegisterListener' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddEventListener(IGKGameSessionEventListener listener)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selAddEventListener_Handle, listener.Handle);
	}

	[Export("clearBadgeForPlayers:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ClearBadge(GKCloudPlayer[] players, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(players);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selClearBadgeForPlayers_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selClearBadgeForPlayers_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ClearBadgeAsync(GKCloudPlayer[] players)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ClearBadge(players, delegate(NSError obj_)
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

	[Export("createSessionInContainer:withTitle:maxConnectedPlayers:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void CreateSession(string? containerName, string title, nint maxPlayers, [BlockProxy(typeof(Trampolines.NIDActionArity2V51))] Action<GKGameSession, NSError> completionHandler)
	{
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(containerName);
		IntPtr arg2 = NSString.CreateNative(title);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V51.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(class_ptr, selCreateSessionInContainer_WithTitle_MaxConnectedPlayers_CompletionHandler_Handle, arg, arg2, maxPlayers, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKGameSession> CreateSessionAsync(string? containerName, string title, nint maxPlayers)
	{
		TaskCompletionSource<GKGameSession> tcs = new TaskCompletionSource<GKGameSession>();
		CreateSession(containerName, title, maxPlayers, delegate(GKGameSession arg1_, NSError arg2_)
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

	[Export("playersWithConnectionState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKCloudPlayer[] GetPlayers(GKConnectionState state)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selPlayersWithConnectionState_Handle, (long)state));
		}
		return NSArray.ArrayFromHandle<GKCloudPlayer>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selPlayersWithConnectionState_Handle, (long)state));
	}

	[Export("getShareURLWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetShareUrl([BlockProxy(typeof(Trampolines.NIDActionArity2V6))] Action<NSUrl, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V6.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetShareURLWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetShareURLWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrl> GetShareUrlAsync()
	{
		TaskCompletionSource<NSUrl> tcs = new TaskCompletionSource<NSUrl>();
		GetShareUrl(delegate(NSUrl arg1_, NSError arg2_)
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

	[Export("loadDataWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadData([BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadDataAsync()
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		LoadData(delegate(NSData arg1_, NSError arg2_)
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

	[Export("loadSessionWithIdentifier:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadSession(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V51))] Action<GKGameSession, NSError> completionHandler)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V51.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadSessionWithIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKGameSession> LoadSessionAsync(string identifier)
	{
		TaskCompletionSource<GKGameSession> tcs = new TaskCompletionSource<GKGameSession>();
		LoadSession(identifier, delegate(GKGameSession arg1_, NSError arg2_)
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

	[Export("loadSessionsInContainer:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadSessions(string? containerName, [BlockProxy(typeof(Trampolines.NIDActionArity2V52))] Action<GKGameSession[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(containerName);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V52.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadSessionsInContainer_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKGameSession[]> LoadSessionsAsync(string? containerName)
	{
		TaskCompletionSource<GKGameSession[]> tcs = new TaskCompletionSource<GKGameSession[]>();
		LoadSessions(containerName, delegate(GKGameSession[] arg1_, NSError arg2_)
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

	[Export("removeEventListener:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GKLocalPlayer.UnregisterListener' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.UnregisterListener' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.UnregisterListener' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveEventListener(IGKGameSessionEventListener listener)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveEventListener_Handle, listener.Handle);
	}

	[Export("removeSessionWithIdentifier:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RemoveSession(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selRemoveSessionWithIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task RemoveSessionAsync(string identifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RemoveSession(identifier, delegate(NSError obj_)
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

	[Export("saveData:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveData(NSData data, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveData_CompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveData_CompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> SaveDataAsync(NSData data)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		SaveData(data, delegate(NSData arg1_, NSError arg2_)
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

	[Export("sendData:withTransportType:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendData(NSData data, GKTransportType transport, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selSendData_WithTransportType_CompletionHandler_Handle, data.Handle, (long)transport, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selSendData_WithTransportType_CompletionHandler_Handle, data.Handle, (long)transport, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendDataAsync(NSData data, GKTransportType transport)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendData(data, transport, delegate(NSError obj_)
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

	[Export("sendMessageWithLocalizedFormatKey:arguments:data:toPlayers:badgePlayers:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendMessage(string key, string[] arguments, NSData data, GKCloudPlayer[] players, bool badgePlayers, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSArray nSArray = NSArray.FromStrings(arguments);
		NSArray nSArray2 = NSArray.FromNSObjects(players);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr(base.Handle, selSendMessageWithLocalizedFormatKey_Arguments_Data_ToPlayers_BadgePlayers_CompletionHandler_Handle, arg, nSArray.Handle, data.Handle, nSArray2.Handle, badgePlayers, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_bool_IntPtr(base.SuperHandle, selSendMessageWithLocalizedFormatKey_Arguments_Data_ToPlayers_BadgePlayers_CompletionHandler_Handle, arg, nSArray.Handle, data.Handle, nSArray2.Handle, badgePlayers, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendMessageAsync(string key, string[] arguments, NSData data, GKCloudPlayer[] players, bool badgePlayers)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendMessage(key, arguments, data, players, badgePlayers, delegate(NSError obj_)
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

	[Export("setConnectionState:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetConnectionState(GKConnectionState state, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selSetConnectionState_CompletionHandler_Handle, (long)state, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selSetConnectionState_CompletionHandler_Handle, (long)state, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SetConnectionStateAsync(GKConnectionState state)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetConnectionState(state, delegate(NSError obj_)
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
}
