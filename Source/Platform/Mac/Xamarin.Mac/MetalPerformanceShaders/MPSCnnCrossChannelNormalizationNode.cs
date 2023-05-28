using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSCNNCrossChannelNormalizationNode", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSCnnCrossChannelNormalizationNode : MPSCnnNormalizationNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_KernelSize_ = "initWithSource:kernelSize:";

	private static readonly IntPtr selInitWithSource_KernelSize_Handle = Selector.GetHandle("initWithSource:kernelSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKernelSizeInFeatureChannels = "kernelSizeInFeatureChannels";

	private static readonly IntPtr selKernelSizeInFeatureChannelsHandle = Selector.GetHandle("kernelSizeInFeatureChannels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_KernelSize_ = "nodeWithSource:kernelSize:";

	private static readonly IntPtr selNodeWithSource_KernelSize_Handle = Selector.GetHandle("nodeWithSource:kernelSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKernelSizeInFeatureChannels_ = "setKernelSizeInFeatureChannels:";

	private static readonly IntPtr selSetKernelSizeInFeatureChannels_Handle = Selector.GetHandle("setKernelSizeInFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSCNNCrossChannelNormalizationNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint KernelSizeInFeatureChannels
	{
		[Export("kernelSizeInFeatureChannels")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selKernelSizeInFeatureChannelsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selKernelSizeInFeatureChannelsHandle);
		}
		[Export("setKernelSizeInFeatureChannels:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetKernelSizeInFeatureChannels_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetKernelSizeInFeatureChannels_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSCnnCrossChannelNormalizationNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSCnnCrossChannelNormalizationNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:kernelSize:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnCrossChannelNormalizationNode(MPSNNImageNode sourceNode, nuint kernelSize)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithSource_KernelSize_Handle, sourceNode.Handle, kernelSize), "initWithSource:kernelSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithSource_KernelSize_Handle, sourceNode.Handle, kernelSize), "initWithSource:kernelSize:");
		}
	}

	[Export("initWithSource:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSCnnCrossChannelNormalizationNode(MPSNNImageNode sourceNode)
		: base(NSObjectFlag.Empty)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, sourceNode.Handle), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, sourceNode.Handle), "initWithSource:");
		}
	}

	[Export("nodeWithSource:kernelSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSCnnCrossChannelNormalizationNode Create(MPSNNImageNode sourceNode, nuint kernelSize)
	{
		if (sourceNode == null)
		{
			throw new ArgumentNullException("sourceNode");
		}
		return Runtime.GetNSObject<MPSCnnCrossChannelNormalizationNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selNodeWithSource_KernelSize_Handle, sourceNode.Handle, kernelSize));
	}
}
