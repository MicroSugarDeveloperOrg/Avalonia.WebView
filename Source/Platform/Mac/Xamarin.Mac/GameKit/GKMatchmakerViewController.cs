using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKMatchmakerViewController", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKMatchmakerViewController : NSViewController, IGKViewController, INativeObject, IDisposable
{
	[Register]
	internal class _GKMatchmakerViewControllerDelegate : NSObject, IGKMatchmakerViewControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler<GKErrorEventArgs>? didFailWithError;

		internal EventHandler<GKMatchmakingPlayersEventArgs>? didFindHostedPlayers;

		internal EventHandler<GKMatchEventArgs>? didFindMatch;

		internal EventHandler<GKPlayersEventArgs>? didFindPlayers;

		internal EventHandler<GKMatchmakingPlayerEventArgs>? hostedPlayerDidAccept;

		internal EventHandler<GKPlayerEventArgs>? receivedAcceptFromHostedPlayer;

		internal EventHandler? wasCancelled;

		public _GKMatchmakerViewControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:didFailWithError:")]
		public void DidFailWithError(GKMatchmakerViewController viewController, NSError error)
		{
			EventHandler<GKErrorEventArgs> eventHandler = didFailWithError;
			if (eventHandler != null)
			{
				GKErrorEventArgs e = new GKErrorEventArgs(error);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:didFindHostedPlayers:")]
		public void DidFindHostedPlayers(GKMatchmakerViewController viewController, GKPlayer[] playerIDs)
		{
			EventHandler<GKMatchmakingPlayersEventArgs> eventHandler = didFindHostedPlayers;
			if (eventHandler != null)
			{
				GKMatchmakingPlayersEventArgs e = new GKMatchmakingPlayersEventArgs(playerIDs);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:didFindMatch:")]
		public void DidFindMatch(GKMatchmakerViewController viewController, GKMatch match)
		{
			EventHandler<GKMatchEventArgs> eventHandler = didFindMatch;
			if (eventHandler != null)
			{
				GKMatchEventArgs e = new GKMatchEventArgs(match);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:didFindPlayers:")]
		public void DidFindPlayers(GKMatchmakerViewController viewController, string[] playerIDs)
		{
			EventHandler<GKPlayersEventArgs> eventHandler = didFindPlayers;
			if (eventHandler != null)
			{
				GKPlayersEventArgs e = new GKPlayersEventArgs(playerIDs);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:hostedPlayerDidAccept:")]
		public void HostedPlayerDidAccept(GKMatchmakerViewController viewController, GKPlayer playerID)
		{
			EventHandler<GKMatchmakingPlayerEventArgs> eventHandler = hostedPlayerDidAccept;
			if (eventHandler != null)
			{
				GKMatchmakingPlayerEventArgs e = new GKMatchmakingPlayerEventArgs(playerID);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewController:didReceiveAcceptFromHostedPlayer:")]
		public void ReceivedAcceptFromHostedPlayer(GKMatchmakerViewController viewController, string playerID)
		{
			EventHandler<GKPlayerEventArgs> eventHandler = receivedAcceptFromHostedPlayer;
			if (eventHandler != null)
			{
				GKPlayerEventArgs e = new GKPlayerEventArgs(playerID);
				eventHandler(viewController, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("matchmakerViewControllerWasCancelled:")]
		public void WasCancelled(GKMatchmakerViewController viewController)
		{
			wasCancelled?.Invoke(viewController, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddPlayersToMatch_ = "addPlayersToMatch:";

	private static readonly IntPtr selAddPlayersToMatch_Handle = Selector.GetHandle("addPlayersToMatch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultInvitationMessage = "defaultInvitationMessage";

	private static readonly IntPtr selDefaultInvitationMessageHandle = Selector.GetHandle("defaultInvitationMessage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInvite_ = "initWithInvite:";

	private static readonly IntPtr selInitWithInvite_Handle = Selector.GetHandle("initWithInvite:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMatchRequest_ = "initWithMatchRequest:";

	private static readonly IntPtr selInitWithMatchRequest_Handle = Selector.GetHandle("initWithMatchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHosted = "isHosted";

	private static readonly IntPtr selIsHostedHandle = Selector.GetHandle("isHosted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchRequest = "matchRequest";

	private static readonly IntPtr selMatchRequestHandle = Selector.GetHandle("matchRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchmakerDelegate = "matchmakerDelegate";

	private static readonly IntPtr selMatchmakerDelegateHandle = Selector.GetHandle("matchmakerDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultInvitationMessage_ = "setDefaultInvitationMessage:";

	private static readonly IntPtr selSetDefaultInvitationMessage_Handle = Selector.GetHandle("setDefaultInvitationMessage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHosted_ = "setHosted:";

	private static readonly IntPtr selSetHosted_Handle = Selector.GetHandle("setHosted:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHostedPlayer_Connected_ = "setHostedPlayer:connected:";

	private static readonly IntPtr selSetHostedPlayer_Connected_Handle = Selector.GetHandle("setHostedPlayer:connected:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHostedPlayer_DidConnect_ = "setHostedPlayer:didConnect:";

	private static readonly IntPtr selSetHostedPlayer_DidConnect_Handle = Selector.GetHandle("setHostedPlayer:didConnect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchmakerDelegate_ = "setMatchmakerDelegate:";

	private static readonly IntPtr selSetMatchmakerDelegate_Handle = Selector.GetHandle("setMatchmakerDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMatchmakerViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakMatchmakerDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
	public virtual string DefaultInvitationMessage
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("defaultInvitationMessage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultInvitationMessageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultInvitationMessageHandle));
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, null)]
		[Export("setDefaultInvitationMessage:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultInvitationMessage_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultInvitationMessage_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hosted
	{
		[Export("isHosted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHostedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHostedHandle);
		}
		[Export("setHosted:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHosted_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHosted_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKMatchRequest MatchRequest
	{
		[Export("matchRequest", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKMatchRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchRequestHandle));
			}
			return Runtime.GetNSObject<GKMatchRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchRequestHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKMatchmakerViewControllerDelegate? MatchmakerDelegate
	{
		get
		{
			return WeakMatchmakerDelegate as IGKMatchmakerViewControllerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakMatchmakerDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakMatchmakerDelegate
	{
		[Export("matchmakerDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchmakerDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchmakerDelegateHandle)));
			MarkDirty();
			__mt_WeakMatchmakerDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setMatchmakerDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakMatchmakerDelegate_var, value, GetInternalEventMatchmakerDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMatchmakerDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMatchmakerDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakMatchmakerDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventMatchmakerDelegateType => typeof(_GKMatchmakerViewControllerDelegate);

	public event EventHandler<GKErrorEventArgs> DidFailWithError
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFailWithError = (EventHandler<GKErrorEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.didFailWithError, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFailWithError = (EventHandler<GKErrorEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.didFailWithError, value);
		}
	}

	public event EventHandler<GKMatchmakingPlayersEventArgs> DidFindHostedPlayers
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindHostedPlayers = (EventHandler<GKMatchmakingPlayersEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.didFindHostedPlayers, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindHostedPlayers = (EventHandler<GKMatchmakingPlayersEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.didFindHostedPlayers, value);
		}
	}

	public event EventHandler<GKMatchEventArgs> DidFindMatch
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindMatch = (EventHandler<GKMatchEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.didFindMatch, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindMatch = (EventHandler<GKMatchEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.didFindMatch, value);
		}
	}

	public event EventHandler<GKPlayersEventArgs> DidFindPlayers
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindPlayers = (EventHandler<GKPlayersEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.didFindPlayers, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.didFindPlayers = (EventHandler<GKPlayersEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.didFindPlayers, value);
		}
	}

	public event EventHandler<GKMatchmakingPlayerEventArgs> HostedPlayerDidAccept
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.hostedPlayerDidAccept = (EventHandler<GKMatchmakingPlayerEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.hostedPlayerDidAccept, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.hostedPlayerDidAccept = (EventHandler<GKMatchmakingPlayerEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.hostedPlayerDidAccept, value);
		}
	}

	public event EventHandler<GKPlayerEventArgs> ReceivedAcceptFromHostedPlayer
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.receivedAcceptFromHostedPlayer = (EventHandler<GKPlayerEventArgs>)Delegate.Combine(gKMatchmakerViewControllerDelegate.receivedAcceptFromHostedPlayer, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.receivedAcceptFromHostedPlayer = (EventHandler<GKPlayerEventArgs>)Delegate.Remove(gKMatchmakerViewControllerDelegate.receivedAcceptFromHostedPlayer, value);
		}
	}

	public event EventHandler WasCancelled
	{
		add
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.wasCancelled = (EventHandler)Delegate.Combine(gKMatchmakerViewControllerDelegate.wasCancelled, value);
		}
		remove
		{
			_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = EnsureGKMatchmakerViewControllerDelegate();
			gKMatchmakerViewControllerDelegate.wasCancelled = (EventHandler)Delegate.Remove(gKMatchmakerViewControllerDelegate.wasCancelled, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKMatchmakerViewController(NSCoder coder)
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
	protected GKMatchmakerViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMatchmakerViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMatchmakerViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibNameOrNull);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, nibBundleOrNull?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithMatchRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMatchmakerViewController(GKMatchRequest request)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMatchRequest_Handle, request.Handle), "initWithMatchRequest:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMatchRequest_Handle, request.Handle), "initWithMatchRequest:");
		}
	}

	[Export("initWithInvite:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMatchmakerViewController(GKInvite invite)
		: base(NSObjectFlag.Empty)
	{
		if (invite == null)
		{
			throw new ArgumentNullException("invite");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithInvite_Handle, invite.Handle), "initWithInvite:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithInvite_Handle, invite.Handle), "initWithInvite:");
		}
	}

	[Export("addPlayersToMatch:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddPlayersToMatch(GKMatch match)
	{
		if (match == null)
		{
			throw new ArgumentNullException("match");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddPlayersToMatch_Handle, match.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddPlayersToMatch_Handle, match.Handle);
		}
	}

	[Export("setHostedPlayer:connected:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'SetHostedPlayerConnected (GKPlayer,bool)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetHostedPlayerConnected (GKPlayer,bool)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHostedPlayerConnected(string playerID, bool connected)
	{
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		IntPtr arg = NSString.CreateNative(playerID);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetHostedPlayer_Connected_Handle, arg, connected);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetHostedPlayer_Connected_Handle, arg, connected);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setHostedPlayer:didConnect:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetHostedPlayerConnected(GKPlayer playerID, bool connected)
	{
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSetHostedPlayer_DidConnect_Handle, playerID.Handle, connected);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSetHostedPlayer_DidConnect_Handle, playerID.Handle, connected);
		}
	}

	internal virtual _GKMatchmakerViewControllerDelegate CreateInternalEventMatchmakerDelegateType()
	{
		return new _GKMatchmakerViewControllerDelegate();
	}

	internal _GKMatchmakerViewControllerDelegate EnsureGKMatchmakerViewControllerDelegate()
	{
		if (WeakMatchmakerDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakMatchmakerDelegate, GetInternalEventMatchmakerDelegateType);
		}
		_GKMatchmakerViewControllerDelegate gKMatchmakerViewControllerDelegate = MatchmakerDelegate as _GKMatchmakerViewControllerDelegate;
		if (gKMatchmakerViewControllerDelegate == null)
		{
			gKMatchmakerViewControllerDelegate = (_GKMatchmakerViewControllerDelegate)(MatchmakerDelegate = CreateInternalEventMatchmakerDelegateType());
		}
		return gKMatchmakerViewControllerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakMatchmakerDelegate_var = null;
		}
	}
}
