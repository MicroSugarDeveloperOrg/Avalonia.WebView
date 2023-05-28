using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNLossLabels", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnLossLabels : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LabelsDescriptor_ = "initWithDevice:labelsDescriptor:";

	private static readonly IntPtr selInitWithDevice_LabelsDescriptor_Handle = Selector.GetHandle("initWithDevice:labelsDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_LossImageSize_LabelsDescriptor_WeightsDescriptor_ = "initWithDevice:lossImageSize:labelsDescriptor:weightsDescriptor:";

	private static readonly IntPtr selInitWithDevice_LossImageSize_LabelsDescriptor_WeightsDescriptor_Handle = Selector.GetHandle("initWithDevice:lossImageSize:labelsDescriptor:weightsDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelsImage = "labelsImage";

	private static readonly IntPtr selLabelsImageHandle = Selector.GetHandle("labelsImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossImage = "lossImage";

	private static readonly IntPtr selLossImageHandle = Selector.GetHandle("lossImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightsImage = "weightsImage";

	private static readonly IntPtr selWeightsImageHandle = Selector.GetHandle("weightsImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNLossLabels");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MPSImage LabelsImage
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("labelsImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelsImageHandle));
			}
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelsImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage LossImage
	{
		[Export("lossImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selLossImageHandle));
			}
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLossImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual MPSImage WeightsImage
	{
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("weightsImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selWeightsImageHandle));
			}
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWeightsImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnLossLabels(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnLossLabels(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:labelsDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLossLabels(IMTLDevice device, MPSCnnLossDataDescriptor labelsDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (labelsDescriptor == null)
		{
			throw new ArgumentNullException("labelsDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_LabelsDescriptor_Handle, device.Handle, labelsDescriptor.Handle), "initWithDevice:labelsDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_LabelsDescriptor_Handle, device.Handle, labelsDescriptor.Handle), "initWithDevice:labelsDescriptor:");
		}
	}

	[Export("initWithDevice:lossImageSize:labelsDescriptor:weightsDescriptor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnLossLabels(IMTLDevice device, MTLSize lossImageSize, MPSCnnLossDataDescriptor labelsDescriptor, MPSCnnLossDataDescriptor? weightsDescriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (labelsDescriptor == null)
		{
			throw new ArgumentNullException("labelsDescriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_MTLSize_IntPtr_IntPtr(base.Handle, selInitWithDevice_LossImageSize_LabelsDescriptor_WeightsDescriptor_Handle, device.Handle, lossImageSize, labelsDescriptor.Handle, weightsDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:lossImageSize:labelsDescriptor:weightsDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_MTLSize_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_LossImageSize_LabelsDescriptor_WeightsDescriptor_Handle, device.Handle, lossImageSize, labelsDescriptor.Handle, weightsDescriptor?.Handle ?? IntPtr.Zero), "initWithDevice:lossImageSize:labelsDescriptor:weightsDescriptor:");
		}
	}
}
