using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNRectangleObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNRectangleObservation : VNDetectedObjectObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomLeft = "bottomLeft";

	private static readonly IntPtr selBottomLeftHandle = Selector.GetHandle("bottomLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomRight = "bottomRight";

	private static readonly IntPtr selBottomRightHandle = Selector.GetHandle("bottomRight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithBoundingBox_ = "observationWithBoundingBox:";

	private static readonly IntPtr selObservationWithBoundingBox_Handle = Selector.GetHandle("observationWithBoundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithRequestRevision_BoundingBox_ = "observationWithRequestRevision:boundingBox:";

	private static readonly IntPtr selObservationWithRequestRevision_BoundingBox_Handle = Selector.GetHandle("observationWithRequestRevision:boundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRectangleObservationWithRequestRevision_TopLeft_BottomLeft_BottomRight_TopRight_ = "rectangleObservationWithRequestRevision:topLeft:bottomLeft:bottomRight:topRight:";

	private static readonly IntPtr selRectangleObservationWithRequestRevision_TopLeft_BottomLeft_BottomRight_TopRight_Handle = Selector.GetHandle("rectangleObservationWithRequestRevision:topLeft:bottomLeft:bottomRight:topRight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopLeft = "topLeft";

	private static readonly IntPtr selTopLeftHandle = Selector.GetHandle("topLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopRight = "topRight";

	private static readonly IntPtr selTopRightHandle = Selector.GetHandle("topRight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNRectangleObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint BottomLeft
	{
		[Export("bottomLeft", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selBottomLeftHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selBottomLeftHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint BottomRight
	{
		[Export("bottomRight", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selBottomRightHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selBottomRightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint TopLeft
	{
		[Export("topLeft", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selTopLeftHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTopLeftHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint TopRight
	{
		[Export("topRight", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selTopRightHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selTopRightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNRectangleObservation(NSCoder coder)
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
	protected VNRectangleObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNRectangleObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("observationWithBoundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static VNRectangleObservation FromBoundingBox(CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNRectangleObservation>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selObservationWithBoundingBox_Handle, boundingBox));
	}

	[Export("observationWithRequestRevision:boundingBox:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNRectangleObservation FromBoundingBox(VNRectangleObservationRequestRevision requestRevision, CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNRectangleObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect(class_ptr, selObservationWithRequestRevision_BoundingBox_Handle, (ulong)requestRevision, boundingBox));
	}

	[Export("rectangleObservationWithRequestRevision:topLeft:bottomLeft:bottomRight:topRight:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNRectangleObservation GetRectangleObservation(VNRectangleObservationRequestRevision requestRevision, CGPoint topLeft, CGPoint bottomLeft, CGPoint bottomRight, CGPoint topRight)
	{
		return Runtime.GetNSObject<VNRectangleObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint_CGPoint_CGPoint_CGPoint(class_ptr, selRectangleObservationWithRequestRevision_TopLeft_BottomLeft_BottomRight_TopRight_Handle, (ulong)requestRevision, topLeft, bottomLeft, bottomRight, topRight));
	}
}
