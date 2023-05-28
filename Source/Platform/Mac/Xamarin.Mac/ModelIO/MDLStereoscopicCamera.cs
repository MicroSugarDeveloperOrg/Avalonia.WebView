using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLStereoscopicCamera", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLStereoscopicCamera : MDLCamera
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterPupillaryDistance = "interPupillaryDistance";

	private static readonly IntPtr selInterPupillaryDistanceHandle = Selector.GetHandle("interPupillaryDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftProjectionMatrix = "leftProjectionMatrix";

	private static readonly IntPtr selLeftProjectionMatrixHandle = Selector.GetHandle("leftProjectionMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftVergence = "leftVergence";

	private static readonly IntPtr selLeftVergenceHandle = Selector.GetHandle("leftVergence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftViewMatrix = "leftViewMatrix";

	private static readonly IntPtr selLeftViewMatrixHandle = Selector.GetHandle("leftViewMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverlap = "overlap";

	private static readonly IntPtr selOverlapHandle = Selector.GetHandle("overlap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightProjectionMatrix = "rightProjectionMatrix";

	private static readonly IntPtr selRightProjectionMatrixHandle = Selector.GetHandle("rightProjectionMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightVergence = "rightVergence";

	private static readonly IntPtr selRightVergenceHandle = Selector.GetHandle("rightVergence");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightViewMatrix = "rightViewMatrix";

	private static readonly IntPtr selRightViewMatrixHandle = Selector.GetHandle("rightViewMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterPupillaryDistance_ = "setInterPupillaryDistance:";

	private static readonly IntPtr selSetInterPupillaryDistance_Handle = Selector.GetHandle("setInterPupillaryDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeftVergence_ = "setLeftVergence:";

	private static readonly IntPtr selSetLeftVergence_Handle = Selector.GetHandle("setLeftVergence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverlap_ = "setOverlap:";

	private static readonly IntPtr selSetOverlap_Handle = Selector.GetHandle("setOverlap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRightVergence_ = "setRightVergence:";

	private static readonly IntPtr selSetRightVergence_Handle = Selector.GetHandle("setRightVergence:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLStereoscopicCamera");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float InterPupillaryDistance
	{
		[Export("interPupillaryDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selInterPupillaryDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selInterPupillaryDistanceHandle);
		}
		[Export("setInterPupillaryDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetInterPupillaryDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetInterPupillaryDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'LeftProjectionMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 LeftProjectionMatrix
	{
		[Export("leftProjectionMatrix")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selLeftProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLeftProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 LeftProjectionMatrix4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selLeftProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLeftProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LeftVergence
	{
		[Export("leftVergence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLeftVergenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLeftVergenceHandle);
		}
		[Export("setLeftVergence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLeftVergence_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLeftVergence_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'LeftViewMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 LeftViewMatrix
	{
		[Export("leftViewMatrix")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selLeftViewMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLeftViewMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 LeftViewMatrix4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selLeftViewMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selLeftViewMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Overlap
	{
		[Export("overlap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selOverlapHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selOverlapHandle);
		}
		[Export("setOverlap:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetOverlap_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetOverlap_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'RightProjectionMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 RightProjectionMatrix
	{
		[Export("rightProjectionMatrix")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selRightProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRightProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 RightProjectionMatrix4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selRightProjectionMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRightProjectionMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RightVergence
	{
		[Export("rightVergence")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRightVergenceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRightVergenceHandle);
		}
		[Export("setRightVergence:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRightVergence_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRightVergence_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'RightViewMatrix4x4' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual Matrix4 RightViewMatrix
	{
		[Export("rightViewMatrix")]
		get
		{
			Matrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSend_stret(out retval, base.Handle, selRightViewMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__Matrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRightViewMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NMatrix4 RightViewMatrix4x4
	{
		get
		{
			NMatrix4 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret(out retval, base.Handle, selRightViewMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRightViewMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLStereoscopicCamera()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLStereoscopicCamera(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLStereoscopicCamera(IntPtr handle)
		: base(handle)
	{
	}
}
