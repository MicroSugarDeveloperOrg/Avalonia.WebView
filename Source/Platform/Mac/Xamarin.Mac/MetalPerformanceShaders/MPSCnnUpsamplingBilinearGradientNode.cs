using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNUpsamplingBilinearGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnUpsamplingBilinearGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_ = "initWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_ = "nodeWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactorX = "scaleFactorX";

	private static readonly IntPtr selScaleFactorXHandle = Selector.GetHandle("scaleFactorX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScaleFactorY = "scaleFactorY";

	private static readonly IntPtr selScaleFactorYHandle = Selector.GetHandle("scaleFactorY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNUpsamplingBilinearGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ScaleFactorX
	{
		[Export("scaleFactorX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScaleFactorXHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScaleFactorXHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double ScaleFactorY
	{
		[Export("scaleFactorY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selScaleFactorYHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selScaleFactorYHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnUpsamplingBilinearGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnUpsamplingBilinearGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnUpsamplingBilinearGradientNode(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, double scaleFactorX, double scaleFactorY)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Double_Double(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, scaleFactorX, scaleFactorY), "initWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Double_Double(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, scaleFactorX, scaleFactorY), "initWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:scaleFactorX:scaleFactorY:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnUpsamplingBilinearGradientNode NodeWithSourceGradient(MPSNNImageNode sourceGradient, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState, double scaleFactorX, double scaleFactorY)
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
		return Runtime.GetNSObject<MPSCnnUpsamplingBilinearGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Double_Double(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_ScaleFactorX_ScaleFactorY_Handle, sourceGradient.Handle, sourceImage.Handle, gradientState.Handle, scaleFactorX, scaleFactorY));
	}
}
