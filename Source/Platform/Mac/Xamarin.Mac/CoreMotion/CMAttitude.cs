using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreMotion;

[Register("CMAttitude", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class CMAttitude : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMultiplyByInverseOfAttitude_ = "multiplyByInverseOfAttitude:";

	private static readonly IntPtr selMultiplyByInverseOfAttitude_Handle = Selector.GetHandle("multiplyByInverseOfAttitude:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPitch = "pitch";

	private static readonly IntPtr selPitchHandle = Selector.GetHandle("pitch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuaternion = "quaternion";

	private static readonly IntPtr selQuaternionHandle = Selector.GetHandle("quaternion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoll = "roll";

	private static readonly IntPtr selRollHandle = Selector.GetHandle("roll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationMatrix = "rotationMatrix";

	private static readonly IntPtr selRotationMatrixHandle = Selector.GetHandle("rotationMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYaw = "yaw";

	private static readonly IntPtr selYawHandle = Selector.GetHandle("yaw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CMAttitude");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Pitch
	{
		[Export("pitch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPitchHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPitchHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMQuaternion Quaternion
	{
		[Export("quaternion")]
		get
		{
			CMQuaternion retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMQuaternion_objc_msgSend_stret(out retval, base.Handle, selQuaternionHandle);
			}
			else
			{
				Messaging.CMQuaternion_objc_msgSendSuper_stret(out retval, base.SuperHandle, selQuaternionHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Roll
	{
		[Export("roll")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selRollHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selRollHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMRotationMatrix RotationMatrix
	{
		[Export("rotationMatrix")]
		get
		{
			CMRotationMatrix retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMRotationMatrix_objc_msgSend_stret(out retval, base.Handle, selRotationMatrixHandle);
			}
			else
			{
				Messaging.CMRotationMatrix_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Yaw
	{
		[Export("yaw")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selYawHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selYawHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CMAttitude(NSCoder coder)
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
	protected CMAttitude(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CMAttitude(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
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

	[Export("multiplyByInverseOfAttitude:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MultiplyByInverseOfAttitude(CMAttitude attitude)
	{
		if (attitude == null)
		{
			throw new ArgumentNullException("attitude");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMultiplyByInverseOfAttitude_Handle, attitude.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMultiplyByInverseOfAttitude_Handle, attitude.Handle);
		}
	}
}
