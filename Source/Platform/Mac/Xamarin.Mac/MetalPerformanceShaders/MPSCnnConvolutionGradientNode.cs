using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionGradientNode : MPSNNGradientFilterNode, IMPSNNTrainableNode, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_ = "initWithSourceGradient:sourceImage:convolutionGradientState:weights:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:convolutionGradientState:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_ = "nodeWithSourceGradient:sourceImage:convolutionGradientState:weights:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:convolutionGradientState:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTrainingStyle_ = "setTrainingStyle:";

	private static readonly IntPtr selSetTrainingStyle_Handle = Selector.GetHandle("setTrainingStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrainingStyle = "trainingStyle";

	private static readonly IntPtr selTrainingStyleHandle = Selector.GetHandle("trainingStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual MPSNNTrainingStyle TrainingStyle
	{
		[Export("trainingStyle", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSNNTrainingStyle)Messaging.UInt64_objc_msgSend(base.Handle, selTrainingStyleHandle);
			}
			return (MPSNNTrainingStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTrainingStyleHandle);
		}
		[Export("setTrainingStyle:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTrainingStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTrainingStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnConvolutionGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:convolutionGradientState:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSCnnConvolutionGradientStateNode gradientState, IMPSCnnConvolutionDataSource? weights)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, weights?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:convolutionGradientState:weights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, weights?.Handle ?? IntPtr.Zero), "initWithSourceGradient:sourceImage:convolutionGradientState:weights:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:convolutionGradientState:weights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionGradientNode Create(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSCnnConvolutionGradientStateNode gradientState, IMPSCnnConvolutionDataSource? weights)
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
		return Runtime.GetNSObject<MPSCnnConvolutionGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_ConvolutionGradientState_Weights_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, weights?.Handle ?? IntPtr.Zero));
	}
}
