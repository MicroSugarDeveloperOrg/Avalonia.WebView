using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSNNReshapeNode", true)]
[Introduced(PlatformName.TvOS, 12, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 1, PlatformArchitecture.All, null)]
public class MPSNNReshapeNode : MPSNNFilterNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_ = "initWithSource:resultWidth:resultHeight:resultFeatureChannels:";

	private static readonly IntPtr selInitWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_Handle = Selector.GetHandle("initWithSource:resultWidth:resultHeight:resultFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_ = "nodeWithSource:resultWidth:resultHeight:resultFeatureChannels:";

	private static readonly IntPtr selNodeWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_Handle = Selector.GetHandle("nodeWithSource:resultWidth:resultHeight:resultFeatureChannels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSNNReshapeNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSNNReshapeNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSNNReshapeNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:resultWidth:resultHeight:resultFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSNNReshapeNode(MPSNNImageNode source, nuint resultWidth, nuint resultHeight, nuint resultFeatureChannels)
		: base(NSObjectFlag.Empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint(base.Handle, selInitWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_Handle, source.Handle, resultWidth, resultHeight, resultFeatureChannels), "initWithSource:resultWidth:resultHeight:resultFeatureChannels:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint(base.SuperHandle, selInitWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_Handle, source.Handle, resultWidth, resultHeight, resultFeatureChannels), "initWithSource:resultWidth:resultHeight:resultFeatureChannels:");
		}
	}

	[Export("nodeWithSource:resultWidth:resultHeight:resultFeatureChannels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSNNReshapeNode Create(MPSNNImageNode source, nuint resultWidth, nuint resultHeight, nuint resultFeatureChannels)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return Runtime.GetNSObject<MPSNNReshapeNode>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint(class_ptr, selNodeWithSource_ResultWidth_ResultHeight_ResultFeatureChannels_Handle, source.Handle, resultWidth, resultHeight, resultFeatureChannels));
	}
}
