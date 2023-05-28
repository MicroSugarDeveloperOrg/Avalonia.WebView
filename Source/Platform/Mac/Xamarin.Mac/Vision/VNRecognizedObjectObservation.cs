using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNRecognizedObjectObservation", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class VNRecognizedObjectObservation : VNDetectedObjectObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabels = "labels";

	private static readonly IntPtr selLabelsHandle = Selector.GetHandle("labels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithBoundingBox_ = "observationWithBoundingBox:";

	private static readonly IntPtr selObservationWithBoundingBox_Handle = Selector.GetHandle("observationWithBoundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithRequestRevision_BoundingBox_ = "observationWithRequestRevision:boundingBox:";

	private static readonly IntPtr selObservationWithRequestRevision_BoundingBox_Handle = Selector.GetHandle("observationWithRequestRevision:boundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNRecognizedObjectObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNClassificationObservation[] Labels
	{
		[Export("labels", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<VNClassificationObservation>(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelsHandle));
			}
			return NSArray.ArrayFromHandle<VNClassificationObservation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNRecognizedObjectObservation(NSCoder coder)
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
	protected VNRecognizedObjectObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNRecognizedObjectObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("observationWithBoundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static VNRecognizedObjectObservation FromBoundingBox(CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNRecognizedObjectObservation>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selObservationWithBoundingBox_Handle, boundingBox));
	}

	[Export("observationWithRequestRevision:boundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNRecognizedObjectObservation FromBoundingBox(VNRecognizedObjectObservationRequestRevision requestRevision, CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNRecognizedObjectObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect(class_ptr, selObservationWithRequestRevision_BoundingBox_Handle, (ulong)requestRevision, boundingBox));
	}
}
