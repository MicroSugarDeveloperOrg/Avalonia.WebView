using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionViewElement", WrapperType = typeof(NSCollectionViewElementWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PrepareForReuse", Selector = "prepareForReuse")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ApplyLayoutAttributes", Selector = "applyLayoutAttributes:", ParameterType = new Type[] { typeof(NSCollectionViewLayoutAttributes) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillTransition", Selector = "willTransitionFromLayout:toLayout:", ParameterType = new Type[]
{
	typeof(NSCollectionViewLayout),
	typeof(NSCollectionViewLayout)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidTransition", Selector = "didTransitionFromLayout:toLayout:", ParameterType = new Type[]
{
	typeof(NSCollectionViewLayout),
	typeof(NSCollectionViewLayout)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetPreferredLayoutAttributes", Selector = "preferredLayoutAttributesFittingAttributes:", ReturnType = typeof(NSCollectionViewLayoutAttributes), ParameterType = new Type[] { typeof(NSCollectionViewLayoutAttributes) }, ParameterByRef = new bool[] { false })]
public interface INSCollectionViewElement : INativeObject, IDisposable, INSUserInterfaceItemIdentification
{
}
