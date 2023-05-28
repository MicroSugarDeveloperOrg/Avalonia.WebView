using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNPoolingL2NormGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnPoolingL2NormGradientNode : MPSCnnPoolingGradientNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_ = "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNPoolingL2NormGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnPoolingL2NormGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnPoolingL2NormGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnPoolingL2NormGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, IMPSNNPadding? paddingPolicy)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:paddingPolicy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSCnnPoolingL2NormGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, IMPSNNPadding? paddingPolicy)
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
		return Runtime.GetNSObject<MPSCnnPoolingL2NormGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_PaddingPolicy_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, paddingPolicy?.Handle ?? IntPtr.Zero));
	}
}
