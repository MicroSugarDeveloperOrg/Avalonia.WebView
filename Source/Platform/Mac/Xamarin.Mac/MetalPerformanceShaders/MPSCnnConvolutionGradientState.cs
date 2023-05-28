using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSCNNConvolutionGradientState", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnConvolutionGradientState : MPSNNGradientState, IMPSImageSizeEncodingState, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvolution = "convolution";

	private static readonly IntPtr selConvolutionHandle = Selector.GetHandle("convolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientForBiases = "gradientForBiases";

	private static readonly IntPtr selGradientForBiasesHandle = Selector.GetHandle("gradientForBiases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientForWeights = "gradientForWeights";

	private static readonly IntPtr selGradientForWeightsHandle = Selector.GetHandle("gradientForWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceHeight = "sourceHeight";

	private static readonly IntPtr selSourceHeightHandle = Selector.GetHandle("sourceHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceWidth = "sourceWidth";

	private static readonly IntPtr selSourceWidthHandle = Selector.GetHandle("sourceWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNConvolutionGradientState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSCnnConvolution Convolution
	{
		[Export("convolution", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPSCnnConvolution>(Messaging.IntPtr_objc_msgSend(base.Handle, selConvolutionHandle));
			}
			return Runtime.GetNSObject<MPSCnnConvolution>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConvolutionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer GradientForBiases
	{
		[Export("gradientForBiases")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGradientForBiasesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientForBiasesHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer GradientForWeights
	{
		[Export("gradientForWeights")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selGradientForWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientForWeightsHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint SourceHeight
	{
		[Export("sourceHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint SourceWidth
	{
		[Export("sourceWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnConvolutionGradientState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnConvolutionGradientState(IntPtr handle)
		: base(handle)
	{
	}
}
