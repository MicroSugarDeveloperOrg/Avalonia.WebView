using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNCrossChannelNormalizationGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnCrossChannelNormalizationGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_KernelSize_ = "initWithSourceGradient:sourceImage:gradientState:kernelSize:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:kernelSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelSize = "kernelSize";

	private static readonly IntPtr selKernelSizeHandle = Selector.GetHandle("kernelSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_ = "nodeWithSourceGradient:sourceImage:gradientState:kernelSize:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:kernelSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNCrossChannelNormalizationGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelSize
	{
		[Export("kernelSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnCrossChannelNormalizationGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnCrossChannelNormalizationGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:kernelSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnCrossChannelNormalizationGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelSize)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize), "initWithSourceGradient:sourceImage:gradientState:kernelSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize), "initWithSourceGradient:sourceImage:gradientState:kernelSize:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:kernelSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnCrossChannelNormalizationGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, nuint kernelSize)
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
		return Runtime.GetNSObject<MPSCnnCrossChannelNormalizationGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_KernelSize_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, kernelSize));
	}
}
