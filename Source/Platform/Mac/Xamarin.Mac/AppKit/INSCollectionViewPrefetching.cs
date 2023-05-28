using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "NSCollectionViewPrefetching", WrapperType = typeof(NSCollectionViewPrefetchingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PrefetchItems", Selector = "collectionView:prefetchItemsAtIndexPaths:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexPath[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CancelPrefetching", Selector = "collectionView:cancelPrefetchingForItemsAtIndexPaths:", ParameterType = new Type[]
{
	typeof(NSCollectionView),
	typeof(NSIndexPath[])
}, ParameterByRef = new bool[] { false, false })]
public interface INSCollectionViewPrefetching : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("collectionView:prefetchItemsAtIndexPaths:")]
	[Preserve(Conditional = true)]
	void PrefetchItems(NSCollectionView collectionView, NSIndexPath[] indexPaths);
}
