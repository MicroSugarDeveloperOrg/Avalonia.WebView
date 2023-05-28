using System;
using Foundation;
using IOSurface;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLTexture", WrapperType = typeof(MTLTextureWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateTextureView", Selector = "newTextureViewWithPixelFormat:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(MTLPixelFormat) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateTextureView", Selector = "newTextureViewWithPixelFormat:textureType:levels:slices:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[]
{
	typeof(MTLPixelFormat),
	typeof(MTLTextureType),
	typeof(NSRange),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBytes", Selector = "getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint),
	typeof(MTLRegion),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBytes", Selector = "getBytes:bytesPerRow:fromRegion:mipmapLevel:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(MTLRegion),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRegion", Selector = "replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:", ParameterType = new Type[]
{
	typeof(MTLRegion),
	typeof(nuint),
	typeof(nuint),
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReplaceRegion", Selector = "replaceRegion:mipmapLevel:withBytes:bytesPerRow:", ParameterType = new Type[]
{
	typeof(MTLRegion),
	typeof(nuint),
	typeof(IntPtr),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateSharedTextureHandle", Selector = "newSharedTextureHandle", ReturnType = typeof(MTLSharedTextureHandle))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Create", Selector = "newTextureViewWithPixelFormat:textureType:levels:slices:swizzle:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[]
{
	typeof(MTLPixelFormat),
	typeof(MTLTextureType),
	typeof(NSRange),
	typeof(NSRange),
	typeof(MTLTextureSwizzleChannels)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateRemoteTexture", Selector = "newRemoteTextureViewForDevice:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[] { typeof(IMTLDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RootResource", Selector = "rootResource", PropertyType = typeof(IMTLResource), GetterSelector = "rootResource", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ParentTexture", Selector = "parentTexture", PropertyType = typeof(IMTLTexture), GetterSelector = "parentTexture", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ParentRelativeLevel", Selector = "parentRelativeLevel", PropertyType = typeof(nuint), GetterSelector = "parentRelativeLevel", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ParentRelativeSlice", Selector = "parentRelativeSlice", PropertyType = typeof(nuint), GetterSelector = "parentRelativeSlice", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Buffer", Selector = "buffer", PropertyType = typeof(IMTLBuffer), GetterSelector = "buffer", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "BufferOffset", Selector = "bufferOffset", PropertyType = typeof(nuint), GetterSelector = "bufferOffset", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "BufferBytesPerRow", Selector = "bufferBytesPerRow", PropertyType = typeof(nuint), GetterSelector = "bufferBytesPerRow", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TextureType", Selector = "textureType", PropertyType = typeof(MTLTextureType), GetterSelector = "textureType", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PixelFormat", Selector = "pixelFormat", PropertyType = typeof(MTLPixelFormat), GetterSelector = "pixelFormat", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Width", Selector = "width", PropertyType = typeof(nuint), GetterSelector = "width", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Height", Selector = "height", PropertyType = typeof(nuint), GetterSelector = "height", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Depth", Selector = "depth", PropertyType = typeof(nuint), GetterSelector = "depth", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MipmapLevelCount", Selector = "mipmapLevelCount", PropertyType = typeof(nuint), GetterSelector = "mipmapLevelCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SampleCount", Selector = "sampleCount", PropertyType = typeof(nuint), GetterSelector = "sampleCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ArrayLength", Selector = "arrayLength", PropertyType = typeof(nuint), GetterSelector = "arrayLength", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FramebufferOnly", Selector = "framebufferOnly", PropertyType = typeof(bool), GetterSelector = "isFramebufferOnly", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AllowGpuOptimizedContents", Selector = "allowGPUOptimizedContents", PropertyType = typeof(bool), GetterSelector = "allowGPUOptimizedContents", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Usage", Selector = "usage", PropertyType = typeof(MTLTextureUsage), GetterSelector = "usage", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IOSurface", Selector = "iosurface", PropertyType = typeof(global::IOSurface.IOSurface), GetterSelector = "iosurface", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IOSurfacePlane", Selector = "iosurfacePlane", PropertyType = typeof(nuint), GetterSelector = "iosurfacePlane", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Shareable", Selector = "shareable", PropertyType = typeof(bool), GetterSelector = "isShareable", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Swizzle", Selector = "swizzle", PropertyType = typeof(MTLTextureSwizzleChannels), GetterSelector = "swizzle", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RemoteStorageTexture", Selector = "remoteStorageTexture", PropertyType = typeof(IMTLTexture), GetterSelector = "remoteStorageTexture", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLTexture : INativeObject, IDisposable, IMTLResource
{
	[Preserve(Conditional = true)]
	IMTLResource RootResource
	{
		[Export("rootResource")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLTextureType TextureType
	{
		[Export("textureType")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLPixelFormat PixelFormat
	{
		[Export("pixelFormat")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint Width
	{
		[Export("width")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint Height
	{
		[Export("height")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint Depth
	{
		[Export("depth")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint MipmapLevelCount
	{
		[Export("mipmapLevelCount")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint SampleCount
	{
		[Export("sampleCount")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint ArrayLength
	{
		[Export("arrayLength")]
		get;
	}

	[Preserve(Conditional = true)]
	bool FramebufferOnly
	{
		[Export("isFramebufferOnly")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newTextureViewWithPixelFormat:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLTexture? CreateTextureView(MTLPixelFormat pixelFormat);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("getBytes:bytesPerRow:bytesPerImage:fromRegion:mipmapLevel:slice:")]
	[Preserve(Conditional = true)]
	void GetBytes(IntPtr pixelBytes, nuint bytesPerRow, nuint bytesPerImage, MTLRegion region, nuint level, nuint slice);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("getBytes:bytesPerRow:fromRegion:mipmapLevel:")]
	[Preserve(Conditional = true)]
	void GetBytes(IntPtr pixelBytes, nuint bytesPerRow, MTLRegion region, nuint level);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("replaceRegion:mipmapLevel:slice:withBytes:bytesPerRow:bytesPerImage:")]
	[Preserve(Conditional = true)]
	void ReplaceRegion(MTLRegion region, nuint level, nuint slice, IntPtr pixelBytes, nuint bytesPerRow, nuint bytesPerImage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("replaceRegion:mipmapLevel:withBytes:bytesPerRow:")]
	[Preserve(Conditional = true)]
	void ReplaceRegion(MTLRegion region, nuint level, IntPtr pixelBytes, nuint bytesPerRow);
}
