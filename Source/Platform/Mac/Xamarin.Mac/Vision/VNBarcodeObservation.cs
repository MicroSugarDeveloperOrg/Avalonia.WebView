using System;
using System.ComponentModel;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNBarcodeObservation", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class VNBarcodeObservation : VNRectangleObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBarcodeDescriptor = "barcodeDescriptor";

	private static readonly IntPtr selBarcodeDescriptorHandle = Selector.GetHandle("barcodeDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithBoundingBox_ = "observationWithBoundingBox:";

	private static readonly IntPtr selObservationWithBoundingBox_Handle = Selector.GetHandle("observationWithBoundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservationWithRequestRevision_BoundingBox_ = "observationWithRequestRevision:boundingBox:";

	private static readonly IntPtr selObservationWithRequestRevision_BoundingBox_Handle = Selector.GetHandle("observationWithRequestRevision:boundingBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPayloadStringValue = "payloadStringValue";

	private static readonly IntPtr selPayloadStringValueHandle = Selector.GetHandle("payloadStringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbology = "symbology";

	private static readonly IntPtr selSymbologyHandle = Selector.GetHandle("symbology");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNBarcodeObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIBarcodeDescriptor? BarcodeDescriptor
	{
		[Export("barcodeDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIBarcodeDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBarcodeDescriptorHandle));
			}
			return Runtime.GetNSObject<CIBarcodeDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBarcodeDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? PayloadStringValue
	{
		[Export("payloadStringValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPayloadStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPayloadStringValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public VNBarcodeSymbology Symbology => VNBarcodeSymbologyExtensions.GetValue(WeakSymbology);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString WeakSymbology
	{
		[Export("symbology")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSymbologyHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSymbologyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public VNBarcodeObservation()
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
	public VNBarcodeObservation(NSCoder coder)
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
	protected VNBarcodeObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNBarcodeObservation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("observationWithBoundingBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static VNBarcodeObservation FromBoundingBox(CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNBarcodeObservation>(Messaging.IntPtr_objc_msgSend_CGRect(class_ptr, selObservationWithBoundingBox_Handle, boundingBox));
	}

	[Export("observationWithRequestRevision:boundingBox:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static VNBarcodeObservation FromBoundingBox(VNBarcodeObservationRequestRevision requestRevision, CGRect boundingBox)
	{
		return Runtime.GetNSObject<VNBarcodeObservation>(Messaging.IntPtr_objc_msgSend_UInt64_CGRect(class_ptr, selObservationWithRequestRevision_BoundingBox_Handle, (ulong)requestRevision, boundingBox));
	}
}
