using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKShuffledDistribution", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKShuffledDistribution : GKRandomDistribution
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRandomSource_LowestValue_HighestValue_ = "initWithRandomSource:lowestValue:highestValue:";

	private static readonly IntPtr selInitWithRandomSource_LowestValue_HighestValue_Handle = Selector.GetHandle("initWithRandomSource:lowestValue:highestValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKShuffledDistribution");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKShuffledDistribution(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKShuffledDistribution(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRandomSource:lowestValue:highestValue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKShuffledDistribution(IGKRandom source, nint lowestInclusive, nint highestInclusive)
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
}
