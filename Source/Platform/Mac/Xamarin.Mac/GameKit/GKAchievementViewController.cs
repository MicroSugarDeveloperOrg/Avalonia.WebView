using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKAchievementViewController", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Use 'GKGameCenterViewController' instead.")]
public class GKAchievementViewController : GKGameCenterViewController
{
	[Register]
	internal class _GKAchievementViewControllerDelegate : _GKGameCenterControllerDelegate, IGKAchievementViewControllerDelegate, INativeObject, IDisposable
	{
		internal EventHandler? didFinish;

		public _GKAchievementViewControllerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("achievementViewControllerDidFinish:")]
		public void DidFinish(GKAchievementViewController viewController)
		{
			didFinish?.Invoke(viewController, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAchievementDelegate = "achievementDelegate";

	private static readonly IntPtr selAchievementDelegateHandle = Selector.GetHandle("achievementDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAchievementDelegate_ = "setAchievementDelegate:";

	private static readonly IntPtr selSetAchievementDelegate_Handle = Selector.GetHandle("setAchievementDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKAchievementViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new IGKAchievementViewControllerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKAchievementViewControllerDelegate;
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
	public new virtual NSObject? WeakDelegate
	{
		[Export("achievementDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAchievementDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAchievementDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setAchievementDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAchievementDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAchievementDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal override Type GetInternalEventDelegateType => typeof(_GKAchievementViewControllerDelegate);

	public event EventHandler DidFinish
	{
		add
		{
			_GKAchievementViewControllerDelegate gKAchievementViewControllerDelegate = EnsureGKAchievementViewControllerDelegate();
			gKAchievementViewControllerDelegate.didFinish = (EventHandler)System.Delegate.Combine(gKAchievementViewControllerDelegate.didFinish, value);
		}
		remove
		{
			_GKAchievementViewControllerDelegate gKAchievementViewControllerDelegate = EnsureGKAchievementViewControllerDelegate();
			gKAchievementViewControllerDelegate.didFinish = (EventHandler)System.Delegate.Remove(gKAchievementViewControllerDelegate.didFinish, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKAchievementViewController()
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
	public GKAchievementViewController(NSCoder coder)
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
	protected GKAchievementViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKAchievementViewController(IntPtr handle)
		: base(handle)
	{
	}

	internal override _GKGameCenterControllerDelegate CreateInternalEventDelegateType()
	{
		return new _GKAchievementViewControllerDelegate();
	}

	internal _GKAchievementViewControllerDelegate EnsureGKAchievementViewControllerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_GKAchievementViewControllerDelegate gKAchievementViewControllerDelegate = Delegate as _GKAchievementViewControllerDelegate;
		if (gKAchievementViewControllerDelegate == null)
		{
			gKAchievementViewControllerDelegate = (_GKAchievementViewControllerDelegate)(Delegate = (_GKAchievementViewControllerDelegate)CreateInternalEventDelegateType());
		}
		return gKAchievementViewControllerDelegate;
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
