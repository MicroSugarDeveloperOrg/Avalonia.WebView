using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionTransposeNode", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionTransposeNode : MPSCnnConvolutionNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ConvolutionGradientState_Weights_ = "initWithSource:convolutionGradientState:weights:";

	private static readonly IntPtr selInitWithSource_ConvolutionGradientState_Weights_Handle = Selector.GetHandle("initWithSource:convolutionGradientState:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ConvolutionGradientState_Weights_ = "nodeWithSource:convolutionGradientState:weights:";

	private static readonly IntPtr selNodeWithSource_ConvolutionGradientState_Weights_Handle = Selector.GetHandle("nodeWithSource:convolutionGradientState:weights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionTransposeNode");

	public override IntPtr ClassHandle => class_ptr;

	[Obsolete("Always return null (not a public API).")]
	public static MPSCnnConvolutionTransposeNode Create(MPSNNImageNode sourceNode, MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights)
	{
		return null;
	}

	[Obsolete("Always throw a 'NotSupportedException' (not a public API).")]
	public MPSCnnConvolutionTransposeNode(MPSNNImageNode sourceNode, MPSCnnConvolutionStateNode convolutionState, IMPSCnnConvolutionDataSource weights)
		: base(IntPtr.Zero)
	{
		throw new NotSupportedException();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnConvolutionTransposeNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionTransposeNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:convolutionGradientState:weights:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnConvolutionTransposeNode(MPSNNImageNode sourceNode, MPSCnnConvolutionGradientStateNode? convolutionGradientState, IMPSCnnConvolutionDataSource weights)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithSource_ConvolutionGradientState_Weights_Handle, sourceNode.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero, weights.Handle), "initWithSource:convolutionGradientState:weights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_ConvolutionGradientState_Weights_Handle, sourceNode.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero, weights.Handle), "initWithSource:convolutionGradientState:weights:");
		}
	}

	[Export("nodeWithSource:convolutionGradientState:weights:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnConvolutionTransposeNode Create(MPSNNImageNode sourceNode, MPSCnnConvolutionGradientStateNode? convolutionGradientState, IMPSCnnConvolutionDataSource weights)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		return Runtime.GetNSObject<MPSCnnConvolutionTransposeNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selNodeWithSource_ConvolutionGradientState_Weights_Handle, sourceNode.Handle, convolutionGradientState?.Handle ?? IntPtr.Zero, weights.Handle));
	}
}
