using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace SpriteKit;

[Register("SKTransformNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class SKTransformNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEulerAngles = "eulerAngles";

	private static readonly IntPtr selEulerAnglesHandle = Selector.GetHandle("eulerAngles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuaternion = "quaternion";

	private static readonly IntPtr selQuaternionHandle = Selector.GetHandle("quaternion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotationMatrix = "rotationMatrix";

	private static readonly IntPtr selRotationMatrixHandle = Selector.GetHandle("rotationMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEulerAngles_ = "setEulerAngles:";

	private static readonly IntPtr selSetEulerAngles_Handle = Selector.GetHandle("setEulerAngles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuaternion_ = "setQuaternion:";

	private static readonly IntPtr selSetQuaternion_Handle = Selector.GetHandle("setQuaternion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotationMatrix_ = "setRotationMatrix:";

	private static readonly IntPtr selSetRotationMatrix_Handle = Selector.GetHandle("setRotationMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXRotation_ = "setXRotation:";

	private static readonly IntPtr selSetXRotation_Handle = Selector.GetHandle("setXRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetYRotation_ = "setYRotation:";

	private static readonly IntPtr selSetYRotation_Handle = Selector.GetHandle("setYRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXRotation = "xRotation";

	private static readonly IntPtr selXRotationHandle = Selector.GetHandle("xRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYRotation = "yRotation";

	private static readonly IntPtr selYRotationHandle = Selector.GetHandle("yRotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTransformNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NVector3 EulerAngles
	{
		[Export("eulerAngles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__NVector3_objc_msgSend(base.Handle, selEulerAnglesHandle);
			}
			return Messaging.xamarin_simd__NVector3_objc_msgSendSuper(base.SuperHandle, selEulerAnglesHandle);
		}
		[Export("setEulerAngles:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NVector3(base.Handle, selSetEulerAngles_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3(base.SuperHandle, selSetEulerAngles_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Quaternion Quaternion
	{
		[Export("quaternion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Quaternion_objc_msgSend(base.Handle, selQuaternionHandle);
			}
			return Messaging.xamarin_simd__Quaternion_objc_msgSendSuper(base.SuperHandle, selQuaternionHandle);
		}
		[Export("setQuaternion:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_Quaternion(base.Handle, selSetQuaternion_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_Quaternion(base.SuperHandle, selSetQuaternion_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix3 RotationMatrix
	{
		[Export("rotationMatrix")]
		get
		{
			NMatrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret(out retval, base.Handle, selRotationMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRotationMatrixHandle);
			}
			return retval;
		}
		[Export("setRotationMatrix:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix3(base.Handle, selSetRotationMatrix_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix3(base.SuperHandle, selSetRotationMatrix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat XRotation
	{
		[Export("xRotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selXRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selXRotationHandle);
		}
		[Export("setXRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetXRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetXRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat YRotation
	{
		[Export("yRotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selYRotationHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selYRotationHandle);
		}
		[Export("setYRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetYRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetYRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKTransformNode()
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
	public SKTransformNode(NSCoder coder)
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
	protected SKTransformNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTransformNode(IntPtr handle)
		: base(handle)
	{
	}
}
