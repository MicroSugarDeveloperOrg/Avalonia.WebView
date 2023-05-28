using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIAccordionFoldTransition", WrapperType = typeof(CIAccordionFoldTransitionProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BottomHeight", Selector = "bottomHeight", PropertyType = typeof(float), GetterSelector = "bottomHeight", SetterSelector = "setBottomHeight:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FoldCount", Selector = "numberOfFolds", PropertyType = typeof(float), GetterSelector = "numberOfFolds", SetterSelector = "setNumberOfFolds:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FoldShadowAmount", Selector = "foldShadowAmount", PropertyType = typeof(float), GetterSelector = "foldShadowAmount", SetterSelector = "setFoldShadowAmount:", ArgumentSemantic = ArgumentSemantic.None)]
public interface ICIAccordionFoldTransitionProtocol : INativeObject, IDisposable, ICIFilterProtocol, ICITransitionFilterProtocol
{
	[Preserve(Conditional = true)]
	float BottomHeight
	{
		[Export("bottomHeight")]
		get;
		[Export("setBottomHeight:")]
		set;
	}

	[Preserve(Conditional = true)]
	float FoldCount
	{
		[Export("numberOfFolds")]
		get;
		[Export("setNumberOfFolds:")]
		set;
	}

	[Preserve(Conditional = true)]
	float FoldShadowAmount
	{
		[Export("foldShadowAmount")]
		get;
		[Export("setFoldShadowAmount:")]
		set;
	}
}
