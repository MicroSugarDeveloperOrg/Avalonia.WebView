using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSNNBinaryArithmeticNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSNNBinaryArithmeticNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBias = "bias";

	private static readonly IntPtr selBiasHandle = Selector.GetHandle("bias");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientClass = "gradientClass";

	private static readonly IntPtr selGradientClassHandle = Selector.GetHandle("gradientClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGradientFiltersWithSources_ = "gradientFiltersWithSources:";

	private static readonly IntPtr selGradientFiltersWithSources_Handle = Selector.GetHandle("gradientFiltersWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLeftSource_RightSource_ = "initWithLeftSource:rightSource:";

	private static readonly IntPtr selInitWithLeftSource_RightSource_Handle = Selector.GetHandle("initWithLeftSource:rightSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSources_ = "initWithSources:";

	private static readonly IntPtr selInitWithSources_Handle = Selector.GetHandle("initWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumValue = "maximumValue";

	private static readonly IntPtr selMaximumValueHandle = Selector.GetHandle("maximumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumValue = "minimumValue";

	private static readonly IntPtr selMinimumValueHandle = Selector.GetHandle("minimumValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithLeftSource_RightSource_ = "nodeWithLeftSource:rightSource:";

	private static readonly IntPtr selNodeWithLeftSource_RightSource_Handle = Selector.GetHandle("nodeWithLeftSource:rightSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSources_ = "nodeWithSources:";

	private static readonly IntPtr selNodeWithSources_Handle = Selector.GetHandle("nodeWithSources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryScale = "primaryScale";

	private static readonly IntPtr selPrimaryScaleHandle = Selector.GetHandle("primaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInFeatureChannels = "primaryStrideInFeatureChannels";

	private static readonly IntPtr selPrimaryStrideInFeatureChannelsHandle = Selector.GetHandle("primaryStrideInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInPixelsX = "primaryStrideInPixelsX";

	private static readonly IntPtr selPrimaryStrideInPixelsXHandle = Selector.GetHandle("primaryStrideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryStrideInPixelsY = "primaryStrideInPixelsY";

	private static readonly IntPtr selPrimaryStrideInPixelsYHandle = Selector.GetHandle("primaryStrideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryScale = "secondaryScale";

	private static readonly IntPtr selSecondaryScaleHandle = Selector.GetHandle("secondaryScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInFeatureChannels = "secondaryStrideInFeatureChannels";

	private static readonly IntPtr selSecondaryStrideInFeatureChannelsHandle = Selector.GetHandle("secondaryStrideInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsX = "secondaryStrideInPixelsX";

	private static readonly IntPtr selSecondaryStrideInPixelsXHandle = Selector.GetHandle("secondaryStrideInPixelsX");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSecondaryStrideInPixelsY = "secondaryStrideInPixelsY";

	private static readonly IntPtr selSecondaryStrideInPixelsYHandle = Selector.GetHandle("secondaryStrideInPixelsY");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBias_ = "setBias:";

	private static readonly IntPtr selSetBias_Handle = Selector.GetHandle("setBias:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumValue_ = "setMaximumValue:";

	private static readonly IntPtr selSetMaximumValue_Handle = Selector.GetHandle("setMaximumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumValue_ = "setMinimumValue:";

	private static readonly IntPtr selSetMinimumValue_Handle = Selector.GetHandle("setMinimumValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryScale_ = "setPrimaryScale:";

	private static readonly IntPtr selSetPrimaryScale_Handle = Selector.GetHandle("setPrimaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInFeatureChannels_ = "setPrimaryStrideInFeatureChannels:";

	private static readonly IntPtr selSetPrimaryStrideInFeatureChannels_Handle = Selector.GetHandle("setPrimaryStrideInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInPixelsX_ = "setPrimaryStrideInPixelsX:";

	private static readonly IntPtr selSetPrimaryStrideInPixelsX_Handle = Selector.GetHandle("setPrimaryStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimaryStrideInPixelsY_ = "setPrimaryStrideInPixelsY:";

	private static readonly IntPtr selSetPrimaryStrideInPixelsY_Handle = Selector.GetHandle("setPrimaryStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryScale_ = "setSecondaryScale:";

	private static readonly IntPtr selSetSecondaryScale_Handle = Selector.GetHandle("setSecondaryScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInFeatureChannels_ = "setSecondaryStrideInFeatureChannels:";

	private static readonly IntPtr selSetSecondaryStrideInFeatureChannels_Handle = Selector.GetHandle("setSecondaryStrideInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsX_ = "setSecondaryStrideInPixelsX:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsX_Handle = Selector.GetHandle("setSecondaryStrideInPixelsX:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSecondaryStrideInPixelsY_ = "setSecondaryStrideInPixelsY:";

	private static readonly IntPtr selSetSecondaryStrideInPixelsY_Handle = Selector.GetHandle("setSecondaryStrideInPixelsY:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNBinaryArithmeticNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Bias
	{
		[Export("bias")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBiasHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBiasHandle);
		}
		[Export("setBias:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetBias_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetBias_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual Class GradientClass
	{
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("gradientClass")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGradientClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selGradientClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumValue
	{
		[Export("maximumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumValueHandle);
		}
		[Export("setMaximumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MinimumValue
	{
		[Export("minimumValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumValueHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumValueHandle);
		}
		[Export("setMinimumValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimumValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimumValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PrimaryScale
	{
		[Export("primaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPrimaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPrimaryScaleHandle);
		}
		[Export("setPrimaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPrimaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPrimaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PrimaryStrideInFeatureChannels
	{
		[Export("primaryStrideInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInFeatureChannelsHandle);
		}
		[Export("setPrimaryStrideInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PrimaryStrideInPixelsX
	{
		[Export("primaryStrideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInPixelsXHandle);
		}
		[Export("setPrimaryStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PrimaryStrideInPixelsY
	{
		[Export("primaryStrideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPrimaryStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPrimaryStrideInPixelsYHandle);
		}
		[Export("setPrimaryStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPrimaryStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPrimaryStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float SecondaryScale
	{
		[Export("secondaryScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selSecondaryScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selSecondaryScaleHandle);
		}
		[Export("setSecondaryScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetSecondaryScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetSecondaryScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInFeatureChannels
	{
		[Export("secondaryStrideInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInFeatureChannelsHandle);
		}
		[Export("setSecondaryStrideInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInPixelsX
	{
		[Export("secondaryStrideInPixelsX")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsXHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsXHandle);
		}
		[Export("setSecondaryStrideInPixelsX:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsX_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SecondaryStrideInPixelsY
	{
		[Export("secondaryStrideInPixelsY")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSecondaryStrideInPixelsYHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSecondaryStrideInPixelsYHandle);
		}
		[Export("setSecondaryStrideInPixelsY:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSecondaryStrideInPixelsY_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNBinaryArithmeticNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNBinaryArithmeticNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNBinaryArithmeticNode(MPSNNImageNode[] sourceNodes)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSources_Handle, nSArray.Handle), "initWithSources:");
		}
		nSArray.Dispose();
	}

	[Export("initWithLeftSource:rightSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNBinaryArithmeticNode(MPSNNImageNode left, MPSNNImageNode right)
		: base(NSObjectFlag.Empty)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithLeftSource_RightSource_Handle, left.Handle, right.Handle), "initWithLeftSource:rightSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithLeftSource_RightSource_Handle, left.Handle, right.Handle), "initWithLeftSource:rightSource:");
		}
	}

	[Export("nodeWithSources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNBinaryArithmeticNode Create(MPSNNImageNode[] sourceNodes)
	{
		if (sourceNodes == null)
		{
			throw new ArgumentNullException("sourceNodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(sourceNodes);
		MPSNNBinaryArithmeticNode nSObject = Runtime.GetNSObject<MPSNNBinaryArithmeticNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selNodeWithSources_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("nodeWithLeftSource:rightSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNBinaryArithmeticNode Create(MPSNNImageNode left, MPSNNImageNode right)
	{
		if (left == null)
		{
			throw new ArgumentNullException("left");
		}
		if (right == null)
		{
			throw new ArgumentNullException("right");
		}
		return Runtime.GetNSObject<MPSNNBinaryArithmeticNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNodeWithLeftSource_RightSource_Handle, left.Handle, right.Handle));
	}

	[Export("gradientFiltersWithSources:")]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSNNGradientFilterNode[] GetGradientFilters(MPSNNImageNode[] gradientImages)
	{
		if (gradientImages == null)
		{
			throw new ArgumentNullException("gradientImages");
		}
		NSArray nSArray = NSArray.FromNSObjects(gradientImages);
		MPSNNGradientFilterNode[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGradientFiltersWithSources_Handle, nSArray.Handle)) : NSArray.ArrayFromHandle<MPSNNGradientFilterNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGradientFiltersWithSources_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}
}
