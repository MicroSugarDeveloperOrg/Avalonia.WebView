using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionLayoutContainer", WrapperType = typeof(NSCollectionLayoutContainerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentSize", Selector = "contentSize", PropertyType = typeof(CGSize), GetterSelector = "contentSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "EffectiveContentSize", Selector = "effectiveContentSize", PropertyType = typeof(CGSize), GetterSelector = "effectiveContentSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ContentInsets", Selector = "contentInsets", PropertyType = typeof(NSDirectionalEdgeInsets), GetterSelector = "contentInsets", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "EffectiveContentInsets", Selector = "effectiveContentInsets", PropertyType = typeof(NSDirectionalEdgeInsets), GetterSelector = "effectiveContentInsets", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSCollectionLayoutContainer : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	CGSize ContentSize
	{
		[Export("contentSize")]
		get;
	}

	[Preserve(Conditional = true)]
	CGSize EffectiveContentSize
	{
		[Export("effectiveContentSize")]
		get;
	}

	[Preserve(Conditional = true)]
	NSDirectionalEdgeInsets ContentInsets
	{
		[Export("contentInsets")]
		get;
	}

	[Preserve(Conditional = true)]
	NSDirectionalEdgeInsets EffectiveContentInsets
	{
		[Export("effectiveContentInsets")]
		get;
	}
}
