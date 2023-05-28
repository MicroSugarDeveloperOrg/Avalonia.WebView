using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSRotationGestureRecognizer", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSRotationGestureRecognizer : NSGestureRecognizer
{
	[Register("__NSRotationGestureRecognizer")]
	[Preserve(Conditional = true)]
	private class Callback : Token
	{
		private Action<NSRotationGestureRecognizer> action;

		internal Callback(Action<NSRotationGestureRecognizer> action)
		{
			this.action = action;
		}

		[Export("target:")]
		[Preserve(Conditional = true)]
		public void Activated(NSRotationGestureRecognizer sender)
		{
			action(sender);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTarget_Action_ = "initWithTarget:action:";

	private static readonly IntPtr selInitWithTarget_Action_Handle = Selector.GetHandle("initWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationInDegrees = "rotationInDegrees";

	private static readonly IntPtr selRotationInDegreesHandle = Selector.GetHandle("rotationInDegrees");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ = "setRotation:";

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationInDegrees_ = "setRotationInDegrees:";

	private static readonly IntPtr selSetRotationInDegrees_Handle = Selector.GetHandle("setRotationInDegrees:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRotationGestureRecognizer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Rotation
	{
		[Export("rotation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat RotationInDegrees
	{
		[Export("rotationInDegrees")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selRotationInDegreesHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selRotationInDegreesHandle);
		}
		[Export("setRotationInDegrees:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetRotationInDegrees_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetRotationInDegrees_Handle, value);
			}
		}
	}

	public NSRotationGestureRecognizer(Action action)
		: base(action)
	{
	}

	public NSRotationGestureRecognizer(Action<NSRotationGestureRecognizer> action)
		: base(NSGestureRecognizer.ParametrizedSelector, new Callback(action))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRotationGestureRecognizer()
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
	public NSRotationGestureRecognizer(NSCoder coder)
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
	protected NSRotationGestureRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRotationGestureRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTarget:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRotationGestureRecognizer(NSObject target, Selector action)
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
