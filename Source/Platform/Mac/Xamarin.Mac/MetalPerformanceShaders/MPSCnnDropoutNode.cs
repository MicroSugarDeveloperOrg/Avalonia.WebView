using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNDropoutNode", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSCnnDropoutNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_KeepProbability_ = "initWithSource:keepProbability:";

	private static readonly IntPtr selInitWithSource_KeepProbability_Handle = Selector.GetHandle("initWithSource:keepProbability:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_KeepProbability_Seed_MaskStrideInPixels_ = "initWithSource:keepProbability:seed:maskStrideInPixels:";

	private static readonly IntPtr selInitWithSource_KeepProbability_Seed_MaskStrideInPixels_Handle = Selector.GetHandle("initWithSource:keepProbability:seed:maskStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeepProbability = "keepProbability";

	private static readonly IntPtr selKeepProbabilityHandle = Selector.GetHandle("keepProbability");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskStrideInPixels = "maskStrideInPixels";

	private static readonly IntPtr selMaskStrideInPixelsHandle = Selector.GetHandle("maskStrideInPixels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ = "nodeWithSource:";

	private static readonly IntPtr selNodeWithSource_Handle = Selector.GetHandle("nodeWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_KeepProbability_ = "nodeWithSource:keepProbability:";

	private static readonly IntPtr selNodeWithSource_KeepProbability_Handle = Selector.GetHandle("nodeWithSource:keepProbability:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_KeepProbability_Seed_MaskStrideInPixels_ = "nodeWithSource:keepProbability:seed:maskStrideInPixels:";

	private static readonly IntPtr selNodeWithSource_KeepProbability_Seed_MaskStrideInPixels_Handle = Selector.GetHandle("nodeWithSource:keepProbability:seed:maskStrideInPixels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNDropoutNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float KeepProbability
	{
		[Export("keepProbability")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selKeepProbabilityHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selKeepProbabilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSize MaskStrideInPixels
	{
		[Export("maskStrideInPixels")]
		get
		{
			MTLSize retval;
			if (base.IsDirectBinding)
			{
				Messaging.MTLSize_objc_msgSend_stret(out retval, base.Handle, selMaskStrideInPixelsHandle);
			}
			else
			{
				Messaging.MTLSize_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMaskStrideInPixelsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnDropoutNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnDropoutNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropoutNode(MPSNNImageNode source)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, source.Handle), "initWithSource:");
		}
	}

	[Export("initWithSource:keepProbability:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropoutNode(MPSNNImageNode source, float keepProbability)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithSource_KeepProbability_Handle, source.Handle, keepProbability), "initWithSource:keepProbability:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithSource_KeepProbability_Handle, source.Handle, keepProbability), "initWithSource:keepProbability:");
		}
	}

	[Export("initWithSource:keepProbability:seed:maskStrideInPixels:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnDropoutNode(MPSNNImageNode source, float keepProbability, nuint seed, MTLSize maskStrideInPixels)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float_nuint_MTLSize(base.Handle, selInitWithSource_KeepProbability_Seed_MaskStrideInPixels_Handle, source.Handle, keepProbability, seed, maskStrideInPixels), "initWithSource:keepProbability:seed:maskStrideInPixels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float_nuint_MTLSize(base.SuperHandle, selInitWithSource_KeepProbability_Seed_MaskStrideInPixels_Handle, source.Handle, keepProbability, seed, maskStrideInPixels), "initWithSource:keepProbability:seed:maskStrideInPixels:");
		}
	}

	[Export("nodeWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDropoutNode Create(MPSNNImageNode source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSCnnDropoutNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSource_Handle, source.Handle));
	}

	[Export("nodeWithSource:keepProbability:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDropoutNode Create(MPSNNImageNode source, float keepProbability)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSCnnDropoutNode>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selNodeWithSource_KeepProbability_Handle, source.Handle, keepProbability));
	}

	[Export("nodeWithSource:keepProbability:seed:maskStrideInPixels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnDropoutNode Create(MPSNNImageNode source, float keepProbability, nuint seed, MTLSize maskStrideInPixels)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSCnnDropoutNode>(Messaging.IntPtr_objc_msgSend_IntPtr_float_nuint_MTLSize(class_ptr, selNodeWithSource_KeepProbability_Seed_MaskStrideInPixels_Handle, source.Handle, keepProbability, seed, maskStrideInPixels));
	}
}
