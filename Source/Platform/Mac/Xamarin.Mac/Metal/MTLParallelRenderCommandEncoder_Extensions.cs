using System;
using ObjCRuntime;

namespace Metal;

public static class MTLParallelRenderCommandEncoder_Extensions
{
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetColorStoreAction(this IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction, nuint colorAttachmentIndex)
	{
		Messaging.void_objc_msgSend_UInt64_nuint(This.Handle, Selector.GetHandle("setColorStoreAction:atIndex:"), (ulong)storeAction, colorAttachmentIndex);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDepthStoreAction(this IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDepthStoreAction:"), (ulong)storeAction);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStencilStoreAction(this IMTLParallelRenderCommandEncoder This, MTLStoreAction storeAction)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setStencilStoreAction:"), (ulong)storeAction);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetColorStoreActionOptions(this IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions, nuint colorAttachmentIndex)
	{
		Messaging.void_objc_msgSend_UInt64_nuint(This.Handle, Selector.GetHandle("setColorStoreActionOptions:atIndex:"), (ulong)storeActionOptions, colorAttachmentIndex);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetDepthStoreActionOptions(this IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setDepthStoreActionOptions:"), (ulong)storeActionOptions);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetStencilStoreActionOptions(this IMTLParallelRenderCommandEncoder This, MTLStoreActionOptions storeActionOptions)
	{
		Messaging.void_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("setStencilStoreActionOptions:"), (ulong)storeActionOptions);
	}
}
