using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSRNNSingleGateDescriptor", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSRnnSingleGateDescriptor : MPSRnnDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRNNSingleGateDescriptorWithInputFeatureChannels_OutputFeatureChannels_ = "createRNNSingleGateDescriptorWithInputFeatureChannels:outputFeatureChannels:";

	private static readonly IntPtr selCreateRNNSingleGateDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle = Selector.GetHandle("createRNNSingleGateDescriptorWithInputFeatureChannels:outputFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputWeights = "inputWeights";

	private static readonly IntPtr selInputWeightsHandle = Selector.GetHandle("inputWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecurrentWeights = "recurrentWeights";

	private static readonly IntPtr selRecurrentWeightsHandle = Selector.GetHandle("recurrentWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInputWeights_ = "setInputWeights:";

	private static readonly IntPtr selSetInputWeights_Handle = Selector.GetHandle("setInputWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRecurrentWeights_ = "setRecurrentWeights:";

	private static readonly IntPtr selSetRecurrentWeights_Handle = Selector.GetHandle("setRecurrentWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNSingleGateDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? InputWeights
	{
		[Export("inputWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputWeightsHandle), owns: false);
		}
		[Export("setInputWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMPSCnnConvolutionDataSource? RecurrentWeights
	{
		[Export("recurrentWeights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecurrentWeightsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMPSCnnConvolutionDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecurrentWeightsHandle), owns: false);
		}
		[Export("setRecurrentWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRecurrentWeights_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPSRnnSingleGateDescriptor()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSRnnSingleGateDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnSingleGateDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createRNNSingleGateDescriptorWithInputFeatureChannels:outputFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSRnnSingleGateDescriptor Create(nuint inputFeatureChannels, nuint outputFeatureChannels)
	{
		return Runtime.GetNSObject<MPSRnnSingleGateDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint(class_ptr, selCreateRNNSingleGateDescriptorWithInputFeatureChannels_OutputFeatureChannels_Handle, inputFeatureChannels, outputFeatureChannels));
	}
}
