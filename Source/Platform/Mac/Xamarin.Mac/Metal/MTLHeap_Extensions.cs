using System;
using ObjCRuntime;

namespace Metal;

public static class MTLHeap_Extensions
{
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLBuffer? CreateBuffer(this IMTLHeap This, nuint length, MTLResourceOptions options, nuint offset)
	{
		return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend_nuint_UInt64_nuint(This.Handle, Selector.GetHandle("newBufferWithLength:options:offset:"), length, (ulong)options, offset), owns: false);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLTexture? CreateTexture(this IMTLHeap This, MTLTextureDescriptor descriptor, nuint offset)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("newTextureWithDescriptor:offset:"), descriptor.Handle, offset), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCurrentAllocatedSize(this IMTLHeap This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("currentAllocatedSize"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLHazardTrackingMode GetHazardTrackingMode(this IMTLHeap This)
	{
		return (MTLHazardTrackingMode)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("hazardTrackingMode"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLResourceOptions GetResourceOptions(this IMTLHeap This)
	{
		return (MTLResourceOptions)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("resourceOptions"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLHeapType GetType(this IMTLHeap This)
	{
		return (MTLHeapType)Messaging.Int64_objc_msgSend(This.Handle, Selector.GetHandle("type"));
	}
}
