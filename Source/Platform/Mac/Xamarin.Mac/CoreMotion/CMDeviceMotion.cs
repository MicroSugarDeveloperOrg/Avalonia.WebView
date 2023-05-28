using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreMotion;

[Register("CMDeviceMotion", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class CMDeviceMotion : CMLogItem, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttitude = "attitude";

	private static readonly IntPtr selAttitudeHandle = Selector.GetHandle("attitude");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGravity = "gravity";

	private static readonly IntPtr selGravityHandle = Selector.GetHandle("gravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeading = "heading";

	private static readonly IntPtr selHeadingHandle = Selector.GetHandle("heading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagneticField = "magneticField";

	private static readonly IntPtr selMagneticFieldHandle = Selector.GetHandle("magneticField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationRate = "rotationRate";

	private static readonly IntPtr selRotationRateHandle = Selector.GetHandle("rotationRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserAcceleration = "userAcceleration";

	private static readonly IntPtr selUserAccelerationHandle = Selector.GetHandle("userAcceleration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CMDeviceMotion");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMAttitude Attitude
	{
		[Export("attitude")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CMAttitude>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttitudeHandle));
			}
			return Runtime.GetNSObject<CMAttitude>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttitudeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMAcceleration Gravity
	{
		[Export("gravity")]
		get
		{
			CMAcceleration retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMAcceleration_objc_msgSend_stret(out retval, base.Handle, selGravityHandle);
			}
			else
			{
				Messaging.CMAcceleration_objc_msgSendSuper_stret(out retval, base.SuperHandle, selGravityHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual double Heading
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("heading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selHeadingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selHeadingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMCalibratedMagneticField MagneticField
	{
		[Export("magneticField")]
		get
		{
			CMCalibratedMagneticField retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMCalibratedMagneticField_objc_msgSend_stret(out retval, base.Handle, selMagneticFieldHandle);
			}
			else
			{
				Messaging.CMCalibratedMagneticField_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMagneticFieldHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMRotationRate RotationRate
	{
		[Export("rotationRate")]
		get
		{
			CMRotationRate retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMRotationRate_objc_msgSend_stret(out retval, base.Handle, selRotationRateHandle);
			}
			else
			{
				Messaging.CMRotationRate_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationRateHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMAcceleration UserAcceleration
	{
		[Export("userAcceleration")]
		get
		{
			CMAcceleration retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMAcceleration_objc_msgSend_stret(out retval, base.Handle, selUserAccelerationHandle);
			}
			else
			{
				Messaging.CMAcceleration_objc_msgSendSuper_stret(out retval, base.SuperHandle, selUserAccelerationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CMDeviceMotion(NSCoder coder)
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
	protected CMDeviceMotion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CMDeviceMotion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
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
}
