using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSPanGestureRecognizer", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSPanGestureRecognizer : NSGestureRecognizer, INSCoding, INativeObject, IDisposable
{
	[Register("__NSPanGestureRecognizer")]
	[Preserve(Conditional = true)]
	private class Callback : Token
	{
		private Action<NSPanGestureRecognizer> action;

		internal Callback(Action<NSPanGestureRecognizer> action)
		{
			this.action = action;
		}

		[Export("target:")]
		[Preserve(Conditional = true)]
		public void Activated(NSPanGestureRecognizer sender)
		{
			action(sender);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtonMask = "buttonMask";

	private static readonly IntPtr selButtonMaskHandle = Selector.GetHandle("buttonMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTarget_Action_ = "initWithTarget:action:";

	private static readonly IntPtr selInitWithTarget_Action_Handle = Selector.GetHandle("initWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTouchesRequired = "numberOfTouchesRequired";

	private static readonly IntPtr selNumberOfTouchesRequiredHandle = Selector.GetHandle("numberOfTouchesRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetButtonMask_ = "setButtonMask:";

	private static readonly IntPtr selSetButtonMask_Handle = Selector.GetHandle("setButtonMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfTouchesRequired_ = "setNumberOfTouchesRequired:";

	private static readonly IntPtr selSetNumberOfTouchesRequired_Handle = Selector.GetHandle("setNumberOfTouchesRequired:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTranslation_InView_ = "setTranslation:inView:";

	private static readonly IntPtr selSetTranslation_InView_Handle = Selector.GetHandle("setTranslation:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTranslationInView_ = "translationInView:";

	private static readonly IntPtr selTranslationInView_Handle = Selector.GetHandle("translationInView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVelocityInView_ = "velocityInView:";

	private static readonly IntPtr selVelocityInView_Handle = Selector.GetHandle("velocityInView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPanGestureRecognizer");

	public override IntPtr ClassHandle => class_ptr;

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

	public NSPanGestureRecognizer(Action action)
		: base(action)
	{
	}

	public NSPanGestureRecognizer(Action<NSPanGestureRecognizer> action)
		: base(NSGestureRecognizer.ParametrizedSelector, new Callback(action))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPanGestureRecognizer()
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
	public NSPanGestureRecognizer(NSCoder coder)
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
	protected NSPanGestureRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPanGestureRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTarget:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSPanGestureRecognizer(NSObject target, Selector action)
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("setTranslation:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetTranslation(CGPoint translation, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_IntPtr(base.Handle, selSetTranslation_InView_Handle, translation, view.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selSetTranslation_InView_Handle, translation, view.Handle);
		}
	}

	[Export("translationInView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint TranslationInView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_IntPtr(base.Handle, selTranslationInView_Handle, view.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_IntPtr(base.SuperHandle, selTranslationInView_Handle, view.Handle);
	}

	[Export("velocityInView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint VelocityInView(NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_IntPtr(base.Handle, selVelocityInView_Handle, view.Handle);
		}
		return Messaging.CGPoint_objc_msgSendSuper_IntPtr(base.SuperHandle, selVelocityInView_Handle, view.Handle);
	}
}
