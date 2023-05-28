using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKGaussianDistribution", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGaussianDistribution : GKRandomDistribution
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviation = "deviation";

	private static readonly IntPtr selDeviationHandle = Selector.GetHandle("deviation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRandomSource_LowestValue_HighestValue_ = "initWithRandomSource:lowestValue:highestValue:";

	private static readonly IntPtr selInitWithRandomSource_LowestValue_HighestValue_Handle = Selector.GetHandle("initWithRandomSource:lowestValue:highestValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRandomSource_Mean_Deviation_ = "initWithRandomSource:mean:deviation:";

	private static readonly IntPtr selInitWithRandomSource_Mean_Deviation_Handle = Selector.GetHandle("initWithRandomSource:mean:deviation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMean = "mean";

	private static readonly IntPtr selMeanHandle = Selector.GetHandle("mean");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGaussianDistribution");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Deviation
	{
		[Export("deviation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selDeviationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selDeviationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Mean
	{
		[Export("mean")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMeanHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMeanHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKGaussianDistribution(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGaussianDistribution(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRandomSource:lowestValue:highestValue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGaussianDistribution(IGKRandom source, nint lowestInclusive, nint highestInclusive)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint(base.Handle, selInitWithRandomSource_LowestValue_HighestValue_Handle, source.Handle, lowestInclusive, highestInclusive), "initWithRandomSource:lowestValue:highestValue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint(base.SuperHandle, selInitWithRandomSource_LowestValue_HighestValue_Handle, source.Handle, lowestInclusive, highestInclusive), "initWithRandomSource:lowestValue:highestValue:");
		}
	}

	[Export("initWithRandomSource:mean:deviation:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGaussianDistribution(IGKRandom source, float mean, float deviation)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_float(base.Handle, selInitWithRandomSource_Mean_Deviation_Handle, source.Handle, mean, deviation), "initWithRandomSource:mean:deviation:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_float(base.SuperHandle, selInitWithRandomSource_Mean_Deviation_Handle, source.Handle, mean, deviation), "initWithRandomSource:mean:deviation:");
		}
	}
}
