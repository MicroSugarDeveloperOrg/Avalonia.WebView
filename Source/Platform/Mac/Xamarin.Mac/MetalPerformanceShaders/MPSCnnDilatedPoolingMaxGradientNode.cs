using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNDilatedPoolingMaxGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnDilatedPoolingMaxGradientNode : MPSCnnPoolingGradientNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateX = "dilationRateX";

	private static readonly IntPtr selDilationRateXHandle = Selector.GetHandle("dilationRateX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDilationRateY = "dilationRateY";

	private static readonly IntPtr selDilationRateYHandle = Selector.GetHandle("dilationRateY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_ = "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDilatedPoolingMaxGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DilationRateX
	{
		[Export("dilationRateX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DilationRateY
	{
		[Export("dilationRateY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDilationRateYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDilationRateYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnDilatedPoolingMaxGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDilatedPoolingMaxGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDilatedPoolingMaxGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, nuint dilationRateX, nuint dilationRateY)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, dilationRateX, dilationRateY), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, dilationRateX, dilationRateY), "initWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelWidth:kernelHeight:strideInPixelsX:strideInPixelsY:dilationRateX:dilationRateY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDilatedPoolingMaxGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelWidth, nuint kernelHeight, nuint strideInPixelsX, nuint strideInPixelsY, nuint dilationRateX, nuint dilationRateY)
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
		return Runtime.GetNSObject<MPSCnnDilatedPoolingMaxGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_nuint_nuint_nuint_nuint_nuint(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelWidth_KernelHeight_StrideInPixelsX_StrideInPixelsY_DilationRateX_DilationRateY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelWidth, kernelHeight, strideInPixelsX, strideInPixelsY, dilationRateX, dilationRateY));
	}
}
