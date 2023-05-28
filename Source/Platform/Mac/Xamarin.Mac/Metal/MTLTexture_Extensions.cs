using System;
using Foundation;
using IOSurface;
using ObjCRuntime;

namespace Metal;

public static class MTLTexture_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLTexture? CreateTextureView(this IMTLTexture This, MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange)
	{
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64_NSRange_NSRange(This.Handle, Selector.GetHandle("newTextureViewWithPixelFormat:textureType:levels:slices:"), (ulong)pixelFormat, (ulong)textureType, levelRange, sliceRange), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static MTLSharedTextureHandle? CreateSharedTextureHandle(this IMTLTexture This)
	{
		MTLSharedTextureHandle nSObject = Runtime.GetNSObject<MTLSharedTextureHandle>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("newSharedTextureHandle")));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLTexture? Create(this IMTLTexture This, MTLPixelFormat pixelFormat, MTLTextureType textureType, NSRange levelRange, NSRange sliceRange, MTLTextureSwizzleChannels swizzle)
	{
		return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_UInt64_UInt64_NSRange_NSRange_MTLTextureSwizzleChannels(This.Handle, Selector.GetHandle("newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:"), (ulong)pixelFormat, (ulong)textureType, levelRange, sliceRange, swizzle), owns: false);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLTexture? CreateRemoteTexture(this IMTLTexture This, IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newRemoteTextureViewForDevice:"), device.Handle), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLTexture GetParentTexture(this IMTLTexture This)
	{
		return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("parentTexture")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetParentRelativeLevel(this IMTLTexture This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("parentRelativeLevel"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetParentRelativeSlice(this IMTLTexture This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("parentRelativeSlice"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLBuffer GetBuffer(this IMTLTexture This)
	{
		return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("buffer")), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetBufferOffset(this IMTLTexture This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("bufferOffset"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetBufferBytesPerRow(this IMTLTexture This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("bufferBytesPerRow"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetAllowGpuOptimizedContents(this IMTLTexture This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("allowGPUOptimizedContents"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLTextureUsage GetUsage(this IMTLTexture This)
	{
		return (MTLTextureUsage)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("usage"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static global::IOSurface.IOSurface GetIOSurface(this IMTLTexture This)
	{
		return Runtime.GetNSObject<global::IOSurface.IOSurface>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("iosurface")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetIOSurfacePlane(this IMTLTexture This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("iosurfacePlane"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetShareable(this IMTLTexture This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("shareable"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLTextureSwizzleChannels GetSwizzle(this IMTLTexture This)
	{
		return Messaging.MTLTextureSwizzleChannels_objc_msgSend(This.Handle, Selector.GetHandle("swizzle"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLTexture GetRemoteStorageTexture(this IMTLTexture This)
	{
		return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("remoteStorageTexture")), owns: false);
	}
}
