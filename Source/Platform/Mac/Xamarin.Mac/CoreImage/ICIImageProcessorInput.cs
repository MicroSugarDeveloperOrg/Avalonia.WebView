using CoreGraphics;
using CoreVideo;
using Foundation;
using IOSurface;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "CIImageProcessorInput", WrapperType = typeof(CIImageProcessorInputWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Region", Selector = "region", PropertyType = typeof(CGRect), GetterSelector = "region", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BytesPerRow", Selector = "bytesPerRow", PropertyType = typeof(nuint), GetterSelector = "bytesPerRow", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Format", Selector = "format", PropertyType = typeof(CIFormat), GetterSelector = "format", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BaseAddress", Selector = "baseAddress", PropertyType = typeof(IntPtr), GetterSelector = "baseAddress", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PixelBuffer", Selector = "pixelBuffer", PropertyType = typeof(CVPixelBuffer), GetterSelector = "pixelBuffer", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "MetalTexture", Selector = "metalTexture", PropertyType = typeof(IMTLTexture), GetterSelector = "metalTexture", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Surface", Selector = "surface", PropertyType = typeof(global::IOSurface.IOSurface), GetterSelector = "surface", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIImageProcessorInput : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CGRect Region
	{
		[Export("region")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint BytesPerRow
	{
		[Export("bytesPerRow")]
		get;
	}

	[Preserve(Conditional = true)]
	CIFormat Format
	{
		[Export("format")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr BaseAddress
	{
		[Export("baseAddress")]
		get;
	}

	[Preserve(Conditional = true)]
	CVPixelBuffer? PixelBuffer
	{
		[Export("pixelBuffer")]
		get;
	}

	[Preserve(Conditional = true)]
	IMTLTexture? MetalTexture
	{
		[Export("metalTexture")]
		get;
	}
}
