using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNFaceObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNFaceObservation : VNDetectedObjectObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceCaptureQuality = "faceCaptureQuality";

	private static readonly IntPtr selFaceCaptureQualityHandle = Selector.GetHandle("faceCaptureQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceObservationWithRequestRevision_BoundingBox_Roll_Yaw_ = "faceObservationWithRequestRevision:boundingBox:roll:yaw:";

	private static readonly IntPtr selFaceObservationWithRequestRevision_BoundingBox_Roll_Yaw_Handle = Selector.GetHandle("faceObservationWithRequestRevision:boundingBox:roll:yaw:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLandmarks = "landmarks";

	private static readonly IntPtr selLandmarksHandle = Selector.GetHandle("landmarks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithBoundingBox_ = "observationWithBoundingBox:";

	private static readonly IntPtr selObservationWithBoundingBox_Handle = Selector.GetHandle("observationWithBoundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithRequestRevision_BoundingBox_ = "observationWithRequestRevision:boundingBox:";

	private static readonly IntPtr selObservationWithRequestRevision_BoundingBox_Handle = Selector.GetHandle("observationWithRequestRevision:boundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoll = "roll";

	private static readonly IntPtr selRollHandle = Selector.GetHandle("roll");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selYaw = "yaw";

	private static readonly IntPtr selYawHandle = Selector.GetHandle("yaw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNFaceObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(float?), OriginalType = typeof(NSNumber))]
	public virtual float? FaceCaptureQuality
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("faceCaptureQuality", ArgumentSemantic.Retain)]
		get
		{
			IntPtr ptr;
			if (base.IsDirectBinding)
			{
				return ((ptr = Messaging.IntPtr_objc_msgSend(base.Handle, selFaceCaptureQualityHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr)?.FloatValue;
			}
			IntPtr ptr2;
			return ((ptr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFaceCaptureQualityHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr2)?.FloatValue;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNFaceLandmarks2D? Landmarks
	{
		[Export("landmarks", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<VNFaceLandmarks2D>(Messaging.IntPtr_objc_msgSend(base.Handle, selLandmarksHandle));
			}
			return Runtime.GetNSObject<VNFaceLandmarks2D>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLandmarksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(nfloat?), OriginalType = typeof(NSNumber))]
	public virtual nfloat? Roll
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("roll", ArgumentSemantic.Retain)]
		get
		{
			IntPtr ptr;
			if (base.IsDirectBinding)
			{
				return ((ptr = Messaging.IntPtr_objc_msgSend(base.Handle, selRollHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr)?.NFloatValue;
			}
			IntPtr ptr2;
			return ((ptr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRollHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr2)?.NFloatValue;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindAs(typeof(nfloat?), OriginalType = typeof(NSNumber))]
	public virtual nfloat? Yaw
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("yaw", ArgumentSemantic.Retain)]
		get
		{
			IntPtr ptr;
			if (base.IsDirectBinding)
			{
				return ((ptr = Messaging.IntPtr_objc_msgSend(base.Handle, selYawHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr)?.NFloatValue;
			}
			IntPtr ptr2;
			return ((ptr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selYawHandle)) == IntPtr.Zero) ? null : Runtime.GetNSObject<NSNumber>(ptr2)?.NFloatValue;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNFaceObservation(NSCoder coder)
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
	protected VNFaceObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNFaceObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("observationWithBoundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static VNFaceObservation FromBoundingBox(CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNFaceObservation>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selObservationWithBoundingBox_Handle, boundingBox));
	}

	[Export("observationWithRequestRevision:boundingBox:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNFaceObservation FromBoundingBox(VNFaceObservationRequestRevision requestRevision, CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNFaceObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect(class_ptr, selObservationWithRequestRevision_BoundingBox_Handle, (ulong)requestRevision, boundingBox));
	}

	[Export("faceObservationWithRequestRevision:boundingBox:roll:yaw:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNFaceObservation FromBoundingBox(VNFaceObservationRequestRevision requestRevision, CGRect boundingBox, [BindAs(typeof(nfloat?), OriginalType = typeof(NSNumber))] nfloat? roll, [BindAs(typeof(nfloat?), OriginalType = typeof(NSNumber))] nfloat? yaw)
	{
		NSNumber nSNumber = ((!roll.HasValue) ? null : new NSNumber(roll.Value));
		NSNumber nSNumber2 = ((!yaw.HasValue) ? null : new NSNumber(yaw.Value));
		return Runtime.GetNSObject<VNFaceObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect_IntPtr_IntPtr(class_ptr, selFaceObservationWithRequestRevision_BoundingBox_Roll_Yaw_Handle, (ulong)requestRevision, boundingBox, nSNumber?.Handle ?? IntPtr.Zero, nSNumber2?.Handle ?? IntPtr.Zero));
	}
}
