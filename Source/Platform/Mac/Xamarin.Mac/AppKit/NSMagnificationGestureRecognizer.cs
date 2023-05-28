using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSMagnificationGestureRecognizer", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSMagnificationGestureRecognizer : NSGestureRecognizer
{
	[Register("__NSMagnificationGestureRecognizer")]
	[Preserve(Conditional = true)]
	private class Callback : Token
	{
		private Action<NSMagnificationGestureRecognizer> action;

		internal Callback(Action<NSMagnificationGestureRecognizer> action)
		{
			this.action = action;
		}

		[Export("target:")]
		[Preserve(Conditional = true)]
		public void Activated(NSMagnificationGestureRecognizer sender)
		{
			action(sender);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTarget_Action_ = "initWithTarget:action:";

	private static readonly IntPtr selInitWithTarget_Action_Handle = Selector.GetHandle("initWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagnification = "magnification";

	private static readonly IntPtr selMagnificationHandle = Selector.GetHandle("magnification");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagnification_ = "setMagnification:";

	private static readonly IntPtr selSetMagnification_Handle = Selector.GetHandle("setMagnification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMagnificationGestureRecognizer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Magnification
	{
		[Export("magnification")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMagnificationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMagnificationHandle);
		}
		[Export("setMagnification:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMagnification_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMagnification_Handle, value);
			}
		}
	}

	public NSMagnificationGestureRecognizer(Action action)
		: base(action)
	{
	}

	public NSMagnificationGestureRecognizer(Action<NSMagnificationGestureRecognizer> action)
		: base(NSGestureRecognizer.ParametrizedSelector, new Callback(action))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMagnificationGestureRecognizer()
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
	public NSMagnificationGestureRecognizer(NSCoder coder)
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
	protected NSMagnificationGestureRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMagnificationGestureRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTarget:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMagnificationGestureRecognizer(NSObject target, Selector action)
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
