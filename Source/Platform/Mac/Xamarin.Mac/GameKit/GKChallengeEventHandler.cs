using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKChallengeEventHandler", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class GKChallengeEventHandler : NSObject
{
	[Register]
	internal class _GKChallengeEventHandlerDelegate : NSObject, IGKChallengeEventHandlerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? localPlayerCompletedChallenge;

		internal EventHandler? localPlayerReceivedChallenge;

		internal EventHandler? localPlayerSelectedChallenge;

		internal EventHandler? remotePlayerCompletedChallenge;

		internal GKChallengePredicate? shouldShowBannerForLocallyCompletedChallenge;

		internal GKChallengePredicate? shouldShowBannerForLocallyReceivedChallenge;

		internal GKChallengePredicate? shouldShowBannerForRemotelyCompletedChallenge;

		public _GKChallengeEventHandlerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("localPlayerDidCompleteChallenge:")]
		public void LocalPlayerCompletedChallenge(GKChallenge challenge)
		{
			localPlayerCompletedChallenge?.Invoke(challenge, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("localPlayerDidReceiveChallenge:")]
		public void LocalPlayerReceivedChallenge(GKChallenge challenge)
		{
			localPlayerReceivedChallenge?.Invoke(challenge, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("localPlayerDidSelectChallenge:")]
		public void LocalPlayerSelectedChallenge(GKChallenge challenge)
		{
			localPlayerSelectedChallenge?.Invoke(challenge, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("remotePlayerDidCompleteChallenge:")]
		public void RemotePlayerCompletedChallenge(GKChallenge challenge)
		{
			remotePlayerCompletedChallenge?.Invoke(challenge, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("shouldShowBannerForLocallyCompletedChallenge:")]
		public bool ShouldShowBannerForLocallyCompletedChallenge(GKChallenge challenge)
		{
			return shouldShowBannerForLocallyCompletedChallenge?.Invoke(challenge) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("shouldShowBannerForLocallyReceivedChallenge:")]
		public bool ShouldShowBannerForLocallyReceivedChallenge(GKChallenge challenge)
		{
			return shouldShowBannerForLocallyReceivedChallenge?.Invoke(challenge) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("shouldShowBannerForRemotelyCompletedChallenge:")]
		public bool ShouldShowBannerForRemotelyCompletedChallenge(GKChallenge challenge)
		{
			return shouldShowBannerForRemotelyCompletedChallenge?.Invoke(challenge) ?? true;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChallengeEventHandler = "challengeEventHandler";

	private static readonly IntPtr selChallengeEventHandlerHandle = Selector.GetHandle("challengeEventHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKChallengeEventHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKChallengeEventHandlerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKChallengeEventHandlerDelegate;
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
	public static GKChallengeEventHandler Instance
	{
		[Export("challengeEventHandler")]
		get
		{
			return Runtime.GetNSObject<GKChallengeEventHandler>(Messaging.IntPtr_objc_msgSend(class_ptr, selChallengeEventHandlerHandle));
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

	internal virtual Type GetInternalEventDelegateType => typeof(_GKChallengeEventHandlerDelegate);

	public GKChallengePredicate? ShouldShowBannerForLocallyCompletedChallenge
	{
		get
		{
			return EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForLocallyCompletedChallenge;
		}
		set
		{
			EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForLocallyCompletedChallenge = value;
		}
	}

	public GKChallengePredicate? ShouldShowBannerForLocallyReceivedChallenge
	{
		get
		{
			return EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForLocallyReceivedChallenge;
		}
		set
		{
			EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForLocallyReceivedChallenge = value;
		}
	}

	public GKChallengePredicate? ShouldShowBannerForRemotelyCompletedChallenge
	{
		get
		{
			return EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForRemotelyCompletedChallenge;
		}
		set
		{
			EnsureGKChallengeEventHandlerDelegate().shouldShowBannerForRemotelyCompletedChallenge = value;
		}
	}

	public event EventHandler LocalPlayerCompletedChallenge
	{
		add
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerCompletedChallenge = (EventHandler)System.Delegate.Combine(gKChallengeEventHandlerDelegate.localPlayerCompletedChallenge, value);
		}
		remove
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerCompletedChallenge = (EventHandler)System.Delegate.Remove(gKChallengeEventHandlerDelegate.localPlayerCompletedChallenge, value);
		}
	}

	public event EventHandler LocalPlayerReceivedChallenge
	{
		add
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerReceivedChallenge = (EventHandler)System.Delegate.Combine(gKChallengeEventHandlerDelegate.localPlayerReceivedChallenge, value);
		}
		remove
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerReceivedChallenge = (EventHandler)System.Delegate.Remove(gKChallengeEventHandlerDelegate.localPlayerReceivedChallenge, value);
		}
	}

	public event EventHandler LocalPlayerSelectedChallenge
	{
		add
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerSelectedChallenge = (EventHandler)System.Delegate.Combine(gKChallengeEventHandlerDelegate.localPlayerSelectedChallenge, value);
		}
		remove
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.localPlayerSelectedChallenge = (EventHandler)System.Delegate.Remove(gKChallengeEventHandlerDelegate.localPlayerSelectedChallenge, value);
		}
	}

	public event EventHandler RemotePlayerCompletedChallenge
	{
		add
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.remotePlayerCompletedChallenge = (EventHandler)System.Delegate.Combine(gKChallengeEventHandlerDelegate.remotePlayerCompletedChallenge, value);
		}
		remove
		{
			_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = EnsureGKChallengeEventHandlerDelegate();
			gKChallengeEventHandlerDelegate.remotePlayerCompletedChallenge = (EventHandler)System.Delegate.Remove(gKChallengeEventHandlerDelegate.remotePlayerCompletedChallenge, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKChallengeEventHandler(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKChallengeEventHandler(IntPtr handle)
		: base(handle)
	{
	}

	internal virtual _GKChallengeEventHandlerDelegate CreateInternalEventDelegateType()
	{
		return new _GKChallengeEventHandlerDelegate();
	}

	internal _GKChallengeEventHandlerDelegate EnsureGKChallengeEventHandlerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_GKChallengeEventHandlerDelegate gKChallengeEventHandlerDelegate = Delegate as _GKChallengeEventHandlerDelegate;
		if (gKChallengeEventHandlerDelegate == null)
		{
			gKChallengeEventHandlerDelegate = (_GKChallengeEventHandlerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return gKChallengeEventHandlerDelegate;
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
