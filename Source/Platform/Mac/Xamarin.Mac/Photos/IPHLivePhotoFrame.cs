using System;
using CoreImage;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "PHLivePhotoFrame", WrapperType = typeof(PHLivePhotoFrameWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof(CIImage), GetterSelector = "image", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Time", Selector = "time", PropertyType = typeof(CMTime), GetterSelector = "time", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof(PHLivePhotoFrameType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RenderScale", Selector = "renderScale", PropertyType = typeof(nfloat), GetterSelector = "renderScale", ArgumentSemantic = ArgumentSemantic.None)]
public interface IPHLivePhotoFrame : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CIImage Image
	{
		[Export("image")]
		get;
	}

	[Preserve(Conditional = true)]
	CMTime Time
	{
		[Export("time")]
		get;
	}

	[Preserve(Conditional = true)]
	PHLivePhotoFrameType Type
	{
		[Export("type")]
		get;
	}

	[Preserve(Conditional = true)]
	nfloat RenderScale
	{
		[Export("renderScale")]
		get;
	}
}
