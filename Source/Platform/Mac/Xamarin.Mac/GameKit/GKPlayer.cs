using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKPlayer", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKPlayer : GKBasePlayer, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveDidChangeNotificationName(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotificationNameNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeNotificationName(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeNotificationNameNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlias = "alias";

	private static readonly IntPtr selAliasHandle = Selector.GetHandle("alias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnonymousGuestPlayerWithIdentifier_ = "anonymousGuestPlayerWithIdentifier:";

	private static readonly IntPtr selAnonymousGuestPlayerWithIdentifier_Handle = Selector.GetHandle("anonymousGuestPlayerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGamePlayerID = "gamePlayerID";

	private static readonly IntPtr selGamePlayerIDHandle = Selector.GetHandle("gamePlayerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGuestIdentifier = "guestIdentifier";

	private static readonly IntPtr selGuestIdentifierHandle = Selector.GetHandle("guestIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFriend = "isFriend";

	private static readonly IntPtr selIsFriendHandle = Selector.GetHandle("isFriend");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadPhotoForSize_WithCompletionHandler_ = "loadPhotoForSize:withCompletionHandler:";

	private static readonly IntPtr selLoadPhotoForSize_WithCompletionHandler_Handle = Selector.GetHandle("loadPhotoForSize:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadPlayersForIdentifiers_WithCompletionHandler_ = "loadPlayersForIdentifiers:withCompletionHandler:";

	private static readonly IntPtr selLoadPlayersForIdentifiers_WithCompletionHandler_Handle = Selector.GetHandle("loadPlayersForIdentifiers:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerID = "playerID";

	private static readonly IntPtr selPlayerIDHandle = Selector.GetHandle("playerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScopedIDsArePersistent = "scopedIDsArePersistent";

	private static readonly IntPtr selScopedIDsArePersistentHandle = Selector.GetHandle("scopedIDsArePersistent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTeamPlayerID = "teamPlayerID";

	private static readonly IntPtr selTeamPlayerIDHandle = Selector.GetHandle("teamPlayerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeNotificationNameNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Alias
	{
		[Export("alias", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAliasHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAliasHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 4, PlatformArchitecture.All, null)]
	public virtual string GamePlayerId
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 4, PlatformArchitecture.All, null)]
		[Export("gamePlayerID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGamePlayerIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGamePlayerIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string GuestIdentifier
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("guestIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGuestIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGuestIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.LoadFriendPlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.LoadFriendPlayers' instead.")]
	public virtual bool IsFriend
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'GKLocalPlayer.LoadFriendPlayers' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKLocalPlayer.LoadFriendPlayers' instead.")]
		[Export("isFriend")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFriendHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFriendHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
	public new virtual string PlayerID
	{
		[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
		[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'TeamPlayerId' instead.")]
		[Export("playerID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual bool ScopedIdsArePersistent
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("scopedIDsArePersistent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selScopedIDsArePersistentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selScopedIDsArePersistentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 4, PlatformArchitecture.All, null)]
	public virtual string TeamPlayerId
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 6, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 4, PlatformArchitecture.All, null)]
		[Export("teamPlayerID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTeamPlayerIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTeamPlayerIDHandle));
		}
	}

	[Field("GKPlayerDidChangeNotificationName", "GameKit")]
	[Advice("Use GKPlayer.Notifications.ObserveDidChangeNotificationName helper method instead.")]
	public static NSString DidChangeNotificationNameNotification
	{
		get
		{
			if (_DidChangeNotificationNameNotification == null)
			{
				_DidChangeNotificationNameNotification = Dlfcn.GetStringConstant(Libraries.GameKit.Handle, "GKPlayerDidChangeNotificationName");
			}
			return _DidChangeNotificationNameNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKPlayer()
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
	public GKPlayer(NSCoder coder)
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
	protected GKPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("anonymousGuestPlayerWithIdentifier:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPlayer GetAnonymousGuestPlayer(string guestIdentifier)
	{
		if (guestIdentifier == null)
		{
			throw new ArgumentNullException("guestIdentifier");
		}
		IntPtr arg = NSString.CreateNative(guestIdentifier);
		GKPlayer nSObject = Runtime.GetNSObject<GKPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnonymousGuestPlayerWithIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("loadPhotoForSize:withCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadPhoto(GKPhotoSize size, [BlockProxy(typeof(Trampolines.NIDGKPlayerPhotoLoaded))] GKPlayerPhotoLoaded? onCompleted)
	{
		BlockLiteral* ptr;
		if (onCompleted == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKPlayerPhotoLoaded.Handler, onCompleted);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selLoadPhotoForSize_WithCompletionHandler_Handle, (long)size, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selLoadPhotoForSize_WithCompletionHandler_Handle, (long)size, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSImage> LoadPhotoAsync(GKPhotoSize size)
	{
		TaskCompletionSource<NSImage> tcs = new TaskCompletionSource<NSImage>();
		LoadPhoto(size, delegate(NSImage photo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(photo_);
			}
		});
		return tcs.Task;
	}

	[Export("loadPlayersForIdentifiers:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadPlayersForIdentifiers(string[] identifiers, [BlockProxy(typeof(Trampolines.NIDGKPlayersHandler))] GKPlayersHandler? completionHandler)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKPlayersHandler.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadPlayersForIdentifiers_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKPlayer[]> LoadPlayersForIdentifiersAsync(string[] identifiers)
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		LoadPlayersForIdentifiers(identifiers, delegate(GKPlayer[] players_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(players_);
			}
		});
		return tcs.Task;
	}
}
