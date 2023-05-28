using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSRNNRecurrentImageState", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSRnnRecurrentImageState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetMemoryCellImageForLayerIndex_ = "getMemoryCellImageForLayerIndex:";

	private static readonly IntPtr selGetMemoryCellImageForLayerIndex_Handle = Selector.GetHandle("getMemoryCellImageForLayerIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetRecurrentOutputImageForLayerIndex_ = "getRecurrentOutputImageForLayerIndex:";

	private static readonly IntPtr selGetRecurrentOutputImageForLayerIndex_Handle = Selector.GetHandle("getRecurrentOutputImageForLayerIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNRecurrentImageState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSRnnRecurrentImageState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnRecurrentImageState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getMemoryCellImageForLayerIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage? GetMemoryCellImage(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetMemoryCellImageForLayerIndex_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetMemoryCellImageForLayerIndex_Handle, layerIndex));
	}

	[Export("getRecurrentOutputImageForLayerIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSImage? GetRecurrentOutputImage(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetRecurrentOutputImageForLayerIndex_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MPSImage>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetRecurrentOutputImageForLayerIndex_Handle, layerIndex));
	}
}
