using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNReduceFeatureChannelsAndWeightsSum", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSNNReduceFeatureChannelsAndWeightsSum : MPSNNReduceBinary
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoWeightedSumByNonZeroWeights = "doWeightedSumByNonZeroWeights";

	private static readonly IntPtr selDoWeightedSumByNonZeroWeightsHandle = Selector.GetHandle("doWeightedSumByNonZeroWeights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_DoWeightedSumByNonZeroWeights_ = "initWithDevice:doWeightedSumByNonZeroWeights:";

	private static readonly IntPtr selInitWithDevice_DoWeightedSumByNonZeroWeights_Handle = Selector.GetHandle("initWithDevice:doWeightedSumByNonZeroWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNReduceFeatureChannelsAndWeightsSum");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DoWeightedSumByNonZeroWeights
	{
		[Export("doWeightedSumByNonZeroWeights")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDoWeightedSumByNonZeroWeightsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDoWeightedSumByNonZeroWeightsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSNNReduceFeatureChannelsAndWeightsSum(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNReduceFeatureChannelsAndWeightsSum(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNReduceFeatureChannelsAndWeightsSum(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNReduceFeatureChannelsAndWeightsSum(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("initWithDevice:doWeightedSumByNonZeroWeights:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNReduceFeatureChannelsAndWeightsSum(IMTLDevice device, bool doWeightedSumByNonZeroWeights)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithDevice_DoWeightedSumByNonZeroWeights_Handle, device.Handle, doWeightedSumByNonZeroWeights), "initWithDevice:doWeightedSumByNonZeroWeights:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithDevice_DoWeightedSumByNonZeroWeights_Handle, device.Handle, doWeightedSumByNonZeroWeights), "initWithDevice:doWeightedSumByNonZeroWeights:");
		}
	}
}
