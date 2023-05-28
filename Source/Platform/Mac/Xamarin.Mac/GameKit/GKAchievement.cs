using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKAchievement", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKAchievement : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChallengeComposeControllerWithMessage_Players_CompletionHandler_ = "challengeComposeControllerWithMessage:players:completionHandler:";

	private static readonly IntPtr selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle = Selector.GetHandle("challengeComposeControllerWithMessage:players:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_Player_ = "initWithIdentifier:player:";

	private static readonly IntPtr selInitWithIdentifier_Player_Handle = Selector.GetHandle("initWithIdentifier:player:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompleted = "isCompleted";

	private static readonly IntPtr selIsCompletedHandle = Selector.GetHandle("isCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIssueChallengeToPlayers_Message_ = "issueChallengeToPlayers:message:";

	private static readonly IntPtr selIssueChallengeToPlayers_Message_Handle = Selector.GetHandle("issueChallengeToPlayers:message:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastReportedDate = "lastReportedDate";

	private static readonly IntPtr selLastReportedDateHandle = Selector.GetHandle("lastReportedDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAchievementsWithCompletionHandler_ = "loadAchievementsWithCompletionHandler:";

	private static readonly IntPtr selLoadAchievementsWithCompletionHandler_Handle = Selector.GetHandle("loadAchievementsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPercentComplete = "percentComplete";

	private static readonly IntPtr selPercentCompleteHandle = Selector.GetHandle("percentComplete");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer = "player";

	private static readonly IntPtr selPlayerHandle = Selector.GetHandle("player");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportAchievementWithCompletionHandler_ = "reportAchievementWithCompletionHandler:";

	private static readonly IntPtr selReportAchievementWithCompletionHandler_Handle = Selector.GetHandle("reportAchievementWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportAchievements_WithCompletionHandler_ = "reportAchievements:withCompletionHandler:";

	private static readonly IntPtr selReportAchievements_WithCompletionHandler_Handle = Selector.GetHandle("reportAchievements:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReportAchievements_WithEligibleChallenges_WithCompletionHandler_ = "reportAchievements:withEligibleChallenges:withCompletionHandler:";

	private static readonly IntPtr selReportAchievements_WithEligibleChallenges_WithCompletionHandler_Handle = Selector.GetHandle("reportAchievements:withEligibleChallenges:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetAchievementsWithCompletionHandler_ = "resetAchievementsWithCompletionHandler:";

	private static readonly IntPtr selResetAchievementsWithCompletionHandler_Handle = Selector.GetHandle("resetAchievementsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectChallengeablePlayerIDs_WithCompletionHandler_ = "selectChallengeablePlayerIDs:withCompletionHandler:";

	private static readonly IntPtr selSelectChallengeablePlayerIDs_WithCompletionHandler_Handle = Selector.GetHandle("selectChallengeablePlayerIDs:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectChallengeablePlayers_WithCompletionHandler_ = "selectChallengeablePlayers:withCompletionHandler:";

	private static readonly IntPtr selSelectChallengeablePlayers_WithCompletionHandler_Handle = Selector.GetHandle("selectChallengeablePlayers:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPercentComplete_ = "setPercentComplete:";

	private static readonly IntPtr selSetPercentComplete_Handle = Selector.GetHandle("setPercentComplete:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsCompletionBanner_ = "setShowsCompletionBanner:";

	private static readonly IntPtr selSetShowsCompletionBanner_Handle = Selector.GetHandle("setShowsCompletionBanner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsCompletionBanner = "showsCompletionBanner";

	private static readonly IntPtr selShowsCompletionBannerHandle = Selector.GetHandle("showsCompletionBanner");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKAchievement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Completed
	{
		[Export("isCompleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompletedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompletedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
	public virtual bool Hidden
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'IsHidden' on the 'GKAchievementDescription' class instead.")]
		[Export("isHidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LastReportedDate
	{
		[Export("lastReportedDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastReportedDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastReportedDateHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double PercentComplete
	{
		[Export("percentComplete")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPercentCompleteHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPercentCompleteHandle);
		}
		[Export("setPercentComplete:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPercentComplete_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPercentComplete_Handle, value);
			}
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
	public virtual bool ShowsCompletionBanner
	{
		[Export("showsCompletionBanner")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsCompletionBannerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsCompletionBannerHandle);
		}
		[Export("setShowsCompletionBanner:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsCompletionBanner_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsCompletionBanner_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKAchievement(NSCoder coder)
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
	protected GKAchievement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKAchievement(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKAchievement()
		: this((string?)null)
	{
	}

	[Export("initWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKAchievement(string? identifier)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithIdentifier:player:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKAchievement(string? identifier, GKPlayer player)
		: base(NSObjectFlag.Empty)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_Player_Handle, arg, player.Handle), "initWithIdentifier:player:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_Player_Handle, arg, player.Handle), "initWithIdentifier:player:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("challengeComposeControllerWithMessage:players:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSViewController ChallengeComposeController(string? message, GKPlayer[] players, [BlockProxy(typeof(Trampolines.NIDGKChallengeComposeHandler))] GKChallengeComposeHandler? completionHandler)
	{
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		IntPtr arg = NSString.CreateNative(message);
		NSArray nSArray = NSArray.FromNSObjects(players);
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
		NSViewController result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle, arg, nSArray.Handle, (IntPtr)ptr)) : Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selChallengeComposeControllerWithMessage_Players_CompletionHandler_Handle, arg, nSArray.Handle, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync(string? message, GKPlayer[] players)
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
	public virtual Task<GKChallengeComposeResult> ChallengeComposeControllerAsync(string? message, GKPlayer[] players, out NSViewController result)
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

	[Export("issueChallengeToPlayers:message:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Pass 'GKPlayers' to 'ChallengeComposeController(GKPlayer[] players, string message, ...)' and present the view controller instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Pass 'GKPlayers' to 'ChallengeComposeController(GKPlayer[] players, string message, ...)' and present the view controller instead.")]
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

	[Export("loadAchievementsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadAchievements([BlockProxy(typeof(Trampolines.NIDGKCompletionHandler))] GKCompletionHandler? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKCompletionHandler.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadAchievementsWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKAchievement[]> LoadAchievementsAsync()
	{
		TaskCompletionSource<GKAchievement[]> tcs = new TaskCompletionSource<GKAchievement[]>();
		LoadAchievements(delegate(GKAchievement[] achivements_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(achivements_);
			}
		});
		return tcs.Task;
	}

	[Export("reportAchievementWithCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReportAchievement([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReportAchievementWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReportAchievementWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use ReportAchievements '(GKAchievement[] achievements, Action<NSError> completionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ReportAchievementAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportAchievement(delegate(NSError obj_)
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

	[Export("reportAchievements:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ReportAchievements(GKAchievement[] achievements, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (achievements == null)
		{
			throw new ArgumentNullException("achievements");
		}
		NSArray nSArray = NSArray.FromNSObjects(achievements);
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selReportAchievements_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ReportAchievementsAsync(GKAchievement[] achievements)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportAchievements(achievements, delegate(NSError obj_)
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

	[Export("reportAchievements:withEligibleChallenges:withCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ReportAchievements(GKAchievement[] achievements, GKChallenge[]? challenges, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (achievements == null)
		{
			throw new ArgumentNullException("achievements");
		}
		NSArray nSArray = NSArray.FromNSObjects(achievements);
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selReportAchievements_WithEligibleChallenges_WithCompletionHandler_Handle, nSArray.Handle, nSArray2?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
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
	public static Task ReportAchievementsAsync(GKAchievement[] achievements, GKChallenge[]? challenges)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReportAchievements(achievements, challenges, delegate(NSError obj_)
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

	[Export("resetAchievementsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ResetAchivements([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selResetAchievementsWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ResetAchivementsAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ResetAchivements(delegate(NSError obj_)
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

	[Export("selectChallengeablePlayerIDs:withCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SelectChallengeablePlayerIDs(string[]? playerIDs, [BlockProxy(typeof(Trampolines.NIDActionArity2V47))] Action<string[], NSError>? completionHandler)
	{
		NSArray nSArray = ((playerIDs == null) ? null : NSArray.FromStrings(playerIDs));
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V47.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectChallengeablePlayerIDs_WithCompletionHandler_Handle, nSArray?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectChallengeablePlayerIDs_WithCompletionHandler_Handle, nSArray?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		nSArray?.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Pass 'GKPlayers' to 'SelectChallengeablePlayers' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string[]> SelectChallengeablePlayerIDsAsync(string[]? playerIDs)
	{
		TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
		SelectChallengeablePlayerIDs(playerIDs, delegate(string[] arg1_, NSError arg2_)
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

	[Export("selectChallengeablePlayers:withCompletionHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SelectChallengeablePlayers(GKPlayer[] players, [BlockProxy(typeof(Trampolines.NIDActionArity2V48))] Action<GKPlayer[], NSError>? completionHandler)
	{
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		NSArray nSArray = NSArray.FromNSObjects(players);
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSelectChallengeablePlayers_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSelectChallengeablePlayers_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKPlayer[]> SelectChallengeablePlayersAsync(GKPlayer[] players)
	{
		TaskCompletionSource<GKPlayer[]> tcs = new TaskCompletionSource<GKPlayer[]>();
		SelectChallengeablePlayers(players, delegate(GKPlayer[] arg1_, NSError arg2_)
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
}
