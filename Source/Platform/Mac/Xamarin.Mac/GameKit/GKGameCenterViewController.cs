using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKGameCenterViewController", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class GKGameCenterViewController : NSViewController, IGKViewController, INativeObject, IDisposable
{
	[Register]
	internal class _GKGameCenterControllerDelegate : NSObject, IGKGameCenterControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? finished;

		public _GKGameCenterControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("gameCenterViewControllerDidFinish:")]
		public void Finished(GKGameCenterViewController controller)
		{
			finished?.Invoke(controller, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGameCenterDelegate = "gameCenterDelegate";

	private static readonly IntPtr selGameCenterDelegateHandle = Selector.GetHandle("gameCenterDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeaderboardCategory = "leaderboardCategory";

	private static readonly IntPtr selLeaderboardCategoryHandle = Selector.GetHandle("leaderboardCategory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeaderboardIdentifier = "leaderboardIdentifier";

	private static readonly IntPtr selLeaderboardIdentifierHandle = Selector.GetHandle("leaderboardIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeaderboardTimeScope = "leaderboardTimeScope";

	private static readonly IntPtr selLeaderboardTimeScopeHandle = Selector.GetHandle("leaderboardTimeScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGameCenterDelegate_ = "setGameCenterDelegate:";

	private static readonly IntPtr selSetGameCenterDelegate_Handle = Selector.GetHandle("setGameCenterDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeaderboardCategory_ = "setLeaderboardCategory:";

	private static readonly IntPtr selSetLeaderboardCategory_Handle = Selector.GetHandle("setLeaderboardCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeaderboardIdentifier_ = "setLeaderboardIdentifier:";

	private static readonly IntPtr selSetLeaderboardIdentifier_Handle = Selector.GetHandle("setLeaderboardIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeaderboardTimeScope_ = "setLeaderboardTimeScope:";

	private static readonly IntPtr selSetLeaderboardTimeScope_Handle = Selector.GetHandle("setLeaderboardTimeScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetViewState_ = "setViewState:";

	private static readonly IntPtr selSetViewState_Handle = Selector.GetHandle("setViewState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewState = "viewState";

	private static readonly IntPtr selViewStateHandle = Selector.GetHandle("viewState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGameCenterViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKGameCenterControllerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKGameCenterControllerDelegate;
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
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
	public virtual string? LeaderboardCategory
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Export("leaderboardCategory", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLeaderboardCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeaderboardCategoryHandle));
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'LeaderboardIdentifier' instead.")]
		[Export("setLeaderboardCategory:", ArgumentSemantic.Retain)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLeaderboardCategory_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLeaderboardCategory_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual string? LeaderboardIdentifier
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("leaderboardIdentifier", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLeaderboardIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeaderboardIdentifierHandle));
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setLeaderboardIdentifier:", ArgumentSemantic.Retain)]
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
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
	public virtual GKLeaderboardTimeScope LeaderboardTimeScope
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[Export("leaderboardTimeScope", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKLeaderboardTimeScope)Messaging.Int64_objc_msgSend(base.Handle, selLeaderboardTimeScopeHandle);
			}
			return (GKLeaderboardTimeScope)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLeaderboardTimeScopeHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "This class no longer support 'LeaderboardTimeScope', will always default to 'AllTime'.")]
		[Export("setLeaderboardTimeScope:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLeaderboardTimeScope_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLeaderboardTimeScope_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	public virtual GKGameCenterViewControllerState ViewState
	{
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("viewState", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKGameCenterViewControllerState)Messaging.Int64_objc_msgSend(base.Handle, selViewStateHandle);
			}
			return (GKGameCenterViewControllerState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selViewStateHandle);
		}
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Export("setViewState:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetViewState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetViewState_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("gameCenterDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGameCenterDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGameCenterDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setGameCenterDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGameCenterDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGameCenterDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_GKGameCenterControllerDelegate);

	public event EventHandler Finished
	{
		add
		{
			_GKGameCenterControllerDelegate gKGameCenterControllerDelegate = EnsureGKGameCenterControllerDelegate();
			gKGameCenterControllerDelegate.finished = (EventHandler)System.Delegate.Combine(gKGameCenterControllerDelegate.finished, value);
		}
		remove
		{
			_GKGameCenterControllerDelegate gKGameCenterControllerDelegate = EnsureGKGameCenterControllerDelegate();
			gKGameCenterControllerDelegate.finished = (EventHandler)System.Delegate.Remove(gKGameCenterControllerDelegate.finished, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGameCenterViewController()
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
	public GKGameCenterViewController(NSCoder coder)
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
	protected GKGameCenterViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGameCenterViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGameCenterViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
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

	internal virtual _GKGameCenterControllerDelegate CreateInternalEventDelegateType()
	{
		return new _GKGameCenterControllerDelegate();
	}

	internal _GKGameCenterControllerDelegate EnsureGKGameCenterControllerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_GKGameCenterControllerDelegate gKGameCenterControllerDelegate = Delegate as _GKGameCenterControllerDelegate;
		if (gKGameCenterControllerDelegate == null)
		{
			gKGameCenterControllerDelegate = (_GKGameCenterControllerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return gKGameCenterControllerDelegate;
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
