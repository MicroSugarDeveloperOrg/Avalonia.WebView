using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPressGestureRecognizer", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSPressGestureRecognizer : NSGestureRecognizer
{
	[Register("__NSPressGestureRecognizer")]
	[Preserve(Conditional = true)]
	private class Callback : Token
	{
		private Action<NSPressGestureRecognizer> action;

		internal Callback(Action<NSPressGestureRecognizer> action)
		{
			this.action = action;
		}

		[Export("target:")]
		[Preserve(Conditional = true)]
		public void Activated(NSPressGestureRecognizer sender)
		{
			action(sender);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowableMovement = "allowableMovement";

	private static readonly IntPtr selAllowableMovementHandle = Selector.GetHandle("allowableMovement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonMask = "buttonMask";

	private static readonly IntPtr selButtonMaskHandle = Selector.GetHandle("buttonMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTarget_Action_ = "initWithTarget:action:";

	private static readonly IntPtr selInitWithTarget_Action_Handle = Selector.GetHandle("initWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumPressDuration = "minimumPressDuration";

	private static readonly IntPtr selMinimumPressDurationHandle = Selector.GetHandle("minimumPressDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTouchesRequired = "numberOfTouchesRequired";

	private static readonly IntPtr selNumberOfTouchesRequiredHandle = Selector.GetHandle("numberOfTouchesRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowableMovement_ = "setAllowableMovement:";

	private static readonly IntPtr selSetAllowableMovement_Handle = Selector.GetHandle("setAllowableMovement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetButtonMask_ = "setButtonMask:";

	private static readonly IntPtr selSetButtonMask_Handle = Selector.GetHandle("setButtonMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumPressDuration_ = "setMinimumPressDuration:";

	private static readonly IntPtr selSetMinimumPressDuration_Handle = Selector.GetHandle("setMinimumPressDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfTouchesRequired_ = "setNumberOfTouchesRequired:";

	private static readonly IntPtr selSetNumberOfTouchesRequired_Handle = Selector.GetHandle("setNumberOfTouchesRequired:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPressGestureRecognizer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat AllowableMovement
	{
		[Export("allowableMovement")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAllowableMovementHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAllowableMovementHandle);
		}
		[Export("setAllowableMovement:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAllowableMovement_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAllowableMovement_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ButtonMask
	{
		[Export("buttonMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selButtonMaskHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selButtonMaskHandle);
		}
		[Export("setButtonMask:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetButtonMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetButtonMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MinimumPressDuration
	{
		[Export("minimumPressDuration")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumPressDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumPressDurationHandle);
		}
		[Export("setMinimumPressDuration:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMinimumPressDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMinimumPressDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public virtual nint NumberOfTouchesRequired
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("numberOfTouchesRequired")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfTouchesRequiredHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfTouchesRequiredHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("setNumberOfTouchesRequired:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetNumberOfTouchesRequired_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetNumberOfTouchesRequired_Handle, value);
			}
		}
	}

	public NSPressGestureRecognizer(Action action)
		: base(action)
	{
	}

	public NSPressGestureRecognizer(Action<NSPressGestureRecognizer> action)
		: base(NSGestureRecognizer.ParametrizedSelector, new Callback(action))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPressGestureRecognizer()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSPressGestureRecognizer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSPressGestureRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPressGestureRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTarget:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPressGestureRecognizer(NSObject target, Selector action)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTarget_Action_Handle, target.Handle, action.Handle), "initWithTarget:action:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTarget_Action_Handle, target.Handle, action.Handle), "initWithTarget:action:");
		}
	}
}
