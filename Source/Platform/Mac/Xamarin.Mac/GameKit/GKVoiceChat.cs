using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKVoiceChat", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKVoiceChat : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVoIPAllowed = "isVoIPAllowed";

	private static readonly IntPtr selIsVoIPAllowedHandle = Selector.GetHandle("isVoIPAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerIDs = "playerIDs";

	private static readonly IntPtr selPlayerIDsHandle = Selector.GetHandle("playerIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerStateUpdateHandler = "playerStateUpdateHandler";

	private static readonly IntPtr selPlayerStateUpdateHandlerHandle = Selector.GetHandle("playerStateUpdateHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayers = "players";

	private static readonly IntPtr selPlayersHandle = Selector.GetHandle("players");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActive_ = "setActive:";

	private static readonly IntPtr selSetActive_Handle = Selector.GetHandle("setActive:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMute_ForPlayer_ = "setMute:forPlayer:";

	private static readonly IntPtr selSetMute_ForPlayer_Handle = Selector.GetHandle("setMute:forPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayer_Muted_ = "setPlayer:muted:";

	private static readonly IntPtr selSetPlayer_Muted_Handle = Selector.GetHandle("setPlayer:muted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayerStateUpdateHandler_ = "setPlayerStateUpdateHandler:";

	private static readonly IntPtr selSetPlayerStateUpdateHandler_Handle = Selector.GetHandle("setPlayerStateUpdateHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayerVoiceChatStateDidChangeHandler_ = "setPlayerVoiceChatStateDidChangeHandler:";

	private static readonly IntPtr selSetPlayerVoiceChatStateDidChangeHandler_Handle = Selector.GetHandle("setPlayerVoiceChatStateDidChangeHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKVoiceChat");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
		[Export("setActive:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetActive_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActive_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Players' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Players' instead.")]
	public virtual string[] PlayerIDs
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Players' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Players' instead.")]
		[Export("playerIDs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerIDsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerIDsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
	public unsafe virtual GKPlayerStateUpdateHandler? PlayerStateUpdateHandler
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
		[Export("playerStateUpdateHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDGKPlayerStateUpdateHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerStateUpdateHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerStateUpdateHandlerHandle));
			return Trampolines.NIDGKPlayerStateUpdateHandler.Create(block);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetPlayerVoiceChatStateChangeHandler' instead.")]
		[Export("setPlayerStateUpdateHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDGKPlayerStateUpdateHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKPlayerStateUpdateHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlayerStateUpdateHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlayerStateUpdateHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKPlayer[] Players
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("players")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayersHandle));
			}
			return NSArray.ArrayFromHandle<GKPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[Obsolete("Use 'SetMute (bool, string)' method.")]
	public virtual void SetMute(bool isMuted, GKPlayer player)
	{
		SetMute(isMuted, player?.PlayerID);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKVoiceChat()
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
	protected GKVoiceChat(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKVoiceChat(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isVoIPAllowed")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsVoIPAllowed()
	{
		return Messaging.bool_objc_msgSend(class_ptr, selIsVoIPAllowedHandle);
	}

	[Export("setMute:forPlayer:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SetMuteStatus' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetMuteStatus' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMute(bool isMuted, string playerID)
	{
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		IntPtr arg = NSString.CreateNative(playerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selSetMute_ForPlayer_Handle, isMuted, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selSetMute_ForPlayer_Handle, isMuted, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setPlayer:muted:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMuteStatus(GKPlayer player, bool isMuted)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetPlayer_Muted_Handle, player.Handle, isMuted);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetPlayer_Muted_Handle, player.Handle, isMuted);
		}
	}

	[Export("setPlayerVoiceChatStateDidChangeHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetPlayerVoiceChatStateChangeHandler([BlockProxy(typeof(Trampolines.NIDActionArity2V65))] Action<GKPlayer, GKVoiceChatPlayerState> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V65.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlayerVoiceChatStateDidChangeHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlayerVoiceChatStateDidChangeHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Start()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
	}
}
