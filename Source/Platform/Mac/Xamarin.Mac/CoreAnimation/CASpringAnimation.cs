using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CASpringAnimation", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CASpringAnimation : CABasicAnimation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationWithKeyPath_ = "animationWithKeyPath:";

	private static readonly IntPtr selAnimationWithKeyPath_Handle = Selector.GetHandle("animationWithKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDamping = "damping";

	private static readonly IntPtr selDampingHandle = Selector.GetHandle("damping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialVelocity = "initialVelocity";

	private static readonly IntPtr selInitialVelocityHandle = Selector.GetHandle("initialVelocity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMass = "mass";

	private static readonly IntPtr selMassHandle = Selector.GetHandle("mass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDamping_ = "setDamping:";

	private static readonly IntPtr selSetDamping_Handle = Selector.GetHandle("setDamping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInitialVelocity_ = "setInitialVelocity:";

	private static readonly IntPtr selSetInitialVelocity_Handle = Selector.GetHandle("setInitialVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMass_ = "setMass:";

	private static readonly IntPtr selSetMass_Handle = Selector.GetHandle("setMass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStiffness_ = "setStiffness:";

	private static readonly IntPtr selSetStiffness_Handle = Selector.GetHandle("setStiffness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSettlingDuration = "settlingDuration";

	private static readonly IntPtr selSettlingDurationHandle = Selector.GetHandle("settlingDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStiffness = "stiffness";

	private static readonly IntPtr selStiffnessHandle = Selector.GetHandle("stiffness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CASpringAnimation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Damping
	{
		[Export("damping")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDampingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDampingHandle);
		}
		[Export("setDamping:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetDamping_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetDamping_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat InitialVelocity
	{
		[Export("initialVelocity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selInitialVelocityHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selInitialVelocityHandle);
		}
		[Export("setInitialVelocity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInitialVelocity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInitialVelocity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Mass
	{
		[Export("mass")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMassHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMassHandle);
		}
		[Export("setMass:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMass_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMass_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double SettlingDuration
	{
		[Export("settlingDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selSettlingDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selSettlingDurationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Stiffness
	{
		[Export("stiffness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStiffnessHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStiffnessHandle);
		}
		[Export("setStiffness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetStiffness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetStiffness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CASpringAnimation()
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
	public CASpringAnimation(NSCoder coder)
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
	protected CASpringAnimation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CASpringAnimation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("animationWithKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CABasicAnimation FromKeyPath(string? path)
	{
		IntPtr arg = NSString.CreateNative(path);
		CABasicAnimation nSObject = Runtime.GetNSObject<CABasicAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAnimationWithKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
