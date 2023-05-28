using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKImageEditPanelDataSource", WrapperType = typeof(IKImageEditPanelDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetImageAndProperties", Selector = "setImage:imageProperties:", ParameterType = new Type[]
{
	typeof(CGImage),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetThumbnail", Selector = "thumbnailWithMaximumSize:", ReturnType = typeof(CGImage), ParameterType = new Type[] { typeof(CGSize) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Image", Selector = "image", PropertyType = typeof(CGImage), GetterSelector = "image", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageProperties", Selector = "imageProperties", PropertyType = typeof(NSDictionary), GetterSelector = "imageProperties", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasAdjustMode", Selector = "hasAdjustMode", PropertyType = typeof(bool), GetterSelector = "hasAdjustMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasEffectsMode", Selector = "hasEffectsMode", PropertyType = typeof(bool), GetterSelector = "hasEffectsMode", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "HasDetailsMode", Selector = "hasDetailsMode", PropertyType = typeof(bool), GetterSelector = "hasDetailsMode", ArgumentSemantic = ArgumentSemantic.None)]
public interface IIKImageEditPanelDataSource : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CGImage Image
	{
		[Export("image")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setImage:imageProperties:")]
	[Preserve(Conditional = true)]
	void SetImageAndProperties(CGImage image, NSDictionary metaData);
}
