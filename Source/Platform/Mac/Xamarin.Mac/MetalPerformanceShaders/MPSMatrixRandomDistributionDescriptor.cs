using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixRandomDistributionDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MPSMatrixRandomDistributionDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDistributionDescriptor = "defaultDistributionDescriptor";

	private static readonly IntPtr selDefaultDistributionDescriptorHandle = Selector.GetHandle("defaultDistributionDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistributionType = "distributionType";

	private static readonly IntPtr selDistributionTypeHandle = Selector.GetHandle("distributionType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximum = "maximum";

	private static readonly IntPtr selMaximumHandle = Selector.GetHandle("maximum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMean = "mean";

	private static readonly IntPtr selMeanHandle = Selector.GetHandle("mean");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimum = "minimum";

	private static readonly IntPtr selMinimumHandle = Selector.GetHandle("minimum");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDistributionType_ = "setDistributionType:";

	private static readonly IntPtr selSetDistributionType_Handle = Selector.GetHandle("setDistributionType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximum_ = "setMaximum:";

	private static readonly IntPtr selSetMaximum_Handle = Selector.GetHandle("setMaximum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMean_ = "setMean:";

	private static readonly IntPtr selSetMean_Handle = Selector.GetHandle("setMean:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimum_ = "setMinimum:";

	private static readonly IntPtr selSetMinimum_Handle = Selector.GetHandle("setMinimum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStandardDeviation_ = "setStandardDeviation:";

	private static readonly IntPtr selSetStandardDeviation_Handle = Selector.GetHandle("setStandardDeviation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardDeviation = "standardDeviation";

	private static readonly IntPtr selStandardDeviationHandle = Selector.GetHandle("standardDeviation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformDistributionDescriptorWithMinimum_Maximum_ = "uniformDistributionDescriptorWithMinimum:maximum:";

	private static readonly IntPtr selUniformDistributionDescriptorWithMinimum_Maximum_Handle = Selector.GetHandle("uniformDistributionDescriptorWithMinimum:maximum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixRandomDistributionDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSMatrixRandomDistribution DistributionType
	{
		[Export("distributionType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSMatrixRandomDistribution)Messaging.UInt64_objc_msgSend(base.Handle, selDistributionTypeHandle);
			}
			return (MPSMatrixRandomDistribution)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDistributionTypeHandle);
		}
		[Export("setDistributionType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDistributionType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDistributionType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Maximum
	{
		[Export("maximum")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumHandle);
		}
		[Export("setMaximum:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximum_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximum_Handle, value);
			}
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
		[Export("setMean:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMean_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMean_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Minimum
	{
		[Export("minimum")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMinimumHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMinimumHandle);
		}
		[Export("setMinimum:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMinimum_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMinimum_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float StandardDeviation
	{
		[Export("standardDeviation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selStandardDeviationHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selStandardDeviationHandle);
		}
		[Export("setStandardDeviation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetStandardDeviation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetStandardDeviation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MPSMatrixRandomDistributionDescriptor()
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
	protected MPSMatrixRandomDistributionDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixRandomDistributionDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("defaultDistributionDescriptor")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixRandomDistributionDescriptor CreateDefault()
	{
		return Runtime.GetNSObject<MPSMatrixRandomDistributionDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultDistributionDescriptorHandle));
	}

	[Export("uniformDistributionDescriptorWithMinimum:maximum:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixRandomDistributionDescriptor CreateUniform(float minimum, float maximum)
	{
		return Runtime.GetNSObject<MPSMatrixRandomDistributionDescriptor>(Messaging.IntPtr_objc_msgSend_float_float(class_ptr, selUniformDistributionDescriptorWithMinimum_Maximum_Handle, minimum, maximum));
	}
}
