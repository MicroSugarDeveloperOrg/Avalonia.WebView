using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Protocol(Name = "IKImageBrowserItem", WrapperType = typeof(IKImageBrowserItemWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageUID", Selector = "imageUID", PropertyType = typeof(string), GetterSelector = "imageUID", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageRepresentationType", Selector = "imageRepresentationType", PropertyType = typeof(NSString), GetterSelector = "imageRepresentationType", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageRepresentation", Selector = "imageRepresentation", PropertyType = typeof(NSObject), GetterSelector = "imageRepresentation", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageVersion", Selector = "imageVersion", PropertyType = typeof(nint), GetterSelector = "imageVersion", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageTitle", Selector = "imageTitle", PropertyType = typeof(string), GetterSelector = "imageTitle", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageSubtitle", Selector = "imageSubtitle", PropertyType = typeof(string), GetterSelector = "imageSubtitle", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsSelectable", Selector = "isSelectable", PropertyType = typeof(bool), GetterSelector = "isSelectable", ArgumentSemantic = ArgumentSemantic.None)]
public interface IIKImageBrowserItem : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string ImageUID
	{
		[Export("imageUID")]
		get;
	}

	[Preserve(Conditional = true)]
	NSString ImageRepresentationType
	{
		[Export("imageRepresentationType")]
		get;
	}

	[Preserve(Conditional = true)]
	NSObject ImageRepresentation
	{
		[Export("imageRepresentation")]
		get;
	}
}
