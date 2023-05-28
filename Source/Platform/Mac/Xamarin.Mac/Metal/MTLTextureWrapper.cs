using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLTextureWrapper : BaseWrapper, IMTLTexture, INativeObject, IDisposable, IMTLResource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public IMTLResource RootResource
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("rootResource")]
		get
		{
			return Runtime.GetINativeObject<IMTLResource>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("rootResource")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLTextureType TextureType
	{
		[Export("textureType")]
		get
		{
			return (MTLTextureType)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("textureType"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLPixelFormat PixelFormat
	{
		[Export("pixelFormat")]
		get
		{
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("pixelFormat"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint Width
	{
		[Export("width")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("width"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint Height
	{
		[Export("height")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("height"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint Depth
	{
		[Export("depth")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("depth"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint MipmapLevelCount
	{
		[Export("mipmapLevelCount")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("mipmapLevelCount"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint SampleCount
	{
		[Export("sampleCount")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("sampleCount"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint ArrayLength
	{
		[Export("arrayLength")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("arrayLength"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool FramebufferOnly
	{
		[Export("isFramebufferOnly")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isFramebufferOnly"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode")]
		get
		{
			return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("cpuCacheMode"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLTextureWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("newTextureViewWithPixelFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLTexture? CreateTextureView(MTLPixelFormat pixelFormat)
	{
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("newTextureViewWithPixelFormat:"), (ulong)pixelFormat), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void GetBytes(IntPtr pixelBytes, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, nuint level, nuint slice)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_MTLRegion_nuint_nuint(base.Handle, Selector.GetHandle("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:"), pixelBytes, bytesPerRow, bytesPerImage, region, level, slice);
	}

	[Export("getBytes:bytesPerRow:fromRegion:mipmapLevel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void GetBytes(IntPtr pixelBytes, nuint bytesPerRow, MTLRegion region, nuint level)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_MTLRegion_nuint(base.Handle, Selector.GetHandle("getBytes:bytesPerRow:fromRegion:mipmapLevel:"), pixelBytes, bytesPerRow, region, level);
	}

	[Export("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReplaceRegion(MTLRegion region, nuint level, nuint slice, IntPtr pixelBytes, nuint bytesPerRow, nuint bytesPerImage)
	{
		Messaging.void_objc_msgSend_MTLRegion_nuint_nuint_IntPtr_nuint_nuint(base.Handle, Selector.GetHandle("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:"), region, level, slice, pixelBytes, bytesPerRow, bytesPerImage);
	}

	[Export("replaceRegion:mipmapLevel:withBytes:bytesPerRow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReplaceRegion(MTLRegion region, nuint level, IntPtr pixelBytes, nuint bytesPerRow)
	{
		Messaging.void_objc_msgSend_MTLRegion_nuint_IntPtr_nuint(base.Handle, Selector.GetHandle("replaceRegion:mipmapLevel:withBytes:bytesPerRow:"), region, level, pixelBytes, bytesPerRow);
	}

	[Export("setPurgeableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLPurgeableState SetPurgeableState(MTLPurgeableState state)
	{
		return (MTLPurgeableState)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setPurgeableState:"), (ulong)state);
	}
}
