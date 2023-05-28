using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreAnimation;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "CAMetalDrawable", WrapperType = typeof(CAMetalDrawableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Texture", Selector = "texture", PropertyType = typeof(IMTLTexture), GetterSelector = "texture", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Layer", Selector = "layer", PropertyType = typeof(CAMetalLayer), GetterSelector = "layer", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICAMetalDrawable : INativeObject, IDisposable, IMTLDrawable
{
	[Preserve(Conditional = true)]
	IMTLTexture Texture
	{
		[Export("texture")]
		get;
	}

	[Preserve(Conditional = true)]
	CAMetalLayer Layer
	{
		[Export("layer")]
		get;
	}
}
