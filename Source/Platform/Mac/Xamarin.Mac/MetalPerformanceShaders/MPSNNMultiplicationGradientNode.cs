using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNMultiplicationGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNMultiplicationGradientNode : MPSNNArithmeticGradientNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_ = "initWithGradientImages:forwardFilter:isSecondarySourceFilter:";

	private static readonly IntPtr selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle = Selector.GetHandle("initWithGradientImages:forwardFilter:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_ = "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_ = "nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNMultiplicationGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNMultiplicationGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNMultiplicationGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNMultiplicationGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNBinaryGradientStateNode gradientState, bool isSecondarySourceFilter)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter), "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter), "initWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:");
		}
	}

	[Export("initWithGradientImages:forwardFilter:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNMultiplicationGradientNode(MPSNNImageNode[] gradientImages, MPSNNFilterNode filter, bool isSecondarySourceFilter)
		: base(NSObjectFlag.Empty)
	{
		if (gradientImages == null)
		{
			throw new ArgumentNullException("gradientImages");
		}
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		NSArray nSArray = NSArray.FromNSObjects(gradientImages);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle, nSArray.Handle, filter.Handle, isSecondarySourceFilter), "initWithGradientImages:forwardFilter:isSecondarySourceFilter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selInitWithGradientImages_ForwardFilter_IsSecondarySourceFilter_Handle, nSArray.Handle, filter.Handle, isSecondarySourceFilter), "initWithGradientImages:forwardFilter:isSecondarySourceFilter:");
		}
		nSArray.Dispose();
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:isSecondarySourceFilter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSNNMultiplicationGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNBinaryGradientStateNode gradientState, bool isSecondarySourceFilter)
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
		return Runtime.GetNSObject<MPSNNMultiplicationGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_IsSecondarySourceFilter_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, isSecondarySourceFilter));
	}
}
