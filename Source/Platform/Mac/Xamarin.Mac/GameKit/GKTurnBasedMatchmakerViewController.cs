using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKTurnBasedMatchmakerViewController", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKTurnBasedMatchmakerViewController : NSViewController, IGKViewController, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMatchRequest_ = "initWithMatchRequest:";

	private static readonly IntPtr selInitWithMatchRequest_Handle = Selector.GetHandle("initWithMatchRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowExistingMatches_ = "setShowExistingMatches:";

	private static readonly IntPtr selSetShowExistingMatches_Handle = Selector.GetHandle("setShowExistingMatches:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTurnBasedMatchmakerDelegate_ = "setTurnBasedMatchmakerDelegate:";

	private static readonly IntPtr selSetTurnBasedMatchmakerDelegate_Handle = Selector.GetHandle("setTurnBasedMatchmakerDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowExistingMatches = "showExistingMatches";

	private static readonly IntPtr selShowExistingMatchesHandle = Selector.GetHandle("showExistingMatches");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTurnBasedMatchmakerDelegate = "turnBasedMatchmakerDelegate";

	private static readonly IntPtr selTurnBasedMatchmakerDelegateHandle = Selector.GetHandle("turnBasedMatchmakerDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKTurnBasedMatchmakerViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IGKTurnBasedMatchmakerViewControllerDelegate Delegate
	{
		get
		{
			return WeakDelegate as IGKTurnBasedMatchmakerViewControllerDelegate;
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
	public virtual bool ShowExistingMatches
	{
		[Export("showExistingMatches")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowExistingMatchesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowExistingMatchesHandle);
		}
		[Export("setShowExistingMatches:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowExistingMatches_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowExistingMatches_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("turnBasedMatchmakerDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTurnBasedMatchmakerDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTurnBasedMatchmakerDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setTurnBasedMatchmakerDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTurnBasedMatchmakerDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTurnBasedMatchmakerDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKTurnBasedMatchmakerViewController(NSCoder coder)
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
	protected GKTurnBasedMatchmakerViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedMatchmakerViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKTurnBasedMatchmakerViewController(string? nibNameOrNull, NSBundle? nibBundleOrNull)
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

	[Export("initWithMatchRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKTurnBasedMatchmakerViewController(GKMatchRequest request)
		: base(NSObjectFlag.Empty)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMatchRequest_Handle, request.Handle), "initWithMatchRequest:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMatchRequest_Handle, request.Handle), "initWithMatchRequest:");
		}
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
