using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKLeaderboard", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKLeaderboard : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategory = "category";

	private static readonly IntPtr selCategoryHandle = Selector.GetHandle("category");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupIdentifier = "groupIdentifier";

	private static readonly IntPtr selGroupIdentifierHandle = Selector.GetHandle("groupIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlayerIDs_ = "initWithPlayerIDs:";

	private static readonly IntPtr selInitWithPlayerIDs_Handle = Selector.GetHandle("initWithPlayerIDs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlayers_ = "initWithPlayers:";

	private static readonly IntPtr selInitWithPlayers_Handle = Selector.GetHandle("initWithPlayers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLoading = "isLoading";

	private static readonly IntPtr selIsLoadingHandle = Selector.GetHandle("isLoading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadCategoriesWithCompletionHandler_ = "loadCategoriesWithCompletionHandler:";

	private static readonly IntPtr selLoadCategoriesWithCompletionHandler_Handle = Selector.GetHandle("loadCategoriesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadImageWithCompletionHandler_ = "loadImageWithCompletionHandler:";

	private static readonly IntPtr selLoadImageWithCompletionHandler_Handle = Selector.GetHandle("loadImageWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadLeaderboardsWithCompletionHandler_ = "loadLeaderboardsWithCompletionHandler:";

	private static readonly IntPtr selLoadLeaderboardsWithCompletionHandler_Handle = Selector.GetHandle("loadLeaderboardsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadScoresWithCompletionHandler_ = "loadScoresWithCompletionHandler:";

	private static readonly IntPtr selLoadScoresWithCompletionHandler_Handle = Selector.GetHandle("loadScoresWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalPlayerScore = "localPlayerScore";

	private static readonly IntPtr selLocalPlayerScoreHandle = Selector.GetHandle("localPlayerScore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxRange = "maxRange";

	private static readonly IntPtr selMaxRangeHandle = Selector.GetHandle("maxRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerScope = "playerScope";

	private static readonly IntPtr selPlayerScopeHandle = Selector.GetHandle("playerScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRange = "range";

	private static readonly IntPtr selRangeHandle = Selector.GetHandle("range");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScores = "scores";

	private static readonly IntPtr selScoresHandle = Selector.GetHandle("scores");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategory_ = "setCategory:";

	private static readonly IntPtr selSetCategory_Handle = Selector.GetHandle("setCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultLeaderboard_WithCompletionHandler_ = "setDefaultLeaderboard:withCompletionHandler:";

	private static readonly IntPtr selSetDefaultLeaderboard_WithCompletionHandler_Handle = Selector.GetHandle("setDefaultLeaderboard:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayerScope_ = "setPlayerScope:";

	private static readonly IntPtr selSetPlayerScope_Handle = Selector.GetHandle("setPlayerScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRange_ = "setRange:";

	private static readonly IntPtr selSetRange_Handle = Selector.GetHandle("setRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeScope_ = "setTimeScope:";

	private static readonly IntPtr selSetTimeScope_Handle = Selector.GetHandle("setTimeScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeScope = "timeScope";

	private static readonly IntPtr selTimeScopeHandle = Selector.GetHandle("timeScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKLeaderboard");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'Identifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Identifier' instead.")]
	public virtual string? Category
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'Identifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Identifier' instead.")]
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
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'Identifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Identifier' instead.")]
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
	public virtual string GroupIdentifier
	{
		[Export("groupIdentifier", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupIdentifierHandle));
		}
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? Identifier
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool IsLoading
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isLoading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLoadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLoadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKScore LocalPlayerScore
	{
		[Export("localPlayerScore", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKScore>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalPlayerScoreHandle));
			}
			return Runtime.GetNSObject<GKScore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalPlayerScoreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaxRange
	{
		[Export("maxRange", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxRangeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKLeaderboardPlayerScope PlayerScope
	{
		[Export("playerScope", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKLeaderboardPlayerScope)Messaging.Int64_objc_msgSend(base.Handle, selPlayerScopeHandle);
			}
			return (GKLeaderboardPlayerScope)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPlayerScopeHandle);
		}
		[Export("setPlayerScope:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPlayerScope_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPlayerScope_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange Range
	{
		[Export("range", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selRangeHandle);
		}
		[Export("setRange:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSRange(base.Handle, selSetRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selSetRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKScore[] Scores
	{
		[Export("scores", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKScore>(Messaging.IntPtr_objc_msgSend(base.Handle, selScoresHandle));
			}
			return NSArray.ArrayFromHandle<GKScore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScoresHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKLeaderboardTimeScope TimeScope
	{
		[Export("timeScope", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKLeaderboardTimeScope)Messaging.Int64_objc_msgSend(base.Handle, selTimeScopeHandle);
			}
			return (GKLeaderboardTimeScope)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTimeScopeHandle);
		}
		[Export("setTimeScope:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTimeScope_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTimeScope_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKLeaderboard()
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
	protected GKLeaderboard(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKLeaderboard(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPlayerIDs:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'ctor (GKPlayer [] players)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'ctor (GKPlayer [] players)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKLeaderboard(string[]? players)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((players == null) ? null : NSArray.FromStrings(players));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlayerIDs_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithPlayerIDs:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlayerIDs_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithPlayerIDs:");
		}
		nSArray?.Dispose();
	}

	[Export("initWithPlayers:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKLeaderboard(GKPlayer[] players)
		: base(NSObjectFlag.Empty)
	{
		if (players == null)
		{
			throw new ArgumentNullException("players");
		}
		NSArray nSArray = NSArray.FromNSObjects(players);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlayers_Handle, nSArray.Handle), "initWithPlayers:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlayers_Handle, nSArray.Handle), "initWithPlayers:");
		}
		nSArray.Dispose();
	}

	[Export("loadCategoriesWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'LoadLeaderboards' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'LoadLeaderboards' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadCategories([BlockProxy(typeof(Trampolines.NIDGKCategoryHandler))] GKCategoryHandler? categoryHandler)
	{
		BlockLiteral* ptr;
		if (categoryHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKCategoryHandler.Handler, categoryHandler);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadCategoriesWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'LoadLeaderboards' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'LoadLeaderboards' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKCategoryResult> LoadCategoriesAsync()
	{
		TaskCompletionSource<GKCategoryResult> tcs = new TaskCompletionSource<GKCategoryResult>();
		LoadCategories(delegate(string[] categories_, string[] titles_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new GKCategoryResult(categories_, titles_));
			}
		});
		return tcs.Task;
	}

	[Export("loadImageWithCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadImage([BlockProxy(typeof(Trampolines.NIDGKImageLoadedHandler))] GKImageLoadedHandler? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKImageLoadedHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadImageWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadImageWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSImage> LoadImageAsync()
	{
		TaskCompletionSource<NSImage> tcs = new TaskCompletionSource<NSImage>();
		LoadImage(delegate(NSImage image_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(image_);
			}
		});
		return tcs.Task;
	}

	[Export("loadLeaderboardsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadLeaderboards([BlockProxy(typeof(Trampolines.NIDActionArity2V53))] Action<GKLeaderboard[], NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V53.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadLeaderboardsWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKLeaderboard[]> LoadLeaderboardsAsync()
	{
		TaskCompletionSource<GKLeaderboard[]> tcs = new TaskCompletionSource<GKLeaderboard[]>();
		LoadLeaderboards(delegate(GKLeaderboard[] arg1_, NSError arg2_)
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

	[Export("loadScoresWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadScores([BlockProxy(typeof(Trampolines.NIDGKScoresLoadedHandler))] GKScoresLoadedHandler? scoresLoadedHandler)
	{
		BlockLiteral* ptr;
		if (scoresLoadedHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKScoresLoadedHandler.Handler, scoresLoadedHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadScoresWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadScoresWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKScore[]> LoadScoresAsync()
	{
		TaskCompletionSource<GKScore[]> tcs = new TaskCompletionSource<GKScore[]>();
		LoadScores(delegate(GKScore[] scoreArray_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(scoreArray_);
			}
		});
		return tcs.Task;
	}

	[Export("setDefaultLeaderboard:withCompletionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void SetDefaultLeaderboard(string? leaderboardIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? notificationHandler)
	{
		IntPtr arg = NSString.CreateNative(leaderboardIdentifier);
		BlockLiteral* ptr;
		if (notificationHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, notificationHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetDefaultLeaderboard_WithCompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'SetDefaultLeaderboard' on 'GKLocalPlayer' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task SetDefaultLeaderboardAsync(string? leaderboardIdentifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SetDefaultLeaderboard(leaderboardIdentifier, delegate(NSError obj_)
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
