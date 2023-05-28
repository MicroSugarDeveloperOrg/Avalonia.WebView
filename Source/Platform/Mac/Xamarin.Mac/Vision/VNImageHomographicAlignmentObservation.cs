using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace Vision;

[Register("VNImageHomographicAlignmentObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNImageHomographicAlignmentObservation : VNImageAlignmentObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWarpTransform_ = "setWarpTransform:";

	private static readonly IntPtr selSetWarpTransform_Handle = Selector.GetHandle("setWarpTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWarpTransform = "warpTransform";

	private static readonly IntPtr selWarpTransformHandle = Selector.GetHandle("warpTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNImageHomographicAlignmentObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix3 WarpTransform
	{
		[Export("warpTransform", ArgumentSemantic.Assign)]
		get
		{
			NMatrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret(out retval, base.Handle, selWarpTransformHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selWarpTransformHandle);
			}
			return retval;
		}
		[Export("setWarpTransform:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NMatrix3(base.Handle, selSetWarpTransform_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix3(base.SuperHandle, selSetWarpTransform_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNImageHomographicAlignmentObservation(NSCoder coder)
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
	protected VNImageHomographicAlignmentObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNImageHomographicAlignmentObservation(IntPtr handle)
		: base(handle)
	{
	}
}
