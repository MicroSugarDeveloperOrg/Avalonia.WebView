using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKMatch", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKMatch : NSObject
{
	[Register]
	internal class _GKMatchDelegate : NSObject, IGKMatchDelegate, INativeObject, IDisposable
	{
		internal EventHandler<GKPlayerErrorEventArgs>? connectionFailed;

		internal EventHandler<GKDataEventArgs>? dataReceived;

		internal EventHandler<GKDataReceivedForRecipientEventArgs>? dataReceivedForRecipient;

		internal EventHandler<GKMatchReceivedDataFromRemotePlayerEventArgs>? dataReceivedFromPlayer;

		internal EventHandler<GKErrorEventArgs>? failed;

		internal GKMatchReinvitationForDisconnectedPlayer? shouldReinviteDisconnectedPlayer;

		internal GKMatchReinvitation? shouldReinvitePlayer;

		internal EventHandler<GKStateEventArgs>? stateChanged;

		internal EventHandler<GKMatchConnectionChangedEventArgs>? stateChangedForPlayer;

		public _GKMatchDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("xamarin:selector:removed:")]
		public void ConnectionFailed(GKMatch match, string playerId, NSError error)
		{
			EventHandler<GKPlayerErrorEventArgs> eventHandler = connectionFailed;
			if (eventHandler != null)
			{
				GKPlayerErrorEventArgs e = new GKPlayerErrorEventArgs(playerId, error);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:didReceiveData:fromPlayer:")]
		public void DataReceived(GKMatch match, NSData data, string playerId)
		{
			EventHandler<GKDataEventArgs> eventHandler = dataReceived;
			if (eventHandler != null)
			{
				GKDataEventArgs e = new GKDataEventArgs(data, playerId);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:didReceiveData:forRecipient:fromRemotePlayer:")]
		public void DataReceivedForRecipient(GKMatch match, NSData data, GKPlayer recipient, GKPlayer player)
		{
			EventHandler<GKDataReceivedForRecipientEventArgs> eventHandler = dataReceivedForRecipient;
			if (eventHandler != null)
			{
				GKDataReceivedForRecipientEventArgs e = new GKDataReceivedForRecipientEventArgs(data, recipient, player);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:didReceiveData:fromRemotePlayer:")]
		public void DataReceivedFromPlayer(GKMatch match, NSData data, GKPlayer player)
		{
			EventHandler<GKMatchReceivedDataFromRemotePlayerEventArgs> eventHandler = dataReceivedFromPlayer;
			if (eventHandler != null)
			{
				GKMatchReceivedDataFromRemotePlayerEventArgs e = new GKMatchReceivedDataFromRemotePlayerEventArgs(data, player);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:didFailWithError:")]
		public void Failed(GKMatch match, NSError? error)
		{
			EventHandler<GKErrorEventArgs> eventHandler = failed;
			if (eventHandler != null)
			{
				GKErrorEventArgs e = new GKErrorEventArgs(error);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:shouldReinviteDisconnectedPlayer:")]
		public bool ShouldReinviteDisconnectedPlayer(GKMatch match, GKPlayer player)
		{
			return shouldReinviteDisconnectedPlayer?.Invoke(match, player) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("match:shouldReinvitePlayer:")]
		public bool ShouldReinvitePlayer(GKMatch match, string playerId)
		{
			return shouldReinvitePlayer?.Invoke(match, playerId) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("match:player:didChangeState:")]
		public void StateChanged(GKMatch match, string playerId, GKPlayerConnectionState state)
		{
			EventHandler<GKStateEventArgs> eventHandler = stateChanged;
			if (eventHandler != null)
			{
				GKStateEventArgs e = new GKStateEventArgs(playerId, state);
				eventHandler(match, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("match:player:didChangeConnectionState:")]
		public void StateChangedForPlayer(GKMatch match, GKPlayer player, GKPlayerConnectionState state)
		{
			EventHandler<GKMatchConnectionChangedEventArgs> eventHandler = stateChangedForPlayer;
			if (eventHandler != null)
			{
				GKMatchConnectionChangedEventArgs e = new GKMatchConnectionChangedEventArgs(player, state);
				eventHandler(match, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChooseBestHostPlayerWithCompletionHandler_ = "chooseBestHostPlayerWithCompletionHandler:";

	private static readonly IntPtr selChooseBestHostPlayerWithCompletionHandler_Handle = Selector.GetHandle("chooseBestHostPlayerWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChooseBestHostingPlayerWithCompletionHandler_ = "chooseBestHostingPlayerWithCompletionHandler:";

	private static readonly IntPtr selChooseBestHostingPlayerWithCompletionHandler_Handle = Selector.GetHandle("chooseBestHostingPlayerWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisconnect = "disconnect";

	private static readonly IntPtr selDisconnectHandle = Selector.GetHandle("disconnect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpectedPlayerCount = "expectedPlayerCount";

	private static readonly IntPtr selExpectedPlayerCountHandle = Selector.GetHandle("expectedPlayerCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerIDs = "playerIDs";

	private static readonly IntPtr selPlayerIDsHandle = Selector.GetHandle("playerIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayers = "players";

	private static readonly IntPtr selPlayersHandle = Selector.GetHandle("players");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRematchWithCompletionHandler_ = "rematchWithCompletionHandler:";

	private static readonly IntPtr selRematchWithCompletionHandler_Handle = Selector.GetHandle("rematchWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendData_ToPlayers_DataMode_Error_ = "sendData:toPlayers:dataMode:error:";

	private static readonly IntPtr selSendData_ToPlayers_DataMode_Error_Handle = Selector.GetHandle("sendData:toPlayers:dataMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendData_ToPlayers_WithDataMode_Error_ = "sendData:toPlayers:withDataMode:error:";

	private static readonly IntPtr selSendData_ToPlayers_WithDataMode_Error_Handle = Selector.GetHandle("sendData:toPlayers:withDataMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendDataToAllPlayers_WithDataMode_Error_ = "sendDataToAllPlayers:withDataMode:error:";

	private static readonly IntPtr selSendDataToAllPlayers_WithDataMode_Error_Handle = Selector.GetHandle("sendDataToAllPlayers:withDataMode:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoiceChatWithName_ = "voiceChatWithName:";

	private static readonly IntPtr selVoiceChatWithName_Handle = Selector.GetHandle("voiceChatWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMatch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKMatchDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKMatchDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ExpectedPlayerCount
	{
		[Export("expectedPlayerCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selExpectedPlayerCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selExpectedPlayerCountHandle);
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
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Players' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Players' instead.")]
	public virtual string[] PlayersIDs
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
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_GKMatchDelegate);

	public GKMatchReinvitationForDisconnectedPlayer? ShouldReinviteDisconnectedPlayer
	{
		get
		{
			return EnsureGKMatchDelegate().shouldReinviteDisconnectedPlayer;
		}
		set
		{
			EnsureGKMatchDelegate().shouldReinviteDisconnectedPlayer = value;
		}
	}

	public GKMatchReinvitation? ShouldReinvitePlayer
	{
		get
		{
			return EnsureGKMatchDelegate().shouldReinvitePlayer;
		}
		set
		{
			EnsureGKMatchDelegate().shouldReinvitePlayer = value;
		}
	}

	[Obsolete("It will never be called.", false)]
	public event EventHandler<GKPlayerErrorEventArgs> ConnectionFailed
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.connectionFailed = (EventHandler<GKPlayerErrorEventArgs>)System.Delegate.Combine(gKMatchDelegate.connectionFailed, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.connectionFailed = (EventHandler<GKPlayerErrorEventArgs>)System.Delegate.Remove(gKMatchDelegate.connectionFailed, value);
		}
	}

	public event EventHandler<GKDataEventArgs> DataReceived
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceived = (EventHandler<GKDataEventArgs>)System.Delegate.Combine(gKMatchDelegate.dataReceived, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceived = (EventHandler<GKDataEventArgs>)System.Delegate.Remove(gKMatchDelegate.dataReceived, value);
		}
	}

	public event EventHandler<GKDataReceivedForRecipientEventArgs> DataReceivedForRecipient
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceivedForRecipient = (EventHandler<GKDataReceivedForRecipientEventArgs>)System.Delegate.Combine(gKMatchDelegate.dataReceivedForRecipient, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceivedForRecipient = (EventHandler<GKDataReceivedForRecipientEventArgs>)System.Delegate.Remove(gKMatchDelegate.dataReceivedForRecipient, value);
		}
	}

	public event EventHandler<GKMatchReceivedDataFromRemotePlayerEventArgs> DataReceivedFromPlayer
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceivedFromPlayer = (EventHandler<GKMatchReceivedDataFromRemotePlayerEventArgs>)System.Delegate.Combine(gKMatchDelegate.dataReceivedFromPlayer, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.dataReceivedFromPlayer = (EventHandler<GKMatchReceivedDataFromRemotePlayerEventArgs>)System.Delegate.Remove(gKMatchDelegate.dataReceivedFromPlayer, value);
		}
	}

	public event EventHandler<GKErrorEventArgs> Failed
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.failed = (EventHandler<GKErrorEventArgs>)System.Delegate.Combine(gKMatchDelegate.failed, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.failed = (EventHandler<GKErrorEventArgs>)System.Delegate.Remove(gKMatchDelegate.failed, value);
		}
	}

	public event EventHandler<GKStateEventArgs> StateChanged
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.stateChanged = (EventHandler<GKStateEventArgs>)System.Delegate.Combine(gKMatchDelegate.stateChanged, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.stateChanged = (EventHandler<GKStateEventArgs>)System.Delegate.Remove(gKMatchDelegate.stateChanged, value);
		}
	}

	public event EventHandler<GKMatchConnectionChangedEventArgs> StateChangedForPlayer
	{
		add
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.stateChangedForPlayer = (EventHandler<GKMatchConnectionChangedEventArgs>)System.Delegate.Combine(gKMatchDelegate.stateChangedForPlayer, value);
		}
		remove
		{
			_GKMatchDelegate gKMatchDelegate = EnsureGKMatchDelegate();
			gKMatchDelegate.stateChangedForPlayer = (EventHandler<GKMatchConnectionChangedEventArgs>)System.Delegate.Remove(gKMatchDelegate.stateChangedForPlayer, value);
		}
	}

	public virtual bool SendData(NSData data, string[] players, GKMatchSendDataMode mode, NSError error)
	{
		return SendData(data, players, mode, out error);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKMatch(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMatch(IntPtr handle)
		: base(handle)
	{
	}

	[Export("chooseBestHostPlayerWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'ChooseBestHostingPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ChooseBestHostingPlayer' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ChooseBestHostPlayer([BlockProxy(typeof(Trampolines.NIDActionArity1V44))] Action<string> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V44.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChooseBestHostPlayerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChooseBestHostPlayerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'ChooseBestHostingPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ChooseBestHostingPlayer' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string> ChooseBestHostPlayerAsync()
	{
		TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
		ChooseBestHostPlayer(delegate(string obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("chooseBestHostingPlayerWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ChooseBestHostingPlayer([BlockProxy(typeof(Trampolines.NIDActionArity1V45))] Action<GKPlayer> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V45.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selChooseBestHostingPlayerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selChooseBestHostingPlayerWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer> ChooseBestHostingPlayerAsync()
	{
		TaskCompletionSource<GKPlayer> tcs = new TaskCompletionSource<GKPlayer>();
		ChooseBestHostingPlayer(delegate(GKPlayer obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("disconnect")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Disconnect()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisconnectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisconnectHandle);
		}
	}

	[Export("rematchWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Rematch([BlockProxy(typeof(Trampolines.NIDActionArity2V58))] Action<GKMatch, NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V58.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRematchWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRematchWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKMatch> RematchAsync()
	{
		TaskCompletionSource<GKMatch> tcs = new TaskCompletionSource<GKMatch>();
		Rematch(delegate(GKMatch arg1_, NSError arg2_)
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

	[Export("sendData:toPlayers:withDataMode:error:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SendDataToAllPlayers (NSData, GKPlayer[] players, GKMatchSendDataMode mode, NSError error)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SendDataToAllPlayers (NSData, GKPlayer[] players, GKMatchSendDataMode mode, NSError error)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendData(NSData data, string[] players, GKMatchSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromStrings(players);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selSendData_ToPlayers_WithDataMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_Int64_ref_IntPtr(base.Handle, selSendData_ToPlayers_WithDataMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("sendData:toPlayers:dataMode:error:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendData(NSData data, GKPlayer[] players, GKMatchSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(players);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selSendData_ToPlayers_DataMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_Int64_ref_IntPtr(base.Handle, selSendData_ToPlayers_DataMode_Error_Handle, data.Handle, nSArray.Handle, (long)mode, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("sendDataToAllPlayers:withDataMode:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SendDataToAllPlayers(NSData data, GKMatchSendDataMode mode, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selSendDataToAllPlayers_WithDataMode_Error_Handle, data.Handle, (long)mode, ref arg) : Messaging.bool_objc_msgSend_IntPtr_Int64_ref_IntPtr(base.Handle, selSendDataToAllPlayers_WithDataMode_Error_Handle, data.Handle, (long)mode, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("voiceChatWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKVoiceChat VoiceChatWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		GKVoiceChat result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<GKVoiceChat>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVoiceChatWithName_Handle, arg)) : Runtime.GetNSObject<GKVoiceChat>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVoiceChatWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	internal virtual _GKMatchDelegate CreateInternalEventDelegateType()
	{
		return new _GKMatchDelegate();
	}

	internal _GKMatchDelegate EnsureGKMatchDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_GKMatchDelegate gKMatchDelegate = Delegate as _GKMatchDelegate;
		if (gKMatchDelegate == null)
		{
			gKMatchDelegate = (_GKMatchDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return gKMatchDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
