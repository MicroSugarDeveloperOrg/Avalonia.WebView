using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSRNNRecurrentMatrixState", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSRnnRecurrentMatrixState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetMemoryCellMatrixForLayerIndex_ = "getMemoryCellMatrixForLayerIndex:";

	private static readonly IntPtr selGetMemoryCellMatrixForLayerIndex_Handle = Selector.GetHandle("getMemoryCellMatrixForLayerIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRecurrentOutputMatrixForLayerIndex_ = "getRecurrentOutputMatrixForLayerIndex:";

	private static readonly IntPtr selGetRecurrentOutputMatrixForLayerIndex_Handle = Selector.GetHandle("getRecurrentOutputMatrixForLayerIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNRecurrentMatrixState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSRnnRecurrentMatrixState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnRecurrentMatrixState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getMemoryCellMatrixForLayerIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSMatrix? GetMemoryCellMatrix(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSMatrix>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetMemoryCellMatrixForLayerIndex_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MPSMatrix>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetMemoryCellMatrixForLayerIndex_Handle, layerIndex));
	}

	[Export("getRecurrentOutputMatrixForLayerIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSMatrix? GetRecurrentOutputMatrix(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSMatrix>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetRecurrentOutputMatrixForLayerIndex_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MPSMatrix>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetRecurrentOutputMatrixForLayerIndex_Handle, layerIndex));
	}
}
