using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNReductionSpatialMeanGradientNode", true)]
[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
public class MPSNNReductionSpatialMeanGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_ = "initWithSourceGradient:sourceImage:gradientState:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_ = "nodeWithSourceGradient:sourceImage:gradientState:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNReductionSpatialMeanGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNReductionSpatialMeanGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNReductionSpatialMeanGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNReductionSpatialMeanGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState)
		: base(NSObjectFlag.Empty)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle), "initWithSourceGradient:sourceImage:gradientState:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle), "initWithSourceGradient:sourceImage:gradientState:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNReductionSpatialMeanGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState)
	{
		if (sourceGradient == null)
		{
			throw new ArgumentNullException("sourceGradient");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		return Runtime.GetNSObject<MPSNNReductionSpatialMeanGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle));
	}
}
