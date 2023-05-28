using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace AVFoundation;

[Register("AVCameraCalibrationData", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class AVCameraCalibrationData : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtrinsicMatrix = "extrinsicMatrix";

	private static readonly IntPtr selExtrinsicMatrixHandle = Selector.GetHandle("extrinsicMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntrinsicMatrix = "intrinsicMatrix";

	private static readonly IntPtr selIntrinsicMatrixHandle = Selector.GetHandle("intrinsicMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntrinsicMatrixReferenceDimensions = "intrinsicMatrixReferenceDimensions";

	private static readonly IntPtr selIntrinsicMatrixReferenceDimensionsHandle = Selector.GetHandle("intrinsicMatrixReferenceDimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInverseLensDistortionLookupTable = "inverseLensDistortionLookupTable";

	private static readonly IntPtr selInverseLensDistortionLookupTableHandle = Selector.GetHandle("inverseLensDistortionLookupTable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLensDistortionCenter = "lensDistortionCenter";

	private static readonly IntPtr selLensDistortionCenterHandle = Selector.GetHandle("lensDistortionCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLensDistortionLookupTable = "lensDistortionLookupTable";

	private static readonly IntPtr selLensDistortionLookupTableHandle = Selector.GetHandle("lensDistortionLookupTable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelSize = "pixelSize";

	private static readonly IntPtr selPixelSizeHandle = Selector.GetHandle("pixelSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCameraCalibrationData");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4x3 ExtrinsicMatrix
	{
		[Export("extrinsicMatrix")]
		get
		{
			NMatrix4x3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix4x3_objc_msgSend_stret(out retval, base.Handle, selExtrinsicMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix4x3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtrinsicMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix3 IntrinsicMatrix
	{
		[Export("intrinsicMatrix")]
		get
		{
			NMatrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret(out retval, base.Handle, selIntrinsicMatrixHandle);
			}
			else
			{
				Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selIntrinsicMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize IntrinsicMatrixReferenceDimensions
	{
		[Export("intrinsicMatrixReferenceDimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selIntrinsicMatrixReferenceDimensionsHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selIntrinsicMatrixReferenceDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? InverseLensDistortionLookupTable
	{
		[Export("inverseLensDistortionLookupTable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selInverseLensDistortionLookupTableHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInverseLensDistortionLookupTableHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint LensDistortionCenter
	{
		[Export("lensDistortionCenter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selLensDistortionCenterHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selLensDistortionCenterHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? LensDistortionLookupTable
	{
		[Export("lensDistortionLookupTable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selLensDistortionLookupTableHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLensDistortionLookupTableHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PixelSize
	{
		[Export("pixelSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPixelSizeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPixelSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCameraCalibrationData(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCameraCalibrationData(IntPtr handle)
		: base(handle)
	{
	}
}
