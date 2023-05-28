using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKScore", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKScore : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategory = "category";

	private static readonly IntPtr selCategoryHandle = Selector.GetHandle("category");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChallengeComposeControllerWithMessage_Players_CompletionHandler_ = "challengeComposeControllerWithMessage:players:completionHandler:";

	private static readonly IntPtr selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle = Selector.GetHandle("challengeComposeControllerWithMessage:players:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContext = "context";

	private static readonly IntPtr selContextHandle = Selector.GetHandle("context");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDate = "date";

	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormattedValue = "formattedValue";

	private static readonly IntPtr selFormattedValueHandle = Selector.GetHandle("formattedValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCategory_ = "initWithCategory:";

	private static readonly IntPtr selInitWithCategory_Handle = Selector.GetHandle("initWithCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeaderboardIdentifier_ = "initWithLeaderboardIdentifier:";

	private static readonly IntPtr selInitWithLeaderboardIdentifier_Handle = Selector.GetHandle("initWithLeaderboardIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeaderboardIdentifier_ForPlayer_ = "initWithLeaderboardIdentifier:forPlayer:";

	private static readonly IntPtr selInitWithLeaderboardIdentifier_ForPlayer_Handle = Selector.GetHandle("initWithLeaderboardIdentifier:forPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeaderboardIdentifier_Player_ = "initWithLeaderboardIdentifier:player:";

	private static readonly IntPtr selInitWithLeaderboardIdentifier_Player_Handle = Selector.GetHandle("initWithLeaderboardIdentifier:player:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIssueChallengeToPlayers_Message_ = "issueChallengeToPlayers:message:";

	private static readonly IntPtr selIssueChallengeToPlayers_Message_Handle = Selector.GetHandle("issueChallengeToPlayers:message:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeaderboardIdentifier = "leaderboardIdentifier";

	private static readonly IntPtr selLeaderboardIdentifierHandle = Selector.GetHandle("leaderboardIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer = "player";

	private static readonly IntPtr selPlayerHandle = Selector.GetHandle("player");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRank = "rank";

	private static readonly IntPtr selRankHandle = Selector.GetHandle("rank");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportScoreWithCompletionHandler_ = "reportScoreWithCompletionHandler:";

	private static readonly IntPtr selReportScoreWithCompletionHandler_Handle = Selector.GetHandle("reportScoreWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportScores_WithCompletionHandler_ = "reportScores:withCompletionHandler:";

	private static readonly IntPtr selReportScores_WithCompletionHandler_Handle = Selector.GetHandle("reportScores:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportScores_WithEligibleChallenges_WithCompletionHandler_ = "reportScores:withEligibleChallenges:withCompletionHandler:";

	private static readonly IntPtr selReportScores_WithEligibleChallenges_WithCompletionHandler_Handle = Selector.GetHandle("reportScores:withEligibleChallenges:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategory_ = "setCategory:";

	private static readonly IntPtr selSetCategory_Handle = Selector.GetHandle("setCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContext_ = "setContext:";

	private static readonly IntPtr selSetContext_Handle = Selector.GetHandle("setContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeaderboardIdentifier_ = "setLeaderboardIdentifier:";

	private static readonly IntPtr selSetLeaderboardIdentifier_Handle = Selector.GetHandle("setLeaderboardIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldSetDefaultLeaderboard_ = "setShouldSetDefaultLeaderboard:";

	private static readonly IntPtr selSetShouldSetDefaultLeaderboard_Handle = Selector.GetHandle("setShouldSetDefaultLeaderboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldSetDefaultLeaderboard = "shouldSetDefaultLeaderboard";

	private static readonly IntPtr selShouldSetDefaultLeaderboardHandle = Selector.GetHandle("shouldSetDefaultLeaderboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKScore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
	public virtual string? Category
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Export("category", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCategoryHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Export("setCategory:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCategory_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCategory_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong Context
	{
		[Export("context")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selContextHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selContextHandle);
		}
		[Export("setContext:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetContext_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetContext_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate Date
	{
		[Export("date", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FormattedValue
	{
		[Export("formattedValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFormattedValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormattedValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? LeaderboardIdentifier
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("leaderboardIdentifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLeaderboardIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeaderboardIdentifierHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLeaderboardIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLeaderboardIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLeaderboardIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKPlayer? Player
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("player", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerHandle));
			}
			return Runtime.GetNSObject<GKPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Rank
	{
		[Export("rank", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRankHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRankHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldSetDefaultLeaderboard
	{
		[Export("shouldSetDefaultLeaderboard")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldSetDefaultLeaderboardHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldSetDefaultLeaderboardHandle);
		}
		[Export("setShouldSetDefaultLeaderboard:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldSetDefaultLeaderboard_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldSetDefaultLeaderboard_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selValueHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selValueHandle);
		}
		[Export("setValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKScore()
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
	public GKScore(NSCoder coder)
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
	protected GKScore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKScore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLeaderboardIdentifier:player:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKScore(string identifier, GKPlayer player)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLeaderboardIdentifier_Player_Handle, arg, player.Handle), "initWithLeaderboardIdentifier:player:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLeaderboardIdentifier_Player_Handle, arg, player.Handle), "initWithLeaderboardIdentifier:player:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithLeaderboardIdentifier:forPlayer:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use the overload that takes a 'GKPlayer' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKScore(string identifier, string playerID)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (playerID == null)
		{
			throw new ArgumentNullException("playerID");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(playerID);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLeaderboardIdentifier_ForPlayer_Handle, arg, arg2), "initWithLeaderboardIdentifier:forPlayer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLeaderboardIdentifier_ForPlayer_Handle, arg, arg2), "initWithLeaderboardIdentifier:forPlayer:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("challengeComposeControllerWithMessage:players:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSViewController ChallengeComposeController(string? message, GKPlayer[]? players, [BlockProxy(typeof(Trampolines.NIDGKChallengeComposeHandler))] GKChallengeComposeHandler? completionHandler)
	{
		IntPtr arg = NSString.CreateNative(message);
		NSArray nSArray = ((players == null) ? null : NSArray.FromNSObjects(players));
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKChallengeComposeHandler.Handler, completionHandler);
		}
		NSViewController result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle, arg, nSArray?.Handle ?? IntPtr.Zero, (IntPtr)ptr)) : Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle, arg, nSArray?.Handle ?? IntPtr.Zero, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		nSArray?.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync(string? message, GKPlayer[]? players)
	{
		TaskCompletionSource<GKChallengeComposeResult> tcs = new TaskCompletionSource<GKChallengeComposeResult>();
		ChallengeComposeController(message, players, delegate(NSViewController composeController_, bool issuedChallenge_, string[] sentPlayerIDs_)
		{
			tcs.SetResult(new GKChallengeComposeResult(composeController_, issuedChallenge_, sentPlayerIDs_));
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync(string? message, GKPlayer[]? players, out NSViewController result)
	{
		TaskCompletionSource<GKChallengeComposeResult> tcs = new TaskCompletionSource<GKChallengeComposeResult>();
		result = ChallengeComposeController(message, players, delegate(NSViewController composeController_, bool issuedChallenge_, string[] sentPlayerIDs_)
		{
			tcs.SetResult(new GKChallengeComposeResult(composeController_, issuedChallenge_, sentPlayerIDs_));
		});
		return tcs.Task;
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

	[Export("initWithCategory:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'InitWithLeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'InitWithLeaderboardIdentifier' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithCategory(string? category)
	{
		IntPtr arg = NSString.CreateNative(category);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCategory_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCategory_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithLeaderboardIdentifier:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithLeaderboardIdentifier(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithLeaderboardIdentifier_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithLeaderboardIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("issueChallengeToPlayers:message:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ... )' and present the view controller instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Pass 'GKPlayers' to 'ChallengeComposeController (GKPlayer [] players, string message, ... )' and present the view controller instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IssueChallengeToPlayers(string[]? playerIDs, string? message)
	{
		NSArray nSArray = ((playerIDs == null) ? null : NSArray.FromStrings(playerIDs));
		IntPtr arg = NSString.CreateNative(message);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selIssueChallengeToPlayers_Message_Handle, nSArray?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIssueChallengeToPlayers_Message_Handle, nSArray?.Handle ?? IntPtr.Zero, arg);
		}
		nSArray?.Dispose();
		NSString.ReleaseNative(arg);
	}

	[Export("reportScoreWithCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'ReportScores' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ReportScores' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReportScore([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? errorHandler)
	{
		BlockLiteral* ptr;
		if (errorHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, errorHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReportScoreWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReportScoreWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'ReportScores' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ReportScores' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ReportScoreAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportScore(delegate(NSError obj_)
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

	[Export("reportScores:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ReportScores(GKScore[] scores, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (scores == null)
		{
			throw new ArgumentNullException("scores");
		}
		NSArray nSArray = NSArray.FromNSObjects(scores);
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selReportScores_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ReportScoresAsync(GKScore[] scores)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportScores(scores, delegate(NSError obj_)
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

	[Export("reportScores:withEligibleChallenges:withCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ReportScores(GKScore[] scores, GKChallenge[]? challenges, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (scores == null)
		{
			throw new ArgumentNullException("scores");
		}
		NSArray nSArray = NSArray.FromNSObjects(scores);
		NSArray nSArray2 = ((challenges == null) ? null : NSArray.FromNSObjects(challenges));
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selReportScores_WithEligibleChallenges_WithCompletionHandler_Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		nSArray.Dispose();
		nSArray2?.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ReportScoresAsync(GKScore[] scores, GKChallenge[]? challenges)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportScores(scores, challenges, delegate(NSError obj_)
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
