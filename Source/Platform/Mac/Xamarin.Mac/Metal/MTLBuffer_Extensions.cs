using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLBuffer_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLTexture? CreateTexture(this IMTLBuffer This, MTLTextureDescriptor descriptor, nuint offset, nuint bytesPerRow)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(This.Handle, Selector.GetHandle("newTextureWithDescriptor:offset:bytesPerRow:"), descriptor.Handle, offset, bytesPerRow), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void AddDebugMarker(this IMTLBuffer This, string marker, NSRange range)
	{
		if (marker == null)
		{
			throw new ArgumentNullException("marker");
		}
		IntPtr intPtr = NSString.CreateNative(marker);
		Messaging.void_objc_msgSend_IntPtr_NSRange(This.Handle, Selector.GetHandle("addDebugMarker:range:"), intPtr, range);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveAllDebugMarkers(this IMTLBuffer This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("removeAllDebugMarkers"));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLBuffer? CreateRemoteBuffer(this IMTLBuffer This, IMTLDevice device)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newRemoteBufferViewForDevice:"), device.Handle), owns: false);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLBuffer GetRemoteStorageBuffer(this IMTLBuffer This)
	{
		return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("remoteStorageBuffer")), owns: false);
	}
}
