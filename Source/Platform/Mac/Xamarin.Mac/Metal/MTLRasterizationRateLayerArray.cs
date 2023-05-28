using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRasterizationRateLayerArray", true)]
[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MTLRasterizationRateLayerArray : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_AtIndexedSubscript_ = "setObject:atIndexedSubscript:";

	private static readonly IntPtr selSetObject_AtIndexedSubscript_Handle = Selector.GetHandle("setObject:atIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRasterizationRateLayerArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRasterizationRateLayerArray()
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
	protected MTLRasterizationRateLayerArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRasterizationRateLayerArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLRasterizationRateLayerDescriptor? GetObject(nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLRasterizationRateLayerDescriptor>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, layerIndex));
		}
		return Runtime.GetNSObject<MTLRasterizationRateLayerDescriptor>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, layerIndex));
	}

	[Export("setObject:atIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObject(MTLRasterizationRateLayerDescriptor? layer, nuint layerIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetObject_AtIndexedSubscript_Handle, layer?.Handle ?? IntPtr.Zero, layerIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetObject_AtIndexedSubscript_Handle, layer?.Handle ?? IntPtr.Zero, layerIndex);
		}
	}
}
