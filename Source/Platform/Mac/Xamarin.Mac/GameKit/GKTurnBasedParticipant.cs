using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKTurnBasedParticipant", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKTurnBasedParticipant : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastTurnDate = "lastTurnDate";

	private static readonly IntPtr selLastTurnDateHandle = Selector.GetHandle("lastTurnDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchOutcome = "matchOutcome";

	private static readonly IntPtr selMatchOutcomeHandle = Selector.GetHandle("matchOutcome");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer = "player";

	private static readonly IntPtr selPlayerHandle = Selector.GetHandle("player");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerID = "playerID";

	private static readonly IntPtr selPlayerIDHandle = Selector.GetHandle("playerID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchOutcome_ = "setMatchOutcome:";

	private static readonly IntPtr selSetMatchOutcome_Handle = Selector.GetHandle("setMatchOutcome:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutDate = "timeoutDate";

	private static readonly IntPtr selTimeoutDateHandle = Selector.GetHandle("timeoutDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKTurnBasedParticipant");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate LastTurnDate
	{
		[Export("lastTurnDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastTurnDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastTurnDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedMatchOutcome MatchOutcome
	{
		[Export("matchOutcome", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKTurnBasedMatchOutcome)Messaging.Int64_objc_msgSend(base.Handle, selMatchOutcomeHandle);
			}
			return (GKTurnBasedMatchOutcome)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMatchOutcomeHandle);
		}
		[Export("setMatchOutcome:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMatchOutcome_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMatchOutcome_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual GKPlayer Player
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
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Player' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Player' instead.")]
	public virtual string PlayerID
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 8, 0, PlatformArchitecture.None, "Use 'Player' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'Player' instead.")]
		[Export("playerID", ArgumentSemantic.Copy)]
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
	public virtual GKTurnBasedParticipantStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKTurnBasedParticipantStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (GKTurnBasedParticipantStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate TimeoutDate
	{
		[Export("timeoutDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeoutDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeoutDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKTurnBasedParticipant()
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
	protected GKTurnBasedParticipant(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedParticipant(IntPtr handle)
		: base(handle)
	{
	}
}
