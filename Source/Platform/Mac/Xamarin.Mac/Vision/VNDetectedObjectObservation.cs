using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNDetectedObjectObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNDetectedObjectObservation : VNObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBox = "boundingBox";

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithBoundingBox_ = "observationWithBoundingBox:";

	private static readonly IntPtr selObservationWithBoundingBox_Handle = Selector.GetHandle("observationWithBoundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithRequestRevision_BoundingBox_ = "observationWithRequestRevision:boundingBox:";

	private static readonly IntPtr selObservationWithRequestRevision_BoundingBox_Handle = Selector.GetHandle("observationWithRequestRevision:boundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNDetectedObjectObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundingBox
	{
		[Export("boundingBox", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundingBoxHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingBoxHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNDetectedObjectObservation(NSCoder coder)
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
	protected VNDetectedObjectObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNDetectedObjectObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("observationWithBoundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNDetectedObjectObservation FromBoundingBox(CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNDetectedObjectObservation>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selObservationWithBoundingBox_Handle, boundingBox));
	}

	[Export("observationWithRequestRevision:boundingBox:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNDetectedObjectObservation FromBoundingBox(VNDetectedObjectObservationRequestRevision requestRevision, CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNDetectedObjectObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect(class_ptr, selObservationWithRequestRevision_BoundingBox_Handle, (ulong)requestRevision, boundingBox));
	}
}
