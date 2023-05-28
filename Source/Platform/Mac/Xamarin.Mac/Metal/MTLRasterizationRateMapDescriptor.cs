using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRasterizationRateMapDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MTLRasterizationRateMapDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerAtIndex_ = "layerAtIndex:";

	private static readonly IntPtr selLayerAtIndex_Handle = Selector.GetHandle("layerAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRasterizationRateMapDescriptorWithScreenSize_ = "rasterizationRateMapDescriptorWithScreenSize:";

	private static readonly IntPtr selRasterizationRateMapDescriptorWithScreenSize_Handle = Selector.GetHandle("rasterizationRateMapDescriptorWithScreenSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRasterizationRateMapDescriptorWithScreenSize_Layer_ = "rasterizationRateMapDescriptorWithScreenSize:layer:";

	private static readonly IntPtr selRasterizationRateMapDescriptorWithScreenSize_Layer_Handle = Selector.GetHandle("rasterizationRateMapDescriptorWithScreenSize:layer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRasterizationRateMapDescriptorWithScreenSize_LayerCount_Layers_ = "rasterizationRateMapDescriptorWithScreenSize:layerCount:layers:";

	private static readonly IntPtr selRasterizationRateMapDescriptorWithScreenSize_LayerCount_Layers_Handle = Selector.GetHandle("rasterizationRateMapDescriptorWithScreenSize:layerCount:layers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayer_AtIndex_ = "setLayer:atIndex:";

	private static readonly IntPtr selSetLayer_AtIndex_Handle = Selector.GetHandle("setLayer:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRasterizationRateMapDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRasterizationRateMapDescriptor()
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
	protected MTLRasterizationRateMapDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRasterizationRateMapDescriptor(IntPtr handle)
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

	[Export("rasterizationRateMapDescriptorWithScreenSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLRasterizationRateMapDescriptor Create(MTLSize screenSize)
	{
		return Runtime.GetNSObject<MTLRasterizationRateMapDescriptor>(Messaging.IntPtr_objc_msgSend_MTLSize(class_ptr, selRasterizationRateMapDescriptorWithScreenSize_Handle, screenSize));
	}

	[Export("rasterizationRateMapDescriptorWithScreenSize:layer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLRasterizationRateMapDescriptor Create(MTLSize screenSize, MTLRasterizationRateLayerDescriptor layer)
	{
		if (layer == null)
		{
			throw new ArgumentNullException("layer");
		}
		return Runtime.GetNSObject<MTLRasterizationRateMapDescriptor>(Messaging.IntPtr_objc_msgSend_MTLSize_IntPtr(class_ptr, selRasterizationRateMapDescriptorWithScreenSize_Layer_Handle, screenSize, layer.Handle));
	}

	[Export("rasterizationRateMapDescriptorWithScreenSize:layerCount:layers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLRasterizationRateMapDescriptor Create(MTLSize screenSize, nuint layerCount, out MTLRasterizationRateLayerDescriptor layers)
	{
		IntPtr arg = IntPtr.Zero;
		MTLRasterizationRateMapDescriptor nSObject = Runtime.GetNSObject<MTLRasterizationRateMapDescriptor>(Messaging.IntPtr_objc_msgSend_MTLSize_nuint_ref_IntPtr(class_ptr, selRasterizationRateMapDescriptorWithScreenSize_LayerCount_Layers_Handle, screenSize, layerCount, ref arg));
		layers = Runtime.GetNSObject<MTLRasterizationRateLayerDescriptor>(arg);
		return nSObject;
	}

	[Export("layerAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRasterizationRateLayerDescriptor? GetLayer(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLRasterizationRateLayerDescriptor>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selLayerAtIndex_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MTLRasterizationRateLayerDescriptor>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selLayerAtIndex_Handle, layerIndex));
	}

	[Export("setLayer:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLayer(MTLRasterizationRateLayerDescriptor? layer, nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetLayer_AtIndex_Handle, layer?.Handle ?? IntPtr.Zero, layerIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetLayer_AtIndex_Handle, layer?.Handle ?? IntPtr.Zero, layerIndex);
		}
	}
}
