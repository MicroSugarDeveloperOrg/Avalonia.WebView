using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNConcatenationGradientNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNConcatenationGradientNode : MPSNNGradientFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSourceGradient_SourceImage_GradientState_ = "initWithSourceGradient:sourceImage:gradientState:";

	private static readonly IntPtr selInitWithSourceGradient_SourceImage_GradientState_Handle = Selector.GetHandle("initWithSourceGradient:sourceImage:gradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSourceGradient_SourceImage_GradientState_ = "nodeWithSourceGradient:sourceImage:gradientState:";

	private static readonly IntPtr selNodeWithSourceGradient_SourceImage_GradientState_Handle = Selector.GetHandle("nodeWithSourceGradient:sourceImage:gradientState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNConcatenationGradientNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNConcatenationGradientNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNConcatenationGradientNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSourceGradient:sourceImage:gradientState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNConcatenationGradientNode(MPSNNImageNode gradientSourceNode, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState)
		: base(NSObjectFlag.Empty)
	{
		if (gradientSourceNode == null)
		{
			throw new ArgumentNullException("gradientSourceNode");
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSourceGradient_SourceImage_GradientState_Handle, gradientSourceNode.Handle, sourceImage.Handle, gradientState.Handle), "initWithSourceGradient:sourceImage:gradientState:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSourceGradient_SourceImage_GradientState_Handle, gradientSourceNode.Handle, sourceImage.Handle, gradientState.Handle), "initWithSourceGradient:sourceImage:gradientState:");
		}
	}

	[Export("nodeWithSourceGradient:sourceImage:gradientState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNConcatenationGradientNode Create(MPSNNImageNode gradientSourceNode, MPSNNImageNode sourceImage, MPSNNGradientStateNode gradientState)
	{
		if (gradientSourceNode == null)
		{
			throw new ArgumentNullException("gradientSourceNode");
		}
		if (sourceImage == null)
		{
			throw new ArgumentNullException("sourceImage");
		}
		if (gradientState == null)
		{
			throw new ArgumentNullException("gradientState");
		}
		return Runtime.GetNSObject<MPSNNConcatenationGradientNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSourceGradient_SourceImage_GradientState_Handle, gradientSourceNode.Handle, sourceImage.Handle, gradientState.Handle));
	}
}
