using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKLeaderboardViewController", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
public class GKLeaderboardViewController : GKGameCenterViewController
{
	[Register]
	internal class _GKLeaderboardViewControllerDelegate : _GKGameCenterControllerDelegate, IGKLeaderboardViewControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? didFinish;

		public _GKLeaderboardViewControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("leaderboardViewControllerDidFinish:")]
		public void DidFinish(GKLeaderboardViewController viewController)
		{
			didFinish?.Invoke(viewController, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategory = "category";

	private static readonly IntPtr selCategoryHandle = Selector.GetHandle("category");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeaderboardDelegate = "leaderboardDelegate";

	private static readonly IntPtr selLeaderboardDelegateHandle = Selector.GetHandle("leaderboardDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCategory_ = "setCategory:";

	private static readonly IntPtr selSetCategory_Handle = Selector.GetHandle("setCategory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeaderboardDelegate_ = "setLeaderboardDelegate:";

	private static readonly IntPtr selSetLeaderboardDelegate_Handle = Selector.GetHandle("setLeaderboardDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeScope_ = "setTimeScope:";

	private static readonly IntPtr selSetTimeScope_Handle = Selector.GetHandle("setTimeScope:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeScope = "timeScope";

	private static readonly IntPtr selTimeScopeHandle = Selector.GetHandle("timeScope");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKLeaderboardViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Category
	{
		[Export("category", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCategoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCategoryHandle));
		}
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
	public new IGKLeaderboardViewControllerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKLeaderboardViewControllerDelegate;
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
	public new virtual NSObject? WeakDelegate
	{
		[Export("leaderboardDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeaderboardDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLeaderboardDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setLeaderboardDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLeaderboardDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLeaderboardDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal override Type GetInternalEventDelegateType => typeof(_GKLeaderboardViewControllerDelegate);

	public event EventHandler DidFinish
	{
		add
		{
			_GKLeaderboardViewControllerDelegate gKLeaderboardViewControllerDelegate = EnsureGKLeaderboardViewControllerDelegate();
			gKLeaderboardViewControllerDelegate.didFinish = (EventHandler)System.Delegate.Combine(gKLeaderboardViewControllerDelegate.didFinish, value);
		}
		remove
		{
			_GKLeaderboardViewControllerDelegate gKLeaderboardViewControllerDelegate = EnsureGKLeaderboardViewControllerDelegate();
			gKLeaderboardViewControllerDelegate.didFinish = (EventHandler)System.Delegate.Remove(gKLeaderboardViewControllerDelegate.didFinish, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKLeaderboardViewController()
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
	public GKLeaderboardViewController(NSCoder coder)
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
	protected GKLeaderboardViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKLeaderboardViewController(IntPtr handle)
		: base(handle)
	{
	}

	internal override _GKGameCenterControllerDelegate CreateInternalEventDelegateType()
	{
		return new _GKLeaderboardViewControllerDelegate();
	}

	internal _GKLeaderboardViewControllerDelegate EnsureGKLeaderboardViewControllerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_GKLeaderboardViewControllerDelegate gKLeaderboardViewControllerDelegate = Delegate as _GKLeaderboardViewControllerDelegate;
		if (gKLeaderboardViewControllerDelegate == null)
		{
			gKLeaderboardViewControllerDelegate = (_GKLeaderboardViewControllerDelegate)(Delegate = (_GKLeaderboardViewControllerDelegate)CreateInternalEventDelegateType());
		}
		return gKLeaderboardViewControllerDelegate;
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
