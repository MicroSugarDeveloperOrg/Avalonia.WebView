using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKRandomDistribution", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKRandomDistribution : NSObject, IGKRandom, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selD20 = "d20";

	private static readonly IntPtr selD20Handle = Selector.GetHandle("d20");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selD6 = "d6";

	private static readonly IntPtr selD6Handle = Selector.GetHandle("d6");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistributionForDieWithSideCount_ = "distributionForDieWithSideCount:";

	private static readonly IntPtr selDistributionForDieWithSideCount_Handle = Selector.GetHandle("distributionForDieWithSideCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistributionWithLowestValue_HighestValue_ = "distributionWithLowestValue:highestValue:";

	private static readonly IntPtr selDistributionWithLowestValue_HighestValue_Handle = Selector.GetHandle("distributionWithLowestValue:highestValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighestValue = "highestValue";

	private static readonly IntPtr selHighestValueHandle = Selector.GetHandle("highestValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRandomSource_LowestValue_HighestValue_ = "initWithRandomSource:lowestValue:highestValue:";

	private static readonly IntPtr selInitWithRandomSource_LowestValue_HighestValue_Handle = Selector.GetHandle("initWithRandomSource:lowestValue:highestValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowestValue = "lowestValue";

	private static readonly IntPtr selLowestValueHandle = Selector.GetHandle("lowestValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextBool = "nextBool";

	private static readonly IntPtr selNextBoolHandle = Selector.GetHandle("nextBool");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextInt = "nextInt";

	private static readonly IntPtr selNextIntHandle = Selector.GetHandle("nextInt");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextIntWithUpperBound_ = "nextIntWithUpperBound:";

	private static readonly IntPtr selNextIntWithUpperBound_Handle = Selector.GetHandle("nextIntWithUpperBound:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextUniform = "nextUniform";

	private static readonly IntPtr selNextUniformHandle = Selector.GetHandle("nextUniform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfPossibleOutcomes = "numberOfPossibleOutcomes";

	private static readonly IntPtr selNumberOfPossibleOutcomesHandle = Selector.GetHandle("numberOfPossibleOutcomes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKRandomDistribution");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HighestValue
	{
		[Export("highestValue", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHighestValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHighestValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LowestValue
	{
		[Export("lowestValue", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLowestValueHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLowestValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfPossibleOutcomes
	{
		[Export("numberOfPossibleOutcomes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfPossibleOutcomesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfPossibleOutcomesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKRandomDistribution(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKRandomDistribution(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRandomSource:lowestValue:highestValue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKRandomDistribution(IGKRandom source, nint lowestInclusive, nint highestInclusive)
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

	[Export("d20")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRandomDistribution GetD20()
	{
		return Runtime.GetNSObject<GKRandomDistribution>(Messaging.IntPtr_objc_msgSend(class_ptr, selD20Handle));
	}

	[Export("d6")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRandomDistribution GetD6()
	{
		return Runtime.GetNSObject<GKRandomDistribution>(Messaging.IntPtr_objc_msgSend(class_ptr, selD6Handle));
	}

	[Export("distributionForDieWithSideCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRandomDistribution GetDie(nint sideCount)
	{
		return Runtime.GetNSObject<GKRandomDistribution>(Messaging.IntPtr_objc_msgSend_nint(class_ptr, selDistributionForDieWithSideCount_Handle, sideCount));
	}

	[Export("distributionWithLowestValue:highestValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRandomDistribution GetDistributionBetween(nint lowestInclusive, nint highestInclusive)
	{
		return Runtime.GetNSObject<GKRandomDistribution>(Messaging.IntPtr_objc_msgSend_nint_nint(class_ptr, selDistributionWithLowestValue_HighestValue_Handle, lowestInclusive, highestInclusive));
	}

	[Export("nextBool")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetNextBool()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selNextBoolHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNextBoolHandle);
	}

	[Export("nextInt")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetNextInt()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selNextIntHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNextIntHandle);
	}

	[Export("nextIntWithUpperBound:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetNextInt(nuint upperBound)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint(base.Handle, selNextIntWithUpperBound_Handle, upperBound);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint(base.SuperHandle, selNextIntWithUpperBound_Handle, upperBound);
	}

	[Export("nextUniform")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetNextUniform()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend(base.Handle, selNextUniformHandle);
		}
		return Messaging.float_objc_msgSendSuper(base.SuperHandle, selNextUniformHandle);
	}
}
