using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameKit;

[Register("GKTurnBasedMatch", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKTurnBasedMatch : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptInviteWithCompletionHandler_ = "acceptInviteWithCompletionHandler:";

	private static readonly IntPtr selAcceptInviteWithCompletionHandler_Handle = Selector.GetHandle("acceptInviteWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActiveExchanges = "activeExchanges";

	private static readonly IntPtr selActiveExchangesHandle = Selector.GetHandle("activeExchanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletedExchanges = "completedExchanges";

	private static readonly IntPtr selCompletedExchangesHandle = Selector.GetHandle("completedExchanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationDate = "creationDate";

	private static readonly IntPtr selCreationDateHandle = Selector.GetHandle("creationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentParticipant = "currentParticipant";

	private static readonly IntPtr selCurrentParticipantHandle = Selector.GetHandle("currentParticipant");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeclineInviteWithCompletionHandler_ = "declineInviteWithCompletionHandler:";

	private static readonly IntPtr selDeclineInviteWithCompletionHandler_Handle = Selector.GetHandle("declineInviteWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndMatchInTurnWithMatchData_CompletionHandler_ = "endMatchInTurnWithMatchData:completionHandler:";

	private static readonly IntPtr selEndMatchInTurnWithMatchData_CompletionHandler_Handle = Selector.GetHandle("endMatchInTurnWithMatchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_ = "endMatchInTurnWithMatchData:scores:achievements:completionHandler:";

	private static readonly IntPtr selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_Handle = Selector.GetHandle("endMatchInTurnWithMatchData:scores:achievements:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndTurnWithNextParticipant_MatchData_CompletionHandler_ = "endTurnWithNextParticipant:matchData:completionHandler:";

	private static readonly IntPtr selEndTurnWithNextParticipant_MatchData_CompletionHandler_Handle = Selector.GetHandle("endTurnWithNextParticipant:matchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_ = "endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:";

	private static readonly IntPtr selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle = Selector.GetHandle("endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeDataMaximumSize = "exchangeDataMaximumSize";

	private static readonly IntPtr selExchangeDataMaximumSizeHandle = Selector.GetHandle("exchangeDataMaximumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeMaxInitiatedExchangesPerPlayer = "exchangeMaxInitiatedExchangesPerPlayer";

	private static readonly IntPtr selExchangeMaxInitiatedExchangesPerPlayerHandle = Selector.GetHandle("exchangeMaxInitiatedExchangesPerPlayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchanges = "exchanges";

	private static readonly IntPtr selExchangesHandle = Selector.GetHandle("exchanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindMatchForRequest_WithCompletionHandler_ = "findMatchForRequest:withCompletionHandler:";

	private static readonly IntPtr selFindMatchForRequest_WithCompletionHandler_Handle = Selector.GetHandle("findMatchForRequest:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadMatchDataWithCompletionHandler_ = "loadMatchDataWithCompletionHandler:";

	private static readonly IntPtr selLoadMatchDataWithCompletionHandler_Handle = Selector.GetHandle("loadMatchDataWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadMatchWithID_WithCompletionHandler_ = "loadMatchWithID:withCompletionHandler:";

	private static readonly IntPtr selLoadMatchWithID_WithCompletionHandler_Handle = Selector.GetHandle("loadMatchWithID:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadMatchesWithCompletionHandler_ = "loadMatchesWithCompletionHandler:";

	private static readonly IntPtr selLoadMatchesWithCompletionHandler_Handle = Selector.GetHandle("loadMatchesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchData = "matchData";

	private static readonly IntPtr selMatchDataHandle = Selector.GetHandle("matchData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchDataMaximumSize = "matchDataMaximumSize";

	private static readonly IntPtr selMatchDataMaximumSizeHandle = Selector.GetHandle("matchDataMaximumSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchID = "matchID";

	private static readonly IntPtr selMatchIDHandle = Selector.GetHandle("matchID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessage = "message";

	private static readonly IntPtr selMessageHandle = Selector.GetHandle("message");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_ = "participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:";

	private static readonly IntPtr selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_Handle = Selector.GetHandle("participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_ = "participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:";

	private static readonly IntPtr selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle = Selector.GetHandle("participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_ = "participantQuitOutOfTurnWithOutcome:withCompletionHandler:";

	private static readonly IntPtr selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_Handle = Selector.GetHandle("participantQuitOutOfTurnWithOutcome:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParticipants = "participants";

	private static readonly IntPtr selParticipantsHandle = Selector.GetHandle("participants");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRematchWithCompletionHandler_ = "rematchWithCompletionHandler:";

	private static readonly IntPtr selRematchWithCompletionHandler_Handle = Selector.GetHandle("rematchWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveWithCompletionHandler_ = "removeWithCompletionHandler:";

	private static readonly IntPtr selRemoveWithCompletionHandler_Handle = Selector.GetHandle("removeWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveCurrentTurnWithMatchData_CompletionHandler_ = "saveCurrentTurnWithMatchData:completionHandler:";

	private static readonly IntPtr selSaveCurrentTurnWithMatchData_CompletionHandler_Handle = Selector.GetHandle("saveCurrentTurnWithMatchData:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_ = "saveMergedMatchData:withResolvedExchanges:completionHandler:";

	private static readonly IntPtr selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_Handle = Selector.GetHandle("saveMergedMatchData:withResolvedExchanges:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_ = "sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:";

	private static readonly IntPtr selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_Handle = Selector.GetHandle("sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_ = "sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:";

	private static readonly IntPtr selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_Handle = Selector.GetHandle("sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizableMessageWithKey_Arguments_ = "setLocalizableMessageWithKey:arguments:";

	private static readonly IntPtr selSetLocalizableMessageWithKey_Arguments_Handle = Selector.GetHandle("setLocalizableMessageWithKey:arguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMessage_ = "setMessage:";

	private static readonly IntPtr selSetMessage_Handle = Selector.GetHandle("setMessage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKTurnBasedMatch");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKTurnBasedExchange[] ActiveExchanges
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("activeExchanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveExchangesHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveExchangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKTurnBasedExchange[] CompletedExchanges
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("completedExchanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompletedExchangesHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletedExchangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate CreationDate
	{
		[Export("creationDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedParticipant CurrentParticipant
	{
		[Export("currentParticipant", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentParticipantHandle));
			}
			return Runtime.GetNSObject<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentParticipantHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nuint ExchangeMaxInitiatedExchangesPerPlayer
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("exchangeMaxInitiatedExchangesPerPlayer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selExchangeMaxInitiatedExchangesPerPlayerHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selExchangeMaxInitiatedExchangesPerPlayerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKTurnBasedExchange[] Exchanges
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("exchanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSend(base.Handle, selExchangesHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedExchange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExchangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual nuint ExhangeDataMaximumSize
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("exchangeDataMaximumSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selExchangeDataMaximumSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selExchangeDataMaximumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData MatchData
	{
		[Export("matchData", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MatchDataMaximumSize
	{
		[Export("matchDataMaximumSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMatchDataMaximumSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMatchDataMaximumSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MatchID
	{
		[Export("matchID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMatchIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMatchIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Message
	{
		[Export("message", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMessageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessageHandle));
		}
		[Export("setMessage:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMessage_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMessage_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedParticipant[] Participants
	{
		[Export("participants", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selParticipantsHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParticipantsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedMatchStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKTurnBasedMatchStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (GKTurnBasedMatchStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[Field("GKTurnTimeoutDefault", "GameKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static double DefaultTimeout
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.GameKit.Handle, "GKTurnTimeoutDefault");
		}
	}

	[Field("GKTurnTimeoutNone", "GameKit")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static double NoTimeout
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.GameKit.Handle, "GKTurnTimeoutNone");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKTurnBasedMatch()
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
	protected GKTurnBasedMatch(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedMatch(IntPtr handle)
		: base(handle)
	{
	}

	[Export("acceptInviteWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AcceptInvite([BlockProxy(typeof(Trampolines.NIDActionArity2V63))] Action<GKTurnBasedMatch, NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V63.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAcceptInviteWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptInviteWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKTurnBasedMatch> AcceptInviteAsync()
	{
		TaskCompletionSource<GKTurnBasedMatch> tcs = new TaskCompletionSource<GKTurnBasedMatch>();
		AcceptInvite(delegate(GKTurnBasedMatch arg1_, NSError arg2_)
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

	[Export("declineInviteWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DeclineInvite([BlockProxy(typeof(Trampolines.NIDActionArity2V63))] Action<GKTurnBasedMatch, NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V63.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeclineInviteWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeclineInviteWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKTurnBasedMatch> DeclineInviteAsync()
	{
		TaskCompletionSource<GKTurnBasedMatch> tcs = new TaskCompletionSource<GKTurnBasedMatch>();
		DeclineInvite(delegate(GKTurnBasedMatch arg1_, NSError arg2_)
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

	[Export("endMatchInTurnWithMatchData:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EndMatchInTurn(NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? onCompletion)
	{
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		BlockLiteral* ptr;
		if (onCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, onCompletion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEndMatchInTurnWithMatchData_CompletionHandler_Handle, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEndMatchInTurnWithMatchData_CompletionHandler_Handle, matchData.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task EndMatchInTurnAsync(NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		EndMatchInTurn(matchData, delegate(NSError obj_)
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

	[Export("endMatchInTurnWithMatchData:scores:achievements:completionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EndMatchInTurn(NSData matchData, GKScore[]? scores, GKAchievement[]? achievements, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		NSArray nSArray = ((scores == null) ? null : NSArray.FromNSObjects(scores));
		NSArray nSArray2 = ((achievements == null) ? null : NSArray.FromNSObjects(achievements));
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_Handle, matchData.Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEndMatchInTurnWithMatchData_Scores_Achievements_CompletionHandler_Handle, matchData.Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task EndMatchInTurnAsync(NSData matchData, GKScore[]? scores, GKAchievement[]? achievements)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		EndMatchInTurn(matchData, scores, achievements, delegate(NSError obj_)
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

	[Export("endTurnWithNextParticipants:turnTimeout:matchData:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EndTurn(GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (nextParticipants == null)
		{
			throw new ArgumentNullException("nextParticipants");
		}
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		NSArray nSArray = NSArray.FromNSObjects(nextParticipants);
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
			Messaging.void_objc_msgSend_IntPtr_Double_IntPtr_IntPtr(base.Handle, selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle, nSArray.Handle, timeoutSeconds, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr(base.SuperHandle, selEndTurnWithNextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle, nSArray.Handle, timeoutSeconds, matchData.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task EndTurnAsync(GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		EndTurn(nextParticipants, timeoutSeconds, matchData, delegate(NSError obj_)
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

	[Export("endTurnWithNextParticipant:matchData:completionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'EndTurn' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'EndTurn' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EndTurnWithNextParticipant(GKTurnBasedParticipant nextParticipant, NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? noCompletion)
	{
		if (nextParticipant == null)
		{
			throw new ArgumentNullException("nextParticipant");
		}
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		BlockLiteral* ptr;
		if (noCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, noCompletion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selEndTurnWithNextParticipant_MatchData_CompletionHandler_Handle, nextParticipant.Handle, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEndTurnWithNextParticipant_MatchData_CompletionHandler_Handle, nextParticipant.Handle, matchData.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'EndTurn' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'EndTurn' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task EndTurnWithNextParticipantAsync(GKTurnBasedParticipant nextParticipant, NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		EndTurnWithNextParticipant(nextParticipant, matchData, delegate(NSError obj_)
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

	[Export("findMatchForRequest:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void FindMatch(GKMatchRequest request, [BlockProxy(typeof(Trampolines.NIDGKTurnBasedMatchRequest))] GKTurnBasedMatchRequest onCompletion)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (onCompletion == null)
		{
			throw new ArgumentNullException("onCompletion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGKTurnBasedMatchRequest.Handler, onCompletion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selFindMatchForRequest_WithCompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKTurnBasedMatch> FindMatchAsync(GKMatchRequest request)
	{
		TaskCompletionSource<GKTurnBasedMatch> tcs = new TaskCompletionSource<GKTurnBasedMatch>();
		FindMatch(request, delegate(GKTurnBasedMatch match_, NSError error_)
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

	[Export("loadMatchWithID:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadMatch(string matchId, [BlockProxy(typeof(Trampolines.NIDActionArity2V63))] Action<GKTurnBasedMatch, NSError>? completionHandler)
	{
		if (matchId == null)
		{
			throw new ArgumentNullException("matchId");
		}
		IntPtr arg = NSString.CreateNative(matchId);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V63.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selLoadMatchWithID_WithCompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKTurnBasedMatch> LoadMatchAsync(string matchId)
	{
		TaskCompletionSource<GKTurnBasedMatch> tcs = new TaskCompletionSource<GKTurnBasedMatch>();
		LoadMatch(matchId, delegate(GKTurnBasedMatch arg1_, NSError arg2_)
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

	[Export("loadMatchDataWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadMatchData([BlockProxy(typeof(Trampolines.NIDGKTurnBasedMatchData))] GKTurnBasedMatchData? onCompletion)
	{
		BlockLiteral* ptr;
		if (onCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKTurnBasedMatchData.Handler, onCompletion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadMatchDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadMatchDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> LoadMatchDataAsync()
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		LoadMatchData(delegate(NSData matchData_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(matchData_);
			}
		});
		return tcs.Task;
	}

	[Export("loadMatchesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadMatches([BlockProxy(typeof(Trampolines.NIDGKTurnBasedMatchesRequest))] GKTurnBasedMatchesRequest? onCompletion)
	{
		BlockLiteral* ptr;
		if (onCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDGKTurnBasedMatchesRequest.Handler, onCompletion);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadMatchesWithCompletionHandler_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<GKTurnBasedMatch[]> LoadMatchesAsync()
	{
		TaskCompletionSource<GKTurnBasedMatch[]> tcs = new TaskCompletionSource<GKTurnBasedMatch[]>();
		LoadMatches(delegate(GKTurnBasedMatch[] matches_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(matches_);
			}
		});
		return tcs.Task;
	}

	[Export("participantQuitInTurnWithOutcome:nextParticipant:matchData:completionHandler:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ParticipantQuitInTurn(GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant nextParticipant, NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? onCompletion)
	{
		if (nextParticipant == null)
		{
			throw new ArgumentNullException("nextParticipant");
		}
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		BlockLiteral* ptr;
		if (onCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, onCompletion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_Handle, (long)matchOutcome, nextParticipant.Handle, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selParticipantQuitInTurnWithOutcome_NextParticipant_MatchData_CompletionHandler_Handle, (long)matchOutcome, nextParticipant.Handle, matchData.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.None, "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, "Use 'ParticipantQuitInTurn (GKTurnBasedMatchOutcome, GKTurnBasedParticipant[], double, NSData, Action<NSError>)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ParticipantQuitInTurnAsync(GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant nextParticipant, NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ParticipantQuitInTurn(matchOutcome, nextParticipant, matchData, delegate(NSError obj_)
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

	[Export("participantQuitInTurnWithOutcome:nextParticipants:turnTimeout:matchData:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ParticipantQuitInTurn(GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (nextParticipants == null)
		{
			throw new ArgumentNullException("nextParticipants");
		}
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		NSArray nSArray = NSArray.FromNSObjects(nextParticipants);
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
			Messaging.void_objc_msgSend_Int64_IntPtr_Double_IntPtr_IntPtr(base.Handle, selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle, (long)matchOutcome, nSArray.Handle, timeoutSeconds, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_Double_IntPtr_IntPtr(base.SuperHandle, selParticipantQuitInTurnWithOutcome_NextParticipants_TurnTimeout_MatchData_CompletionHandler_Handle, (long)matchOutcome, nSArray.Handle, timeoutSeconds, matchData.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ParticipantQuitInTurnAsync(GKTurnBasedMatchOutcome matchOutcome, GKTurnBasedParticipant[] nextParticipants, double timeoutSeconds, NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ParticipantQuitInTurn(matchOutcome, nextParticipants, timeoutSeconds, matchData, delegate(NSError obj_)
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

	[Export("participantQuitOutOfTurnWithOutcome:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ParticipantQuitOutOfTurn(GKTurnBasedMatchOutcome matchOutcome, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? onCompletion)
	{
		BlockLiteral* ptr;
		if (onCompletion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, onCompletion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_Handle, (long)matchOutcome, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selParticipantQuitOutOfTurnWithOutcome_WithCompletionHandler_Handle, (long)matchOutcome, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ParticipantQuitOutOfTurnAsync(GKTurnBasedMatchOutcome matchOutcome)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ParticipantQuitOutOfTurn(matchOutcome, delegate(NSError obj_)
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

	[Export("rematchWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Rematch([BlockProxy(typeof(Trampolines.NIDActionArity2V63))] Action<GKTurnBasedMatch, NSError>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V63.Handler, completionHandler);
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
	public virtual Task<GKTurnBasedMatch> RematchAsync()
	{
		TaskCompletionSource<GKTurnBasedMatch> tcs = new TaskCompletionSource<GKTurnBasedMatch>();
		Rematch(delegate(GKTurnBasedMatch arg1_, NSError arg2_)
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

	[Export("removeWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Remove([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> onCompletion)
	{
		if (onCompletion == null)
		{
			throw new ArgumentNullException("onCompletion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, onCompletion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RemoveAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Remove(delegate(NSError obj_)
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

	[Export("saveCurrentTurnWithMatchData:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveCurrentTurn(NSData matchData, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveCurrentTurnWithMatchData_CompletionHandler_Handle, matchData.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveCurrentTurnWithMatchData_CompletionHandler_Handle, matchData.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SaveCurrentTurnAsync(NSData matchData)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SaveCurrentTurn(matchData, delegate(NSError obj_)
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

	[Export("saveMergedMatchData:withResolvedExchanges:completionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveMergedMatchData(NSData matchData, GKTurnBasedExchange[] exchanges, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (matchData == null)
		{
			throw new ArgumentNullException("matchData");
		}
		if (exchanges == null)
		{
			throw new ArgumentNullException("exchanges");
		}
		NSArray nSArray = NSArray.FromNSObjects(exchanges);
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_Handle, matchData.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveMergedMatchData_WithResolvedExchanges_CompletionHandler_Handle, matchData.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SaveMergedMatchDataAsync(NSData matchData, GKTurnBasedExchange[] exchanges)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SaveMergedMatchData(matchData, exchanges, delegate(NSError obj_)
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

	[Export("sendExchangeToParticipants:data:localizableMessageKey:arguments:timeout:completionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendExchange(GKTurnBasedParticipant[] participants, NSData data, string localizableMessage, NSObject[] arguments, double timeout, [BlockProxy(typeof(Trampolines.NIDActionArity2V64))] Action<GKTurnBasedExchange, NSError>? completionHandler)
	{
		if (participants == null)
		{
			throw new ArgumentNullException("participants");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (localizableMessage == null)
		{
			throw new ArgumentNullException("localizableMessage");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		NSArray nSArray = NSArray.FromNSObjects(participants);
		IntPtr arg = NSString.CreateNative(localizableMessage);
		NSArray nSArray2 = NSArray.FromNSObjects(arguments);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V64.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr(base.Handle, selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_Handle, nSArray.Handle, data.Handle, arg, nSArray2.Handle, timeout, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr(base.SuperHandle, selSendExchangeToParticipants_Data_LocalizableMessageKey_Arguments_Timeout_CompletionHandler_Handle, nSArray.Handle, data.Handle, arg, nSArray2.Handle, timeout, (IntPtr)ptr);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		nSArray2.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GKTurnBasedExchange> SendExchangeAsync(GKTurnBasedParticipant[] participants, NSData data, string localizableMessage, NSObject[] arguments, double timeout)
	{
		TaskCompletionSource<GKTurnBasedExchange> tcs = new TaskCompletionSource<GKTurnBasedExchange>();
		SendExchange(participants, data, localizableMessage, arguments, timeout, delegate(GKTurnBasedExchange arg1_, NSError arg2_)
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

	[Export("sendReminderToParticipants:localizableMessageKey:arguments:completionHandler:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendReminder(GKTurnBasedParticipant[] participants, string localizableMessage, NSObject[] arguments, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (participants == null)
		{
			throw new ArgumentNullException("participants");
		}
		if (localizableMessage == null)
		{
			throw new ArgumentNullException("localizableMessage");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		NSArray nSArray = NSArray.FromNSObjects(participants);
		IntPtr arg = NSString.CreateNative(localizableMessage);
		NSArray nSArray2 = NSArray.FromNSObjects(arguments);
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_Handle, nSArray.Handle, arg, nSArray2.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSendReminderToParticipants_LocalizableMessageKey_Arguments_CompletionHandler_Handle, nSArray.Handle, arg, nSArray2.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		nSArray2.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendReminderAsync(GKTurnBasedParticipant[] participants, string localizableMessage, NSObject[] arguments)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendReminder(participants, localizableMessage, arguments, delegate(NSError obj_)
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

	[Export("setLocalizableMessageWithKey:arguments:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetMessage(string localizableMessage, params NSObject[] arguments)
	{
		if (localizableMessage == null)
		{
			throw new ArgumentNullException("localizableMessage");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(localizableMessage);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetLocalizableMessageWithKey_Arguments_Handle, arg, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetLocalizableMessageWithKey_Arguments_Handle, arg, nSArray.Handle);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}
}
