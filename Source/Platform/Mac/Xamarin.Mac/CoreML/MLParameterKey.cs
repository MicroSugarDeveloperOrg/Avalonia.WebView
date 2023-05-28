using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLParameterKey", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLParameterKey : MLKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta1 = "beta1";

	private static readonly IntPtr selBeta1Handle = Selector.GetHandle("beta1");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeta2 = "beta2";

	private static readonly IntPtr selBeta2Handle = Selector.GetHandle("beta2");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBiases = "biases";

	private static readonly IntPtr selBiasesHandle = Selector.GetHandle("biases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpochs = "epochs";

	private static readonly IntPtr selEpochsHandle = Selector.GetHandle("epochs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEps = "eps";

	private static readonly IntPtr selEpsHandle = Selector.GetHandle("eps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLearningRate = "learningRate";

	private static readonly IntPtr selLearningRateHandle = Selector.GetHandle("learningRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkedModelFileName = "linkedModelFileName";

	private static readonly IntPtr selLinkedModelFileNameHandle = Selector.GetHandle("linkedModelFileName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinkedModelSearchPath = "linkedModelSearchPath";

	private static readonly IntPtr selLinkedModelSearchPathHandle = Selector.GetHandle("linkedModelSearchPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiniBatchSize = "miniBatchSize";

	private static readonly IntPtr selMiniBatchSizeHandle = Selector.GetHandle("miniBatchSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMomentum = "momentum";

	private static readonly IntPtr selMomentumHandle = Selector.GetHandle("momentum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfNeighbors = "numberOfNeighbors";

	private static readonly IntPtr selNumberOfNeighborsHandle = Selector.GetHandle("numberOfNeighbors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScopedTo_ = "scopedTo:";

	private static readonly IntPtr selScopedTo_Handle = Selector.GetHandle("scopedTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShuffle = "shuffle";

	private static readonly IntPtr selShuffleHandle = Selector.GetHandle("shuffle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeights = "weights";

	private static readonly IntPtr selWeightsHandle = Selector.GetHandle("weights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLParameterKey");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Beta1
	{
		[Export("beta1")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selBeta1Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Beta2
	{
		[Export("beta2")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selBeta2Handle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Biases
	{
		[Export("biases")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selBiasesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Epochs
	{
		[Export("epochs")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selEpochsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Eps
	{
		[Export("eps")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selEpsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey LearningRate
	{
		[Export("learningRate")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selLearningRateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey LinkedModelFileName
	{
		[Export("linkedModelFileName")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinkedModelFileNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey LinkedModelSearchPath
	{
		[Export("linkedModelSearchPath")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selLinkedModelSearchPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey MiniBatchSize
	{
		[Export("miniBatchSize")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selMiniBatchSizeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Momentum
	{
		[Export("momentum")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selMomentumHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey NumberOfNeighbors
	{
		[Export("numberOfNeighbors")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selNumberOfNeighborsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Seed
	{
		[Export("seed")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selSeedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Shuffle
	{
		[Export("shuffle")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selShuffleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLParameterKey Weights
	{
		[Export("weights")]
		get
		{
			return Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selWeightsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MLParameterKey(NSCoder coder)
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
	protected MLParameterKey(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLParameterKey(IntPtr handle)
		: base(handle)
	{
	}

	[Export("scopedTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLParameterKey GetScopedParameter(string scope)
	{
		if (scope == null)
		{
			throw new ArgumentNullException("scope");
		}
		IntPtr arg = NSString.CreateNative(scope);
		MLParameterKey result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selScopedTo_Handle, arg)) : Runtime.GetNSObject<MLParameterKey>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selScopedTo_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
